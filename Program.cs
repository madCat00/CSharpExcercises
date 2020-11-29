using System;
using ECommerce;


namespace CSharpExercises
{
    class Program
    {
        static void Main(string[] args)
        {   /*
            Console.WriteLine("Inserisci il tuo nome"); 
            string name = Console.ReadLine();
            string toUpper = name.ToUpper();                                                //First Excercise
            System.Console.WriteLine( "Il nome inserito in maiuscolo è" +" "+ toUpper);
            */

            /*
            if(args.Length > 0 ){  
                var name = args[0];
                var toUpper = name.ToUpper();
            Console.WriteLine($"{toUpper}");                                        //Second Excercise
            }   
            else{

                Console.WriteLine("Please, insert a param after cmd dotnet run!!!");
            }
            */

             var firstCustomer = new Customer("Francesco","Rossi","Hotmail.com");           //Third Excercise;

            //Another way to call class Customer, and initialize an istance.
            // Customer firstCustomer = new Customer("francesco","Rossi","Email : Hotmail.com");

            firstCustomer.Login();

            DateTime today = new DateTime(2020,11,29,10,30,50); 

            OrderHeader one = new OrderHeader(77,123456,today.ToString());

            one.CreateOrder();

        }
    }
}


