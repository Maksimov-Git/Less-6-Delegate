using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate_2
{
    public class MyClass
    { // метод 
        public void Method()
        {
            Console.WriteLine(" Я могу делегаты из экземпляра класса ! ");
        }
    }

    public delegate void MyDelegate(); 
    class Program
    {
        static void Main(string[] args)
        {

            MyClass My = new MyClass();
            MyDelegate myDelegate = new MyDelegate(My.Method);
            MyDelegate myDelegate1 = My.Method;//  техника предположения делегата
            My.Method();
            myDelegate.Invoke();// вызов метода делегата 
            myDelegate(); //упрашенный синтаксис вызова метода
            Console.ReadKey();


        }
    }
}
