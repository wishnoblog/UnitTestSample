using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var sorting = new QuickSort();
            var arr = new int[] { 43, 82, 26, -8, 89, 62, -3, 94, 26, 11};
            
            Console.WriteLine($"排序前: {string.Join(", ", arr)}");
            
            sorting.Sort(arr);
            Console.WriteLine($"排序後: {string.Join(", ", arr)} ");

        }
    }
    
}
