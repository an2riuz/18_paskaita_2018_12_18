using System;
namespace _18_paskaita_2018_12_18
{
    internal class Bank
    {
        private string bankName;
        private int amount;

        public Bank(string bankName, int amount)
        {
            this.bankName = bankName;
            this.amount = amount;
        }

        public void AddMoney(int suma)
        {
            Console.WriteLine("Prideta pinigu: " + (amount + suma));
        }

        public void OnAnyTransaction()
        {
            Console.WriteLine("Atlikta operacija");
        }
    }
}