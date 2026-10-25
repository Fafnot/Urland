// Порт inputlag.bat (Made By: Verloren, v0.2.1.1) на C#.
// Данные (ключи реестра, команды, арты) лежат в InputLagTweaker.Data.cs.
// Работает только в Windows и только с правами администратора.
//
// Вызов:  if (OperatingSystem.IsWindows()) InputLagTweaker.Run();

using System.Diagnostics;
using System.IO.Compression;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Security.Principal;
using System.Text;
using Microsoft.Win32;

[SupportedOSPlatform("windows")]
public static partial class InputLagTweaker
{
    const string Version = "0.2.1.1";

    // ANSI-цвета (те же коды, что были в bat)
    const string Reset = "\u001b[0m", Inv = "\u001b[7m", Bold = "\u001b[1m",
                 Mag = "\u001b[95m", Yel = "\u001b[33m", Grn = "\u001b[92m",
                 Blu = "\u001b[38;5;63m", Red = "\u001b[91m", Dim = "\u001b[90m";

    const int StepDelayMs = 300;                       // пауза между пунктами (в bat было timeout /t 1)
    const string DisplayClass = "{4d36e968-e325-11ce-bfc1-08002be10318}";   // класс видеоадаптеров
    const string AdapterClass = "{4d36e972-e325-11ce-bfc1-08002be10318}";   // класс сетевых адаптеров
    const string PowerPlanGuid = "11111111-1111-1111-1111-111111111111";

    static readonly string WorkDir = Path.Combine(Path.GetTempPath(), "UrlandInputLag");
    static readonly HttpClient Http = CreateHttp();

    static readonly string[] BannerArt =
    {
        @"╔═════════════════════════════════════════════════════════════╗",
        @"│             __  __     __                __                 │",
        @"│            / / / /____/ /___ _____  ____/ /                 │",
        @"│           / / / / ___/ / __ `/ __ \/ __  /                  │",
        @"│          / /_/ / /  / / /_/ / / / / /_/ /                   │",
        @"│          \____/_/  /_/\__,_/_/ /_/\__,_/                    │",
        @"│                                                             │",
        @"╚═════════════════════════════════════════════════════════════╝",
    };

    // ───────────────────────────── вход ─────────────────────────────

    public static void Run()
    {
        if (!OperatingSystem.IsWindows())
        {
            Console.WriteLine("Эти твики работают только в Windows.");
            return;
        }

        Console.OutputEncoding = Encoding.UTF8;                 // chcp 65001
        Console.Title = "Made By: Verloren";
        EnableAnsi();

        if (!IsAdmin())
        {
            Console.WriteLine($"{Red}Скрипт должен быть запущен с правами администратора.{Reset}");
            Console.WriteLine("Запустите терминал «От имени администратора» и повторите. Enter — назад.");
            Console.ReadLine();
            return;
        }

        if (Ask("Создать точку восстановления?"))
            CreateRestorePoint();

        while (true)
        {
            ShowMenu();
            string? line = Console.ReadLine();
            if (line == null) return;                           // закрыт поток ввода
            string input = line.Trim().ToLowerInvariant();
            Console.WriteLine();

            switch (input)
            {
                case "1": WinTweaks(); break;
                case "2": GpuTweaks(); break;
                case "3": NetworkTweaks(); break;
                case "4": MouseTweaks(); break;
                case "5": PowerPlan(); break;
                case "6": case "7": case "8": break;            // «В разработке»
                case "0": OpenUrl("https://www.youtube.com/@igromanoff"); break;
                case "q": case "exit": return;                  // добавлено: выход обратно в программу
                default:
                    Console.WriteLine("Неверный выбор, попробуйте снова.");
                    Thread.Sleep(2000);
                    break;
            }
        }
    }

    // ───────────────────────────── меню ─────────────────────────────

