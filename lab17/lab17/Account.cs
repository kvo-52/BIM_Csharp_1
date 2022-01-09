using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab17
{
    class Account<T>
    {
        private T NewNumber { get; set; }
        private decimal Balance { get; set; }
        private string Owner { get; set; }
        public Account(T newNumber, decimal balance, string owner)
        {
            NewNumber = newNumber;
            Balance = balance;
            Owner = owner;
        }
    }
}
