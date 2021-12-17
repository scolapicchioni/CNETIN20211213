using Simona.SomeNameSpace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    internal class ClassThatImplementsMyInterface : MyInterface {
        public void Method01() {
            Console.WriteLine("Method 01!");
        }

        public int Method02(decimal x) {
            return 42;
        }

        public string Method03() {
            return "HI!";
        }
    }
}
