using System;

namespace lab1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            River Berezina = new River();
            River Sorjyanka = new River(sorjyanka, 23, 3457565);
        }
    }

    public class River
    {
        public string name;
        public double square;
        public double length;

        public River(string name, double square, double length)
        {
            this.name = name;
            this.square = square;
            this.length = length;
        }
        
        
        public River(string Name, double Square, double Length)
        {
            name = Name;
            square = Square;
            length = Length;
        }
        public River(){}
    }
}