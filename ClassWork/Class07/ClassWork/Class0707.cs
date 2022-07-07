using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class07.ClassWork
{
    public class Class0707
    {
        public void LyginiuSkaiciuSpausdinimas()
        {
            /*
             * Paprašyti vartotojo įvesti bet kokį skaičių. 
             * Išvesti visus lyginius skaičius nuo 0 iki pasirinkto skaičiaus, 
             * vienoje eilutėje per kablelį. Pvz.: 0, 2, 4, 6.....
             */

            Console.WriteLine("Iveskite skaiciu");
            var skaicius = int.Parse(Console.ReadLine());
            Console.WriteLine(IsvestiLyginiusSkaicius(skaicius));
        }

        private string IsvestiLyginiusSkaicius(int skaicius)
        {
            var i = 0;
            var skaiciai = "";
            while(i <= skaicius)
            {
                if (i % 2 == 0)
                    skaiciai += i.ToString() + ", ";
                i++;
            }
            return skaiciai.TrimEnd().TrimEnd(',');
        }

        public void SkaiciuSumavimas()
        {
            /*
             * Parasyti programa kuri apskaiciuoja visu ivestu skaiciu suma, 
             * kurie buvo ivesti iki ivesto neigiamo skaiciaus
             * 
             * PVZ
             * 1,23,4,5,7,8,-1
             */

            Console.WriteLine("Iveskite skaicius. Kai baigsite, iveskite neigiama skaiciu:");
            var i = 0;
            var suma = 0;
            while(i >= 0)
            {
                suma += i;
                i = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Suma yra {0}", suma);
        }

        public void Slaptazodis()
        {
            /*
             *6.Parasykite slaptazodzio ivedimo simuliacija.Pirma kompiuteris paprasys, kad nustatytumete slaptazodi tada prasys naudotojo 
             *pakartoti slaptazodi. Bet koks neteisingas ivedimas grazina “Slaptazodis neteisingas. Bandykite dar karta”. 
             *Kada slaptazodis atspejamas turi buti isvedamas tekstas “Sveikinam! Prisijungete!”.
             *BONUS TASKAI: Padarykite taip, kad po 3 neteisingai ivestu slaptazodzio kartu programa ismestu teksta “Jus uzblokuotas” ir iseitu is ciklo.
             */
            Console.WriteLine("Iveskite slaptazodi:");
            var slaptazodis = Console.ReadLine();
            var i = 0;

            while(true)
            {
                Console.WriteLine("Pakartokite slaptazodi:");
                var bandymas = Console.ReadLine();
                if(bandymas == slaptazodis)
                {
                    Console.WriteLine("Sveikinam! Prisijungete!");
                    break;
                }
                i++;
                if(i==3)
                {
                    Console.WriteLine("Jus uzblokuotas");
                    break;
                }
                Console.WriteLine("Slaptazodis neteisingas.Bandykite dar karta");
            }
        }
    }
}
