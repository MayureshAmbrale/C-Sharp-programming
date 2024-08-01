using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Addition
{
    private int No1, No2;
    public Addition(int A, int B)
    {
        this.No1 = A;
        this.No2 = B;
    }
    public int Add()
    {
        int Ans = 0;
        Ans = No1 + No2;
        return Ans;
    }

}
namespace Program2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Ret = 0;
            Console.WriteLine("Enter number 1");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Addition aobj = new Addition(n1, n2);
            Ret = aobj.Add();
            Console.WriteLine(Ret);
        }
    }
}
