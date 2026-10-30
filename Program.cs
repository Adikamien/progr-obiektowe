
using System;

namespace SystemZarzadzaniaPracownikami
{
    public class Pracownik
    {
        private decimal wynagrodzenie;
        protected string imie;
        internal string dzial;

        public Pracownik(string imie, string dzial, decimal wynagrodzenie)
        {
            this.imie = imie;
            this.dzial = dzial;

            if (wynagrodzenie > 0)
            {
                this.wynagrodzenie = wynagrodzenie;
            }
            else
            {
                this.wynagrodzenie = 0;
            }
        }

        public void PokazDane()
        {
            Console.WriteLine("Imię: " + imie);
            Console.WriteLine("Dział: " + dzial);
            Console.WriteLine("Wynagrodzenie: " + wynagrodzenie + " zł");
        }

        public void ZmienWynagrodzenie(decimal kwota)
        {
            if (kwota > 0)
            {
                wynagrodzenie = kwota;
                Console.WriteLine($"Zmieniono wynagrodzenie.{wynagrodzenie}");
            }
            else
            {
                Console.WriteLine("Błąd: kwota musi być większa od zera.");
            }
        }
    }

    public class Kierownik : Pracownik
    {
        public Kierownik(string imie, string dzial, decimal wynagrodzenie)
            : base(imie, dzial, wynagrodzenie)
        {
        }

        public void PrzedstawSie()
        {
            Console.WriteLine($" Mam na imię {imie}");
        }
    }

    class Program
    {
        static void Main()
        {
            Pracownik pracownik = new Pracownik("Jan", "IT", 5000m);
            Kierownik kierownik = new Kierownik("Anna", "Administracja", 8000m);

            
            

            

            
            kierownik.PokazDane();
            kierownik.PrzedstawSie();

            

            
            pracownik.ZmienWynagrodzenie(6000m);
            pracownik.PokazDane();

           
            Console.WriteLine();
            
            Console.WriteLine("Dział pracownika: " + pracownik.dzial);

          
            Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć.");
           
        }
    }
}

