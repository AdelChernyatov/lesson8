using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson8
{
    class Bank_account
    {

        private decimal balance;
        public decimal Getbalance()
        {
            return balance;
        }
        public void Setbalance(decimal _balance)
        {
            balance = _balance;
        }
        public void Transfer(ref Bank_account person, int sum_, int balance, int balance2) //счет с которого снимают
        {
            if (sum_ <= balance)
            {
                balance2 += sum_;
                Setbalance(balance2);
                Console.WriteLine(Getbalance());
            }
            else
            {
                Setbalance(balance2);
                Console.WriteLine(Getbalance());
            }
            return;
        }





    }
}
