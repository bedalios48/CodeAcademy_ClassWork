using System.Text;

namespace Class07.ClassWork
{
    internal class Class0712
    {
        public void StatusisTrikampis()
        {
            /*
            Sukurti metodą SkaiciuTrikampis, kuri paprašo vartotojo įvesti skaičių nuo 1 iki 9 
            (jeigu įveda netinkamą skaičių prašo įvesti vėl, kol įves tinkamą). 
            Metodas turi grąžinti atitinkamą statųjį trikampį su tiek eilučių koks skaičius įvestas.
            5
            55
            555
            5555
            55555
             */
            var skaicius = GautiSkaiciu();
            Console.WriteLine(StatusisTrikamis(skaicius));

        }

        private string StatusisTrikamis(int skaicius)
        {
            var sb = new StringBuilder();
            var result = new StringBuilder();
            for (int i = 1; i <= skaicius; i++)
            {
                sb.Append(i.ToString());
                result.Append(sb.ToString());
                result.Append(Environment.NewLine);
            }
            return result.ToString();
        }

        public void LygiasonisTrikampis()
        {
            /* Sukurti metodą SkaiciuPiramide, kuri paprašo vartotojo įvesti skaičių nuo 1 iki 9
           jeigu įveda netinkamą skaičių
           prašo įvesti vėl, kol įves tinkamą Programa turi atspausdinti atitinkamą lygiašonį trikampį.
            7
            77
            777
            7777
            77777
            777777
            7777777
            777777
            77777
            7777
            777
            77
            7*/

            var skaicius = GautiSkaiciu();
            Console.WriteLine(LygiasonisTrikampis(skaicius));
        }

        private string LygiasonisTrikampis(int skaicius)
        {
            var sb = new StringBuilder();
            var result = new StringBuilder();
            for (int i = 1; i <= 2 * skaicius; i++)
            {
                if (i <= skaicius)
                    sb.Append(skaicius.ToString());
                else
                    sb.Remove(sb.Length - 1, 1);
                result.Append(sb.ToString());
                result.Append(Environment.NewLine);
            }
            return result.ToString();
        }

        public void DidejanciuSkaiciuPiramide()
        {
            /* Sukurti metodą DidejanciuSkaiciuPiramide, kuri paprašo vartotojo įvesti skaičių nuo 1 iki 9 
          (jeigu įveda netinkamą skaičių prašo įvesti vėl, kol įves tinkamą )). 
          Metodas turi grąžinti atitinkamą lygiašonį trikampį (ivestas skaičius 4).
          1
          22
          333
          4444
          333
          22
          1*/

            var skaicius = GautiSkaiciu();
            Console.WriteLine(DidejanciuSkaiciuLygiasonisTrikampis(skaicius));
        }

        private string DidejanciuSkaiciuLygiasonisTrikampis(int skaicius)
        {
            var sb = new StringBuilder();
            var result = new StringBuilder();
            for (int i = 1; i <= skaicius; i++)
            {
                sb.Clear();
                sb.Append(char.Parse(i.ToString()), i);
                result.Append(sb.ToString());
                result.Append(Environment.NewLine);
            }

            for (int i = skaicius - 1; i > 0; i--)
            {
                sb.Clear();
                sb.Append(char.Parse(i.ToString()), i);
                result.Append(sb.ToString());
                result.Append(Environment.NewLine);
            }
            return result.ToString();
        }

        private int GautiSkaiciu()
        {
            Console.WriteLine("Iveskite skaiciu:");
            var arSkaicius = int.TryParse(Console.ReadLine(), out var skaicius);

            while (!arSkaicius || skaicius < 1 || skaicius > 9)
            {
                Console.WriteLine("Blogas skaicius. Veskite dar karta");
                arSkaicius = int.TryParse(Console.ReadLine(), out skaicius);
            }

            return skaicius;
        }

