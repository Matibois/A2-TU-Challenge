using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyMathImplementation
    {
        public static int Add(int a, int b)
        {
            return a + b;

        }

        public static List<int> GenericSort(List<int> toSort, object isInOrder)
        {
            /*
            isInOrder.AddRange(toSort);
            for (int i = 0; i < isInOrder.Count - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < isInOrder.Count; j++)
                {
                    if (isInOrder[j] < isInOrder[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = isInOrder[i];
                isInOrder[i] = isInOrder[minIndex];
                isInOrder[minIndex] = temp;
            }
            return isInOrder;*/

            throw new NotImplementedException();

        }

        public static List<int> GetAllPrimary(int a)
        {
            var count = new List<int>(){0,0 };
            for (int i = 2; i <= a; i++)
            {
                bool isPrime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    //count++;
                }
            }
            return count;
        }

        public static bool IsDivisible(int a, int b)
        {
            if (a % b == 0) return true;
            return false;

        }

        public static bool IsEven(int a)
        {
            if (a % 2 == 0) return true;
            else return false;
        }

        public static int IsInOrder(int a, int b)
        {
            if (a > b) return -1;
            else if (a < b) return 1;
            else return 0;
        }

        public static bool IsInOrderDesc(int arg1, int arg2)
        {
            throw new NotImplementedException();
        }

        public static bool IsListInOrder(List<int> list)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[j] < list[minIndex])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool IsMajeur(int age)
        {
            if (age < 18 && age > -1) return false;
            else if (age > 17 && age < 141) return true;
            else throw new ArgumentException();
        }

        public static bool IsPrimary(int a)
        {
            for (int i = 2; i < a; i++)
            {
                if (a % i == 0) return false;
            }
            return a > 1;
        }

        public static int Power(int a, int b)
        {
            int result = a;
            for (int i = 1; i < b; i++)
            {
                result = result * a;
            }
            return result;
        }

        public static int Power2(int a)
        {
            return a * a;
        }

        public static List<int> Sort(List<int> toSort)
        {

            for (int i = 0; i < toSort.Count - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < toSort.Count; j++)
                {
                    if (toSort[j] < toSort[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = toSort[i];
                toSort[i] = toSort[minIndex];
                toSort[minIndex] = temp;
            }
            return toSort;
        }
    }
}
