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

            DateTime now = DateTime.Now; //Instance of object Datatime;

            OrderHeader one = new OrderHeader(77,123456,now); // Create a new istance of OrderHeader class

            one.CreateOrder(); //Call method

        //Create an Istance of class Article

        Article article1 = new Article(23,22.50,22);

        article1.Destroy();
        article1.Retrieve();

        Article articles = new Article(23,22.55,22); //New Istance of Articles and set the value
        
        articles.Price = 55.44; //Access to field and set a new value, this became a property

        Console.WriteLine("The new price is {0}",articles.Price);//Access to a new price
        Console.WriteLine("The invoice is {0}",article1.Invoice);//Get the value of invoice "0"

        Customer Antonio = new Customer ("Antoni","Rossi","@gmail.com");
        
        Antonio.Age =22;
        var age = Antonio.Age;
        Antonio.CheckAge();
        Article wine = new Article(23,23.44,age);
        wine.Create();
        
        }
    }
}


