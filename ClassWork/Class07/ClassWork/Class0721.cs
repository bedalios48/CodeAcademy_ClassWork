using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class07.ClassWork
{
    public class Class0721
    {
    /*    Parašyti metodą SukonstruotiKalade(rusis, kortos). Sis metodas turi sukonstruoti kalade is duotu 2 string sarasu.
        ///  Po to parasyti metoda, kuris surikiuoja jusu kalade pagal abeceles tvarka.
        ///  Ir galiausiai parasyti, kad jusu visas kortas atspausdintu ekrane.
        ///  PRIMINIMAS: 
        ///  Kortu rusys

 * "Sirdziu",
        "Bugnu",
        "Vynu",
        "Kryziu",
 * 
 * Kortos
 * 
 * "Tuzas",
        "Dviake",
        "Triake",
        "Keturake",
        "Penkake",
        "Sesake",
        "Septynake",
        "Astuonake",
        "Devynakės",
        "Desimtake",
        "Valetas",
        "Dama",
        "Karalius",

PVZ: Isvedimas - Bugnu Tuzas, Bugnu Dviake...Bugnu Dama, Bugnu Karalius... Kryziu Karalius*/

        public void KaladesKonstravimas()
        {
            var rusys = new List<string>
            {
                "Sirdziu",
                "Bugnu",
                "Vynu",
                "Kryziu"
            };
            var kortos = new List<string>
            {
                "Tuzas",
                "Dviake",
                "Triake",
                "Keturake",
                "Penkake",
                "Sesake",
                "Septynake",
                "Astuonake",
                "Devynakės",
                "Desimtake",
                "Valetas",
                "Dama",
                "Karalius"
            };

            var kalade = SukonstruotiKalade(rusys, kortos);
            Console.WriteLine();
            Console.WriteLine("Kortu kalade:");
            AtspausdintiKalade(kalade);

            SurikiuotiKalade(kalade);
            Console.WriteLine();
            Console.WriteLine("Surikiuojame kalade:");
            AtspausdintiKalade(kalade);
        }
        public static List<string> SukonstruotiKalade(List<string> rusys, List<string> kortos)
        {
            var kalade = new List<string>();
            foreach(var rusis in rusys)
                foreach (var korta in kortos)
                    kalade.Add($"{rusis} {korta}");

            return kalade;
        }

        public static void SurikiuotiKalade(List<string> kalade)
        {
            kalade.Sort();
        }

        public void AtspausdintiKalade(List<string> kalade)
        {
            foreach(var korta in kalade)
                Console.WriteLine(korta);
        }
}
}
