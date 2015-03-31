using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TwelveStatementsLogic;

namespace StatementCheckerTests
{
    [TestClass]
    public class StatementCheckerTests
    {
        [TestMethod]
        public void Statement1CheckSetsSolutionHoldsToTrue()
        {
            var check = new StatementChecker();
            check.possibleSolution = new bool[] { true, true, true, true, true, true, true, true, true, false, false, false };
            check.statement1Check();

            var actual = true;

            Assert.AreEqual(check.solutionHolds, actual);
        }

        [TestMethod]
        public void Statement1CheckSetsSolutionHoldsToFalse()
        {
            var check = new StatementChecker();
            check.possibleSolution = new bool[] { true, false, true, true, true, true, true, true, true, false, false, false };
            check.statement1Check();

            var actual = false;

            Assert.AreEqual(check.solutionHolds, actual);
        }

        [TestMethod]
        public void Statement2CheckSetsSolutionHoldsToTrue()
        {
            var check = new StatementChecker();
            check.possibleSolution = new bool[] { true, false, false, true, true, true, true, true, true, false, false, false };
            check.statement2Check();

            var actual = true;

            Assert.AreEqual(check.solutionHolds, actual);
        }

        [TestMethod]
        public void Statement2CheckSetsSolutionHoldsToFalse()
        {
            var check = new StatementChecker();
            check.possibleSolution = new bool[] { true, false, true, true, true, true, true, true, true, false, false, false };
            check.statement2Check();

            var actual = false;

            Assert.AreEqual(check.solutionHolds, actual);
        }

        [TestMethod]
        public void Statement3CheckSetsSolutionHoldsToTrue()
        {
            var check = new StatementChecker();
            check.possibleSolution = new bool[] { true, false, false, true, true, true, true, true, true, false, false, false };
            check.statement3Check();

            var actual = true;

            Assert.AreEqual(check.solutionHolds, actual);
        }

        [TestMethod]
        public void Statement3CheckSetsSolutionHoldsToFalse()
        {
            var check = new StatementChecker();
            check.possibleSolution = new bool[] { true, false, false, false, true, true, true, true, true, false, false, false };
            check.statement3Check();

            var actual = false;

            Assert.AreEqual(check.solutionHolds, actual);
        }

        [TestMethod]
        public void Statement4CheckSetsSolutionHoldsToTrue()
        {
            var check = new StatementChecker();
            check.possibleSolution = new bool[] { true, false, false, true, false, true, true, true, true, false, false, false };
            check.statement4Check();

            var actual = true;

            Assert.AreEqual(check.solutionHolds, actual);
        }

        [TestMethod]
        public void Statement4CheckSetsSolutionHoldsToFalse()
        {
            var check = new StatementChecker();
            check.possibleSolution = new bool[] { true, false, false, true, true, true, true, true, true, false, false, false };
            check.statement4Check();

            var actual = false;

            Assert.AreEqual(check.solutionHolds, actual);
        }

        [TestMethod]
        public void Statement5CheckSetsSolutionHoldsTrue()
        {
            var check = new StatementChecker();
            check.possibleSolution = new bool[] { true, false, false, true, true, true, true, true, true, false, false, false };
            check.statement5Check();

            var actual = true;

            Assert.AreEqual(check.solutionHolds, actual);
        }

        [TestMethod]
        public void Statement5CheckSetsSolutionHoldsFalse()
        {
            var check = new StatementChecker();
            check.possibleSolution = new bool[] { true, false, false, true, true, false, true, true, true, false, false, false };
            check.statement5Check();

            var actual = false;

            Assert.AreEqual(check.solutionHolds, actual);
        }

        [TestMethod]
        public void Statement6CheckSetsSolutionHoldsTrue()
        {
            var check = new StatementChecker();
            check.possibleSolution = new bool[] { true, false, false, true, true, true, false, true, true, false, false, false };
            check.statement6Check();

            var actual = true;

            Assert.AreEqual(check.solutionHolds, actual);
        }

