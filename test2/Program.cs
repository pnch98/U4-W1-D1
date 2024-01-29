using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Atleta calciatore = new Atleta("Giovanni", "Matteotti", "calciatore");
            Dipendente insegnante = new Dipendente("Alfredo", "Patrizi", "insegnante");
            Animale cane = new Animale("cane", "bassotto", "Ciro");
            Animale gatto = new Animale("coccodrillo", "persiano", "PastadentFricioMaxi");
            Veicolo auto = new Veicolo("auto", "Ford", "Fiesta");
            calciatore.SayHello();
            insegnante.SayHello();
            cane.SayHello();
            gatto.SayHello();
            auto.TurnOn();
            auto.TurnOff();
        }
    }

    class Atleta
    {
        public string name;
        public string surname;
        public string sport;

        public Atleta(string name, string surname, string sport)
        {
            this.name = name;
            this.surname = surname;
            this.sport = sport;
        }

        public void SayHello()
        {
            Console.WriteLine($"Il mio nome è {this.name} {this.surname} e pratico {this.sport}");
        }
    }

    class Dipendente
    {
        public string name;
        public string surname;
        public string job;

        public Dipendente(string name, string surname, string job)
        {
            this.name = name;
            this.surname = surname;
            this.job = job;
        }

        public void SayHello()
        {
            Console.WriteLine($"Il mio nome è {this.name} {this.surname} e sono un {this.job}");
        }
    }

    class Animale
    {
        public string race;
        public string breed;
        public string name;

        public Animale (string race, string breed, string name)
        {
            this.race = race;
            this.breed = breed;
            this.name = name;
        }

        public void SayHello() {
        switch(this.race)
            {
                case "cane":
                    Console.WriteLine($"{this.name}: Bau!");
                    break;
                case "gatto":
                    Console.WriteLine($"{this.name}: Miao!");
                    break;
                case "rana":
                    Console.WriteLine($"{this.name}: Crack!");
                    break;
                default: Console.WriteLine($"{this.name}: Onomatopea dell'animale selezionato!");
                    break;
            }
        }
    }

    class Veicolo
    {
        public string type;
        public string company;
        public string model;

        public Veicolo (string type, string company, string model)
        {
            this.type = type; 
            this.company = company;
            this.model = model;
        }

        public void TurnOn()
        {
            Console.WriteLine("Brum brum!");
        }
        public void TurnOff()
        {
               Console.WriteLine("Engine Off!");
        }
    }
}




