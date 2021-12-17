using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    internal class ConstructorsDemo {
        public int IntProperty { get; set; }
        public bool BoolProperty { get; set; }
        public string StringProperty { get; set; }
        public Customer CustomerProperty { get; set; }
        //new ConstructorsDemo();
        public ConstructorsDemo() : this(5, true, new(), "Hi")
        {
            Console.WriteLine("Default constructor has been invoked!");

        }
        //new ConstructorsDemo(new Customer(){Name = "Mario"});
        public ConstructorsDemo(Customer customer) : this(5, true, customer, "Hi") 
        {
            Console.WriteLine("Constructor with 1 customer parameter has been invoked!");
        }
        public ConstructorsDemo(int intValue, bool boolValue, Customer customer, string stringValue) {
            Console.WriteLine("Constructor with 4 parameter has been invoked!");
            IntProperty = intValue;
            BoolProperty = boolValue;
            CustomerProperty = customer;
            StringProperty = stringValue;
        }
        ~ConstructorsDemo() {
            Console.WriteLine($"Destructor were invoked for {IntProperty}");
        }
    }
}
