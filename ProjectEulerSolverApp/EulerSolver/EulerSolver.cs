using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerSolver
{
    public class Solver
    {
        public int QuestionOne()
        {
            var result = 0;
            foreach (var number in Enumerable.Range(1, 999))
            {
                if (number % 3 == 0 || number % 5 == 0)
                    result += number;
            }

            return result;
        }

        public long QuestionTwo()
        {
            long first = 1;
            long next = 1;
            long result = 0;
            long summed = 0;

            while (result < 4000000)
            {
                if ((result % 2) == 0)
                {
                    summed += result;
                }

                result = first + next;
                next = first;
                first = result;
            }

            return summed;
        }

        public long QuestionFive()
        {
            long  next = 1 ;
            while (!IsEvenlyDivisable(next))
            {
                next += 1;
            }

            bool IsEvenlyDivisable(long number)
            {
                // Don't need to test for 1 because it can be divided evenly into anything
                foreach (var num in Enumerable.Range(2, 19))
                {
                    if (!(number % num== 0))
                    {
                        return false;
                    }
                }
                return true;
            }

            return next;
        }

        public int QuestionSix()
        {
            double sumOfSquares = Enumerable.Range(1, 100).Select(num => num * num).Sum();
            double squareOfSums = Math.Pow(Enumerable.Range(1, 100).Sum(), 2);
            double result = 0;
            if (sumOfSquares < squareOfSums)
                result = squareOfSums - sumOfSquares;
            else
                result = sumOfSquares - squareOfSums;

            return (int)result;
        }

        public long QuestionEight()
        {
            const string testString = "73167176531330624919225119674426574742355349194934" +
                                                    "96983520312774506326239578318016984801869478851843" +
                                                     "85861560789112949495459501737958331952853208805511" +
                                                     "12540698747158523863050715693290963295227443043557" +
                                                     "66896648950445244523161731856403098711121722383113" +
                                                     "62229893423380308135336276614282806444486645238749" +
                                                     "30358907296290491560440772390713810515859307960866" +
                                                     "70172427121883998797908792274921901699720888093776" +
                                                     "65727333001053367881220235421809751254540594752243" +
                                                     "52584907711670556013604839586446706324415722155397" +
                                                     "53697817977846174064955149290862569321978468622482" +
                                                     "83972241375657056057490261407972968652414535100474" +
                                                     "82166370484403199890008895243450658541227588666881" +
                                                     "16427171479924442928230863465674813919123162824586" +
                                                     "17866458359124566529476545682848912883142607690042" +
                                                     "24219022671055626321111109370544217506941658960408" +
                                                     "07198403850962455444362981230987879927244284909188" +
                                                     "84580156166097919133875499200524063689912560717606" +
                                                     "05886116467109405077541002256983155200055935729725" +
                                                     "71636269561882670428252483600823257530420752963450";

            long largest = 0;
            long num = 0;

            for (int i = 0; i <  testString.Length - 12; i++) {
                num = Enumerable.
                                Range(1, 12).
                                Aggregate(long.Parse(testString.Substring(i, 1)),
                                                  (seed, next) => long.Parse(testString.Substring(i + next, 1)) * seed);
                if (num > largest) {
                    largest = num;
                }
            }

            return largest;
        }
    }
}
