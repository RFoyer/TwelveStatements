using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwelveStatementsLogic
{
    public class SolutionFinder : StatementChecker
    {
        public List<bool[]> solutions { get; set; }


        public SolutionFinder()
        {
            solutions = new List<bool[]>();
        }

        private void checkIfSolution()
        {
            runAllChecks();
            if (solutionHolds)
            {
                solutions.Add(possibleSolution);
            }
        }

        public void findSolutions()
        {
            foreach (var c in combinations)
            {
                foreach (var b in c)
                {
                    possibleSolution[b + 1] = !possibleSolution[b + 1];
                    checkIfSolution();
                }
            }
        }
    }
}
