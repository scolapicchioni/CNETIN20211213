using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    internal class NameTooLongException : Exception {
        public NameTooLongException() {

        }
        public NameTooLongException(string message) : base(message) { //new Exception(message)

        }
        public int MaxAllowedLength { get; set; }
        public int FoundLenght { get; set; }
    }
}
