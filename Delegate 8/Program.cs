using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_8
{
   public static class A
    {
        private static int i;

        public static void MetA()
        {
            Console.WriteLine("A");
        }

        public static void MetA1()
        {
            throw new System.NotImplementedException();
        }
    }
    public static class B
    {
        public static void MetB()
        {
            Console.WriteLine("B");
        }

        public static string NotorStart()
        {
            Console.WriteLine("Врррррррр");
            throw new System.NotImplementedException();
        }
    }
    public delegate void MultiDelegate();

    class Program
    {
        static void Main(string[] args)
        {
            MultiDelegate Mul1 = new MultiDelegate(A.MetA);
            MultiDelegate Mul2 = new MultiDelegate(B.MetB);

            MultiDelegate Mul3 = Mul1 + Mul2;
            Mul3();
            Console.ReadKey();

        }
    }

    public class ClassHrenas : Program, Interface1
    {

    }

    public delegate void Delegate1();

    public interface Interface1
    {
    }
}
