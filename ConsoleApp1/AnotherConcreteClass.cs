using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    internal class AnotherConcreteClass : MyAbstractClass {
        public override int SomeAbstractMethod() {
            return 42;
        }
    }
}
