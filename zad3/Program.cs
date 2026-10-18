int f_rations;
int team_n;
int days_of_t;

string t_f_rations;
string t_team_n;
string t_days_of_t;

Console.WriteLine("podaj ilosc racji");
t_f_rations = Console.ReadLine();
Console.WriteLine("podaj osob");
t_team_n = Console.ReadLine();
Console.WriteLine("podaj dni przygody");
t_days_of_t = Console.ReadLine();

int.TryParse(t_f_rations, out f_rations);
int.TryParse(t_team_n, out team_n);
int.TryParse(t_days_of_t, out days_of_t);

Console.WriteLine("team dostanie po "+(f_rations/team_n)+" racji z czego zostanie "+(f_rations%team_n)+" w zapasie");
Console.WriteLine("dziennie "+((f_rations/team_n)/(double)days_of_t)+" na osobe "+((double)f_rations/days_of_t)+" w zapasie");
