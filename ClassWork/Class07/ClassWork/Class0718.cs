using CommonMethods;

namespace Class07.ClassWork
{
    internal class Class0718
    {
        public void MaziausiasSkaiciusMasyve(int[] masyvas)
        {
            /*## Rasti mažiausią ##
          Duotas vienatis sveikų skaičių masyvas.
          Parašykite programą, kuri į ekraną išves mažiausią skaičių masyve
          { 5, 3, 7, 6, 8, 7, 10 }
          rezultatas:  3*/

            Console.WriteLine("Masyvas yra: {0}", string.Join("; ", masyvas));
            Console.WriteLine("Maziausias skaicius yra: {0}", GautiMaziausiaSkaiciuMasyve(masyvas));
        }

        private int GautiMaziausiaSkaiciuMasyve(int[] masyvas)
        {
            var maziausias = masyvas[0];
            for(int i = 0; i < masyvas.Length; i++)
                maziausias = maziausias <= masyvas[i] ? maziausias : masyvas[i];
            return maziausias;
        }
        public void DidziausiasSkaiciusMasyve(int[] masyvas)
        {
            /*2. ## Rasti didžiausią ##
           Duotas vienatis sveikų skaičių masyvas.
           Parašykite programą, kuri į ekraną išves mažiausią skaičių masyve
           { 5, 3, 7, 6, 8, 7, 10 }
           rezultatas:  10*/

            Console.WriteLine("Masyvas yra: {0}", string.Join("; ", masyvas));
            Console.WriteLine("Didziausias skaicius yra: {0}", GautiDidziausiaSkaiciuMasyve(masyvas));
        }

        private int GautiDidziausiaSkaiciuMasyve(int[] masyvas)
        {
            var didziausias = masyvas[0];
            for (int i = 0; i < masyvas.Length; i++)
                didziausias = didziausias >= masyvas[i] ? didziausias : masyvas[i];
            return didziausias;
        }

        public void MasyvoRikiavimas(int[] masyvas)
        {
            /*3. ## RIKIUOTI SKAICIUS DIDĖJIMO TVARKA ##
           Duotas vienmatis sveikų skaičių masyvas. 
           Parašykite programą, kuri į ekraną išves surikiuotusskaičius nuo 
            mažiausio iki didžiausio
           { 5, 1, 7, 6, 8, 7, 10 }

           rezultatas:  1, 5, 6, 7, 7, 8, 10*/

            Console.WriteLine("Masyvas yra: {0}", string.Join("; ", masyvas));
            SurikiuotiMasyvaDidejimoTvarka(ref masyvas);
            Console.WriteLine("Surikiuotas masyvas: {0}", string.Join("; ", masyvas));
        }

        private void SurikiuotiMasyvaDidejimoTvarka(ref int[] masyvas)
        {
            for (int i = 0; i < masyvas.Length - 1; i++)
            {
                for (int j = i; j < masyvas.Length; j++)
                {
                    if (masyvas[i] > masyvas[j])
                    {
                        var didesnis = masyvas[i];
                        masyvas[i] = masyvas[j];
                        masyvas[j] = didesnis;
                    }
                }
            }
        }

        public void RaidziuRikiavimas()
        {
            /*## RIKIUOTI TRIS RAIDES ##
            Parašykite programą kurioje vienas metodas.
              - Naudotojo paprašome įvesti 3 raides (atskirai).
                Būtina validacija kad įvesta tik vienas simbolis.
              - Metodas priima masyvą iš char ir grąžina masyvą iš char - surikiuotas raides pagal abecelę.
              Pvz:
              > Iveskite pirma raide:
              _ C
              > Iveskite antra raide:
              _ D
              > Iveskite trecia raide:
              _ B
              >  B, C, D*/

            var pirma = KintamujuModifikavimas.PadidintiRaide(DarbasSuKonsole.GautiIvestaRaide("Iveskite pirma raide:"));
            var antra = KintamujuModifikavimas.PadidintiRaide(DarbasSuKonsole.GautiIvestaRaide("Iveskite antra raide:"));
            var trecia = KintamujuModifikavimas.PadidintiRaide(DarbasSuKonsole.GautiIvestaRaide("Iveskite trecia raide:"));

            var raides = new char[] { pirma, antra, trecia };
            SurikiuotiRaides(raides);
            Console.WriteLine("Surikiuotos raides: {0}", string.Join('-', raides));
        }

        private void SurikiuotiRaides(char[] raides)
        {
            var charVertes = new int[raides.Length];
            for (int i = 0; i < raides.Length; i++)
                charVertes[i] = (int)raides[i];

            SurikiuotiMasyvaDidejimoTvarka(ref charVertes);

            for (int i = 0; i < raides.Length; i++)
                raides[i] = (char)charVertes[i];
        }

        public void KeturiuRaidziuRikiavimas()
        {
            /*## RIKIUOTI KETURIAS RAIDES ##
            Parašykite programą kurioje vienas metodas.
            - Naudotojo paprašome įvesti 4 raides (atskirai).
              Būtina validacija kad įvesta tik vienas simbolis.
            - Metodas priima masyvą iš string (su prielaidai kad kiekvienas string yra tik 1 raide)
              ir grąžina string (NB! ne masyvą) - surikiuotas raides pagal abecelę atskirtas -.
            Pvz:
            > Iveskite pirma raide:
            _ C
            > Iveskite antra raide:
            _ A
            > Iveskite trecia raide:
            _ B
            > Iveskite ketvirtą raide:
            _ E
            > A-B-C-E*/

            var pirma = KintamujuModifikavimas.PadidintiRaide(DarbasSuKonsole.GautiIvestaRaide("Iveskite pirma raide:"));
            var antra = KintamujuModifikavimas.PadidintiRaide(DarbasSuKonsole.GautiIvestaRaide("Iveskite antra raide:"));
            var trecia = KintamujuModifikavimas.PadidintiRaide(DarbasSuKonsole.GautiIvestaRaide("Iveskite trecia raide:"));
            var ketvirta = KintamujuModifikavimas.PadidintiRaide(DarbasSuKonsole.GautiIvestaRaide("Iveskite ketvirta raide:"));

            var raides = new string[] { pirma.ToString(), antra.ToString(), trecia.ToString(), ketvirta.ToString() };

            Console.WriteLine("Surikiuotos raides: {0}", SurikiuotiRaides(raides));
        }

        private string SurikiuotiRaides(string[] raides)
        {
            var sujungtosRaides = string.Join("", raides);
            var charRaides = sujungtosRaides.ToCharArray();
            SurikiuotiRaides(charRaides);
            return string.Join('-', charRaides);
        }
    }
}
