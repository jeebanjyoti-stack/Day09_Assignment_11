using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_Assignment_11
{
    internal class MyClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public MyClass(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}";
        }
    }
}
