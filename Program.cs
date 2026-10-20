namespace Diakok_dolgozat.Modul
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Diak Bence = new Diak(1000,"Bence","Férfi",2006,3.77,false);
            Diak Szabi = new Diak(1001,"Szabi","Férfi",2009,4.89);
            Diak Nora = new Diak(1002, "Nora", "Nő", 2007, 4.66);
            Diak Lili = new Diak(1003,"Lili","Nő",2008,4.49,true);
            
            Console.WriteLine(Bence.ToString());
            Bence.Eletkor();
            Console.WriteLine(Szabi);
            Szabi.Eletkor();
            Console.WriteLine(Nora.ToString());
            Nora.Eletkor();
            Console.WriteLine(Lili.ToString());
            Lili.Eletkor();


            Console.WriteLine(Diak.LetszamSzoveg(Diak.DiakokSzama.ToString()));


            Diak diak = new Diak();
            Console.WriteLine("Kérlek add meg az új diák azonosítóját:");
            diak.ID = int.Parse(Console.ReadLine());

            Console.WriteLine("Kérlek add meg az új diák nevét:");
            diak.Nev = Console.ReadLine();

            Console.WriteLine($"Kérlek add meg {diak.Nev} nemét:");
            diak.Nem = Console.ReadLine();

            Console.WriteLine($"Kérlek add meg {diak.Nev} születési évét:");
            diak.SzuletesiEv = int.Parse(Console.ReadLine());

            Console.WriteLine($"Kérlek add meg {diak.Nev} átlagát:");
            diak.Atlag = double.Parse(Console.ReadLine());

            Console.WriteLine($"{diak.Nev} Baján lakik? (Igem/Nem)");
            string holVan = Console.ReadLine();
            if(holVan == "Igen")
            {
                diak.Bajai = true;
            }
            else
            {
                diak.Bajai = false;
            }


            Console.WriteLine(diak.ToString());
            diak.Eletkor();


            Console.WriteLine(Diak.LetszamSzoveg(Diak.DiakokSzama.ToString()));

        }
    }
}
