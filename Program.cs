using System;
using System.Collections.Generic;

namespace Day9_Assignment_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<object> initialData = new List<object> { 75, "Hello", new MyClass(1, "Harry"), new MyClass(2, "Jack"), new MyClass(3, "Anil"), new MyClass(4, "Pritesh"), new MyClass(5, "Jafar"),new MyClass(6,"Abdul"), 20, "World" };
            var largeDataCollection = new LargeDataCollection(initialData);
            largeDataCollection.Add(42);
            largeDataCollection.Remove("Hello");
            largeDataCollection.Remove(20);
            Console.WriteLine("All elements in the LargeDataCollection:");
            for (int i = 0; i < initialData.Count; i++)
            {
                var element = largeDataCollection.GetElement(i);
                Console.WriteLine(element);
            }
            largeDataCollection.Dispose();
        }
    }
}