    static void ShowMenu()
    {
        Cls();
        Console.WriteLine(Mag);
        foreach (string l in BannerArt) Console.WriteLine("                " + l);
        Console.WriteLine($"{Yel}{new string(' ', 46)}Version {Version}{Reset}");
        Console.WriteLine();

        string ind = new(' ', 20);
        Console.WriteLine($"{Blu}{ind}╔{new string('═', 55)}╗{Reset}");
        Row("[1] - Windows Твики", "[2] - Твики Видеокарты");
        Row("[3] - Интернет Твики", "[4] - Клавиатура и Мышь");
        Row("[5] - План Питания", "[6] - В разработке");
        Row("[7] - В разработке", "[8] - В разработке");
        Console.WriteLine($"{Blu}{ind}╚{new string('═', 55)}╝{Reset}");
        Console.WriteLine($"{Dim}{new string(' ', 27)}[Q] - Выйти в программу{Reset}");
        Console.WriteLine();
        Console.Write($"{Mag}             ► {Reset}");

        static void Row(string a, string b)
        {
            Console.WriteLine($"{new string(' ', 27)}{Grn}{a.PadRight(26)}{b}{Reset}");
            Console.WriteLine();
        }
    }

    // ───────────────────────────── разделы ─────────────────────────────

    static void CreateRestorePoint()
    {
        Console.WriteLine("Создаем точку восстановления...");
        WriteReg(new(H.LM, @"SOFTWARE\Microsoft\Windows NT\CurrentVersion\SystemRestore",
                     "SystemRestorePointCreationFrequency", K.Dword, "0"));

        bool ok = RunHidden("powershell",
            "-NoProfile -ExecutionPolicy Bypass -Command \"Checkpoint-Computer -Description 'Igromanoff Tweaks' -RestorePointType 'MODIFY_SETTINGS'\"");

        Console.WriteLine(ok
            ? $"{Grn}Точка восстановления успешно создана.{Reset}"
            : $"{Yel}Не удалось создать точку восстановления (возможно, выключена защита системы).{Reset}");
        Thread.Sleep(2000);
    }

    // [1] Windows Твики
    static void WinTweaks()
    {
        Intro("Применение твиков");
        RunSteps(WinSteps);

        if (Ask("Отключить Уведомления системы и некоторых приложений?"))
        {
            Cls(); Console.WriteLine("Отключение уведомлений");
            RunSteps(PushSteps);
        }

        if (Ask("Запретить Телеметрию системы и приложений?"))
        {
            Cls(); Console.WriteLine("Настройка параметров конфиденциальности Windows");
            RunSteps(CapabilitySteps);
        }

        Cls();
        RunSteps(ContentDeliverySteps);

        if (Ask("Сделать очистку Приложений в Автозагрузки?"))
        {
            Cls();
            RunSteps(StartupSteps);
        }

        Cls();
        RunSteps(AccessibilitySteps);

        if (Ask("Частично Отключить и ограничить Windows Defender?",
                $"{Yel}Внимание: это снижает защиту компьютера.{Reset}"))
        {
            Cls();
            RunSteps(DefenderSteps);
        }

        Cls();
        RunSteps(FseSteps);
        Pause();
    }

    // [2] Твики Видеокарты
    static void GpuTweaks()
    {
        int gpu = AskOption("Какая у тебя Видеокарта?", "NVIDIA = 1", "AMD = 2");

        if (gpu == 1)
        {
            if (Ask("Приминить Настройки Igromanoff для Nvidia Nvidia Profile Inspector?"))
                ApplyNvidiaProfile();

            Cls();
            PrintArt(ArtNvidiaGuid, Grn);
            string? guid = AskGuid();
            if (guid == null) return;

            RunSteps(NvidiaGuidSteps, guid);
            Console.WriteLine($"\n{Grn}Готово, а ты переживал :){Reset}");
            Thread.Sleep(3000);
        }
        else if (gpu == 2)
        {
            Cls();
            PrintArt(ArtAmd, Red);
            string? guid = AskGuid();
            if (guid == null) return;

            RunSteps(AmdSteps, guid);
            Console.WriteLine($"\n{Grn}Готово.{Reset}");
            Thread.Sleep(2000);
        }
    }

