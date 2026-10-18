string imie = "imie";
char symbol = '@';
string poziom_txt;
int poziom = 2;
int zloto = 3;
double waga = 5.2;
bool mapa = true;

Console.WriteLine("=== EKWIPUNEK === \nImię (string): "+imie+"\nSymbol (char): "+symbol+"\nPoziom (int): "+poziom+"\nZłoto (int): "+zloto+"\nWaga (double): "+waga+"\nWaga (double): "+zloto+"\nMa mapę (bool): "+mapa);

Console.WriteLine("Zmień dane: imie");
imie = Console.ReadLine();
Console.WriteLine("zmien dane: poziom");
poziom_txt = Console.ReadLine();
int.TryParse(poziom_txt, out poziom);

Console.WriteLine("=== EKWIPUNEK === \nImię (string): "+imie+"\nSymbol (char): "+symbol+"\nPoziom (int): "+poziom+"\nZłoto (int): "+zloto+"\nWaga (double): "+waga+"\nWaga (double): "+zloto+"\nMa mapę (bool): "+mapa);
