using NUnit.Framework;
using System;

namespace TestProject1
{
    public class ArithmeticSequenceTest
    {
        [TestCase(1, 1, 2, 1)]
        [TestCase(1, 5, 2, 9)]
        [TestCase(10, 100, 10, 1000)]
        public void 代刚眔材N计(int first, int n, int diff, int expected)
        {
            int actual = ArithmeticSequence.眔计材N计(first, n, diff);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(1, 1)]
        [TestCase(3,15)]
        [TestCase(7, 87)]
        public void 代刚计计羆㎝(int input,int expected)
        {
            int actual = ArithmeticSequence.Calculate(input);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(1, 1)]
        [TestCase(3, 15)]
        [TestCase(7, 87)]
        public void 代刚计计羆㎝Calc(int input, int expected)
        {
            int actual = ArithmeticSequence.Calc(input);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(2)]
        [TestCase(4)]
        [TestCase(-1)]
        [TestCase(-3)]
        public void 代刚案计の璽计(int input)
        {
            var ex = Assert.Throws<Exception>(() => ArithmeticSequence.Calc(input));
            Assert.That(() => ex != null && ex.Message.Contains("块岿粇"));
        }
    }

    public class ArithmeticSequence
    {
        public static int Calc(int number)
        {
            // number ゲ惠琌案计
            if (number < 0 || number % 2 == 0)
                throw new Exception("块岿粇叫穝块");

            if (number == 1)
                return 1;
         
            // 仓縩瞷ぶ计?
            int h = (number + 1) / 2; //辫そΑ蔼
            int count = (1 + number) * h / 2; 
            // 仓縩瞷ぶ计
            // 沮计计,眔程计琌ぶ
            int lastNumber = count * 2 - 1;
            // 程计羆㎝琌
            int result = (lastNumber - 2) * 3;
            return result;
        }
        public static int Calculate(int input)
        {
            if (input < 0 || input % 2 == 0)
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