    static void ApplyNvidiaProfile()
    {
        Cls();
        PrintArt(ArtNvidiaProfile, Grn);
        Console.WriteLine("Применение Профиля NVIDIA");

        try
        {
            string? zip = Download("https://github.com/Orbmu2k/nvidiaProfileInspector/releases/latest/download/nvidiaProfileInspector.zip",
                                   "nvidiaProfileInspector.zip");
            string? nip = Download("https://github.com/ancel1x/Ancels-Performance-Batch/raw/main/bin/ancel_nv_profile.nip",
                                   "ancel_nv_profile.nip");
            if (zip == null || nip == null) return;

            string dir = Path.Combine(WorkDir, "NvidiaProfileInspector");
            ZipFile.ExtractToDirectory(zip, dir, overwriteFiles: true);

            RunVisible(Path.Combine(dir, "nvidiaProfileInspector.exe"), nip);   // как «start /wait» в bat
        }
        catch (Exception ex)
        {
            Console.WriteLine($"{Red}Ошибка применения профиля: {ex.Message}{Reset}");
            Thread.Sleep(3000);
        }
    }

    // [3] Интернет Твики
    static void NetworkTweaks()
    {
        Cls();
        Console.WriteLine($"{Mag}          Применение Интернет Твиков...{Reset}\n");

        ApplyAdapterTweaks();
        ApplyInterfaceTweaks();

        int ok = 0, fail = 0;
        foreach (Reg r in NetGlobalRegs) { if (WriteReg(r)) ok++; else fail++; }
        foreach (string c in NetshCmds)  { if (Exec(c)) ok++; else fail++; }
        Console.WriteLine($"TCP/сеть: применено {ok}, пропущено {fail}");
        Thread.Sleep(1000);

        bool disable = Ask("Отключить Window Auto-Tuning?",
            "Если отключить - Снизиться скорость Интернета",
            "Но улучшиться регистрация поподаний в играх.",
            "По умолчанию Включена - Normal",
            "",
            "Отключаем?");
        Exec("netsh int tcp set global autotuninglevel=" + (disable ? "disable" : "normal"));

        if (Ask("Открыть настройки Адаптера Интернета?"))
        {
            Cls();
            Console.WriteLine("Открываем Настройки Адаптера...");
            RunRemoteScript("https://github.com/Igromanoff/Igromanoff-Tweaks/raw/refs/heads/main/Bin/TweakingAdapter.ps1",
                            "TweakingAdapter.ps1");
        }
    }

    // Энергосбережение сетевых карт: пишем в каждый реальный адаптер (в bat не было цикла for).
    static void ApplyAdapterTweaks()
    {
        string cls = $@"SYSTEM\CurrentControlSet\Control\Class\{AdapterClass}";
        int adapters = 0, ok = 0, fail = 0;

        using var root = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
        using var cl = root.OpenSubKey(cls);
        if (cl != null)
        {
            foreach (string sub in cl.GetSubKeyNames())
            {
                if (sub.Length != 4 || !sub.All(char.IsDigit)) continue;
                using var k = root.OpenSubKey($@"{cls}\{sub}", writable: true);
                if (k?.GetValue("NetCfgInstanceId") == null) continue;   // не сетевой адаптер

                adapters++;
                foreach (Reg r in NetAdapterRegs)
                {
                    try { SetValue(k, r); ok++; } catch { fail++; }
                }
            }
        }
        Console.WriteLine($"Сетевые адаптеры: {adapters} (значений {ok}, ошибок {fail})");
    }

    // TcpAckFrequency / TCPNoDelay / TcpDelAckTicks: в каждый интерфейс Tcpip.
    static void ApplyInterfaceTweaks()
    {
        const string ifs = @"SYSTEM\CurrentControlSet\Services\Tcpip\Parameters\Interfaces";
        int n = 0, fail = 0;

        using var root = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
        using var parent = root.OpenSubKey(ifs);
        if (parent != null)
        {
            foreach (string name in parent.GetSubKeyNames())
            {
                using var k = root.OpenSubKey($@"{ifs}\{name}", writable: true);
                if (k == null) { fail++; continue; }
                n++;
                foreach (Reg r in NetInterfaceRegs)
                {
                    try { SetValue(k, r); } catch { fail++; }
                }
            }
        }
        Console.WriteLine($"Сетевые интерфейсы Tcpip: {n} (ошибок {fail})");
    }

