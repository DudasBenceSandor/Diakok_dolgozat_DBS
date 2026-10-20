using System;
using System.Collections.Generic;
using System.Text;

namespace Diakok_dolgozat.Modul
{
    internal class Diak
    {

        public int ID { get; set; }
        public string Nev { get; set; }
        public string Nem { get; set; }
        public int SzuletesiEv {  get; set; }
        public double Atlag {  get; set; }
        public bool Bajai { get; set; }
        public static int DiakokSzama;


        public Diak(int id,string nev,string nem,int szuletesiEv,double atlag,bool bajai)
        {
            ID = id;
            Nev = nev;
            Nem = nem;
            SzuletesiEv = szuletesiEv;
            Atlag = atlag;
            Bajai = bajai;
            DiakokSzama++;
        }

        public Diak(int id, string nev, string nem, int szuletesiEv, double atlag)
        {
            ID = id;
            Nev = nev;
            Nem = nem;
            SzuletesiEv = szuletesiEv;
            Atlag = atlag;
            Bajai = true;
            DiakokSzama++;
        }


        public Diak()
        {
            DiakokSzama++;
        }

        public void Eletkor()
        {
            Console.WriteLine($"A diák életkora {2026-SzuletesiEv}");
        }

        public override string ToString()
        {
            string holvan = Bajai ? "Baján lakik" : "Nem lakik Baján";
            return $"A diák azonosítója: {ID}, neve: {Nev}, neme: {Nem}, születési év: {SzuletesiEv}, átlaga: {Math.Round(Atlag,1)} és {holvan}";
        }

        public static string LetszamSzoveg(string mennyiseg)
        {
            mennyiseg = $"{DiakokSzama}db diák lett példényosítva";
            return mennyiseg;
        }
    }
}
