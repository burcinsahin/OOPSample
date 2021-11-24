using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using Xunit;

namespace AlgorithmWorkshop
{

    public class Exceptionly
    {
        [Fact]
        public void Q1()
        {
            Assert.Equal(1, solve(6));
            Assert.Equal(1, solve(12));
            Assert.Equal(7, solve(10));
            Assert.Equal(4, solve(8));
            Assert.Equal(5, solve(11));
            Assert.Equal(8, solve(3));
            Assert.Equal(2, solve(7));
            Assert.Equal(4, solve(32));
            Assert.Equal(7, solve(64));
        }

        static BigInteger solve(int N)
        {
            BigInteger value = 1;

            for (int i = 0; i < N; i++)
            {
                value *= 2;
            }

            while (value > 9)
            {
                value = SumDigits(value);
            }

            return value;
        }

        private static BigInteger SumDigits(BigInteger val)
        {
            if (val < 10)
                return val;

            return val % 10 + SumDigits(val / 10);
        }

        [Fact]
        public void Q3()
        {
            Assert.True(IsPrime(2));
            Assert.True(IsPrime(3));
            Assert.True(IsPrime(5));
            Assert.True(IsPrime(7));
            Assert.True(IsPrime(11));
            Assert.True(IsPrime(23));
            Assert.False(IsPrime(16));
            Assert.False(IsPrime(38));

            Assert.Equal(1, solve2(10));
            Assert.Equal(2, solve2(8));
            Assert.Equal(3, solve2(16));
            Assert.Equal(2, solve2(99));
            Assert.Equal(9, solve2(1024));
        }

        private static int solve2(int N)
        {
            var primeNumbers = new List<int>();
            for (int i = 2; i < 1000; i++)
            {
                if (IsPrime(i)) primeNumbers.Add(i);
            }

            var height = 0;
            var temp = N;
            for (int i = 0; i < primeNumbers.Count; i++)
            {
                while (temp > primeNumbers[i] && temp % primeNumbers[i] == 0)
                {
                    height++;
                    temp = temp / primeNumbers[i];
                }
            }

            return height;
        }

        private static bool IsPrime(int value)
        {
            if (value == 2) return true;
            for (int i = 2; i < value / 2; i++)
            {
                if (value % i == 0)
                    return false;
            }
            return true;
        }

        [Fact]
        public void S()
        {
            StringBuilder s = new StringBuilder("ttt");
            s[0] = 'c';
            Assert.Equal("ctt", s.ToString());
        }


        [Fact]
        public void Q2()
        {
            Assert.Equal(new long[] { 1 }, solve3(5, 1, new[] { 1, 2, 4, 2, 4 }, new[] { 2 }));
        }

        public long[] solve3(int N, int Q, int[] X, int[] queries)
        {
            var p = new int[N];

            for (int i = 0; i < X.Length; i++)
            {
                p[X[i]]++;
            }

            var result = new long[queries.Length];
            for (int i = 0; i < queries.Length; i++)
            {
                result[0] = p[queries[i]];
            }

            return result;
        }
    }
}
