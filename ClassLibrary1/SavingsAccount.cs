using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    internal class SavingsAccount : BankAccount {
        public double Interest { get; set; }
        public decimal CalculateYearlyInterest() {
            return (decimal)Interest * Balance;
        }
        public override void WithDraw(decimal amount) {
            base.WithDraw(amount);
        }
    }
}
