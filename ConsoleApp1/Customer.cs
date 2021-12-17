using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    /// <summary>
    /// This rpresents the data of our customers of the web shop
    /// </summary>
    internal class Customer {
        public int Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; } = "";
        public string? Surname { get; set; }
        public int Age { get; set; }
        public ConsoleColor FavoriteColor { get; set; }
        public ItalianDay FavoriteDay { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string SayHi() {
            return $"Hi, my name is {Name} {Surname}";
        }
        //SayHi("Texas")
        public string SayHi(string you) => $"Hi {you}, my name is {Name} {Surname}";
        //SayHi(5)
        public string SayHi(int times) {
            string result = "";
            for (int i = 0; i < times; i++) {
                result += $"Hi , my name is {Name} {Surname}\r\n";
            }
            return result;
        }
        public Customer() {

        }

        //public Customer(int id, string name, string surname, int age) {
        //    Id = id; 
        //    Name = name; 
        //    Surname = surname; 
        //    Age = age;
        //}

        public Customer(int id, string name, string surname, int age) => (Id, Name, Surname, Age) = (id, name, surname, age);

        override public string ToString() => $"Customer {Name} {Surname}";
    }
}
