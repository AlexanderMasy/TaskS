using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryForTasks.ForTask5
{
    public class Football : TeamTypeSport
    {
        public string NameTeam { get; private set; }
        public string InfoAboutTeam { get; private set; }
        public Football(string nameTeam, string infoAboutTeam) : base("Football")
        {
            this.NameTeam = nameTeam;
            this.InfoAboutTeam = infoAboutTeam;
        }
        public override string Сhant()
        {
            return "Ура! Ура Ура " + NameTeam + " чемпион!";
        }
    }
}
