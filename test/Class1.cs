using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Bil
    {
        public void MortorStart() { Console.WriteLine("Motoren er startet"); }
        public void MortorStop() { Console.WriteLine("Motoren er slukket"); }

        public double FillGas(double add, double InTank)
        {
            Console.WriteLine("You added "+add+" to the gastank you have "+(add+InTank)+" in the tank now");
            double x=add+InTank;
            return x;

        }

        public double Drive(double disten,double InTank)
        {
            double GasLeft= InTank-(disten / 14);
            GasLeft=Math.Round(GasLeft, 2);
            ///(L / 100 km) = (Litres Used X 100) ÷ Kilometers Traveled
            ///KPL = D/F
            ///KPL is the kilometers per liter
            ///D is the distance traveled(kilometers)
            ///F is the fuel used(liters)

            ///disten * fuel pr km - intank to get remaining
            ///disten is 100km you used 1l per 20km you start with 20l
            ///Gas Used = Fuel Efficiency / Distance
            return GasLeft;            

        }
        public void FuleATM(double intank)
        {
            Console.WriteLine("You have " + intank + " liters of gas left");
        }
        public int PlayerLootNumber(int numofloot)
        {
            int x;
            Random random = new Random();
            x = random.Next(1, numofloot+1);
            return x;
            
        }
    }
}

     
