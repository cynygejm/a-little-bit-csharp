using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_figury
{
    interface IFiguryPrzestrzenne
    {
        double ObliczObjetosc();
        void WyswietlObjetosc();
    }

    abstract class Figura
    {
        protected int _x;
        protected int _y;

        public Figura(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public virtual void Wyswietl() 
        {
            Console.WriteLine($" x= {_x} y= {_y}");
        }

        public abstract void WyswietlObwod();
        public abstract void WyswietlPole();
        public abstract void WyswietlObjetosc();
    }

    class Kwadrat : Figura
    {
        protected int _a;
        public Kwadrat(int x, int y, int a) : base(x, y)
        {
            _a = a;
        }

        public int ObliczPole()
        {
            return _a * _a;
        }
        public override void WyswietlPole()
        {
            Console.WriteLine($"Pole KWADRATU = {ObliczPole()}");   
        }
        public int ObliczObwod()
        {
            return 4 * _a;
        }
        public override void WyswietlObwod()
        {
            Console.WriteLine($"Obwód KWADRATU = {ObliczObwod()}");
        }

        public void Skaluj(int skala)
        {
            Console.WriteLine("Po skalowaniu");
            _a *= skala;
        }

        public override void Wyswietl()
        {
            Console.WriteLine($"  Bok A. figury: {_a}");
            base.Wyswietl();
        }
        public int PobierzObjetosc()
        {
            return 0;
        }
        public override void WyswietlObjetosc()
        {
        }
    }

    class Kolo : Figura
    {
        protected double _p;

        public Kolo(int x, int y, double p) : base(x, y)
        {
            _p = p;
        }

        public double ObliczObwod()
        {
            return 2 * Math.PI * _p;
        }

        public override void WyswietlObwod()
        {
            Console.WriteLine($"Obwód KOŁA wynosi: {ObliczObwod()}");
        }
        public double ObliczPole()
        {
            return Math.PI * (_p * _p);
        }
        public override void WyswietlPole()
        {
            Console.WriteLine($"Pole KOŁA wynosi: {ObliczPole()}");
        }

        public void Skaluj(int skala)
        {
            Console.WriteLine($"Po skalowaniu promień KOŁA: {_p *= skala} ");
        }
        public override void Wyswietl()
        {
            Console.WriteLine($" PROMIEŃ figury: {_p}");
            base.Wyswietl();
        }

        public int PobierzObjetosc()
        {
            return 0;
        }
        public override void WyswietlObjetosc()
        {
        }
    }
    
    class Prostokat : Figura
    {
        protected int _a;
        protected int _b;
        public Prostokat(int x, int y, int a, int b) : base(x, y)
        {
            _a = a;
            _b = b;
        }
        
        public int ObliczPole()
        {
            return _a * _b;
        }
        public int ObliczObwod()
        {
            return 2 * _a + 2 * _b;
        }

        public override void WyswietlPole()
        {
            Console.WriteLine($"Pole PROSTOKĄTA = {ObliczPole()}");
        }
        public override void WyswietlObwod()
        {
            Console.WriteLine($"Obwód PROSTOKĄTA = {ObliczObwod()}");
        }

        public void Skaluj(int skala)
        {
            Console.WriteLine($"Po skalowaniu prostokąta boki A: {_a *= skala} B: {_b *= skala}");
        }

        public override void Wyswietl()
        {
            Console.WriteLine($"  Bok A. figury: {_a} B. {_b}");
            base.Wyswietl();
        }
        
        public int PobierzObjetosc()
        {
            return 0;
        }
        public override void WyswietlObjetosc()
        {
        }
    }
    class Prostopadloscian : Figura, IFiguryPrzestrzenne
    {
        int _a;
        int _b;
        int _c;
        public Prostopadloscian(int x, int y, int a, int b, int c) : base(x, y)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        public int ObliczPole()
        {
            return 2 * (_a * _b) + 2 * (_b * _c) + 2 * (_a * _c);
        }
        public override void WyswietlPole()
        {
            Console.WriteLine($"Pole PROSTOPADŁOŚCIANU = {ObliczPole()}");
        }
        public double ObliczObjetosc()
        {
            return _a * _b * _c;
        }
        public override void WyswietlObjetosc()
        {
            Console.WriteLine($"Objetosc PROSTOPADŁOŚCIANU = {ObliczObjetosc()}");
        }

        public override void Wyswietl()
        {
            Console.WriteLine($"  Bok C. figury: {_c}");
            base.Wyswietl();
        }

        public int PobierzObwod()
        {
            return 0;
        }
        public override void WyswietlObwod()
        {
        }
    }

    class Walec : Figura, IFiguryPrzestrzenne
    {
        double _p;
        int _z;
        public Walec(int x, int y, double p, int z) : base(x, y)
        {
            _p = p;
            _z = z;
        }
        public double ObliczPole()
        {
            return 2 * Math.PI * (_p * _p) + 2 * (Math.PI * _p * _z);
        }
        public override void WyswietlPole()
        {
            Console.WriteLine($"Pole WALCA = {ObliczPole()}");
        }
        public double ObliczObjetosc()
        {
            return Math.PI * (_p * _p) * _z;
        }
        public override void WyswietlObjetosc()
        {
            Console.WriteLine($"Objetosc WALCA wynosi: {ObliczObjetosc()}");
        }
        public override void Wyswietl()
        {
            Console.WriteLine($"Wysokość WALCA = {_z} promień podstawy {_p}");
            base.Wyswietl();
        }
        public int PobierzObwod()
        {
            return 0;
        }
        public override void WyswietlObwod()
        {
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //  Kwadrat kwadrat = new Kwadrat(2,2, 3);
            //  kwadrat.WyswietlPole();
            // Prostokat prostokat = new Prostokat(2,2, 3, 4);          //     to jest nieważne
            // prostokat.WyswietlPole();
            //  Kolo koło = new Kolo(1, 2, 3);
            //  koło.WyswietlPole();

            List<Figura> figury = new List<Figura>();
            figury.Add(new Kwadrat(2, 2, 2));
            figury.Add(new Prostokat(2, 2, 3, 4));
            figury.Add(new Kolo(2, 2, 3));
            figury.Add(new Prostopadloscian(2, 2, 3, 4, 5));
            figury.Add(new Walec(2, 2, 3, 5));

            for (int i = 0; i < figury.Count; i++)
            {
                figury[i].WyswietlPole();    
            }

            Console.ReadLine();
        }
    }
}



