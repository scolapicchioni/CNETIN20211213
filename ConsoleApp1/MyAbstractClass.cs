using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    internal abstract class MyAbstractClass {
        public int MyProperty { get; set; }
        public int SomeMethod() {
            return 42;
        }

        public abstract int SomeAbstractMethod();
    }
}
