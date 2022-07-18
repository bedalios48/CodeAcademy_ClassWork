using CommonMethods;

namespace Class07.ClassWork
{
    internal class Class0714
    {
        public void ZmonesPamokoje()
        {
            /*3. Parasykite programa, kuri leistu ivesti kiek zmoniu siandiena atejo i pamoka. Ivedus skaiciu programa prasytu 
            ivesti visu atejusiu zmoniu vardus. Kada visi vardai buna ivesti programa turetu atspausdinti visu vardus atvirkstine seka.
            Pvz: 
            3
            Edvinas
            Jonas
            Petras----------
            Petras
            Jonas
            Edvinas*/
            AtspausdintiAtvirkstineTvarka(GautiPamokosDalyvius());
        }

        private string[] GautiPamokosDalyvius()
        {
            var dalyviuSkaicius = DarbasSuKonsole.GautiIvestaSveikaSkaiciu("Iveskite, kiek zmoniu atejo i pamoka:");
            return GautiDalyviuVardus(dalyviuSkaicius);
        }

        private string[] GautiDalyviuVardus(int dalyviuSkaicius)
        {
            var vardai = new string[dalyviuSkaicius];
            Console.WriteLine("Irasykite visus vardus:");
            for (int i = 0; i < dalyviuSkaicius; i++)
            {
                vardai[i] = Console.ReadLine();
            }
            return vardai;
        }

        private void AtspausdintiAtvirkstineTvarka(string[] vardai)
        {
            for (int i = vardai.Length - 1; i > 0; i--)
                Console.WriteLine(vardai[i]);
        }

        public void IlgiausiVardaiPamokoje()
        {
            /*4. Parasykite programa, kuri leistu ivesti kiek zmoniu siandiena atejo i pamoka.
            Ivedus skaiciu programa prasytu ivesti visu atejusiu zmoniu vardus. Kada visi vardai 
            buna ivesti programa turetu atspausdinti ilgiausia varda ekrane. Jei vardai yra 
            vienodo ilgio turetu atspausdinti abu vardus.           
            Pvz:             
            3            
            Edvinas            
            Jonas            
            Petras
            ---------------------            
            Edvinas*/

            var ilgiausiVardai = GautiIlgiausiusVardus(GautiPamokosDalyvius());
            Console.WriteLine("Ilgiausi vardai yra:");
            AtspausdintiNetusciusElementus(ilgiausiVardai);
        }

        private string[] GautiIlgiausiusVardus(string[] vardai)
        {
            for (int i = 0; i < vardai.Length; i++)
            {
                var arIlgiausias = true;
                for (int j = 0; j < vardai.Length; j++)
                {
                    if (!string.IsNullOrEmpty(vardai[j]) && vardai[i].Length < vardai[j].Length)
                    {
                        arIlgiausias = false;
                        break;
                    }
                }

                if (!arIlgiausias)
                    vardai[i] = null;
            }

            return vardai;
        }

        private void AtspausdintiNetusciusElementus(string[] elementai)
        {
            for (int i = 0; i < elementai.Length; i++)
                if (elementai[i] != null)
                    Console.WriteLine(elementai[i]);
        }

        private void AtspausdintiNetusciusElementus(int?[] elementai)
        {
            for (int i = 0; i < elementai.Length; i++)
                if (elementai[i] != null)
                    Console.WriteLine(elementai[i]);
        }

        public void PasikartojanciuSkaiciuPaieska()
        {
            /*5. Parasykite programa, kuri rastu visus pasikartojancius skaicius duotame 
                 masyve ir juos atvaizduotu ekrane
                 PVZ: 1,2,2,4,2,7,6,1
                 Pasikartojantys skaiciai: 1, 2*/

            var pasikartojantysSkaiciai = GautiPasikartojanciusSkaicius(GautiSkaiciuMasyvaIsKonsoles());
            Console.WriteLine("Pasikartojantys skaiciai yra:");
            AtspausdintiNetusciusElementus(pasikartojantysSkaiciai);
        }

