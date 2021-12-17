using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    internal class MyConcreteClass : MyAbstractClass {
        public override int SomeAbstractMethod() {
            return 42;
        }
        public int SomeAbstractMethod(string x) {
            return 42;
        }
    }
}
