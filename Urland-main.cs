using System.Text;


Console.OutputEncoding = Encoding.UTF8;
Console.Title = "Urland";

var finish_program = false;

// Баннеры для программы 
string urland_main_banner = File.ReadAllText("ascii_art_txt/Urland.txt");
string next_banner = File.ReadAllText("ascii_art_txt/next.txt");


// цикл для программы 
while (!finish_program)
{
    Console.Clear();
    Console.WriteLine(urland_main_banner);
    var name = Console.ReadLine();

    switch (name)
    {
        case "exit":
            finish_program = true;
            return;
        case "next":
            // переход на next баннер и на его фукций 
            var next_finish = false;
            while (!next_finish)
            {
                Console.Clear();
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
            
    }
}




