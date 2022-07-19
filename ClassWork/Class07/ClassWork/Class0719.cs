using CommonMethods;

namespace Class07.ClassWork
{
    public class Class0719
    {
        public void DidziausiasSkaiciusSarase(List<int> skaiciai)
        {
            /*DIDŽIAUSIAS SĄRAŠE
             Duotas vienmatis sveikų skaičių sąrašas. 
             Parašykite programą, kuri suranda didžiausią skaičių saraše
             { 5, 1, 6, 8, 7 }

             rezultatas:  8*/

            DarbasSuKonsole.AtspausdintiSarasa(skaiciai);
            Console.WriteLine("Didziausias skaicius yra: {0}", RastiDidziausiaSkaiciu(skaiciai));
        }

        public static int RastiDidziausiaSkaiciu(List<int> skaiciai)
        {
            return skaiciai.Max();
        }

        public void DidziausioSkaiciausPridejimas(List<int> skaiciai)
        {
            /*DIDESNIS UŽ DIDŽIAUSIĄ
           Duotas vienmatis sveikų skaičių sąrašas. 
           Parašykite programą, kuri į sąrašo galą prideda vienetu didesnį skaičių už patį didžiausią

           pvz:
           { 5, 1, 6, 8, 7 }
           rezultatas:  5, 1, 6, 8, 7, 9*/

            DarbasSuKonsole.AtspausdintiSarasa(skaiciai);
            DarbasSuKonsole.AtspausdintiSarasa(PridetiDidziausiaSkaiciuGale(skaiciai),
                "Pridedam didziausia skaiciu gale:");
        }

        public static int GautiDidziausiaSkaiciuSarase(List<int> masyvas)
        {
            var didziausias = masyvas[0];
            for (int i = 0; i < masyvas.Count; i++)
                didziausias = didziausias >= masyvas[i] ? didziausias : masyvas[i];
            return didziausias;
        }

        public static List<int> PridetiDidziausiaSkaiciuGale(List<int> skaiciai)
        {
            skaiciai.Add(GautiDidziausiaSkaiciuSarase(skaiciai) + 1);
            return skaiciai;
        }
    }
}
