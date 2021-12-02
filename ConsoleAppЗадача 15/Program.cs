using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppЗадача_15
{
    class Program
    {
        static void Main(string[] args)
        {
            ArithProgression ar1 = new ArithProgression(2);
            ar1.SetStart(5);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(ar1.GetNext());
            }
            ar1.Reset();
            Console.WriteLine(ar1.GetNext());
            Console.WriteLine("\n\n");
            GeomProgression ar2 = new GeomProgression(2);
            ar2.SetStart(5);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(ar2.GetNext());
            }
            ar2.Reset();
            Console.WriteLine(ar2.GetNext());
        }
    }
    public interface ISeries
    {
        void SetStart(int x);
        int GetNext();
        void Reset();
    }
    public class ArithProgression : ISeries
    {
        private int Start { get; set; }
        private int Current { get; set; }
        private int Step { get; set; }
        public ArithProgression(int step)
        {
            Step = step;
        }
        public void SetStart(int x)
        {
            Start = x;
            Current = x;
        }
        public int GetNext()
        {
            return Current += Step;
        }
        public void Reset()
        {
            Current = Start;
        }
    }
    public class GeomProgression : ISeries
    {
        private int Start { get; set; }
        private int Current { get; set; } = 1;
        private int Step { get; set; }
        public GeomProgression(int step)
        {
            Step = step;
        }
        public void SetStart(int x)
        {
            Start = x;
            Current = x;
        }
        public int GetNext()
        {
            return Current *= Step;
        }
        public void Reset()
        {
            Current = Start;
            Console.ReadKey();
        }
    }
}
        
    

