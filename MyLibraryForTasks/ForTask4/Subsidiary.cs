using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryForTasks.ForTask4
{
    public class Subsidiary : Director
    {
        private int evaluationByDescendants;
        public Subsidiary(string surname, int selfAssessment, int evaluationOfPeople, int evaluationByDescendants) : 
            base(surname,selfAssessment, evaluationOfPeople)
        {
            this.EvaluationByDescendants = evaluationByDescendants;
        }
        public int EvaluationByDescendants//Свойство: Оценка потомками
        {
            get
            {
                return evaluationByDescendants;
            }
            private set
            {
                if (value >= 0 && value <= 10)
                    evaluationByDescendants = value;
            }
        }

        public override double Calculator()
        {
            return base.Calculator()*0.3 + 0.7* Convert.ToDouble(evaluationByDescendants);
        }
    }
}