    // [4] Клавиатура и Мышь
    static void MouseTweaks()
    {
        Cls();
        PrintArt(ArtMouse, Yel);
        Intro("Применение Твиков Мыши и Клавиатуры");

        int ok = 0, fail = 0;
        foreach (Reg r in MouseRegs) { if (WriteReg(r)) ok++; else fail++; }
        Console.WriteLine($"Мышь/клавиатура: применено {ok}, пропущено {fail}");

        ApplyUsbDeviceTweaks();

        Intro("Отключение Энергосбережения USB");
        RunRemoteScript("https://github.com/Igromanoff/Igromanoff-Tweaks/raw/refs/heads/main/Bin/DisablePowerSavingUsb.ps1",
                        "DisablePowerSavingUsb.ps1");
        Pause();
    }

    // MSI-режим / приоритет / энергосбережение для USB-устройств (в bat не было цикла for).
    static void ApplyUsbDeviceTweaks()
    {
        const string usb = @"SYSTEM\CurrentControlSet\Enum\USB";
        int devices = 0, ok = 0, fail = 0;

        using var root = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
        using var usbKey = root.OpenSubKey(usb);
        if (usbKey != null)
        {
            foreach (string hw in usbKey.GetSubKeyNames())
            {
                using var hwKey = usbKey.OpenSubKey(hw);
                if (hwKey == null) continue;
                foreach (string inst in hwKey.GetSubKeyNames())
                {
                    devices++;
                    foreach (Reg r in MouseDeviceRegs)
                    {
                        if (WriteRegAt(H.LM, $@"{usb}\{hw}\{inst}\{r.Path}", r)) ok++; else fail++;
                    }
                }
            }
        }
        Console.WriteLine($"USB-устройства: {devices} (значений {ok}, пропущено {fail})");
    }

    // [5] План Питания
    static void PowerPlan()
    {
        Cls();
        PrintArt(ArtPower, Mag);
        Console.WriteLine("Применяем план питания - igromanoff V2");

        string? pow = Download("https://github.com/Igromanoff/Igromanoff-Tweaks/raw/refs/heads/main/Bin/igromanoff.pow",
                               "igromanoff_v2.pow");
        if (pow == null) { Thread.Sleep(3000); return; }

        RunHidden("powercfg", $"-import \"{pow}\" {PowerPlanGuid}");          // если план уже есть — игнорируем
        bool active = RunHidden("powercfg", $"-setactive {PowerPlanGuid}");

        Console.WriteLine(active
            ? $"{Grn}План питания включён.{Reset}"
            : $"{Red}Не удалось включить план питания.{Reset}");
        Thread.Sleep(2000);
    }

    // ───────────────────────────── ввод ─────────────────────────────

    // «Да = 1 / Нет = 2»
    static bool Ask(string title, params string[] notes)
    {
        while (true)
        {
            Cls();
            Console.WriteLine($"{Inv}{title}{Reset}\n");
            if (notes.Length > 0)
            {
                foreach (string n in notes) Console.WriteLine(n);
                Console.WriteLine();
            }
            Console.WriteLine($"{Bold}Да = 1{Reset}\n");
            Console.WriteLine($"{Bold}Нет = 2{Reset}\n");

            string? c = Console.ReadLine();
            if (c == null) return false;
            c = c.Trim();
            if (c == "1") return true;
            if (c == "2") return false;

            Console.WriteLine("Неверный выбор, попробуйте снова.");
            Thread.Sleep(1000);
        }
    }

    // Выбор из нескольких вариантов, возвращает 1..N (0 если поток ввода закрыт)
    static int AskOption(string title, params string[] options)
    {
        while (true)
        {
            Cls();
            Console.WriteLine($"{Inv}{title}{Reset}\n");
            foreach (string o in options) Console.WriteLine($"{Bold}{o}{Reset}\n");

            string? c = Console.ReadLine();
            if (c == null) return 0;
            if (int.TryParse(c.Trim(), out int n) && n >= 1 && n <= options.Length) return n;

            Console.WriteLine("Неверный выбор, попробуйте снова.");
            Thread.Sleep(1000);
        }
    }

