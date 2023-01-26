using System;
using System.Drawing;
using Colorful;
using Console = Colorful.Console;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Sample
    {
        public void ColorConsole(){
            Console.WriteLine("console in pink", Color.Pink);
            Console.WriteLine("console in default");
            string dream = "a dream of {0} and {1} and {2} and {3} and {4} and {5} and {6} and {7} and {8} and {9}...";
            Formatter[] fruits = new Formatter[]
            {
                new Formatter("bananas", Color.LightGoldenrodYellow),
                new Formatter("strawberries", Color.Pink),
                new Formatter("mangoes", Color.PeachPuff),
                new Formatter("pineapples", Color.Yellow),
                new Formatter("cherries", Color.Red),
                new Formatter("oranges", Color.Orange),
                new Formatter("apples", Color.LawnGreen),
                new Formatter("peaches", Color.MistyRose),
                new Formatter("plums", Color.Indigo),
                new Formatter("melons", Color.LightGreen),
            };

            Console.WriteLineFormatted(dream, Color.Gray, fruits);
        }
        public void Meth()
        {
            Meth1();
            Meth2();
            Console.WriteLine("Hello World! Math");
        }
        private void Meth1()
        {
            Meth2();
            Console.WriteLine("Hello World! Math");
        }
        protected void Meth2()
        {
            Console.WriteLine("Hello World! Math");
        }
        internal void Meth3()
        {
            Meth2();
            Console.WriteLine("Hello World! Math");
        }
    }

    public class childClass : Sample{
        public void Test(){
            Meth2();
            Meth();
            Meth3();
        }
    }
}