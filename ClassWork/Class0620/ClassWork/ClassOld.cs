namespace Class0620.ClassWork
{
    internal class ClassOld
    {
        public void MethodOld()
        {
            /*PARAŠYTI PROGRAMĄ, KURI PAPRAŠO
               VARTOTOJO ĮVESTI GRUPĖS NARIŲ KIEKĮ.
               JEI NARIŲ KIEKIS LYGUS 1 PROGRAMA IŠVEDA
               „TAI SOLO ATLIKĖJAS“, JEI NARIŲ KIEKIS 2 --„TAI
               DUETAS“, JEI NARIŲ KIEKIS DAUGIAU NEI 2 BET
               MAŽIAU NEI 10 ––„TAI ANSAMBLIS“, JEI
               DAUGIAU NEI 10 ––„TAI KAMERINIS
               ANSAMBLIS“.*/

            /*
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
            */

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

            /*PARAŠYTI PROGRAMĄ, KURI PAPRAŠO VARTOTOJO ĮVESTI
            EGZAMINO PAŽYMĮ. IŠVESTI:
            0 - 4: NEPATEKINAMAI
            5: SILPNAI
            6: PATENKINAMAI
            7: VIDUTINIŠKAI
            8: GERAI
            9: LABAI GERAI
            10: PUIKIAI*/

            /*
            Console.Write("Iveskite pazymi: ");
            var arSkaicius = int.TryParse(Console.ReadLine(), out var pazymys);
            if (arSkaicius)
            {
                var vertinimas = pazymys switch
                {
                    int n when n >= 0 && n <= 4 => "Nepatenkinamai",
                    5 => "Silpnai",
                    6 => "Patenkinamai",
                    7 => "Vidutiniskai",
                    8 => "Gerai",
                    9 => "Labai gerai",
                    10 => "Puikiai",
                    _ => "Ivestas netinkamas skaicius"
                };
                Console.WriteLine(vertinimas);
            }
            else
                Console.WriteLine("Bloga reiksme {0}", pazymys);
            */

            /*** Nemokama kava **
            Aprašykite int kintamajį kuriame nurodysite kiek puodelių kavos perkama. (tarkim 7)
            Kas 3 puodelis nemokamas. Paskaičiuokite ir išveskite į ekraną ar pirkėjui priklauso nemokama kava
            - Pavyzdžio atsakymas: "pirkėjui priklauso 2 nemokami puodeliai"
            - Alternatyvus atsakymas: "Pirkėjui nepriklauso nemokama kava"*/

            /*
            Console.Write("Iveskite kavos puodeliu skaiciu: ");
            var arSkaicius = int.TryParse(Console.ReadLine(), out var kavosPuodeliai);

            if (arSkaicius)
            {
                var nemokamiPuodeliai = kavosPuodeliai / 3;
                Console.WriteLine(nemokamiPuodeliai switch
                {
                    0 => "Pirkejui nepriklauso nemokama kava",
                    1 => "Pirkejui priklauso 1 nemokamas puodelis",
                    int n when n >= 2 => $"Prikejui priklauso {nemokamiPuodeliai} nemokami puodeliai",
                    _ => "Blogas skaicius"
                });
            }
            else
                Console.WriteLine("Ivesta netinkama reiksme");

            */

            /*** Piešingi skaičiai **
            Naudotojas įveda betkokius 4 sveikus skaicius (tarkim 5; 15; -25; 0;)
            - Parašykite programą kuri į ekraną išves neigiamą/teigiamą skaičiaus reikšmę
            - Pavyzdžio atsakymas 5 -> -5; 15 -> -15; -25 -> 25; 0 -> N/A;*/

            /*
            Console.WriteLine("Veskite skaicius. Kai baigsite, iveskite 0");
            var skaicius = 1;
            while (skaicius != 0)
            {
                var arInt = int.TryParse(Console.ReadLine(), out skaicius);
                if (!arInt)
                {
                    Console.WriteLine("Bloga reiksme!");
                    skaicius = 1;
                    continue;
                }

                var tekstas = skaicius == 0 ? "N/A" : $"Priesingas skaicius: {skaicius * -1}";
                Console.WriteLine(tekstas);
            }
            */

            /*ŽAIDIMAS ATSPĖK SKAIČIŲ
            - ĮHARDKODINAMAS BETKOKS SKAIČIUS NUO 1 IKI 20
            - NAUDOTOJAS 6 KARTUS PRAŠOMAS ĮVESTI SKAIČIŲ NUO 1 IKI 20
            - JEI NAUDOTOJAS ĮVEDĖ TEISINGAI - IŠVEDAMAS SVEIKINIMAS "TEISINGAI" IR PROGRAMA STABDOMA
            - JEI NAUDOTOJAS ĮVEDĖ PER MAŽĄ SKAIČIŲ - IŠVEDAMAS PRANEŠIMAS "SKAIČIUS YRA DIDESNIS"
            - JEI NAUDOTOJAS ĮVEDĖ PER DIDELĮ SKAIČIŲ - IŠVEDAMAS PRANEŠIMAS "SKAIČIUS YRA MAŽESNIS"
            nutraukiant programos vykdymą Environment.Exit(0) ar pan. naudoti negalima. Naudoti if.*/

            /*
            var rand = new Random();
            var teisingasSkaicius = rand.Next(1, 20);
            var teisingai = "Teisingai";
            var skaiciusDidesnis = "Skaicius yra didesnis";
            var skaiciusMazesnis = "Skaicius yra mazesnis";
            var blogasSkaicius = "Ivestas blogas skaicius";
            Console.Write("Iveskite spejima: ");
            var spejimas = int.Parse(Console.ReadLine());
            if(spejimas == teisingasSkaicius)
            {
                Console.WriteLine(teisingai);
            }
            else
            {
                string? tekstas = spejimas > 20 ? blogasSkaicius : 
                    spejimas > teisingasSkaicius ? skaiciusMazesnis : 
                    spejimas < 0 ? blogasSkaicius : 
                    skaiciusDidesnis;
                Console.WriteLine(tekstas);
                Console.Write("Iveskite spejima: ");
                spejimas = int.Parse(Console.ReadLine());
                if (spejimas == teisingasSkaicius)
                {
                    Console.WriteLine(teisingai);
                }
                else
                {
                    tekstas = spejimas > 20 ? blogasSkaicius :
                    spejimas > teisingasSkaicius ? skaiciusMazesnis :
                    spejimas < 0 ? blogasSkaicius :
                    skaiciusDidesnis;
                    Console.WriteLine(tekstas);
                    Console.Write("Iveskite spejima: ");
                    spejimas = int.Parse(Console.ReadLine());
                    if (spejimas == teisingasSkaicius)
                    {
                        Console.WriteLine(teisingai);
                    }
                    else
                    {
                        tekstas = spejimas > 20 ? blogasSkaicius :
                        spejimas > teisingasSkaicius ? skaiciusMazesnis :
                        spejimas < 0 ? blogasSkaicius :
                        skaiciusDidesnis;
                        Console.WriteLine(tekstas);
                        Console.Write("Iveskite spejima: ");
                        spejimas = int.Parse(Console.ReadLine());
                        if (spejimas == teisingasSkaicius)
                        {
                            Console.WriteLine(teisingai);
                        }
                        else
                        {
                            tekstas = spejimas > 20 ? blogasSkaicius :
                            spejimas > teisingasSkaicius ? skaiciusMazesnis :
                            spejimas < 0 ? blogasSkaicius :
                            skaiciusDidesnis;
                            Console.WriteLine(tekstas);
                            Console.Write("Iveskite spejima: ");
                            spejimas = int.Parse(Console.ReadLine());
                            if (spejimas == teisingasSkaicius)
                            {
                                Console.WriteLine(teisingai);
                            }
                            else
                            {
                                tekstas = spejimas > 20 ? blogasSkaicius :
                                 spejimas > teisingasSkaicius ? skaiciusMazesnis :
                                 spejimas < 0 ? blogasSkaicius :
                                 skaiciusDidesnis;
                                Console.WriteLine(tekstas);
                                Console.Write("Iveskite spejima: ");
                                spejimas = int.Parse(Console.ReadLine());
                                if (spejimas == teisingasSkaicius)
                                {
                                    Console.WriteLine(teisingai);
                                }
                                else Console.WriteLine("Neatspejot. Skaicius {0}", teisingasSkaicius);
                            }
                        }
                    }
                }
            }*/

            /** SKAIČIUOTUVAS *
            Paprašykite naudotojo įvesti du skaičius ir matematinę operaciją ( +, -, * arba / )
            - Parašykite programą kuri į ekraną išves skaičių rezultatą
            - naudokite if
            - naudokite switch*/

            /*
            Console.WriteLine("Iveskite 2 skaicius ir operacija:");
            var pirmas = double.Parse(Console.ReadLine());
            var antras = double.Parse(Console.ReadLine());
            var operacija = Console.ReadKey().KeyChar;
            double? rezultatas = operacija switch
            {
                '+' => pirmas + antras,
                '-' => pirmas - antras,
                '*' => pirmas * antras,
                '/' => pirmas / antras,
                _=> null
            };
            Console.WriteLine(rezultatas);
            */

            /** Trys draugai *
            - Sukurti metodą, kuris paprašytų vartotojo įvesti tris jo draugų vardus bei kiekvieno amžių.
            - Nuskaičius duomenis atskirose eilutėse atspausdinti draugo vardą ir amžių.
            - Atspausdinti draugų amžiaus vidurkį
            - Surasti ir atspausdinti jauniausią draugą (vardą ir amžių).
            - Surasti ir atspausdinti vyriausią draugą (vardą ir amžių).
            <Hint> ieškant jauniausio, seniausio naudoti if sąlygos sakinius ir naudoti tik elementus ir
            konstrukcijas kurias iki šiol išėjome.*/


            Console.WriteLine("Iveskite 3 draugu vardus ir ju amziu:");

            Console.Write("1 draugo vardas: ");
            var vardas1 = Console.ReadLine();
            Console.Write("1 draugo amzius:");
            var amzius1 = int.Parse(Console.ReadLine());

            Console.Write("2 draugo vardas: ");
            var vardas2 = Console.ReadLine();
            Console.Write("2 draugo amzius:");
            var amzius2 = int.Parse(Console.ReadLine());

            Console.Write("3 draugo vardas: ");
            var vardas3 = Console.ReadLine();
            Console.Write("3 draugo amzius:");
            var amzius3 = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}, {1} metu", vardas1, amzius1);
            Console.WriteLine("{0}, {1} metu", vardas2, amzius2);
            Console.WriteLine("{0}, {1} metu", vardas3, amzius3);

            Console.WriteLine("Amziaus vidurkis yra {0} metu", (amzius1 + amzius2 + amzius3) / 3);
            var vyriausias = amzius1 >= amzius2 ?
                amzius1 >= amzius3 ? vardas1 : vardas3 :
                amzius2 >= amzius3 ? vardas2 : vardas3;
            var vyriausiasAmzius = vardas1 == vyriausias ? amzius1 : vardas2 == vyriausias ? amzius2 : amzius3;
            var jauniausias = amzius1 <= amzius2 ?
                amzius1 <= amzius3 ? vardas1 : vardas3 :
                amzius2 <= amzius3 ? vardas2 : vardas3;
            var jauniausiasAmzius = vardas1 == jauniausias ? amzius1 : vardas2 == jauniausias ? amzius2 : amzius3;

            Console.WriteLine("Vyriausias yra {0}, {1} metu", vyriausias, vyriausiasAmzius);
            Console.WriteLine("Jauniausias yra {0}, {1} metu", jauniausias, jauniausiasAmzius);


            /*** Kalėdų sausainiai **
            - Paprašykite vartotojo įvesti betkokias 4 datas (tarkim 2013-12-24, 2020-12-22, 3000-12-24, 2021-03-03)
            - Parašykite programą kuri nustato ar tarp įvestų datų yra kalėdos (gruodžio 24).
            - Ir jei yra kalėdų data, išveda - "Jums priklauso nemokami kalėdiniai sausainiai"
            - Jei nėra išveda - "Palaukite kalėdų"
            Pavyzdzio atsakymas: "Jums priklauso nemokami kalėdų sausainiai"
            <Hint> metodai data.Month ir data.Day*/
        }
    }
}
