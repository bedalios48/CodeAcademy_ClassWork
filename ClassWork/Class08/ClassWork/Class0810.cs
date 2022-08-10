using Class08.Models.Class0810;

namespace Class08.ClassWork
{
    internal class Class0810
    {
        /*Uzduotis 1: Apsirašykite klases, kurios atributų pagalba apibūdintų:Žmogų
        Mašiną
        Namą(Savarankiskai)
        Išmanųjį telefoną
        Šalį(Savarankiskai)
        Knygą(Savarankiskai)
        
         Uzduotis 2: Parasyti kiekvienai is klasiu bent po 1 kompozicijos atributa 
        (Naujas atributas turetu buti naujai sukurta klase su bent 3 naujais atributais). 
        Kompozicijos atributas yra atributas su kitos klases duomenu tipu kintamuosiuose. 
        Pvz: Zmogus gali tureti augintini

        Uzduotis 3: Aprasykite kiekvienai is klasiu aprasytu 1 uzduotyje (P030) po 3 konstruktorius

        public: Tipą ar narį galima pasiekti naudojant bet kurį kitą kodą tame pačiame assembly kode ar kitame assembly, kuris jį referuoja.
     * private: Tipą ar narį galima pasiekti tik pagal kodą toje pačioje klasėje ar struktūroje.
     * internal: Tipą ar narį galima pasiekti naudojant bet kurį kodą tame pačiame assembly kode, bet ne iš kito assembly kodo.
     * protected: tipą arba narį galima pasiekti tik pagal kodą toje pačioje klasėje arba klasėje, kuri yra išvesta iš tos klasės(Paveldėta)
       
        Uzduotis 4: Atnaujinti kiekvienai is klasiu aprasytu 1 uzduotyje atributus (kontrakta) 
        taip, kad atributu reiksmes galima butu skaityti is isores, bet nustatyti reiksmes 
        butu galima tik klases viduje. (Namas, salis, knyga) 

        Uzduotis 5:(Savarankiskai)Sukurti klases Hobis ir Profesija 
Klasės interfeise turi būti properčiai: Id (int), TekstasLietuviskai(string) ir Tekstas(string) 
Sukurti tuscia konstruktorių, kuris inicializuoja duotas reikšmes.
Sukurti konstruktorių, kuris inicializuoja duotas reikšmes.
Kintamieji gali būti tik pasiekiami iš išorės, bet reikšmės gali būti nustatomos tik klasės viduje.
Sukurkite po 3 skirtingus hobius ir profesijas(Panaudoti visus 3 ismoktus deklaravimo ir priskyrimo budus.
        1.Konstruktoriaus pagalba 
        2. Tuscio objekto sukurimas ir pildymas eigoje
        3. Deklaravimo metu priskirti reiksmes)
         */

        public void PenktaUzduotis()
        {
            var hobiai = new List<Hobis>();
            hobiai.Add(new Hobis(1, "Pianinas", "Piano"));
            Console.WriteLine(hobiai[0].Tekstas);
            hobiai[0].Tekstas = "Keyboard";

            hobiai.Add(new Hobis
            {
                Tekstas = "Books"
            });
            hobiai.Add(new Hobis(3, "Plaukiojimas", "Swimming"));
            foreach(var hobis in hobiai)
            {
                Console.WriteLine(hobis.Id);
                Console.WriteLine(hobis.TekstasLietuviskai);
                Console.WriteLine(hobis.Tekstas);
            }

            var profesijos = new List<Profesija>();
            profesijos.Add(new Profesija(1, "Stalius", "Carpenter"));
            profesijos.Add(new Profesija(2, "Sportininkas", "Athlete"));
            profesijos.Add(new Profesija());
            foreach (var profesija in profesijos)
            {
                Console.WriteLine(profesija.Id);
                Console.WriteLine(profesija.TekstasLietuviskai);
                Console.WriteLine(profesija.Tekstas);
            }

            profesijos[2].Id = 3;
            foreach (var profesija in profesijos)
            {
                Console.WriteLine(profesija.Id);
                Console.WriteLine(profesija.TekstasLietuviskai);
                Console.WriteLine(profesija.Tekstas);
            }
        }

        /*Uzduotis 6: (Savarankiskai)Sukurkite klasę “Bendrabutis”. 
         * Klasės kontraktas/interfeisas turėtų turėti šiuos atributus:       
         * BendrabucioId
       KambariuSkaicius
       Kaina
        Sujunkite/sukomponuokite klases “Zmogus” ir “Bendrabutis” taip, kad kiekviename 
        bendrabutyje galėtų gyventi daug žmonių, tačiau vienas žmogus galėtų gyventi tik viename bendrabutyje.*/

        public void SestaUzduotis()
        {
            var zmones = new List<Zmogus>();
            zmones.Add(new Zmogus("Petras", "Petrauskas"));
            zmones.Add(new Zmogus("Justina", "Kersauske"));
            zmones.Add(new Zmogus("Goda", "Mangyte"));

            AtspausdintiZmones(zmones);

            var bendrabuciai = new List<Bendrabutis>();
            bendrabuciai.Add(new Bendrabutis(1, 50, (decimal)353.30));
            bendrabuciai.Add(new Bendrabutis(2, 100, (decimal)222.50));
            bendrabuciai.Add(new Bendrabutis(3, 44, (decimal)589.70));

            zmones[0].Bendrabutis = bendrabuciai[1];
            bendrabuciai[1].PridetiGyventoja(zmones[0]);
            bendrabuciai[1].PridetiGyventoja(zmones[1]);
            bendrabuciai[0].PridetiGyventoja(zmones[2]);

            foreach(var bendrabutis in bendrabuciai)
            {
                Console.WriteLine("Bendrabutyje nr {0} gyvena sie gyventojai:", bendrabutis.BendrabucioId);
                AtspausdintiZmones(bendrabutis.Gyventojai);
            }
        }

        private void AtspausdintiZmones(List<Zmogus> zmones)
        {
            foreach (var zmogus in zmones)
            {
                Console.Write(zmogus.Vardas + " ");
                Console.WriteLine(zmogus.Pavarde);
            }
        }

        /*Uzduotis 7: Sukurkite 5 klases – Studentas, Mokykla, Mokytojas, PazymiuKnygele, Pamoka ir juos 
         * sukomponuokite (Sudekite rysius tarp ju).
Kiekviena mokykla turi nuo 1 iki begalybes mokytoju.
Kiekvienas mokytojas turi nuo 1 iki begalybes studentu.
Kiekvienas studentas turi 1 pažymių knygelę.
Kiekviena pažymių knygelė turi nuo 1 iki begalybės pamokų, kurios turi buti saugomos su studentu pazymiais.
Pamoka turi tik pavadinimą ir nuo 1 iki begalybės priskirtų mokytojų.
Inicializuokite klases su duomenimis (turi buti maziausiai uzpildytos 2 mokyklos) ir sukurkite 3 metodus, 
        kurie atspausdinkite ekrane(Šie metodai turetu priimti tik 1 objekta. Objektai gali buti skirtingi tarp metodu):       
       Mokyklos pavadinima + Kiekviena mokytoja kartu su jo mokiniu vardais
       (Savarankiskai)Kiekviena mokini kartu su kiekvieno is ju pazymiais 
       (Savarankiskai)Kiekvieno studento kiekvienos pamokos pazymiu vidurki*/
    }
}
