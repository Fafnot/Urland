using System.Diagnostics;

public static class Ping
{
    public static void InNewWindow(string host = "8.8.8.8")
    {
        if (OperatingSystem.IsWindows())
        {
            Process.Start(new ProcessStartInfo("cmd.exe", $"/k ping -t {host}") { UseShellExecute = true });
        }
        else if (OperatingSystem.IsMacOS())
        {
            string script = $"tell application \"Terminal\" to do script \"ping {host}\"";
            Process.Start("osascript", new[] { "-e", script });
        }
        else
        {
            foreach (var term in new[] { "x-terminal-emulator", "gnome-terminal", "konsole", "xfce4-terminal", "xterm" })
            {
                try
                {
                    var psi = new ProcessStartInfo(term);
                    psi.ArgumentList.Add(term == "gnome-terminal" ? "--" : "-e");
                    psi.ArgumentList.Add("ping");
                    psi.ArgumentList.Add(host);
                    Process.Start(psi);
                    return;
                }
                catch { /* нет такого терминала, пробуем следующий */ }
            }
            Console.WriteLine("Терминал не найден");
        }
    }
}
