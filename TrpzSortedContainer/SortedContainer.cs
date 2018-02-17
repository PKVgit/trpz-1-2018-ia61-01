﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrpzSortedContainer
{
    public class SortedContainer
    {
        //Сортировка перемешиванием
        public static int[] ShakerSort(int[] arr)
        {
            int left = 0,
            right = arr.Length - 1,
            count = 0;

            while (left <= right)
            {
                for (int i = left; i < right; i++)
                {
                    count++;
                    if (arr[i] > arr[i + 1])
                        Swap(arr, i, i + 1);
                }
                right--;

                for (int i = right; i > left; i--)
                {
                    count++;
                    if (arr[i - 1] > arr[i])
                        Swap(arr, i - 1, i);
                }
                left++;
            }
            return arr;
        }

        private static void Swap(int[] myint, int i, int j)
        {
            int glass = myint[i];
            myint[i] = myint[j];
            myint[j] = glass;
        }
    }
}
