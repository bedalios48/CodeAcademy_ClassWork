namespace CommonMethods
{
    public class DarbasSuKonsole
    {
        public static int GautiIvestaSveikaSkaiciu(string zinute = null)
        {
            if (zinute != null)
                Console.WriteLine(zinute);
            int skaicius;
            while(!int.TryParse(Console.ReadLine(), out skaicius))
            {
                Console.WriteLine("Ivesta neteisingai. Veskite dar karta");
            }
            return skaicius;
        }

        public static double GautiIvestaSkaiciu(string zinute)
        {
            Console.WriteLine(zinute);
            double skaicius;
            while (!double.TryParse(Console.ReadLine(), out skaicius))
            {
                Console.WriteLine("Ivesta neteisingai. Veskite dar karta");
            }
            return skaicius;
        }

        public static char GautiIvestaRaide(string zinute)
        {
            Console.WriteLine(zinute);
            char raide;
            while (!char.TryParse(Console.ReadLine(), out raide)
                || !(((int)raide >= 65 && (int)raide <= 90) || ((int)raide >= 97 && (int)raide <= 122)))
            {
                Console.WriteLine("Ivesta neteisingai. Veskite dar karta");
            }
            return raide;
        }
        public static void AtspausdintiSarasa(IEnumerable<string> zodziai, string zinute = null)
        {
            if (zinute == null)
            {
                Console.WriteLine("Sarasas yra: {0}", string.Join("; ", zodziai));
                return;
            }

            Console.WriteLine(zinute + " " + string.Join("; ", zodziai));
        }
        public static void AtspausdintiSarasa(IEnumerable<int> skaiciai, string zinute = null)
        {
            if (zinute == null)
            {
                Console.WriteLine("Sarasas yra: {0}", string.Join("; ", skaiciai));
                return;
            }

            Console.WriteLine(zinute + " " + string.Join("; ", skaiciai));
        }
    }
}
