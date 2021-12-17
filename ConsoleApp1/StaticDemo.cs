using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    //StaticDemo o1 = new();
    //StaticDemo o2 = new();
    //o1.IntProperty = 5;
    //o2.IntProperty = 10;

    internal class StaticDemo {
        public int IntProperty { get; set; }
        public static int MyStaticProperty { get; set; }
        public int MyMethod() {
            return IntProperty * 2;
        }
        public static int MyStaticMethod() {
            return MyStaticProperty * 2;
        }
    }
}
