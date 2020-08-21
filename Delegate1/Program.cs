using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate1
{
  


    class Program
    {
        static void Main(string[] args)
        {
            // создаем экземпляр класса делегат
            MyDelegate myDelegate = new MyDelegate(MyClass.Method);
            myDelegate.Invoke(); // вызываем метод - Method ;
            myDelegate(); // Или Вот так .

            Console.ReadKey();
        }
    }
}