    // Класс GUID видеодрайвера. Пустой ввод = стандартный класс видеоадаптеров.
    static string? AskGuid()
    {
        Console.Write($"{Mag}          ► Вставьте свой класс GUID ◄ {Dim}(Enter = {DisplayClass}){Reset} ");
        string s = (Console.ReadLine() ?? "").Trim();
        if (s.Length == 0) s = DisplayClass;

        if (!Guid.TryParse(s, out Guid g))
        {
            Console.WriteLine($"{Red}Неверный GUID.{Reset}");
            Thread.Sleep(2000);
            return null;
        }

        string guid = "{" + g.ToString().ToLowerInvariant() + "}";

        using var root = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
        using var k = root.OpenSubKey($@"SYSTEM\CurrentControlSet\Control\Class\{guid}\0000");
        if (k == null)
        {
            Console.WriteLine($"{Red}Не найден ключ драйвера: Class\\{guid}\\0000{Reset}");
            Thread.Sleep(3000);
            return null;
        }
        return guid;
    }

    // ───────────────────────────── реестр и команды ─────────────────────────────

    static void RunSteps(Step[] steps, string? guid = null)
    {
        foreach (Step s in steps)
        {
            Console.Write($"{Grn}{s.Title}{Reset}");
            int ok = 0, fail = 0;

            foreach (Reg r in s.Regs)
            {
                if (WriteReg(r, guid)) ok++; else fail++;
            }
            foreach (string c in s.Cmds)
            {
                if (Exec(c)) ok++; else fail++;
            }

            Console.WriteLine(fail == 0
                ? $"  {Dim}[{ok}]{Reset}"
                : $"  {Dim}[{ok} ок, {Yel}{fail} пропущено{Dim}]{Reset}");
            Thread.Sleep(StepDelayMs);
        }
    }

    static bool WriteReg(Reg r, string? guid = null)
        => WriteRegAt(r.Hive, r.Path.Replace("{guid}", guid ?? ""), r);

    // Эквивалент «reg add ... /f» (64-битное представление реестра, как у reg.exe)
    static bool WriteRegAt(H hive, string path, Reg r)
    {
        try
        {
            using var root = RegistryKey.OpenBaseKey(
                hive == H.LM ? RegistryHive.LocalMachine : RegistryHive.CurrentUser,
                RegistryView.Registry64);
            using var key = root.CreateSubKey(path, writable: true);
            if (key == null) return false;
            SetValue(key, r);
            return true;
        }
        catch
        {
            return false;
        }
    }

    static void SetValue(RegistryKey key, Reg r)
    {
        switch (r.Kind)
        {
            case K.Dword:
                long v = r.Data.StartsWith("0x", StringComparison.OrdinalIgnoreCase)
                    ? Convert.ToInt64(r.Data[2..], 16)
                    : long.Parse(r.Data);
                key.SetValue(r.Name, unchecked((int)v), RegistryValueKind.DWord);
                break;
            case K.Str:
                key.SetValue(r.Name, r.Data, RegistryValueKind.String);
                break;
            case K.Bin:
                key.SetValue(r.Name, Convert.FromHexString(r.Data), RegistryValueKind.Binary);
                break;
        }
    }

    // «netsh ...», «fsutil ...», «powercfg /h off», «PowerShell -Command ...»
    static bool Exec(string commandLine)
    {
        int i = commandLine.IndexOf(' ');
        string file = i < 0 ? commandLine : commandLine[..i];
        string args = i < 0 ? "" : commandLine[(i + 1)..];

        if (file.Equals("powershell", StringComparison.OrdinalIgnoreCase))
            args = "-NoProfile " + args;

        return RunHidden(file, args);
    }

    // Запуск без окна, вывод не показываем (как «>nul 2>&1» в bat). true = код выхода 0.
    static bool RunHidden(string file, string args)
    {
        try
        {
            var psi = new ProcessStartInfo(file, args)
            {
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
            };
            using var p = Process.Start(psi);
            if (p == null) return false;

            p.OutputDataReceived += (_, _) => { };
            p.ErrorDataReceived += (_, _) => { };
            p.BeginOutputReadLine();
            p.BeginErrorReadLine();
            p.WaitForExit();
            return p.ExitCode == 0;
        }
        catch
        {
            return false;
        }
    }

