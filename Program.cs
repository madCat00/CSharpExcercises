using System;
using System.Collections.Generic;
using ECommerce;
using ExLinq;
using System.IO;
using Users;


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

           //Create a logic to write each article in a file on the filesystem
            
            SaveFile way = new SaveFile();

             /* Set the location on harddrive, where do you want create your file.
              * If the file exixt, the progam report the hour and date of creation.
              * N.B: The path can be an absolute or relative address.
              */

           way.Path = @"C:\Users\franc\Desktop\CSharpExcercises\ListofArticle.csv"; //Set the path 

           var pathway = way.Path;

          SaveFile.CreateNewFile(pathway); //Create method, for create a csv file, container of my article
        
          //way.WriteToFile(pathway,socks); //Write an article to a csv file
          //way.WriteToFile(pathway,gloves);
           

            /*--------------------- Milestone 2 -----------------------------*/

            /*we can search for an article by its description, and we can print its price
             *we can add the searched article to the Cart
             */
           
            Console.WriteLine(CreateList.search("Green socks").Price);  //search an article and print his price 

            //Add article

            var myarticle = CreateList.search("green socks");

            Cart addtoCart = new Cart(myarticle,Mark,78); //Add search article to cart

            //Write a logic to search an article from a file

            SaveFile search = new SaveFile();

            search.searchOnFiles(pathway,"gloves"); //Print the entire line of description article
           
           /*--------------------- Milestone 3 -----------------------------*/

           //We can add multiple article to the cart

            //Cart newCart1 = new Cart(hat,Mark,10);
            //Cart newCart2 = new Cart(gloves,Lucy,20); //Create a new istance of a cart

           // newCart1.addMultiplyArticle(gloves);  //Add multiply article to cart
            //newCart1.addMultiplyArticle(hat);

            //newCart1.Total();  //Calculate the total from the cart1
            //newCart1.printToFile(pathway);  //Print in a file all article pre
            search.fileSum(pathway); //Print all prices in ListOfArticle.csv
            
            User Giovanni = new User("Giovanni");
            
            Giovanni.Age = 22; //Giovanni can insert his age

            User Lucia = new User("Lucia"); //Lucia can't insert his age

            Lucia.Age = 15;
            Console.WriteLine(Lucia.Age);

            User Caterina = new User("Caterina");
            User Cristiano = new User("Cristiano"); // Extrapolate name in a list of name

            User addcustomer = new User(); //Create method to add user in a list
            
            addcustomer.addUser(Giovanni);  // Add customer to a list
            addcustomer.addUser(Lucia);
            addcustomer.addUser(Caterina);
            addcustomer.addUser(Cristiano);
            
            addcustomer.checkName();
          

          var speed = new ItalianMeter(100,30);
          var speed2 = new englishMeter(200,30);

          Console.WriteLine($"The speed in km/h is {speed.speed()}");
          Console.WriteLine($"The speed in mph is {speed2.speed()}");

          
        }
    }       
}


