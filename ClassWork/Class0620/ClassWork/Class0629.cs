namespace Class0620.ClassWork
{
    public class Class0629
    {
        public void TekstasMokausi()
        {
            /* Parašykite programą kurioje vienas metodas. 
            - Naudotojo paprašome įvesti betkokį tekstą Main metode. 
            - Metodas grąžina žodžius Taip arba Ne ar tekste rado žodį 'mokausi'. N.B. grąžinama string, o ne bool.
            -  Išvesti rezultatą Main metode.
            Pvz: 
            > Iveskite teksta:
            _ ' as labai mokausi programuoti     '
            > Ar yra mokausi: Taip*/

            Console.WriteLine("Iveskite teksta:");
            var tekstas = Console.ReadLine();
            Console.WriteLine("Ar yra mokausi: {0}", ArYraTekstasMokausi(tekstas) ? "Taip" : "Ne");
        }

        public static bool ArYraTekstasMokausi(string tekstas)
        {
            return tekstas.Contains("mokausi");
        }

        public void ZodisMokausi()
        {
            /*Parašykite programą kurioje vienas metodas. 
            - Naudotojo paprašome įvesti betkokį tekstą Main metode. 
            - Metodas grąžina žodžius Taip arba Ne ar tekste rado žodį 'mokausi'. 
                Bet tik tuo atveju jei žodis 'mokausi' nesulipęs su kitu žodžiu.
                N.B. grąžinama string, o ne bool.
            -  Išvesti rezultatą Main metode.
            Pvz: 
            > Iveskite teksta:
            _ ' as labai mokausi programuoti     '
            > Ar yra mokausi: Taip
            Pvz: 
            > Iveskite teksta:
            _ ' as_labai_mokausi_programuoti     '
            > Ar yra mokausi: Ne*/

            Console.WriteLine("Iveskite teksta:");
            var tekstas = Console.ReadLine();
            Console.WriteLine("Ar yra mokausi: {0}", ArYraZodisMokausi(tekstas) ? "Taip" : "Ne");
        }

        public static bool ArYraZodisMokausi(string? tekstas)
        {
            tekstas = " " + tekstas + " ";
            return tekstas.Contains(" mokausi ");
        }

        public void PirmosARaidesVieta()
        {
            /*Parašykite programą kurioje yra vienas metodas.
              - Main metode Naudotojo paprašome įvesti betkokį tekstą su tarpais
              - Įvestas teikstas kaip argumentas perduodamas metodui. Metodas grąžina pirmos 'a' raidės vietą tekste.
              - Main metode į ekraną išveskite metodo darbo rezultatą
              Pvz:
              > Iveskite teksta:
              _ as mokausi programuoti
              > 'a' raides vieta yra: 0*/

            Console.WriteLine("Iveskite teksta:");
            Console.WriteLine("\'a\' raides vieta yra: {0}",
                GrazintiPirmosARaidesVieta(Console.ReadLine()));
        }

        public static int GrazintiPirmosARaidesVieta(string text)
        {
            return text.IndexOf("a");
        }
    }
}