    // Запуск с видимым выводом и ожиданием завершения
    static int RunVisible(string file, params string[] args)
    {
        try
        {
            var psi = new ProcessStartInfo(file) { UseShellExecute = false };
            foreach (string a in args) psi.ArgumentList.Add(a);
            using var p = Process.Start(psi);
            p?.WaitForExit();
            return p?.ExitCode ?? -1;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"{Red}Не удалось запустить {Path.GetFileName(file)}: {ex.Message}{Reset}");
            return -1;
        }
    }

    // ───────────────────────────── загрузки ─────────────────────────────

    static HttpClient CreateHttp()
    {
        var c = new HttpClient { Timeout = TimeSpan.FromSeconds(90) };
        c.DefaultRequestHeaders.UserAgent.ParseAdd("Urland-InputLag/1.0");
        return c;
    }

    // Скачивает файл в %TEMP%\UrlandInputLag (проверка сертификата включена, в отличие от «curl -k»)
    static string? Download(string url, string fileName)
    {
        try
        {
            Directory.CreateDirectory(WorkDir);
            string path = Path.Combine(WorkDir, fileName);
            Console.WriteLine($"{Dim}Загрузка: {url}{Reset}");

            byte[] data = Http.GetByteArrayAsync(url).GetAwaiter().GetResult();
            File.WriteAllBytes(path, data);
            return path;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"{Red}Не удалось скачать {fileName}: {ex.Message}{Reset}");
            return null;
        }
    }

    // Скачать .ps1 и выполнить (powershell -ExecutionPolicy Bypass -File ...)
    static void RunRemoteScript(string url, string fileName)
    {
        string? ps1 = Download(url, fileName);
        if (ps1 == null) { Thread.Sleep(3000); return; }

        RunVisible("powershell", "-NoProfile", "-ExecutionPolicy", "Bypass", "-File", ps1);
        Thread.Sleep(1500);
    }

    static void OpenUrl(string url)
    {
        try { Process.Start(new ProcessStartInfo(url) { UseShellExecute = true }); }
        catch (Exception ex) { Console.WriteLine($"{Red}{ex.Message}{Reset}"); Thread.Sleep(2000); }
    }

    // ───────────────────────────── вывод ─────────────────────────────

    static void PrintArt(string[] art, string color)
    {
        Console.WriteLine(color);
        foreach (string l in art) Console.WriteLine(l);
        Console.WriteLine(Reset);
    }

    // «Применение твиков.» → «..» → «...» → «....»
    static void Intro(string text)
    {
        for (int i = 1; i <= 4; i++)
        {
            Cls();
            Console.WriteLine(text + new string('.', i));
            Thread.Sleep(500);
        }
        Cls();
    }

    static void Pause()
    {
        Console.WriteLine($"\n{Dim}Готово. Нажмите Enter, чтобы вернуться в меню...{Reset}");
        Console.ReadLine();
    }

    static void Cls()
    {
        try { Console.Clear(); } catch { /* вывод перенаправлен */ }
    }

    // ───────────────────────────── система ─────────────────────────────

    static bool IsAdmin()
    {
        using var id = WindowsIdentity.GetCurrent();
        return new WindowsPrincipal(id).IsInRole(WindowsBuiltInRole.Administrator);
    }

    [DllImport("kernel32.dll")] static extern IntPtr GetStdHandle(int n);
    [DllImport("kernel32.dll")] static extern bool GetConsoleMode(IntPtr h, out uint m);
    [DllImport("kernel32.dll")] static extern bool SetConsoleMode(IntPtr h, uint m);

    // включает цвета (ANSI) в консоли Windows вместо записи VirtualTerminalLevel в реестр
    static void EnableAnsi()
    {
        IntPtr h = GetStdHandle(-11);
        if (GetConsoleMode(h, out uint mode))
            SetConsoleMode(h, mode | 0x0004);   // ENABLE_VIRTUAL_TERMINAL_PROCESSING
    }
}