        [TestMethod]
        public void Statement6CheckSetsSolutionHoldsFalse()
        {
            var check = new StatementChecker();
            check.possibleSolution = new bool[] { true, false, false, true, true, false, true, true, true, false, false, false };
            check.statement6Check();

            var actual = false;

            Assert.AreEqual(check.solutionHolds, actual);
        }

        [TestMethod]
        public void Statement7CheckSetsSolutionHoldsTrue()
        {
            var check = new StatementChecker();
            check.possibleSolution = new bool[] { true, false, false, true, true, true, false, true, true, false, false, false };
            check.statement7Check();

            var actual = true;

            Assert.AreEqual(check.solutionHolds, actual);
        }

        [TestMethod]
        public void Statement7CheckSetsSolutionHoldsFalse()
        {
            var check = new StatementChecker();
            check.possibleSolution = new bool[] { true, false, false, true, true, false, true, true, true, false, false, false };
            check.statement7Check();

            var actual = false;

            Assert.AreEqual(check.solutionHolds, actual);
        }

        [TestMethod]
        public void Statement8CheckSetsSolutionHoldsTrue()
        {
            var check = new StatementChecker();
            check.possibleSolution = new bool[] { true, false, false, false, true, true, false, true, true, false, false, false };
            check.statement8Check();

            var actual = true;

            Assert.AreEqual(check.solutionHolds, actual);
        }

        [TestMethod]
        public void Statement8CheckSetsSolutionHoldsFalse()
        {
            var check = new StatementChecker();
            check.possibleSolution = new bool[] { true, true, false, true, true, false, true, true, true, false, false, false };
            check.statement8Check();

            var actual = false;

            Assert.AreEqual(check.solutionHolds, actual);
        }

        [TestMethod]
        public void Statement9CheckSetsSolutionHoldsTrue()
        {
            var check = new StatementChecker();
            check.possibleSolution = new bool[] { true, false, false, false, true, true, false, true, true, false, false, false };
            check.statement9Check();

            var actual = true;

            Assert.AreEqual(check.solutionHolds, actual);
        }

        [TestMethod]
        public void Statement9CheckSetsSolutionHoldsFalse()
        {
            var check = new StatementChecker();
            check.possibleSolution = new bool[] { true, true, false, true, true, false, true, true, true, true, false, false };
            check.statement9Check();

            var actual = false;

            Assert.AreEqual(check.solutionHolds, actual);
        }

        [TestMethod]
        public void Statement10CheckSetsSolutionHoldsTrue()
        {
            var check = new StatementChecker();
            check.possibleSolution = new bool[] { true, false, false, false, true, true, false, true, true, false, false, false };
            check.statement10Check();

            var actual = true;

            Assert.AreEqual(check.solutionHolds, actual);
        }

        [TestMethod]
        public void Statement10CheckSetsSolutionHoldsFalse()
        {
            var check = new StatementChecker();
            check.possibleSolution = new bool[] { true, true, false, true, true, false, true, true, true, true, true, false };
            check.statement10Check();

            var actual = false;

            Assert.AreEqual(check.solutionHolds, actual);
        }

        [TestMethod]
        public void Statement11CheckSetsSolutionHoldsTrue()
        {
            var check = new StatementChecker();
            check.possibleSolution = new bool[] { true, false, false, false, true, true, false, true, true, false, false, false };
            check.statement11Check();

            var actual = true;

            Assert.AreEqual(check.solutionHolds, actual);
        }

        [TestMethod]
        public void Statement11CheckSetsSolutionHoldsFalse()
        {
            var check = new StatementChecker();
            check.possibleSolution = new bool[] { true, true, false, true, true, false, true, true, true, true, true, true };
            check.statement11Check();

            var actual = false;

            Assert.AreEqual(check.solutionHolds, actual);
        }
    }
}
