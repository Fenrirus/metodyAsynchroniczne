using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodyAsynchroniczne
{
    class Program
    {
        static void Main(string[] args)
        {
            Asynchorniczne asynch = new Asynchorniczne();
            asynch.wypiszDane();
            Console.ReadKey();
        }

       
    }
    public class Asynchorniczne
    {
        public async void wypiszDane()
        {
            int wynikDzialania = wynik(3, 4);
            Console.WriteLine($"Wynik działania to {wynikDzialania}");
            int wynikDzialania2 = await wynikAsync(5, 7);
            Console.WriteLine($"Wynik działania to {wynikDzialania2}");
        }

        int wynik(int a, int b)
        {
            return a * b;
        }
        Task<int> wynikAsync(int a, int b)
        {
            return Task.Run(() => a * b);
        }
    }
}
