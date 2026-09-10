using Bankszamla;

Console.WriteLine("Befizetés:1 ;Kifizetés:2");
Bankszla peldany = new Bankszla();
string irany=Console.ReadLine();
if (irany =="1")
{
    Console.WriteLine("Mekkora összeget szeretne befizetni?");
    double be = Convert.ToDouble(Console.ReadLine());
    peldany.befizetés(be);
}
else
{
    Console.WriteLine("Mekkora összeget szeretne kifizetni?");
    double ki= Convert.ToDouble(Console.ReadLine());
    peldany.kivet(ki);
}