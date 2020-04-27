using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestSample
{
    /// <summary>
    /// 快速排序法
    /// </summary>
    public class QuickSort
    {
        /// <summary>
        /// 排序 
        /// </summary>
        /// <param name="arr">來源資料</param>
        public void Sort(int[] arr)
        {
            Sort(arr, 0, arr.Length - 1);
        }
        /// <summary>
        /// 排序
        /// </summary>
        /// <param name="arr">來源資料</param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        private void Sort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                var pivot = Partition(arr, left, right);
                Sort(arr, left, pivot - 1);
                Sort(arr, pivot + 1, right);
            }
        }
        /// <summary>
        /// Partition 調整數列用
        /// </summary>
        /// <param name="arr">array</param>
        /// <param name="left">start</param>
        /// <param name="right">end</param>
        /// <returns></returns>
        private int Partition(int[] arr, int left, int right)
        {
            var pivot = arr[right];
            var i = left - 1;

            for (int j = left; j <= right - 1; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;
                    Swap(ref arr[i], ref arr[j]);
                }
            }
            Swap(ref arr[i + 1], ref arr[right]);
            return i + 1;
        }
        /// <summary>
        /// 交換元素
        /// </summary>
        /// <param name="a">元素1</param>
        /// <param name="b">元素2</param>
        private void Swap(ref int a, ref int b)
        {
            var temp = a;
            a = b;
            b = temp;
        }
    }
}
