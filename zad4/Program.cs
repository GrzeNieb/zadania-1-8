int life;
int mixture_am;
bool key_p;
bool map_p;

string t_life;
string t_mixture_am;
string t_key_p;
string t_map_p;

bool alive=false;
bool full_hp=false;
bool supplies=false;
bool nav_toot_p=false;
bool req_heal=false;
bool ready_travel=false;

Console.WriteLine("ile masz hp (przedzial od 0 do 100)");
t_life = Console.ReadLine();
Console.WriteLine("ile masz mikstur");
t_mixture_am = Console.ReadLine();
Console.WriteLine("czy masz mapę (true lub false)");
t_map_p = Console.ReadLine();
Console.WriteLine("czy masz klucz (true lub false)");
t_key_p = Console.ReadLine();

int.TryParse(t_life, out life);
int.TryParse(t_mixture_am, out mixture_am);
bool.TryParse(t_map_p, out map_p);
bool.TryParse(t_key_p, out key_p);

while(key_p==true && map_p==true || key_p==false && map_p==true || key_p==true && map_p==false)
{
    nav_toot_p=true;
    Console.WriteLine("Ma klucz lub mapę: True");
    break;
}
while (mixture_am > 0)
{
    supplies=true;
    Console.WriteLine("Ma zaopatrzenie: True");
    break;
}
while (life < 0)
{
    alive=true;  
    break;
}
while (life == 100)
{
    full_hp=true;
    req_heal =!full_hp;
    break;
}
while(alive==true && supplies==true && nav_toot_p == true)
{
   ready_travel=true;
}
Console.WriteLine("Gotowy do wyprawy: "+ready_travel);
Console.WriteLine("Wymaga leczenia: "+req_heal);
Console.WriteLine("Ma pełne zdrowie: "+full_hp);
Console.WriteLine("Żyje: "+alive);
Console.WriteLine("Ma zaopatrzenie: "+supplies);