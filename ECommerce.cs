using System;

namespace ECommerce{
    class Customer{
        protected int Id;
        private string FirstName;
        private string  LastName;
        protected string Address;
        protected string City;
        private string Email;
        protected string Password;
        public int Age{set;get;}
         public Customer(string firstName, string lastName, string mail){
                
                this.FirstName = firstName;
                this.LastName = lastName;
                this.Email = mail;
        }

        public void CheckAge(){
            if(Age<18){
                Console.WriteLine("You might not be able to buy certain articles");
            }else{
                Console.WriteLine("Well done you can buy any article");
            }
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
        private int Id; //Consider to prefer long for much id......

        public DateTime Date{get;set;}
        public int OrderNumber{get;}
        private int UserId;


        public OrderHeader(int userid ,int orderNumber,DateTime date ){
                this.UserId = userid;
                this.OrderNumber = orderNumber;  
                this.Date = DateTime.Now;
                
        }
        public void CreateOrder(){

            System.Console.WriteLine($"Yor order has been created....: Id {this.Id} order_number : {this.OrderNumber} at {this.Date}");
        }

        public void Cancel(){
            System.Console.WriteLine();
        }

        public void list(){

        }

        
    }
 class Article {
     private int Id{get;}
     private string Description{get;set;}
     public double Price{get;set;}
     public int Stock{get;set;}
     public int Invoice{get;}

     public int destroy;
     public int Age;
     

 public Article(int id, double price,int age){
     Id = id;
     Price = price;
     Age = age;
 }

 public void Create(){
     if (Age< 18){
     Console.WriteLine($"You're not be able to make order");
     }else{
         Console.WriteLine($"well done...this is you article id {this.Id} ${this.Price}");
     }
 }

 public void Read(){
     Console.WriteLine();
 }
 public void Update(){
     Console.WriteLine();
 }
 public void Delete(){

 }
 public void List(){
     Console.WriteLine($"");
 }

 public void Destroy(){
    
     Console.WriteLine($"yor id has been eliminate {this.Id} {this.Price}");
 }

 public void Retrieve(){

        Console.WriteLine($"You id has been restore {this.Id} {this.Price}");
 }
 }

}