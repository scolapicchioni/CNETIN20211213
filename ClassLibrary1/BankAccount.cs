using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    
    public class BankAccount {
        internal BankAccount() {

        }
        public decimal Balance { get; protected set; }
        public Guid Id { get; set; }
        
        
        public virtual void WithDraw(decimal amount) {
            Balance -= amount;
        }

        public void Deposit(decimal amount) {
            Balance += amount;
        }
    }
}