        private int[] GautiSkaiciuMasyvaIsKonsoles()
        {
            var ivestiSkaiciai = new int[100];
            Console.WriteLine("Veskite sveikuosius skaicius. Kai baigsite, iveskite kazka kito:");
            int i = 0;
            while (int.TryParse(Console.ReadLine(), out ivestiSkaiciai[i]))
                i++;

            var rezultatas = new int[i];
            for (int j = 0; j < rezultatas.Length; j++)
                rezultatas[j] = ivestiSkaiciai[j];

            return rezultatas;
        }

        private int?[] GautiPasikartojanciusSkaicius(int[] skaiciai)
        {
            var rezultatas = new int?[skaiciai.Length];

            for(int i = 0; i < skaiciai.Length; i++)
            {
                var pasikartojimuSkaicius = 0;
                for (int j = 0; j < skaiciai.Length; j++)
                {
                    if (skaiciai[i] == skaiciai[j])
                        pasikartojimuSkaicius++;
                }

                if (pasikartojimuSkaicius > 1)
                {
                    var arJauYraRezultate = false;
                    for (int k = 0; k < i; k++)
                    {
                        if (rezultatas[k] == skaiciai[i])
                        {
                            arJauYraRezultate = true;
                            break;
                        }
                    }

                    if(!arJauYraRezultate)
                        rezultatas[i] = skaiciai[i];
                }
            }

            return rezultatas;
        }

        public void MatricosIsvedimas()
        {
            /*6. Programa praso ivesti eiluciu ir stulpeliu kieki. Ivedus turetu sukurti masyva 
            duoto dydzio, paprasyti ivesti kiekvieno elemento skaiciu/reiksme ir atspausdintu 
            matrica is pateiktu skaiciu            
            PVZ: Ivedame 2 2. 
            Suvedame 1, 2, 2, 3                 
            1 2                 
            2 3*/

            var eiluciuSkaicius = DarbasSuKonsole.GautiIvestaSveikaSkaiciu("Iveskite eiluciu skaiciu:");
            var stulpeliuSkaicius = DarbasSuKonsole.GautiIvestaSveikaSkaiciu("Iveskite stulpeliu skaiciu:");

            IsvestiMatricaIKonsole(GautiMatricaIsKonsoles(eiluciuSkaicius, stulpeliuSkaicius));
        }

        private int[,] GautiMatricaIsKonsoles(int eiluciuSkaicius, int stulpeliuSkaicius)
        {
            var matrica = new int[eiluciuSkaicius, stulpeliuSkaicius];
            Console.WriteLine("Veskite visus elementus is eiles:");
            for (int i = 0; i < eiluciuSkaicius; i++)
            {
                for (int j = 0; j < stulpeliuSkaicius; j++)
                {
                    matrica[i, j] = DarbasSuKonsole.GautiIvestaSveikaSkaiciu();
                }
            }

            return matrica;
        }

        private void IsvestiMatricaIKonsole(int[,] matrica)
        {
            for (int i = 0; i < matrica.GetLength(0); i++)
            {
                for (int j = 0; j < matrica.GetLength(1); j++)
                {
                    Console.Write("{0, 3}", matrica[i, j]);
                }
                Console.WriteLine();
            }
        }

        public void PasikartojanciuSkaiciuMatricojePaieska()
        {
            /**/
            var eiluciuSkaicius = DarbasSuKonsole.GautiIvestaSveikaSkaiciu("Iveskite eiluciu skaiciu:");
            var stulpeliuSkaicius = DarbasSuKonsole.GautiIvestaSveikaSkaiciu("Iveskite stulpeliu skaiciu:");

            var matrica = GautiMatricaIsKonsoles(eiluciuSkaicius, stulpeliuSkaicius);
            var pasikartojantysSkaiciai = GautiPasikartojanciusSkaicius(GautiSkaiciuMasyvaIsKonsoles());
            Console.WriteLine("Pasikartojantys skaiciai yra:");
            AtspausdintiNetusciusElementus(pasikartojantysSkaiciai);
        }

        private void IslygintiMatrica()
        {

        }

        /*
        7. Parasykite programa, kuri rastu visus pasikartojancius skaicius duotame dvimaciame masyve ir juos atvaizduotu ekrane

        8. Parasykite programa, kuri rastu visus pasikartojancius vardus duotame dvimaciame masyve ir juos atvaizduotu ekrane
         */
    }
}
