using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    
    public class Bank {
        private List<BankAccount> accounts = new List<BankAccount>();
        public BankAccount OpenAccount(string owner, int type) {
            BankAccount account;
            switch (type) {
                case 1:
                    account = new BankAccount() { Id = Guid.NewGuid() };
                    break;
                case 2:
                    account = new SavingsAccount() { Id = Guid.NewGuid() };
                    break;
                default:
                    account = new BankAccount() { Id = Guid.NewGuid() };
                    break;
            }
            
            accounts.Add(account);
            return account;
        }

        //BankAccount b = bank[2];
        public BankAccount this[int index] 
        {
            //BankAccount b = bank[2];
            get { return accounts.ElementAtOrDefault(index); }

            //bank[2] = new BankAccount();
            //set { accounts.Insert(index, value); }
        }
        public BankAccount this[Guid id] {
            //BankAccount b = bank[2];
            get { return accounts.FirstOrDefault(account=>account.Id== id); }

            //bank[2] = new BankAccount();
            //set { accounts.Insert(index, value); }
        }

    }
}
