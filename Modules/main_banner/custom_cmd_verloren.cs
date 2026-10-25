using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;


public static class CustomShell
{
    // ANSI-цвета (те же коды, что были в bat)
    const string Reset = "\e[0m", Green = "\e[92m", White = "\e[97m",
                 Red = "\e[91m", Cyan = "\e[96m", Magenta = "\e[35m";
    // открывает оболочку в НОВОМ окне терминала
    public static void OpenInNewWindow()
    {
        string exe = Environment.ProcessPath!;
        var cmd = new List<string> { exe };

        // при "dotnet run" процесс это dotnet.exe, ему нужно передать путь к dll
        if (Path.GetFileNameWithoutExtension(exe).Equals("dotnet", StringComparison.OrdinalIgnoreCase))
            cmd.Add(Environment.GetCommandLineArgs()[0]);

        cmd.Add("--shell");
        string workDir = Directory.GetCurrentDirectory();

        try
        {
            if (OperatingSystem.IsWindows())
            {
                // UseShellExecute = true: консольное приложение откроется в новом окне
                var psi = new ProcessStartInfo(cmd[0])
                {
                    UseShellExecute = true,
                    WorkingDirectory = workDir
                };
                foreach (var a in cmd.Skip(1)) psi.ArgumentList.Add(a);
                Process.Start(psi);
            }
            else if (OperatingSystem.IsMacOS())
            {
                string line = string.Join(" ", cmd.Select(c => $"'{c}'"));
                string script = $"tell application \"Terminal\" to do script \"cd '{workDir}'; {line.Replace("\"", "\\\"")}\"";
                Process.Start("osascript", new[] { "-e", script });
            }
            else // Linux: пробуем популярные терминалы по очереди
            {
                var terminals = new (string name, string[] pre)[]
                {
                ("x-terminal-emulator", new[] { "-e" }),
                ("gnome-terminal",      new[] { "--" }),
                ("konsole",             new[] { "-e" }),
                ("xfce4-terminal",      new[] { "-e" }),
                ("xterm",               new[] { "-e" }),
                };

                foreach (var (name, pre) in terminals)
                {
                    try
                    {
                        var psi = new ProcessStartInfo(name) { WorkingDirectory = workDir };
                        foreach (var p in pre) psi.ArgumentList.Add(p);
                        foreach (var c in cmd) psi.ArgumentList.Add(c);
                        Process.Start(psi);
                        return;                 // получилось
                    }
                    catch { /* такого терминала нет, пробуем следующий */ }
                }
                Console.WriteLine("Не найден ни один терминал (xterm, gnome-terminal, konsole...)");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"{Red}Не удалось открыть терминал: {ex.Message}{Reset}");
        }
    }
    public static void Run(string artFolder = "")
    {
        Console.OutputEncoding = Encoding.UTF8;          // chcp 65001
        Console.Title = "Verloren |Custom CMD";
        EnableAnsiOnWindows();

        PrintRandomArt(string.IsNullOrEmpty(artFolder) ? AppContext.BaseDirectory : artFolder);

        while (true)
        {
            Console.WriteLine($"{White}╔═══{Reset}{Red}{{{Environment.UserName}}}{Reset} ~ " +
                              $"{Cyan}{{{Environment.MachineName}}}{Reset} ~ " +
                              $"{Magenta}[{Directory.GetCurrentDirectory()}]{Reset}");
            Console.Write("╚═══> ");

            string? input = Console.ReadLine()?.Trim();
            if (input == null) break;                    // Ctrl+Z / закрытие потока
            Console.WriteLine();
            if (input.Length == 0) continue;

            if (!HandleBuiltin(input))
                Exec(input);
        }
    }

    // случайный ascii-арт из anime_art_ascii_*.txt
    static void PrintRandomArt(string folder)
    {
        string[] files = Directory.GetFiles(folder, "anime_art_ascii_*.txt", SearchOption.AllDirectories);
        if (files.Length == 0)
        {
            Console.WriteLine($"{Red}Арты не найдены в: {folder}{Reset}");   // временная диагностика
            return;
        }

        string file = files[Random.Shared.Next(files.Length)];
        foreach (string line in File.ReadLines(file))
            Console.WriteLine($"{Green} {line}{Reset}");
    }

    // команды, которые должны выполняться внутри программы
    static bool HandleBuiltin(string input)
    {
        string lower = input.ToLowerInvariant();

        if (lower == "exit") Environment.Exit(0);

        if (lower == "clear" || lower == "cls") { Console.Clear(); return true; }

        // alias ls=dir (только на Windows, там ls нет)
        if (OperatingSystem.IsWindows() && (lower == "ls" || lower.StartsWith("ls ")))
        {
            Exec("dir" + input[2..]);
            return true;
        }

        // cd должен менять папку у самой программы, иначе он не сработает
        if (lower == "cd" || lower.StartsWith("cd ") || lower.StartsWith("cd.."))
        {
            string arg = input[2..].Trim();
            if (arg.StartsWith("/d", StringComparison.OrdinalIgnoreCase)) arg = arg[2..].Trim();
            arg = arg.Trim('"');

            if (arg.Length == 0) { Console.WriteLine(Directory.GetCurrentDirectory()); return true; }
            ChangeDir(arg);
            return true;
        }

        // смена диска: D:
        if (OperatingSystem.IsWindows() && Regex.IsMatch(input, @"^[A-Za-z]:$"))
        {
            ChangeDir(input + @"\");
            return true;
        }

        return false;
    }

    static void ChangeDir(string path)
    {
        try { Directory.SetCurrentDirectory(Path.GetFullPath(path)); }
        catch (Exception ex) { Console.WriteLine($"{Red}Ошибка: {ex.Message}{Reset}"); }
    }

    // выполнить команду через системную оболочку
    static void Exec(string command)
    {
        bool win = OperatingSystem.IsWindows();
        var psi = new ProcessStartInfo(win ? "cmd.exe" : "/bin/sh") { UseShellExecute = false };
        psi.ArgumentList.Add(win ? "/c" : "-c");
        psi.ArgumentList.Add(command);

        try
        {
            using var p = Process.Start(psi);
            p?.WaitForExit();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"{Red}Ошибка: {ex.Message}{Reset}");
        }
    }

    // включает поддержку цветов (ANSI) в консоли Windows
    [DllImport("kernel32.dll")] static extern IntPtr GetStdHandle(int n);
    [DllImport("kernel32.dll")] static extern bool GetConsoleMode(IntPtr h, out uint m);
    [DllImport("kernel32.dll")] static extern bool SetConsoleMode(IntPtr h, uint m);

    static void EnableAnsiOnWindows()
    {
        if (!OperatingSystem.IsWindows()) return;
        IntPtr h = GetStdHandle(-11);
        if (GetConsoleMode(h, out uint mode))
            SetConsoleMode(h, mode | 0x0004);   // ENABLE_VIRTUAL_TERMINAL_PROCESSING
    }
}
