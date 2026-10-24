using System.Text;
using System.Diagnostics;


Console.OutputEncoding = Encoding.UTF8;
Console.Title = "Urland";

var finish_program = false;

// Баннеры для программы 
string urland_main_banner = File.ReadAllText("ascii_art_txt/Urland.txt");
string next_banner = File.ReadAllText("ascii_art_txt/next.txt");
string install_banner = File.ReadAllText("ascii_art_txt/install.txt");


// цикл для программы 
while (!finish_program)
{
    ClearScreen();
    Console.WriteLine(urland_main_banner);
    var name = Console.ReadLine();

    switch (name)
    {
        case "exit":
            finish_program = true;
            return;
        case "store":
            Process.Start(new ProcessStartInfo(Path.GetFullPath("main/store_html.html")) { UseShellExecute = true });
            break;
        case "soft":
            Process.Start(new ProcessStartInfo(Path.GetFullPath("main/soft_index.html")) { UseShellExecute = true });
            break;
        case "inputlag":
            Process.Start(new ProcessStartInfo(Path.GetFullPath("main/inputlag.bat")) { UseShellExecute = true });
            break;
        case "basket":
            Process.Start(new ProcessStartInfo(Path.GetFullPath("main/basket.lnk")) { UseShellExecute = true });
            break;
        case "ping":
            Process.Start(new ProcessStartInfo(Path.GetFullPath("main/ping_8.8.8.8.bat")) { UseShellExecute = true });
            Process.Start(new ProcessStartInfo(Path.GetFullPath("main/ping_google.com.bat")) { UseShellExecute = true });
            break;
        case "next":
            // переход на next баннер и на его фукций 
            var next_finish = false;
            while (!next_finish)
            {
                ClearScreen();
                Console.WriteLine(next_banner);

                var name_next = Console.ReadLine();

                switch (name_next)
                {
                    case "back":
                        next_finish = true;
                        break;
                    case "exit":
                        next_finish = true;
                        finish_program = true;
                        break;
                }
            }
            break;
        case "install":
            // Переход на install баннер и его функций 
            var install_finish = false;
            while (!install_finish)
            {
                ClearScreen();
                Console.WriteLine(install_banner);

                var name_install = Console.ReadLine();

                switch (name_install)
                {
                    case "back":
                        install_finish = true;
                        break;
                    case "exit":
                        install_finish = true;
                        finish_program = true;
                        break;
                }
            }
            break;

    }

}

static void ClearScreen()
{
    Console.Write("\u001b[2J\u001b[3J\u001b[H");
}




