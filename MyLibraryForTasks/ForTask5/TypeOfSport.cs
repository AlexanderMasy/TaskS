using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryForTasks.ForTask5
{
    public interface TypeOfSport
    {
        string SportName { get; set; }
        int DefinitionID(string name);
        bool DeterminingOlympicsSport(int idSport);
    }
}