        public void SkaiciuGrupes()
        {
            /*Parašykite metodą SkaiciuEile kuri išvestu vienoje eilutėje skaičių grupes tokiu principu: -> 1 -> 11 -> 111 -> 1111 -> 11111 -> .......
            programa turi paprašyti nurodyti skaičių ir grupių kiekį

            naudokite for ir StringBuilder*/

            var skaicius = GautiSkaiciu();
            Console.WriteLine("Iveskite grupiu kieki:");
            var kiekis = int.Parse(Console.ReadLine());
            Console.WriteLine(SkaiciuEile(skaicius, kiekis));
        }

        private string SkaiciuEile(int skaicius, int kiekis)
        {
            var sb = new StringBuilder();
            var result = new StringBuilder();

            for (int i = 1; i <= kiekis; i++)
            {
                sb.Append(skaicius);
                result.Append(" -> ");
                result.Append(sb);
            }

            return result.ToString();
        }

        public void DaugybosLentele()
        {
            /*Sukurkite programa, kuri paprasytu naudotojo ivesti skaiciu. Ivedus skaiciu turetu atspausdinti to skaiciaus daugybos lentele. Pvz
            15 X 1 = 15                                                                                                   
            15 X 2 = 30                                                                                                  
            15 X 3 = 45                                                                                                   
            15 X 4 = 60                                                                                                  
            15 X 5 = 75                                                                                                   
            15 X 6 = 90                                                                                                  
            15 X 7 = 105                                                                                                 
            15 X 8 = 120                                                                                                 
            15 X 9 = 135                                                                                                 
            15 X 10 = 150*/

            Console.WriteLine("Iveskite skaiciu:");
            var skaicius = int.Parse(Console.ReadLine());
            Console.WriteLine(DaugybosLentele(skaicius));
        }

        private string DaugybosLentele(int skaicius)
        {
            var lentele = new StringBuilder();

            for (int i = 1; i <= 10; i++)
            {
                var sandauga = i * skaicius;
                lentele.Append(skaicius);
                lentele.Append(" X ");
                lentele.Append(i);
                lentele.Append(" = ");
                lentele.Append(sandauga);
                lentele.Append(Environment.NewLine);
            }

            return lentele.ToString();
        }

        public void Skaiciuotuvas()
        {
            /* Sukurti skaiciuotuva. Ijungus programa mes turetume gauti pranesima “1. Nauja operacija 2. Testi su rezultatu 3. Iseiti”. Pasirinkus 1 turetu ismesti ”
            1. Sudetis
            2. Atimtis
            3. Daugyba
            4. Dalyba”
            Pasirinkus viena is operaciju programa turetu paprasyti naudotoja ivesti pirma ir antra skaicius, o gale isvesti rezultata ant ekrano ir uzklausti ar naudotojas nori atlikti nauja operacija ar testis u rezultatu. Sudeties pvz:
            “1
            15
            45
            Rezultatas: 60
            1. Nauja operacija 2. Testi su rezultatu 3. Iseiti”
            Pasirinkus 2 programa turetu paprasyti ivesti kokia operacija turetu buti atliekama ir paprasyti TIK SEKANCIO SKAITMENS. Pasirinkus 3 programa turetu issijungti. Visa kita turetu veikti tokiu pat budu.
            BONUS1: Iskelkite operacijas i metodus
            BONUS2: Parasykite operacijoms validacijas pries ivestus neteisingus skaicius. Pvz: dalyba is nulio, neteisingu ivesciu prevencija pvz kada tikimasi gauti skaiciu, bet gaunamas char arba string.
            BONUS3: Parasyti unit testus uztikrinant operaciju veikima
            BONUS4: Parasyti laipsnio pakelimo ir saknies traukimo operacija*/
            PagrindinisMeniu(null);
        }

        private void PagrindinisMeniu(double? pirmas)
        {
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Turimas skaicius: {0}", pirmas);
            Console.WriteLine("1. Nauja operacija" + Environment.NewLine +
                "2. Testi su rezultatu" + Environment.NewLine +
                "3. Iseiti");
            ApdorotiPasirinkima(pirmas);
        }

