using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Table
{
     class Program
    {
        static void Main(string[] args)
        {

            HashTable ht = new HashTable(3);    // making three buckets
            ht.insert("London", 2);
            ht.insert("London", 10);
            ht.insert("New York", 15);
            ht.insert("Tokyo", 7);
            ht.insert("Bangkok", 2);
            ht.insert("Beijing", 6);
            ht.insert("Islamabad", 9);
            ht.display();
            Console.WriteLine("ываываыв");
            ht.resize();   // increase slots to 8
            ht.insert("Beijing", 6);
            ht.insert("Islamabad", 9);
            ht.insert("New Delhi", 17);
            ht.insert("Moscow", 12);
            ht.insert("Amsterdam", 5);
            ht.insert("Paris", 13);

            ht.Delete("Paris");
            ht.Delete("Moscow");

            ht.display();

            return;
        }
    }
}
