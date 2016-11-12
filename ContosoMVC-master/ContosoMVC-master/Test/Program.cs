using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test {
    
    class Program {
        static void Main(string[] args) {
            int[][] a = new int[][] { new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 } };
            Console.WriteLine(a[0].Length); 
            Console.WriteLine(a.Length);
        }
    }
}
