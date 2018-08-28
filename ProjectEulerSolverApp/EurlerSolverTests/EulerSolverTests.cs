using System;
using EulerSolver;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EurlerSolverTests
{
    [TestClass]
    public class EulerSolverTests
    {
        private static Solver _solver;

        [ClassInitialize]
        public static void Up(TestContext context) => _solver = new Solver();

        [TestMethod]
        public void ProblemOneTest()
        {
            var expected = 233168;

            Assert.IsTrue(expected == _solver.QuestionOne());
        }

        [TestMethod]
        public void ProblemTwoTest()
        {
            var expected = 4613732;

            Assert.IsTrue(expected == _solver.QuestionTwo());
        }

        [TestMethod]
        public void ProblemFiveTest()
        {
            var expected = 232792560;

            Assert.IsTrue(expected == _solver.QuestionFive());
        }

        [TestMethod]
        public void ProblemSixTest()
        {
            var expected = 25164150;

            Assert.IsTrue(expected == _solver.QuestionSix());
        }

        [TestMethod]
        public void ProblemEightTest()
        {
            var expected = 23514624000;

            Assert.IsTrue(expected == _solver.QuestionEight());
        }
    }
}
