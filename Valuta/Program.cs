using Valuta;

ValutaValto peldany = new ValutaValto();

peldany.Arfolyam = 370;

Console.WriteLine($"Euró:100,Árfolyam:{ peldany.EurorolHuf(100)}Ft");

Console.WriteLine($"Euró:100,Árfolyam:{ValutaValto.FixEurorolHuf(100)}");
