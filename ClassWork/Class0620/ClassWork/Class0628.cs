namespace Class0620.ClassWork
{
    public class Class0628
    {
        public void SutrumpintoTekstoIlgis()
        {
            /*Parašykite programą kurioje vienas metodas.
            - Naudotojo paprašome įvesti betkokį tekstą Main metode.
            - Metodas į ekraną išveda teksto ilgį be tarpų įvesto teksto pradžioje ir gale
            Pvz:
            > Iveskite teksta:
            _ ' as mokausi '
            > Teksto ilgis yra: 10*/

            Console.WriteLine("Iveskite bet koki teksta:");
            var tekstas = Console.ReadLine();
            PanaikintiTarpusKrastuose(ref tekstas);
            Console.WriteLine("Teksto ilgis yra {0}", tekstas.Length);
        }

        public static void PanaikintiTarpusKrastuose(ref string tekstas)
        {
            tekstas = tekstas.Trim();
        }

    public void ZodziuKiekis()
        {
            /*Parašykite programą kurioje yra vienas metodas priimantis vieną argumentą.
            - Main metode naudotojo paprašome įvesti betkokį tekstą su tarpais
            - Įvestas tekstas metodui perduodamas per parametrus ir grąžina žodžių kiekį
            - Main metode į ekraną išveskite žodžių kiekį
            Pvz:
            > Iveskite teksta:
            _ as mokausi programuoti
            > Zodziu kiekis yra: 3*/

            Console.WriteLine("Iveskite teksta su tarpais:");
            var tekstas = Console.ReadLine();
            Console.WriteLine("Zodziu kiekis yra: {0}", SkaiciuotiZodzius(tekstas));
        }

        public static int SkaiciuotiZodzius(string tekstas)
        {
            var zodziai = tekstas.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            return zodziai.Count();
        }

        public void TarpuKiekisGale()
        {
            /*Parašykite programą kurioje vienas metodas.
           - Naudotojo paprašome įvesti betkokį tekstą Main metode.
           - Metodas grąžina tarpų kiekį teksto gale
           - Main į ekraną išveda rezultatą
           Pvz:
           > Iveskite teksta:
           _ ' as mokausi      '
           > Gale yra tarpų: 6*/

            Console.WriteLine("Iveskite teksta su tarpais gale:");
            var tekstas = Console.ReadLine();
            Console.WriteLine("Gale yra tarpu: {0}", GrazintiTarpuKiekiTekstoGale(tekstas));
        }

        public static int GrazintiTarpuKiekiTekstoGale(string tekstas)
        {
            return tekstas.Length - tekstas.TrimEnd().Length;
        }

        public void TarpuKiekisPradzioje()
        {
            /*Parašykite programą kurioje vienas metodas.
           - Naudotojo paprašome įvesti betkokį tekstą Main metode.
           - Metodas grąžina tarpų kiekį teksto pradžioje
           - Main į ekraną išveda rezultatą
           Pvz:
           > Iveskite teksta:
           _ ' as mokausi      '
           > Pradžioje yra tarpų: 1*/

            Console.WriteLine("Iveskite teksta su tarpais pradzioje:");
            var tekstas = Console.ReadLine();
            Console.WriteLine("Pradzioje yra tarpu: {0}", GrazintiTarpuKiekiTekstoPradzioje(tekstas));
        }

        public static int GrazintiTarpuKiekiTekstoPradzioje(string tekstas)
        {
            return tekstas.Length - tekstas.TrimStart().Length;
        }

        public void TarpaiPriekyIrGale()
        {
            /*Parašykite programą kurioje vienas metodas.
              - Naudotojo paprašome įvesti betkokį tekstą Main metode.
              - Metodas grąžina dvi reikšmes pirmoji - tarpų kiekį teksto pradžioje, antroji - tarpų kiekį teksto gale
                <hint> naudoti out
              - Main į ekraną išveda rezultatą
              Pvz:
              > Iveskite teksta:
              _ ' as mokausi      '
              > Pradžioje yra tarpų: 1
              > Gale yra tarpų: 6*/

            Console.WriteLine("Iveskite teksta su tarpais pradzioje:");
            var tekstas = Console.ReadLine();
            var tarpaiGale = GrazintiTarpusGale(tekstas, out var tarpaiPradzioje);
            Console.WriteLine("Pradzioje yra tarpu: {0}", tarpaiPradzioje);
            Console.WriteLine("Gale yra tarpu: {0}", tarpaiGale);
        }

        public static int GrazintiTarpusGale(string tekstas, out int tarpaiPradzioje)
        {
            tarpaiPradzioje = tekstas.Length - tekstas.TrimStart().Length;
            return tekstas.Length - tekstas.TrimEnd().Length;
        }

        public void ARaidziuSkaiciavimas()
        {
            /*Parašykite programą kurioje yra vienas metodas.
            - Main metode Naudotojo paprašome įvesti betkokį tekstą su tarpais
            - Įvestas teikstas kaip argumentas perduodamas metodui. Metodas grąžina 'a' raidžių kiekį tekste.
            - Main metode į ekraną išveskite metodo darbo rezultatą
            Pvz:
            > Iveskite teksta:
            _ as mokausi programuoti
            > 'a' raidžių kiekis yra: 3*/

            Console.WriteLine("Iveskite teksta su tarpais:");
            var tekstas = Console.ReadLine();
            Console.WriteLine("\'a\' raidziu kiekis yra: {0}", GrazintiARaidziuSkaiciu(tekstas));
        }

        public static int GrazintiARaidziuSkaiciu(string tekstas)
        {
            return tekstas.Split('a').Count() - 1;
        }
    }
}
