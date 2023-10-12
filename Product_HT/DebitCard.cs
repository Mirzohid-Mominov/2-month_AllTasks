using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//DebitCard modelidan foydalanig - ( cardNumber, balance ) 

namespace Product_HT
{
    internal class DebitCard
    {
        public DebitCard(string number, double balance)
        {
            Number = number;
            Balance = balance;
        }

        public string Number { get; set; }
        public double Balance { get; set; }
    }
}
