using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_paskaita_2018_12_18
{
    //delegate void DoOperation(int m1, int m2);
    public delegate void EventHandler(string message);
    

    class Program
    {
        public event EventHandler OnChanged;
        static void Main(string[] args)
        {
            /*
            DoOperation doOperation = new DoOperation(MyMultiply);
            doOperation(12, 5);

            doOperation += MySum;

            doOperation(43, 2);

            doOperation -= MyMultiply;

            doOperation(14, 10);

            Console.ReadKey();
        }
        static void MyMultiply(int m1, int m2)
        {
            Console.WriteLine("Daugyba: " + m1 * m2);
        }
        static void MySum(int m1, int m2)
        {
            Console.WriteLine("Suma: " + (m1 + m2));
        }
        

            Bank myBank = new Bank("SEB", 1000);

            EmailSender emailSender = new EmailSender();

            myBank.AddMoney(100);

            Console.ReadKey();
        }

        static void EmailSender(string message)
        {

        }

        static void FileLogger(string message)
        {
        */

            List<Student> studentai = new List<Student>;
        }
        
    }
}
