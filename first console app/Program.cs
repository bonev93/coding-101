using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_console_app
{
    class Program
    {
        static void Main(string[] args)
        {

            int LilyAge = int.Parse(Console.ReadLine());
            decimal PriceWashmashine = decimal.Parse(Console.ReadLine());
            int PriceToy = int.Parse(Console.ReadLine());
            int ToysReceived = 0;
            int MoneyReceived = 0;
            for (int i = 1; i <= LilyAge; i++)
            {
                

                if (i % 2 == 0)
                {
                    MoneyReceived += 10*(i / 2)-1;
                    Console.WriteLine("Current money {0}", MoneyReceived);
                }
                else
                    ToysReceived += 1;
            }

            int TotalMoneyFromToys = PriceToy * ToysReceived;

            if (PriceWashmashine > (MoneyReceived + TotalMoneyFromToys))
            {
                Console.WriteLine("No! {0}",PriceWashmashine-(MoneyReceived+TotalMoneyFromToys));

            }

            else
                Console.WriteLine("Yes! {0}",MoneyReceived+TotalMoneyFromToys-PriceWashmashine);


        }


    }
}
