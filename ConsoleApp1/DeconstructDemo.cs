using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    internal class DeconstructDemo {
        public int IntProperty { get; set; }
        public string StringProperty { get; set; }
        public bool BoolProperty { get; set; }

        public void Deconstruct(out int first, out string second, out bool third) {
            first = IntProperty;
            second = StringProperty;
            third = BoolProperty;
        }
    }
}
