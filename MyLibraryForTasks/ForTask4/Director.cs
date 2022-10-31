using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryForTasks.ForTask4
{
    public class Director
    {
        private string surname;
        private int selfAssessment;
        private int evaluationOfPeople;
        public Director(string surname, int selfAssessment, int evaluationOfPeople)
        {
            this.Surname = surname;
            this.SelfAssessment = selfAssessment;
            this.EvaluationOfPeople = evaluationOfPeople;
        }
        public string Surname//Свойство: Фамилия
        {
            get
            {
                return surname;
            }
            private set
            {
                if (value is string)
                    surname = value;
            }
        }
        public int SelfAssessment//Свойство: самооценка
        {
            get
            {
                return selfAssessment;
            }
            private set
            {
                if (value is int && value >= 0 && value <= 10)
                    selfAssessment = value;
            }
        }
        public int EvaluationOfPeople//Свойство: Оценка длугих людей 
        {
            get
            {
                return evaluationOfPeople;
            }
            private set
            {
                if (value is int && value >= 0 && value <= 10)
                    evaluationOfPeople = value;
            }
        }

        public virtual double Calculator()
        {
            return Convert.ToDouble(evaluationOfPeople) / Convert.ToDouble(selfAssessment);
        }
    }
}
