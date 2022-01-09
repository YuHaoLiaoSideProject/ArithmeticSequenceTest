using NUnit.Framework;
using System;

namespace TestProject1
{
    public class ArithmeticSequenceTest
    {
        [TestCase(1, 1, 2, 1)]
        [TestCase(1, 5, 2, 9)]
        [TestCase(10, 100, 10, 1000)]
        public void ���ը��o��N���(int first, int n, int diff, int expected)
        {
            int actual = ArithmeticSequence.���o�ƦC��N��Ʀr(first, n, diff);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(1, 1)]
        [TestCase(3,15)]
        [TestCase(7, 87)]
        public void ���ռƦC��T����`�M(int input,int expected)
        {
            int actual = ArithmeticSequence.Calculate(input);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(1, 1)]
        [TestCase(3, 15)]
        [TestCase(7, 87)]
        public void ���ռƦC��T����`�MCalc(int input, int expected)
        {
            int actual = ArithmeticSequence.Calc(input);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(2)]
        [TestCase(4)]
        [TestCase(-1)]
        [TestCase(-3)]
        public void ���հ��Ƥέt��(int input)
        {
            var ex = Assert.Throws<Exception>(() => ArithmeticSequence.Calc(input));
            Assert.That(() => ex != null && ex.Message.Contains("��J���~"));
        }
    }

    public class ArithmeticSequence
    {
        public static int Calc(int number)
        {
            // number ���ݬO����
            if (number < 0 || number % 2 == 0)
                throw new Exception("��J���~�A�Э��s��J");

            if (number == 1)
                return 1;
         
            // �@�@�ֿn�X�{�h�ּƦr?
            int h = (number + 1) / 2; //��Τ�������
            int count = (1 + number) * h / 2; 
            // �@�@�ֿn�X�{�h�ּƦr
            // �ھڼƦr���Ӽ�,�i�H�o���̫�@�ӼƦr�O��
            int lastNumber = count * 2 - 1;
            // �̫�G�ӼƦr���`�M�O
            int result = (lastNumber - 2) * 3;
            return result;
        }
        public static int Calculate(int input)
        {
            if (input < 0 || input % 2 == 0)
                throw new Exception("��J���~�A�Э��s��J");

            if (input == 1)
                return 1;

            //�p��O�ĴX�C
            input = (input + 1) / 2;

            int sumNumber = ArithmeticSequence.�p��ƦC�`�@���X��(input);

            int result = 0;
            //�˼ƤT��[�`
            for (int i = 0; i < 3; i++)
            {
                result += ArithmeticSequence.���o�ƦC��N��Ʀr(1, sumNumber - i, 2);
            }

            return result;
        }
        public static int �p��ƦC�`�@���X��(int input)
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
        /// ���o���t�ƦC�� N ���
        /// </summary>
        /// <param name="first"></param>
        /// <param name="n"></param>
        /// <param name="diff"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static int ���o�ƦC��N��Ʀr(int first, int n, int diff)
        {
            if (n < 1)
            {
                throw new Exception("���~");
            }
            return first + (n - 1) * diff;
        }
    }
}