using System;

namespace ECommerce{
    class Customer{
        protected int Id;
        protected string Name;
        protected string Surname;
        protected string Address;
        protected string City;
        protected string Email;
        protected string Password;


        public void Login(){
            Console.WriteLine( "You're logged in... ");
        }
        public void Buy(){
            Console.WriteLine( "Buy");

        }
        public void MyOrder(){
            Console.WriteLine("View my order");
        }
        public void WishList(){
        Console.WriteLine("Add to whish list");
        }
        public void Cart(){
            Console.WriteLine("View your cart");
        }
        public void SignIn(){
            Console.WriteLine("Please,compile our forum to sig in in this website");
        }
    }
}