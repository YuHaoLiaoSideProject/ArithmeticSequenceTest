using NUnit.Framework;
using System;

namespace TestProject1
{
    public class ArithmeticSequenceTest
    {
        [TestCase(3,15)]
        [TestCase(7, 87)]
        public void 代刚计计羆㎝(int input,int expected)
        {
            int actual = Calculate(input);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(1, 1, 2, 1)]
        [TestCase(1, 5, 2, 9)]
        [TestCase(10, 100, 10, 1000)]
        public void 代刚眔材N计(int first, int n, int diff, int expected)
        {
            int actual = ArithmeticSequence.眔计材N计(first, n, diff);
            Assert.AreEqual(expected, actual);
        }

        public int Calculate(int input)
        {
            if (input % 2 == 0)
                throw new Exception("块岿粇叫穝块");

            if (input == 1)
                return 1;

            //璸衡琌材碭
            input = (input + 1) / 2;

            int sumNumber = ArithmeticSequence.璸衡计羆Τ碭(input);

            int result = 0;
            //计羆
            for (int i = 0; i < 3; i++)
            {
                result += ArithmeticSequence.眔计材N计(1, sumNumber - i, 2);
            }

            return result;
        }

    }

    public class ArithmeticSequence
    {
        public static int 璸衡计羆Τ碭(int input)
        {
            int sumNumber = 0;
            int first = 1;
            for (int i = 0; i < input; i++)
            {
                sumNumber += first;
                first += 2;
            }

            return sumNumber;
        }

        /// <summary>
        /// 眔单畉计材 N 计
        /// </summary>
        /// <param name="first"></param>
        /// <param name="n"></param>
        /// <param name="diff"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static int 眔计材N计(int first, int n, int diff)
        {
            if (n < 1)
            {
                throw new Exception("岿粇");
            }
            return first + (n - 1) * diff;
        }
    }
}