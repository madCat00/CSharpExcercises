using System;
using System.Collections.Generic;
using ECommerce;
using ExLinq;


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
            
            /*    --------------------  Send  Args[] roa program ---------------------------
           
            if(args.Length > 0 ){  
                var name = args[0];
                var toUpper = name.ToUpper();
            Console.WriteLine($"{toUpper}");                                        //Second Excercise
            }else
            {

                Console.WriteLine("Please, insert a param after cmd dotnet run!!!");
            }
            */

            /*-----------------------------Create a HeadHorder Class -------------------------------------------- */

             var firstCustomer = new Customer("Francesco","Rossi","Hotmail.com");           //Third Excercise;

            //Another way to call class Customer, and initialize an istance.
            // Customer firstCustomer = new Customer("francesco","Rossi","Email : Hotmail.com");

            firstCustomer.Login();

            DateTime now = DateTime.Now; //Instance of object Datatime;

            OrderHeader one = new OrderHeader(77,123456,now); // Create a new istance of OrderHeader class

            one.CreateOrder(); //Call method

        /* ----------------------------Create an Istance of class Article ----------------------------------------*/

        Article article12 = new Article("t-shirt",23,22.50);

        article12.Destroy();
        article12.Retrieve();

        Article articles = new Article("Jeans",23,22.55); //New Istance of Articles and set the value
        
        articles.Price = 55.44; //Access to field and set a new value, this became a property

        Console.WriteLine("The new price is {0}",articles.Price);//Access to a new price
        Console.WriteLine("The invoice is {0}",article12.Invoice);//Get the value of invoice "0"

        /* ---------------------Comunication between class ---------------------------------------------*/

        Customer Antonio = new Customer ("Antonio","Rossi","@gmail.com");
        
        Antonio.Age = 10; //Get the age and checked...
        article12.Verify(Antonio.Age); //The class Article print a message 

        /* ----------------Create a list of users and extract them to Customers class-------------- */

            // Create a new users and pass it to list 

            Customer Rose = new Customer("Rose","hamilton","Roseham@gmail.com");
            
            Customers add = new Customers(); //Create istence for method add
            
            add.AddCustomer(Rose); //add users to list of Customer


        /* --------------Create new method to search and add articles to cart---------------------------- */

                // Create a new articles and customer

                Customer Mark = new Customer("Mark","Bay","yahoo.com"); //Create a new customer 

                Articles socks = new Articles("socks",22.30,30);

                // Add some articles to a list 
                
                Mark.AddArticles(socks);
              
        /*-----------------Create a list of city and serach it on a list of city --------------------------*/

                ListOfCity.Cities("Firenze");

                


                
        }
    }       
}