        private void ApdorotiPasirinkima(double? pirmas)
        {
            _ = int.TryParse(Console.ReadLine(), out var pasirinkimas);

            switch (pasirinkimas)
            {
                case 1:
                    OperacijuMeniu(null);
                    break;
                case 2:
                    OperacijuMeniu(pirmas);
                    break;
                case 3:
                    Environment.Exit(1);
                    break;
                default:
                    Console.WriteLine("Blogas skaicius. Paspauskite bet koki klavisa");
                    Console.ReadLine();
                    PagrindinisMeniu(pirmas);
                    break;
            }
        }

        public void IstrauktiSakni()
        {
            Console.WriteLine("Iveskite skaiciu:");
            var skaicius = double.Parse(Console.ReadLine());

            Console.WriteLine("Saknis: {0}", Saknis(skaicius));
        }

        private double Saknis(double sk1)
        {
            double root = 1;
            int i = 0;

            while (true)
            {
                i = i + 1;
                root = (sk1 / root + root) / 2;
                if (i == sk1 + 1) 
                { break; }
            }

            return root;
        }

        static int IntAsk(string specify = "an int number")
        {
            Console.WriteLine($"Please write {specify}: ");
            string? input = Console.ReadLine();

            for (; ; )
            {
                if (Int32.TryParse(input, out _) == false)
                {
                    Console.WriteLine("That is not an int, try again");
                    input = Console.ReadLine();
                }
                else
                {
                    return Convert.ToInt32(input);
                }
            }
        }

        public void PirmaUzduotis()
        {
            Console.Write("Kiek norite eiluciu: ");
            int eilutes = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= eilutes; i++)
                Console.WriteLine(sb.Insert(0, i % 2).ToString());
        }

        private void OperacijuMeniu(double? pirmas)
        {
            Console.WriteLine("1. Sudetis" + Environment.NewLine +
                "2.Atimtis" + Environment.NewLine +
                "3.Daugyba"+ Environment.NewLine +
            "4.Dalyba");
            ApdorotiOperacija(pirmas);
        }

        private void ApdorotiOperacija(double? pirmas)
        {
            var arSkaicius = int.TryParse(Console.ReadLine(), out var pasirinkimas);

            if (!arSkaicius || pasirinkimas < 1 || pasirinkimas > 4)
            {
                Console.WriteLine("Blogas pasirinkimas!");
                PagrindinisMeniu(pirmas);
            }

            double antras;

            if (pirmas == null)
            {
                Console.WriteLine("Iveskite pirma ir antra skaicius:");
                if (!double.TryParse(Console.ReadLine(), out var pirmasN) | !double.TryParse(Console.ReadLine(), out antras))
                {
                    Console.WriteLine("Blogi skaiciai");
                    PagrindinisMeniu(pirmas);
                }
                pirmas = pirmasN;
            }
            else
            {
                Console.WriteLine("Iveskite antra skaiciu:");
                if (!double.TryParse(Console.ReadLine(), out antras))
                {
                    Console.WriteLine("Blogi skaiciai");
                    PagrindinisMeniu(pirmas);
                }
            }

            var rezultatas = pasirinkimas switch
            {
                1 => Sudetis((double)pirmas, antras),
                2 => Atimtis((double)pirmas, antras),
                3 => Daugyba((double)pirmas, antras),
                4 => Dalyba((double)pirmas, antras),
                _ => 0
            };

            Console.WriteLine("Rezultatas: {0}", rezultatas);
            PagrindinisMeniu(rezultatas);
        }

        private double Sudetis(double pirmas, double antras) => pirmas + antras;
        private double Atimtis(double pirmas, double antras) => pirmas - antras;
        private double Daugyba(double pirmas, double antras) => pirmas * antras;
        private double Dalyba(double pirmas, double antras)
        { 
            if (antras == 0)
            {
                Console.WriteLine("Dalyba negalima!");
                PagrindinisMeniu(pirmas);
            }
            return pirmas / antras;
        }
    }
}
