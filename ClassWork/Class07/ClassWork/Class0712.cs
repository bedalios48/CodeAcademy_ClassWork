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
            for(int i = 0; i <= skaicius; i++)
            {
                sb.Append(skaicius.ToString());
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
            for (int i = 0; i <= 2*skaicius-1; i++)
            {
                if (i<skaicius)
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

            for (int i = skaicius-1; i>0; i--)
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
    }
}
