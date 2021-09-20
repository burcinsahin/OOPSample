using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace AlgorithmWorkshop
{
    public class MicrosoftCodility
    {
        #region 1
        [Fact]
        public void Test1()
        {
            int[] a = new int[] { 3, 2, 1, 1, 2, 3, 1 };
            Assert.Equal(5, solution(a));
            a = new int[] { 4, 1, 4, 1 };
            Assert.Equal(6, solution(a));
            a = new int[] { 3, 3, 3 };
            Assert.Equal(0, solution(a));
        }

        public int solution(int[] A)
        {
            double sum = 0;
            foreach (var item in A)
            {
                sum += item;
            }

            var avg = Convert.ToInt32(Math.Round(sum / A.Length));
            var counter = 0;

            for (int i = 0; i < A.Length; i++)
            {
                while (A[i] != avg)
                {
                    counter++;
                    if (A[i] < avg) A[i]++;
                    else A[i]--;
                }
            }

            return counter;
        }
        #endregion

        #region 2
        [Fact]
        public void Test2()
        {
            int[] a = new int[] { 3, 3, 3, 2, 2, 3 };
            Assert.Equal(3, solution2(a));
            a = new int[] { 4, 2, 5, 8, 7, 3, 7 };
            Assert.Equal(2, solution2(a));
            a = new int[] { 14, 21, 16, 35, 22 };
            Assert.Equal(1, solution2(a));
            a = new int[] { 5, 5, 5, 5, 5, 5 };
            Assert.Equal(3, solution2(a));
        }

        public int solution2(int[] A)
        {
            var used = new List<int>();
            //bool skipped = false;
            var counter = 0;
            for (int i = 0; i < A.Length; i++)
            {
                var curr = A[i];
                var prev = GetPrevious(A, i);
                var next = GetNext(A, i);
                int prevIndex = i - 1 < 0 ? A.Length - 1 : i - 1;
                int nextIndex = (i + 1) % A.Length;
                if (used.Contains(i))
                    continue;
                if (!used.Contains(prevIndex) && CheckIfSumEven(curr, next) && CheckIfSumEven(prev, curr))
                {
                    if (CheckIfSumEven(next, GetNext(A, i + 1))) //Check next
                    {
                        counter++;
                        used.Add(i);
                        used.Add(prevIndex);
                    }
                    else
                    {
                        counter++;
                        used.Add(i);
                        used.Add((i + 1) % A.Length);
                        i++;
                    }
                }
                else if (CheckIfSumEven(curr, next))
                {
                    used.Add(i);
                    used.Add((i + 1) % A.Length);
                    counter++;
                    i++;
                }
            }

            return counter;
        }

        private static int GetPrevious(int[] A, int i)
        {
            if (i - 1 < 0)
                return A[A.Length - 1];
            return A[i - 1];
        }

        private static int GetNext(int[] A, int i)
        {
            return A[(i + 1) % A.Length];
        }

        private static bool CheckIfSumEven(int a, int b)
        {
            return (a + b) % 2 == 0;
        }
        #endregion

        #region 3

        [Fact]
        public void Test3()
        {
            int[] a = new int[] { 3, 3, 3, 2, 2, 3 };
            Assert.Equal(3, solution3(5, new [] { 2, 2, 1, 2 }, new [] { 2, 2, 1, 2 }));
        }

        public int solution3(int N, int[] A, int[] B)
        {
            var result = 0;
            var dict = new Dictionary<int, int>();
            for (int i = 0; i < N; i++)
            {
                if (dict.ContainsKey(A[i])) dict[A[i]]++;
                else dict.Add(A[i], 1);
                if (dict.ContainsKey(B[i])) dict[B[i]]++;
                else dict.Add(B[i], 1);
            }

            dict.Values.ToArray<int>();
            //TODO Implement
            return result;
        }
        #endregion
    }
}
