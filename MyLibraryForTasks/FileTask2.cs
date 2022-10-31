using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;

namespace MyLibraryForTasks
{
    public class FileTask2
    {
        private string Path;

        public FileTask2(string path = null)
        {
            this.Path = path;
        }

        public string Open
        {
            get
            {
                return File.ReadAllText(Path);
            }
            set
            {

            }
        }
        public void Save(string saveText)
        {
            File.WriteAllText(Path, saveText);
        }

        public static List<string[]> CreateDictionary(string text)
        {
            List<string[]> dictionary = new List<string[]> { };
            List<string> arrayWord = null;
            List<string> arrayParagraphs = text.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
            foreach(string itemLine in arrayParagraphs)
            {
                arrayWord = itemLine.Split(new string[] { " ", ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();
                foreach(string itemWord in arrayWord)
                {
                    bool check = true;

                    foreach (string[] dictionaryWord in dictionary)
                    {
                        if (itemWord == dictionaryWord[0])
                        {
                            dictionaryWord[1] = Convert.ToString(Convert.ToInt32(dictionaryWord[1]) + 1);
                            check &= false;
                            break;
                        }
                    }

                    if (check == true)
                    {
                        string[] arrStr = { itemWord, "1"};
                        dictionary.Add(arrStr);
                    }
                }
            }
            
            return dictionary;
        } //Создание словаря

        public static string Convert_ListArrStr_To_StrLine(List<string[]> listArrStr)
        {
            string OutStr = "";
            try
            {
                foreach(string[] itemList in listArrStr)
                {
                    OutStr += itemList[0] + " " + itemList[1] + "    ";
                }
            }
            catch (IOException ex)
            {
                OutStr = "Ошибка в MyLibraryForTasks.FileTask2.Convert_ListArrStr_To_StrLine\n" + ex.Message;
            }
            return OutStr;
        } //Конвертация листа массивов в строку
    }
}
