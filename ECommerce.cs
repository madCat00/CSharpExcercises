using System;

namespace ECommerce{
    class Customer{
        protected int Id;
        protected string Name;
        private string FirstName;
        private string  LastName;
        protected string Surname;
        protected string Address;
        protected string City;
        private string Email;
        protected string Password;

         public Customer(string firstName, string lastName, string mail){
                
                this.FirstName = firstName;
                this.LastName = lastName;
                this.Email = mail;
        }

        public void Login(){
            Console.WriteLine( $"Hi,{this.FirstName} {this.LastName} ,your mail: {this.Email}. Well done you 're loggin in.");
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

    class OrderHeader{
        private int id; //Consider to prefer long for much id......

        private string date;
        private long orderNumber;
        private string userId;


        public OrderHeader(int Id ,long OrderNumber,string Date ){
                this.id = Id;
                this.orderNumber = OrderNumber;  
                this.date = Date;
        }
        public void CreateOrder(){
            System.Console.WriteLine($"Yor order has been created....: Id {this.id} order_number : {this.orderNumber} at {this.date}");
        }

        public void Cancel(){
            System.Console.WriteLine();
        }

        public void list(){

        }

        
    }
 class Article{
     private int id;
     private string descrizione;
     private int prezzo;
     private int giacenza;
     public int vat;

     public int destroy;
     

 public Article(int Id){
     this.id = Id;
 }

 public void Crud(){
     Console.WriteLine($"{this.id}");
 }
 public void List(){
     Console.WriteLine($"");
 }

 public void Destroy(){
    
     Console.WriteLine($"yor id has been eliminate {this.id}");
 }

 public void Retrieve(){

        Console.WriteLine($"You id has been restore {this.id}");
 }
 }

}