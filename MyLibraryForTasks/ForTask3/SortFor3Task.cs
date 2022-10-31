using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibraryForTasks.ForTask3.Planes;

namespace MyLibraryForTasks.ForTask3
{
    public class SortFor3Task
    {
        public static string ConvertTwoArrToLineStr(List<PassengerPlane> arrPassengerPlane, List<CargoPlane> cargoPlanes)//обьединяет листы для вывода в string
        {
            string resultStr = "Пассажирские самолёты:\n";
            foreach(Plane itemPlane in arrPassengerPlane)
            {
                PassengerPlane passengerPlane = itemPlane as PassengerPlane;
                if (passengerPlane != null)
                {
                    resultStr += passengerPlane.Model + " " + passengerPlane.CruisingSpeed + " " + passengerPlane.Price + " " + passengerPlane.MaximumRange + " " +
                        passengerPlane.NumberOfPassengerSeats + " " + passengerPlane.LuggageWeight + "\n";
                }
            }
            resultStr += "Грузовые самолёты:\n";
            foreach (Plane itemPlane in cargoPlanes)
            {
                CargoPlane cargoPlane = itemPlane as CargoPlane;
                if (cargoPlane != null)
                {
                    resultStr += cargoPlane.Model + " " + cargoPlane.CruisingSpeed + " " + cargoPlane.Price + " " + cargoPlane.MaximumRange 
                        + " " + cargoPlane.CargoWeight + "\n";
                }
            }
            return resultStr;
        }
       public static string ConvertArrPlanesToLineStr(List<Plane> listPlanes)//Переводит массив самолётов в String
        {
            string result = "";
            foreach(Plane plane in listPlanes)
            {
                if (plane is PassengerPlane)
                {
                    PassengerPlane isPassengerPlane = plane as PassengerPlane;
                    result += isPassengerPlane.Model + " " + isPassengerPlane.CruisingSpeed + " " + isPassengerPlane.Price + " " + isPassengerPlane.MaximumRange + " " +
                        isPassengerPlane.NumberOfPassengerSeats + " " + isPassengerPlane.LuggageWeight + " -Пассажирский\n";
                }
                else
                {
                    CargoPlane isCargoPlane = plane as CargoPlane;
                    result += isCargoPlane.Model + " " + isCargoPlane.CruisingSpeed + " " + isCargoPlane.Price + " " + isCargoPlane.MaximumRange
                        + " " + isCargoPlane.CargoWeight + " -Грузовой\n";
                }
            }
            return result;
        }
        public static int CarryingOfAllPlane(List<CargoPlane> cargoPlanes)//LOGIC считает общую грузоподьемность
        {
            int result = 0;
            foreach(CargoPlane plane in cargoPlanes)
            {
                result += plane.CargoWeight;
            }
            return result;
        }
        public static int CapacityOfAllPlane(List<PassengerPlane> passengerPlane)//LOGIC считает общее число пассажиров
        {
            int result = 0;
            foreach (PassengerPlane plane in passengerPlane)
            {
                result += plane.NumberOfPassengerSeats;
            }
            return result;
        }
        public static List<Plane> SortPlanes(List<Plane> listPlanes)//LOGIC сортирует по возрастанию список по дальности полёта
        {
            int n = listPlanes.Count;
            for(int i = 0; i < listPlanes.Count; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if(j+1 != n && listPlanes[j].MaximumRange > listPlanes[j + 1].MaximumRange)
                    {
                        Plane nextPlane = listPlanes[j + 1];
                        listPlanes[j + 1] = listPlanes[j];
                        listPlanes[j] = nextPlane;
                    }
                }
                n--;
            }
            return listPlanes;
        }
        public static List<Plane> ConnectionOfArrays(List<CargoPlane> cargoPlanes, List<PassengerPlane> passengerPlanes)//обьединяет листы совершая UPCAST
        {
            List<Plane> planes = new List<Plane> { };
            foreach (CargoPlane cargoPlane in cargoPlanes)
            {
                planes.Add((Plane)cargoPlane);
            }
            foreach(PassengerPlane passengerPlane in passengerPlanes)
            {
                planes.Add((Plane)passengerPlane);
            }
            return planes;
        }
    }
}
