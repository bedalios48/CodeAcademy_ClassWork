namespace Class0620
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            /*PARAŠYTI PROGRAMĄ, KURI PAPRAŠO
            VARTOTOJO ĮVESTI GRUPĖS NARIŲ KIEKĮ.
            JEI NARIŲ KIEKIS LYGUS 1 PROGRAMA IŠVEDA
            „TAI SOLO ATLIKĖJAS“, JEI NARIŲ KIEKIS 2 --„TAI
            DUETAS“, JEI NARIŲ KIEKIS DAUGIAU NEI 2 BET
            MAŽIAU NEI 10 ––„TAI ANSAMBLIS“, JEI
            DAUGIAU NEI 10 ––„TAI KAMERINIS
            ANSAMBLIS“.*/
            try
            {
                Console.Write("Iveskite grupes nariu kieki: ");
                var nariuKiekis = int.Parse(Console.ReadLine());
                var tekstas = nariuKiekis switch
                {
                    1 => "Tai solo atlikejas",
                    2 => "Tai duetas",
                    int n when (n < 10 && n > 2) => "Tai ansamblis",
                    int n when n >= 10 => "Tai kamerinis ansamblis",
                    _ => "Netinkamas skaicius",
                };
                Console.WriteLine(tekstas);
            }
            catch (Exception e)
            {
                Console.WriteLine("Klaida");
                Console.WriteLine(e.ToString());
            }

            /*PARAŠYTI PROGRAMĄ, KURI
            PAPRAŠO VARTOTOJO ĮVESTI
            IŠDIRBTAS VALANDAS.
            JEI VALANDŲ YRA MAŽIAU NEI 160,
            PROGRAMA TURI PARODYTI, KIEK
            DAR REIKIA IŠDIRBTI, JEI LYGIAI 160,
            PARODO, KAD IŠDIRBTAS PILNAS
            ETATAS, JEI DAUGIAU PARODO
            KIEK YRA VIRŠVALANDŽIŲ.
            JEI VARTOTOJAS PADARO ĮVEDIMO
            KLAIDĄ PRANEŠTI IR UŽBAIGTI
            DARBĄ*/
        }
    }
}