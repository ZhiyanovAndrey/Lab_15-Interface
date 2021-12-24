using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_15_Interface
{
    /* Разработать интерфейс ISeries генерации ряда чисел. Интерфейс содержит следующие элементы:

     метод void setStart(int x) - устанавливает начальное значение
     метод int getNext() - возвращает следующее число ряда
     метод void reset() - выполняет сброс к начальному значению

 Разработать классы ArithProgression и GeomProgression, которые реализуют интерфейс ISeries.
 В классах реализовать методы интерфейса в соответствии с логикой арифметической 
 и геометрической прогрессии соответственно. */


    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Введите начальное значение для прогрессий");
           int a = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Введите шаг для прогрессий");
           int b = Convert.ToInt32(Console.ReadLine());

            ArithProgression ari = new ArithProgression();
            GeomProgression geo = new GeomProgression();
            Console.WriteLine("Арифметическая прогресссия\tГеометрическая прогресссия");
            
            geo.setStart(a);
            geo.setStep(b);
            ari.setStep(b);
            ari.setStart(a);
            Console.WriteLine($"\t     {ari.getNext()}                   \t{geo.getNext()}");
            Console.WriteLine($"\t     {ari.getNext()}                   \t{geo.getNext()}");
            Console.WriteLine($"\t     {ari.getNext()}                   \t{geo.getNext()}");
            Console.WriteLine($"\t     {ari.getNext()}                   \t{geo.getNext()}");
            Console.WriteLine($"\t     {ari.getNext()}                   \t{geo.getNext()}");
            Console.WriteLine($"\t     {ari.getNext()}                   \t{geo.getNext()}");
            Console.WriteLine($"\t     {ari.getNext()}                   \t{geo.getNext()}");
            geo.reset(); ari.reset();
            Console.WriteLine($"\t     {ari.getNext()}                   \t{geo.getNext()}");
            Console.WriteLine($"\t     {ari.getNext()}                   \t{geo.getNext()}");
            Console.WriteLine($"\t     {ari.getNext()}                   \t{geo.getNext()}");
            Console.ReadKey();

        }
    }

    interface ISeries
    {
        void setStart(int x);
        int getNext();
        void reset();
    }

    class ArithProgression : ISeries
    {
        int step;
        int startValue, curentValue;
        public void setStep(int s)//устанавливает шаг 
        {
            step = s;
        }

        public int getNext()
        {
            curentValue += step;
            return curentValue;
        }

        public void reset()
        {
            curentValue = startValue;
            Console.WriteLine("Reset");

        }

        public void setStart(int x)
        {
            startValue = x;
            curentValue = startValue;
        }

    }
    class GeomProgression : ISeries
    {
        int step;
        int startValue, curentValue;
        public void setStep(int s)//устанавливает шаг 
        {
            step = s;
        }

        public int getNext()
        {
            curentValue *= step;
            return curentValue;
        }

        public void reset()
        {
            curentValue = startValue;
            Console.WriteLine("Reset");
        }

        public void setStart(int x)
        {
            startValue = x;
            curentValue = startValue;
        }
    }

}

