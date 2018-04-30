using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tristan_Yurgionas_projecty_4
{
    class Program
    {
        static void Main(string[] args)

        { 
            
            
            System.Console.WriteLine("  ");
            System.Console.WriteLine("---------------------");
            System.Console.WriteLine("A Night At The Movies");
            System.Console.WriteLine("---------------------");


            System.Console.WriteLine("Are you seeing a Matinee show?");
            System.Console.WriteLine(" Y / N  ?");
           

                String Showings = Console.ReadLine();


            if (Showings.ToUpper()  == "Y")
            {
                System.Console.WriteLine(" You are seeing the Matinee showing.");
                System.Console.WriteLine("Matinee Prices");
                System.Console.WriteLine("-      Child: $3.99");
                System.Console.WriteLine("-      Adult: $5.99");
                System.Console.WriteLine("      Senior: $4.50");

                System.Console.Write(" how Many Children tickets? ");
                int Childtotal;
                Childtotal = int.Parse(System.Console.ReadLine());
                System.Console.Write(" how Many Adult tickets? ");
                int Adulttotal;
                Adulttotal = int.Parse(System.Console.ReadLine());
                System.Console.Write(" how Many Senior tickets? ");
                int Seniortotal;
                Seniortotal = int.Parse(System.Console.ReadLine());

                double totalCostinTickets = 0;
                

                totalCostinTickets += (Childtotal * 3.99);
                totalCostinTickets += (Adulttotal * 5.99);
                totalCostinTickets += (Seniortotal * 4.50);
                int totalTicketNum = 0;
                totalTicketNum += (Childtotal + Adulttotal + Seniortotal);
                
                System.Console.WriteLine("Would you like some snacks from the Concession stand?");
               



                System.Console.WriteLine(" Y / N  ?");
                String Concessions = Console.ReadLine();
                if (Concessions.ToUpper() == "Y") 
                {
                    System.Console.WriteLine("- Small Soda: $3.50");
                    System.Console.WriteLine("- Large Soda: $5.99");
                    System.Console.WriteLine("-    Hot Dog: $3.99");
                    System.Console.WriteLine("-    Popcorn: $4.50");
                    System.Console.WriteLine("-      Candy: $1.99");

                    System.Console.WriteLine("Discounts & Promotions");
                    System.Console.WriteLine("Each Purchase of a popcorn and a large soda grants a $2 discount on one movie ticket.");
                    System.Console.WriteLine("If 3 or more people purchase tickets to an evening show, they get 1 free bag of popcorn.");
                    System.Console.WriteLine("For each 3 candies you buy, you can get a 4th candy for free");

                    System.Console.Write(" how Many small sodas? ");
                    int SmallSodatotal;
                    SmallSodatotal = int.Parse(System.Console.ReadLine());
                    System.Console.Write(" how Many large sodas? ");
                    int LargeSodatotal;
                    LargeSodatotal = int.Parse(System.Console.ReadLine());
                    System.Console.Write(" how Many Hot Dogs? ");
                    int HotDogtotal;
                    HotDogtotal = int.Parse(System.Console.ReadLine());
                    System.Console.Write(" how much Popcorn? ");
                    int Popcorntotal;
                    Popcorntotal = int.Parse(System.Console.ReadLine());
                    System.Console.Write(" how much candy? ");
                    int Candytotal;
                    Candytotal = int.Parse(System.Console.ReadLine());

                    double totalCostinSnacks = 0;

                    totalCostinSnacks += (SmallSodatotal * 3.99);
                    totalCostinSnacks += (LargeSodatotal * 5.99);
                    totalCostinSnacks += (HotDogtotal * 4.50);
                    totalCostinSnacks += (Popcorntotal * 4.50);
                    totalCostinSnacks += (Candytotal * 1.99);

                    double totalDiscountsapplied = 0;
                    double candyDiscount = 0;
                    
                    if (Candytotal % 3 == 1)
                    {
                        int candydiscnum = 0;
                        candydiscnum += 1;
                        Candytotal += (candydiscnum * 1);
                        totalCostinSnacks -= (candydiscnum * 1.99);
                        candyDiscount += (candydiscnum * 1.99);
                        
                        
                    }
                    
                    double ticketDiscountPop = 0;
                    if (totalTicketNum >= 3)
                    {
                        Popcorntotal += 1;
                        totalCostinSnacks -= 4.50;
                        ticketDiscountPop+= 4.50;

                    }
                    double lrgSodaPopcorndisc = 0;
                    if (LargeSodatotal >= 1)
                    {
                        if ( Popcorntotal >= 1)
                        {
                            totalCostinTickets -= 2;
                            lrgSodaPopcorndisc += 2;
                        }
                    }

                    

                    totalDiscountsapplied += (candyDiscount + ticketDiscountPop + lrgSodaPopcorndisc);



                    System.Console.WriteLine("     Your " + totalTicketNum +" tickets cost : $" + totalCostinTickets);
                    System.Console.WriteLine(" Your total concession cost is: $" + totalCostinSnacks);
                    System.Console.WriteLine("       Total discounts applied: $" + totalDiscountsapplied);
                    System.Console.WriteLine(" Concession stand treats:");
                    System.Console.WriteLine(" small soda:" + SmallSodatotal);
                    System.Console.WriteLine(" large soda:" + LargeSodatotal);
                    System.Console.WriteLine(" Hot dogs:" + HotDogtotal);
                    System.Console.WriteLine(" popcorn:" + Popcorntotal);
                    System.Console.WriteLine(" candies:" + Candytotal);


                }
                else
                {
                    double totalDiscountsapplied = 0;
                    System.Console.WriteLine("     Your total ticket cost is: $" + totalCostinTickets);
                    System.Console.WriteLine("       Total discounts applied: $" + totalDiscountsapplied);
                    

                }




            }
            else 
            {
                System.Console.WriteLine(" You are seeing the Evening showing.");
                System.Console.WriteLine("Evening Prices");
                System.Console.WriteLine("-      Child: $6.99");
                System.Console.WriteLine("-      Adult: $10.99");
                System.Console.WriteLine("-     Senior: $8.50");

                System.Console.Write(" how Many Children tickets? ");
                int Childtotal;
                Childtotal = int.Parse(System.Console.ReadLine());
                System.Console.Write(" how Many Adult tickets? ");
                int Adulttotal;
                Adulttotal = int.Parse(System.Console.ReadLine());
                System.Console.Write(" how Many Senior tickets? ");
                int Seniortotal;
                Seniortotal = int.Parse(System.Console.ReadLine());

                double totalCostinTickets = 0;

                totalCostinTickets += (Childtotal * 6.99);
                totalCostinTickets += (Adulttotal * 10.99);
                totalCostinTickets += (Seniortotal * 8.50);
                int totalTicketNum = 0;
                totalTicketNum += (Childtotal + Adulttotal + Seniortotal);


                System.Console.WriteLine("Would you like some snacks from the Concession stand?");

                System.Console.WriteLine(" Y / N  ?");
                 String Concessions = Console.ReadLine();
                if (Concessions.ToUpper() == "Y")
                {
                    System.Console.WriteLine("- Small Soda: $3.50");
                    System.Console.WriteLine("- Large Soda: $5.99");
                    System.Console.WriteLine("-    Hot Dog: $3.99");
                    System.Console.WriteLine("-    Popcorn: $4.50");
                    System.Console.WriteLine("-      Candy: $1.99");

                    System.Console.WriteLine("Discounts & Promotions");
                    System.Console.WriteLine("Each Purchase of a popcorn and a large soda grants a $2 discount on one movie ticket.");
                    System.Console.WriteLine("If 3 or more people purchase tickets to an evening show, they get 1 free bag of popcorn.");
                    System.Console.WriteLine("For each 3 candies you buy, you can get a 4th candy for free");

                    System.Console.Write(" how Many small sodas? ");
                    int SmallSodatotal;
                    SmallSodatotal = int.Parse(System.Console.ReadLine());
                    System.Console.Write(" how Many large sodas? ");
                    int LargeSodatotal;
                    LargeSodatotal = int.Parse(System.Console.ReadLine());
                    System.Console.Write(" how Many Hot Dogs? ");
                    int HotDogtotal;
                    HotDogtotal = int.Parse(System.Console.ReadLine());
                    System.Console.Write(" how much Popcorn? ");
                    int Popcorntotal;
                    Popcorntotal = int.Parse(System.Console.ReadLine());
                    System.Console.Write(" how much candy? ");
                    int Candytotal;
                    Candytotal = int.Parse(System.Console.ReadLine());

                    double totalCostinSnacks = 0;

                    totalCostinSnacks += (SmallSodatotal * 3.99);
                    totalCostinSnacks += (LargeSodatotal * 5.99);
                    totalCostinSnacks += (HotDogtotal * 4.50);
                    totalCostinSnacks += (Popcorntotal * 4.50);
                    totalCostinSnacks += (Candytotal * 1.99);

                    double totalDiscountsapplied = 0;
                    double candyDiscount = 0;

                    if (Candytotal % 3 == 0)
                    {
                        int candydiscnum = 0;
                        candydiscnum += 1;
                        Candytotal += (candydiscnum * 1);
                        totalCostinSnacks -= (candydiscnum * 1.99);
                        candyDiscount += (candydiscnum * 1.99);
                    }

                    double ticketDiscountPop = 0;
                    if (totalTicketNum >= 3)
                    {
                        Popcorntotal += 1;
                        totalCostinSnacks -= 4.50;
                        ticketDiscountPop += 4.50;
                    }
                    double lrgSodaPopcorndisc = 0;
                    if (LargeSodatotal >= 1)
                    {
                        if (Popcorntotal >= 1)
                        {
                            totalCostinTickets -= 2;
                            lrgSodaPopcorndisc += 2;
                        }
                    }



                    totalDiscountsapplied += (candyDiscount + ticketDiscountPop + lrgSodaPopcorndisc);



                    System.Console.WriteLine("     Your " + totalTicketNum + " tickets cost : $" + totalCostinTickets);
                    System.Console.WriteLine(" Your total concession cost is: $" + totalCostinSnacks);
                    System.Console.WriteLine("       Total discounts applied: $" + totalDiscountsapplied);
                    System.Console.WriteLine(" Concession stand treats:");
                    System.Console.WriteLine(" small soda:" + SmallSodatotal);
                    System.Console.WriteLine(" large soda:" + LargeSodatotal);
                    System.Console.WriteLine(" Hot dogs:" + HotDogtotal);
                    System.Console.WriteLine(" popcorn:" + Popcorntotal);
                    System.Console.WriteLine(" candies:" + Candytotal);
                }
                else
                {
                    double totalDiscountsapplied = 0;
                    System.Console.WriteLine("     Your total ticket cost is: $" + totalCostinTickets);
                    System.Console.WriteLine("       Total discounts applied: $" + totalDiscountsapplied);
                    

                }




            }












            System.Console.WriteLine("Press any key to continue...");
            System.Console.ReadKey();
        }
    }
}
