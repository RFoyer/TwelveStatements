using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwelveStatementsLogic
{
    public class StatementChecker
    {
        private List<Action> statementChecks = new List<Action>();
        private bool[] _possibleSolution = new bool[12];
        private List<List<int>> _combinations = new List<List<int>>();
        public List<List<int>> combinations
        {
            get { return _combinations; }
            set { _combinations = value; }
        }
        public bool[] possibleSolution
        {
            get { return _possibleSolution; }
            set { _possibleSolution = value; }
        }
        public bool solutionHolds { get; set; }

        public StatementChecker()
        {
            possibleSolution[0] = true;
            generateAllCombinations();
            statementChecks.Add(statement1Check);
            statementChecks.Add(statement2Check);
            statementChecks.Add(statement3Check);
            statementChecks.Add(statement4Check);
            statementChecks.Add(statement5Check);
            statementChecks.Add(statement6Check);
            statementChecks.Add(statement7Check);
            statementChecks.Add(statement8Check);
            statementChecks.Add(statement9Check);
            statementChecks.Add(statement10Check);
            statementChecks.Add(statement11Check);
        }

        // The 12 statements are made zero-based in the following checks.
        // Statement 0 is assumed to be true.

        public void statement1Check()
        {
            var totalTrue = 0;
            for (int i = 0; i < 6; i++)
            {
                if (possibleSolution[i + 6] == true)
                {
                    totalTrue++;
                }
            }
            if (totalTrue == 3)
            {
                solutionHolds = possibleSolution[1] == true;
                return;
            }
            solutionHolds = possibleSolution[1] == false;
        }

        public void statement2Check()
        {
            var amountTrue = 0;
            for (int i = 1; i < 12; i++, i++)
            {
                if (possibleSolution[i] == true)
                {
                    amountTrue++;
                }
            }
            if (amountTrue == 2)
            {
                solutionHolds = possibleSolution[2] == true;
                return;
            }
            solutionHolds = possibleSolution[2] == false;
        }

        public void statement3Check()
        {
            if (possibleSolution[4] == true)
            {
                if (possibleSolution[5] == false || possibleSolution[6] == false)
                {
                    solutionHolds = possibleSolution[3] == false;
                    return;
                }
            }
            solutionHolds = possibleSolution[3] == true;
        }

        public void statement4Check()
        {
            if (!possibleSolution[1] && !possibleSolution[2] && !possibleSolution[3])
            {
                solutionHolds = possibleSolution[4] == true;
                return;
            }
            solutionHolds = possibleSolution[4] == false;
        }

        public void statement5Check()
        {
            var amountTrue = 0;
            for (int i = 0; i < 11; i++, i++)
            {
                if (possibleSolution[i] == true)
                {
                    amountTrue++;
                }
            }
            if (amountTrue == 4)
            {
                solutionHolds = possibleSolution[5] == true;
                return;
            }
            solutionHolds = possibleSolution[5] == false;
        }

        public void statement6Check()
        {
            if ((possibleSolution[1] && !possibleSolution[2])
                || !possibleSolution[1] && possibleSolution[2])
            {
                solutionHolds = possibleSolution[6] == true;
                return;
            }
            solutionHolds = possibleSolution[6] == false;
        }

        public void statement7Check()
        {
            if (possibleSolution[6] == true)
            {
                if (possibleSolution[4] == false || possibleSolution[5] == false)
                {
                    solutionHolds = possibleSolution[7] == false;
                    return;
                }
            }
            solutionHolds = possibleSolution[7] == true;
        }

        public void statement8Check()
        {
            var amountTrue = 0;
            for (int i = 0; i < 6; i++)
            {
                if (possibleSolution[i] == true)
                {
                    amountTrue++;
                }
            }
            if (amountTrue == 3)
            {
                solutionHolds = possibleSolution[8] == true;
                return;
            }
            solutionHolds = possibleSolution[8] == false;
        }

        public void statement9Check()
        {
            if (possibleSolution[10] && possibleSolution[11])
            {
                solutionHolds = possibleSolution[9] == true;
                return;
            }
            solutionHolds = possibleSolution[9] == false;
        }

        public void statement10Check()
        {
            var amountTrue = 0;
            for (int i = 6; i < 9; i++)
            {
                if (possibleSolution[i] == true)
                {
                    amountTrue++;
                }
            }
            if (amountTrue == 1)
            {
                solutionHolds = possibleSolution[10] == true;
                return;
            }
            solutionHolds = possibleSolution[10] == false;
        }

        public void statement11Check()
        {
            var amountTrue = 0;
            for (int i = 0; i < 11; i++)
            {
                if (possibleSolution[i] == true)
                {
                    amountTrue++;
                }
            }
            if (amountTrue == 4)
            {
                solutionHolds = possibleSolution[11] == true;
                return;
            }
            solutionHolds = possibleSolution[11] == false;
        }

        private void generateAllCombinations()
        {
            for (int i = 0; i < 11; i++)
            {
                List<int> comboList = new List<int>(getListOfCombos(i));
                combinations.Add(comboList);
            }
        }

        private List<int> getListOfCombos(int i)
        {
            List<int> list = new List<int>();
            list.Add(i);
            for (int k = 0; k < combinations.Count; k++)
            {
                foreach (var l in combinations[k])
                {
                    list.Add(l);
                }
            }
            return list;
        }

        public void runAllChecks()
        {
            foreach (var check in statementChecks)
            {
                check();
                if (!solutionHolds)
                {
                    return;
                }
            }
        }
    }
}