using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApplication {
    internal record Employee(int Id, string Name, string Surname) {
        public void DoSomething() {
            Console.WriteLine("Employee doing something");
        }
    }
}
