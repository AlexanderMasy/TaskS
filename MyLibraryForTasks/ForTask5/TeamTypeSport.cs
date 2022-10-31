using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyLibraryForTasks.ForTask5
{
    abstract public class TeamTypeSport : TypeOfSport
    {
        private int idSport;
        private bool olympicsSport;
        public string SportName { get; set; }
        public int IdSport
        {
            get
            {
                return idSport;
            }
            private set
            {
                idSport = value;
            }
        }
        public bool OlympicsSport
        {
            get
            {
                return olympicsSport;
            }
            set
            {
                olympicsSport = value;
            }
        }
        public TeamTypeSport(string name)
        {
            SportName = name;
            idSport = DefinitionID(SportName);
            OlympicsSport = DeterminingOlympicsSport(idSport);
        }
        public int DefinitionID(string name)
        {
            try
            {
                string path = "NameSportAndID.txt";
                Utils ObjectOpen = new Utils(path);
                return UtilsForTask5.SearchForIntInListFromArrayOfStringType(ObjectOpen.SplitParagraphsByTAB(ObjectOpen.SplitByParagraphs(ObjectOpen.Open)), name);
            }
            catch (IOException ex)
            {
                return -1;
            }
        }
        public bool DeterminingOlympicsSport(int idSport)
        {
            string path = "idOlympicSport.txt";
            Utils ObjectOpen = new Utils(path);
            return UtilsForTask5.SearchInArrTypeIntUnknown(ObjectOpen.SplitLineStrByWhiteSpace(ObjectOpen.Open), idSport);
        }
        public abstract string Сhant();
    }
}
