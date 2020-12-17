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
            
            /*

             var firstCustomer = new Customer("Francesco","Rossi","Hotmail.com");           //Third Excercise;

            //Another way to call class Customer, and initialize an istance.
            // Customer firstCustomer = new Customer("francesco","Rossi","Email : Hotmail.com");

            firstCustomer.Login();

            DateTime now = DateTime.Now; //Instance of object Datatime;

            OrderHeader one = new OrderHeader(77,123456,now); // Create a new istance of OrderHeader class

            one.CreateOrder(); //Call method
            
            */

        /* ----------------------------Create an Istance of class Article ----------------------------------------*/

        /*
        Article article12 = new Article("t-shirt",23,22.50);

        article12.Destroy();
        article12.Retrieve();

        Article articles = new Article("Jeans",23,22.55); //New Istance of Articles and set the value
        
        articles.Price = 55.44; //Access to field and set a new value, this became a property

        Console.WriteLine("The new price is {0}",articles.Price);//Access to a new price
        Console.WriteLine("The invoice is {0}",article12.Invoice);//Get the value of invoice "0"

        */

        /* ---------------------Comunication between class ---------------------------------------------*/

        /*

        Customer Antonio = new Customer ("Antonio","Rossi","@gmail.com");
        
        Antonio.Age = 10; //Get the age and checked...
        article12.Verify(Antonio.Age); //The class Article print a message 

        */

        /* ----------------Create a list of users and extract them to Customers class-------------- */

            /*

            // Create a new users and pass it to list 

            Customer Rose = new Customer("Rose","hamilton","Roseham@gmail.com");
            
            Customers add = new Customers(); //Create istence for method add
            
            add.AddCustomer(Rose); //add users to list of Customer

            */


        /* --------------Create new method to search and add articles to cart---------------------------- */

                // Create a new articles and customer
            
            /*

                Customer Mark = new Customer("Mark","Bay","yahoo.com"); //Create a new customer 

                Articles socks = new Articles("socks",22.30,30);

                // Add some articles to a list 
                
                Mark.AddArticles(socks);
            */
              
        /*-----------------Create a list of city and serach it on a list of city --------------------------*/
           /*
            *Console.WriteLine("Please insert a name of a city");
            *var cities = Console.ReadLine();
            *ListOfCity.Cities(cities);
            */
        /* ----------------------- Create a list of peaks from a various string -------------------------*/

        /*
                
            string namesOfPeaks = " Monte Falco, 1658, Parco Foreste Casentinesi ; Monte Falterona, 1654, Parco Foreste Casentinesi; Monte Fumaiolo, 1407, Appennino Tosco Emiliano          ";
             
            var findValues = new string []{" Monte Falterona"}; //Please, respect the space from namesOfPeaks in the search value, or return nothing!!

            Peaks.SearchMountains(namesOfPeaks,findValues);
        */

        
         /*--------------------------------- Milestone 1 -----------------------------------------------------*/
         /*
            *we can create new customers
            *we can create new articles
            *we can add each article to Articles
            *we can list all the articles (printing to console is enough)
        */

        // Create a new users or a list of users.....

            Customer Mark = new Customer ("Mark","Rhod","MarkRhod@gmail.com"); // Create a new customers;
            Customer Lucy = new Customer ("Lucy","Wong","Lucy.Whong@yahoo.com");

           Customers insert  = new Customers(); // Create a new List of customers

           insert.AddCustomer(Mark);
           insert.AddCustomer(Lucy); //With this method we can add users in a list of users
           

           //Now we can create a new Article and add to a list of articles

           Article hat = new Article("white hat",44,66.8); // Article take description, stock and price as arguments
           Article gloves = new Article ("blue gloves",33,56.7);
           Article socks = new Article ("Green socks",43,44.76);

           Articles CreateList = new Articles(); //Set an istance to create a list of article

           CreateList.addToListOfArticles(hat);
           CreateList.addToListOfArticles(gloves);   //Add article to articles
           CreateList.addToListOfArticles(socks);
           
           

           CreateList.List();  //Add a method to diplay all articles add
           
            /*--------------------- Milestone 2 -----------------------------*/

            /*we can search for an article by its description, and we can print its price
             *we can add the searched article to the Cart
            */
           

           
             
        }
    }       
}


