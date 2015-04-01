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

        public void findSolutions()
        {
            foreach (var n in allCombinations)
            {
                possibleSolution[n + 1] = !possibleSolution[n + 1];
                checkIfSolution();
            }
        }

        private void checkIfSolution()
        {
            runAllChecks();
            if (solutionHolds)
            {
                solutions.Add(possibleSolution);
            }
        }

    }
}
