using Class08.Models.Class0804;

namespace Class08.ClassWork
{
    internal class Class0804
    {
        /// <summary>
        /// Susikurti “Kambarys” klasę ir aprašyti bent 10 objektų esančių jūsų kambaryje arba objektų kurie galėtų
        /// egzistuoti kambaryje kaip klases. Visos naujai aprašytos klasės turėtų turėti bent po 5 atributus 
        /// (Kontraktas/interfeisas) ir turėtų būti priskirtos kaip properties (savybes) “Kambarys” klasei. Bent 2
        /// iš aprašytų klasių turėtų turėti kompoziciją su kitomis klasėmis pvz:”Kambarys” turi “Spinta”, kuri gali 
        /// turėti List<Drabuzis>
        /// </summary>
        public void KambarioAprasymas()
        {
            var kambarys = new Kambarys()
            {
                Augalai = new List<Augalas>
                {
                    new Augalas
                    {
                        ArVazoninis = true,
                        ArZydintis = false,
                        Aukstis = 50,
                        Rusis = "Fikusas",
                        Spalva = "Zalia"
                    },
                    new Augalas
                    {
                        ArVazoninis = false,
                        ArZydintis = true,
                        Aukstis = 30,
                        Rusis = "Roze",
                        Spalva = "Raudona"
                    }
                },
                Dziovykla = new Dziovykla
                {
                    Aukstis = 100,
                    Ilgis = 200,
                    Plotis = 50,
                    KabantysDrabuziai = new List<Drabuzis>
                    {
                        new Drabuzis
                        {
                            Medziaga = "Medvilne",
                            Tipas = "Kojines"
                        },
                        new Drabuzis
                        {
                            Medziaga = "Linas",
                            Tipas = "Marskiniai"
                        }
                    },
                    Medziaga = "Plastmase"
                },
                Orkaite = new Orkaite
                {
                    Tipas = "Garine",
                    ArImontuojama = true,
                    ArYraKaitlente = true,
                    Spalva = "Sidabrine",
                    Specifikacija = new ElektrinioIrenginioSpecifikacija
                    {
                        Gamintojas = "Electrolux",
                        Garantija = 24,
                        Matmenys = "50x50x50",
                        PagaminimoMetai = 2018
                    }
                }
            };

            Console.WriteLine($"Kambaryje yra {kambarys.Augalai.Count} augalu");
        }
    }
}
