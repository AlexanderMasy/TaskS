using System;
using MyLibraryForTasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string choosingCyclicRepetition;
            do
            {
                int[,] arr = { { 1, 2, 3, 4}, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };
                try
                {
                    Console.WriteLine("Заполнить массив рандомными значениями или значениями которые предусмотрены программой? В любом случае массив будет 4х4" +
                        "\nВыбирите 1 или любую другую. (Соответственно) изменение Для теста");
                    string choiceOfFillingTheArray = Console.ReadLine();
                    if (choiceOfFillingTheArray == "1")
                    {
                        arr = ClassForTask1.FillingRandomValuesArray(4, 4);
                        ClassForTask1.OutputValuesArray(arr);
                        Console.WriteLine(ClassForTask1.Logic(arr));
                    }
                    else
                    {
                        ClassForTask1.OutputValuesArray(arr);
                        Console.WriteLine(ClassForTask1.Logic(arr));
                    }
                }
                catch
                {
                    Console.WriteLine("Ошибка!!!");
                }
                Console.WriteLine("Если хотете закончить работу с программой нажмите 1");
                choosingCyclicRepetition = Console.ReadLine();
            } while (choosingCyclicRepetition != "1");
        }
    }
}
