using Auto;

Autok piros =new Autok();
piros.marka = "toyota";
piros.Eletkor = 5;

Autok kek=new Autok();
Console.Write("Kérem az autó márkáját:");kek.marka=Console.ReadLine();
Console.Write("Kérem az autó Életkorát:");kek.Eletkor=Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"1.példány:{piros.marka},${piros.Eletkor}Életkor");
Console.WriteLine($"2.példány:{kek.marka},${kek.Eletkor}Életkor");
Console.ReadKey();