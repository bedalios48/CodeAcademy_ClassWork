using System.Text;

namespace Class07.ClassWork
{
    public class Class0720
    {
        #region

        #endregion
        /// <summary>
        ///  Parašyti metodą IstrauktiSkaicius, kuris priima teksta, bet grazina tik skaicius egzistuojancius paciame tekste.
        ///  Isgavus teksta programa turetu naudoti naujai sukurta SurikiuotiSkaiciusIsTeksto metoda, kuris priima "string 
        ///  skaiciaiTekste" ir surikiuoja skaicius
        ///  didejimo tvarka. SurikiuotiSkaiciusIsTeksto privalo panaudoti foreach, kad suformuotumet nauja List<int>:
        ///  PVZ: Ivedame: 1sd512sd5. Programa be rusiavimo grazina mums: 15125. Programa su rusiavimu grazina mums: 11255
        /// </summary>
    
        public void SkaiciuIsTekstoRikiavimas()
        {
            Console.WriteLine("Iveskite teksta:");
            var tekstas = Console.ReadLine();
            Console.WriteLine("Surikiuoti skaiciai: {0}", string.Join("",SurikiuotiSkaicius(IstrauktiSkaiciusIsTeksto(tekstas))));
        }

        public static string IstrauktiSkaiciusIsTeksto(string tekstas)
        {
            var skaiciai = new StringBuilder();
            foreach(var simbolis in tekstas)
                if(int.TryParse(simbolis.ToString(), out _))
                    skaiciai.Append(simbolis);

            return skaiciai.ToString();
        }

        public static List<int> SurikiuotiSkaicius(string skaiciaiTekste)
        {
            var skaiciuSarasas = new List<int>();
            foreach (var skaicius in skaiciaiTekste)
                skaiciuSarasas.Add(int.Parse(skaicius.ToString()));
            skaiciuSarasas.Sort();

            return skaiciuSarasas;
        }

        /// <summary>
        ///  Parašyti metodą IsmetytiZodzius, kuris priima sakini, bet grazina nauja zodziu List 
        ///  sudaryta tik is zodziu, kurie ilgesni nei 5 raides ir yra surikiuoti abeceles tvarka.
        ///  Tada parasykite metoda, kuris priima 2 zodziu sarasus, juos sujungia i viena kolekcija
        ///  naudojant ciklus ir atspausdina ekrane.
        ///  PRIMINIMAS: Kad isskirti string i atskirus zodzius naudokite pavyzdinisString.Split(' ')
        ///  PVZ: Ivedame: "Labas as esu Kodelskis ir labai megstu programuoti". 
        ///  Programa be rusiavimo grazina mums: as esu ir Labas Kodelskis labai megstu programuoti
        ///  Programa su rusiavimu grazina mums: as esu ir Kodelskis labai Labas megstu programuoti
        /// </summary>
        /// 

        public void SakinioZodziuRikiavimas()
        {
            Console.WriteLine("Iveskite teksta:");
            var tekstas = Console.ReadLine();
            var ilgiZodziai = IsmetytiZodzius(tekstas, 5, out var trumpiZodziai);
            Console.WriteLine("Isskaidyti surikiuoti zodziai: {0}", 
                string.Join(" ", SujungtiDuSarasus(trumpiZodziai, ilgiZodziai)));
        }

        public static List<string> IsmetytiZodzius(string sakinys, int ilgoZodzioIlgis, out List<string> trumpiZodziai)
        {
            trumpiZodziai = IsskaidytiSakini(sakinys);
            var ilgiZodziai = AtskirtiIlgesniusZodzius(trumpiZodziai, ilgoZodzioIlgis);
            Console.WriteLine("Isskaidyti zodziai: {0}", string.Join(" ", SujungtiDuSarasus(trumpiZodziai, ilgiZodziai)));
            SurikiuotiZodzius(ilgiZodziai);
            return ilgiZodziai;
        }

        public static List<string> IsskaidytiSakini(string sakinys)
        {
            return sakinys.Split(' ').ToList();
        }

        public static List<string> AtskirtiIlgesniusZodzius(List<string> zodziai, int ilgis)
        {
            var ilgiZodziai = new List<string>();
            foreach(var zodis in zodziai.ToList())
            {
                if(zodis.Length >= ilgis)
                {
                    zodziai.Remove(zodis);
                    ilgiZodziai.Add(zodis);
                }
            }

            return ilgiZodziai;
        }

        public static void SurikiuotiZodzius(List<string> zodziai)
        {
            zodziai.Sort();
        }

        public static List<string> SujungtiDuSarasus(List<string> pirmas, List<string> antras)
        {
            List<string> result = new List<string>();
            result.AddRange(pirmas);
            result.AddRange(antras);
            return result;
        }
    }
}
