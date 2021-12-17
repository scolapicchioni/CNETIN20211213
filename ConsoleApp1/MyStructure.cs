using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    internal struct MyStructure {
        public int IntProperty { get; set; }
        public string StringProperty { get; set; }
        public Customer CustomerProperty { get; set; }
        override public string ToString() => $"{IntProperty} {StringProperty} - {CustomerProperty}";
    }
}
