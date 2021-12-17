using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    internal class PropertiesDemo {
        private int x;

        //Console.WriteLine(p.GetX());
        public int GetX() {
            return x;
        }
        //p.SetX(10);
        public void SetX(int value) {
            x = value;
        }

        public int X 
        {
            //Console.WriteLine(p.X);
            get { return x; }
            //p.X = 10;
            set { x = value; }
        }


        public int Y { get; private set; }
    }
}
