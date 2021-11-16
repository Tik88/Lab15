using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    class Program
    {
        static void Main()
        {
            ArithProgression arithprogression = new ArithProgression();
            GeomProgression geomprogression = new GeomProgression();
            ISeries number;

            for (int i = 0; i <= 50; i++)
            {
                number = arithprogression;
                Console.WriteLine("Следующее четное число равно " + number.GetNext());

                number = geomprogression;
                Console.WriteLine("Следующее простое число " + "равно " + number.GetNext());                
            }
            Console.ReadKey();
        }
        public interface ISeries
        {
            int GetNext();
            void Reset();
            void SetStart(int х);
        }
        class ArithProgression : ISeries
        {
            int start;
            int val;

            public ArithProgression()
            {
                start = 0;
                val = 0;
            }

            public int GetNext()
            {
                val += 2;
                return val;
            }

            public void Reset()
            {
                val = start;
            }

            public void SetStart(int x)
            {
                start = x;
                val = start;
            }
        }

        class GeomProgression : ISeries
        {
            int start;
            int val;
            public GeomProgression()
            {
                start = 2;
                val = 2;
            }

            public int GetNext()
            {
                int i, j;
                bool isprime;
                val++;
                for (i = val; i < 1000000; i++)
                {
                    isprime = true;
                    for (j = 2; j <= i / j; j++)
                    {
                        if ((i % j) == 0)
                        {
                            isprime = false;
                            break;
                        }
                    }
                    if (isprime)
                    {
                        val = i;
                        break;
                    }
                }
                return val;
            }

            public void Reset()
            {
                val = start;
            }

            public void SetStart(int x)
            {
                start = x;
                val = start;
            }
        }
    }    
   
}
