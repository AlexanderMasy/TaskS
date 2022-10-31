using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyLibraryForTasks
{
    public class Utils
    {
        private string Path;

        public Utils(string path = null)
        {
            this.Path = path;
        }

        public string Open
        {
            get
            {
                return File.ReadAllText(Path);
            }
            private set
            {

            }
        }
        public void Save(string saveText)
        {
            File.WriteAllText(Path, saveText);
        }
        public List<string> SplitByParagraphs(string line)//Сплит на параграфы
        {
            return line.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
        }
        public int[] SplitLineStrByWhiteSpace(string line)//сплит на пробелы
        {
            return line.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(i => int.Parse(i)).ToArray();
        }
        public List<string[]> SplitParagraphsByTAB(List<string> arrParagraphs)//сплит на TAB
        {
            List<string[]> result = new List<string[]> { };
            foreach(string line in arrParagraphs)
            {
                result.Add(line.Split(new string[] { "\t" }, StringSplitOptions.RemoveEmptyEntries).ToArray());
            }
            return result;
        }
    }
    public class UtilsForTask5//Частично реализовани логика 5-го Task
    {
        public static int SearchForIntInListFromArrayOfStringType(List<string[]> listArrStr, string unknown)
        {
            foreach(string[] arrStr in listArrStr)
            {
                try
                {
                    if (arrStr[0] == unknown)
                    {
                        return Convert.ToInt32(arrStr[1]);
                    }
                }
                catch
                {
                    return -1;
                }
            }
            return 0;
        }
        public static bool SearchInArrTypeIntUnknown(int[] arrInt, int unknown)
        {
            foreach(int item in arrInt)
            {
                if (item == unknown)
                    return true;
            }
            return false;
        }
    }
}
