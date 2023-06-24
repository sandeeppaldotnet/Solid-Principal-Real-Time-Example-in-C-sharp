using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principal_Real_Time_Example_in_C_sharp
{
    internal class Liskov_Substitution_Principle_in_C_sharp
    {
       
        public class Program
        {
            public void TestProgram()
            {
                IDisountAmount dis = new WeeklyDiscount();
                
                Console.WriteLine($"WeeklyDiscount Amount: {dis.GetDiscount()}");
                 dis = new MonthlyDiscount();

                Console.WriteLine($"WeeklyDiscount Amount: {dis.GetDiscount()}");
            }
            

           
            
        }
        public interface IDisountAmount
        {
            int GetDiscount();
        }
        public class WeeklyDiscount: IDisountAmount
        {
            public int GetDiscount()
            {
                return 20;
            }
        }
        public class MonthlyDiscount : IDisountAmount
        {
            public int GetDiscount()
            {
                return 100;
            }
        }
    }
}
