using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program6
{
    internal class Marks
    {
        int mark;
        public Marks(int no)
        {
            this.mark = no;
        }
        public int CheckMarks()
        {
            if (mark > 100 || mark < 0) return -1;
            else if (mark >= 0 && mark < 35) return 1;
            else if (mark >= 35 && mark < 60) return 2;
            else if (mark >= 60 && mark < 80) return 3;
            else
                return 4;

        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter your marks:");
                int no = Convert.ToInt32(Console.ReadLine());
                Marks mobj = new Marks(no);
                int Ret = 0;
                Ret = mobj.CheckMarks();
                if (Ret == -1) { Console.WriteLine("Marks not in range"); }
                else if (Ret == 1)
                {
                    Console.WriteLine("Fail");

                }
                else if (Ret == 2)
                {
                    Console.WriteLine("C Grade");
                }
                else if (Ret == 3)
                {
                    Console.WriteLine("B Grade");
                }
                else
                {
                    Console.WriteLine("A Grade");
                }
            }
        }
    }
}

                
