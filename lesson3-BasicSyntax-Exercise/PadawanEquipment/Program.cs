using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double allMoney = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double lightsabersPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());

            //totalprice = studentsCount * (light + robe + belt)

            double lightsabersTotal = (studentsCount + Math.Ceiling(studentsCount * 0.1)) * lightsabersPrice;
            double robesTotal = studentsCount * robesPrice;
            double beltsTotal = 0;
            if (studentsCount >= 10)
            {
                beltsTotal = (studentsCount - studentsCount / 6) * beltsPrice;
            }
            else
            {
                beltsTotal = studentsCount * beltsPrice;
            }

            double totalPrice = beltsTotal + robesTotal + lightsabersTotal;

            if (allMoney - totalPrice >= 0)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {(totalPrice - allMoney):f2}lv more.");
            }
        }
    }
}
