using System;
using System.Collections.Generic;

namespace ECommerce{
    class Customer{
        protected int Id;
        private string FirstName;
        private string  LastName;
        protected string Address;
        protected string City;
        private string Email;
        protected string Password;
        private List<Articles> ArticlesList;
        private int _age;
         public Customer(string firstName, string lastName, string mail){ //costructor
                
                this.FirstName = firstName;
                this.LastName = lastName;
                this.Email = mail;
        }

   public int Age{

       get => _age;
       set{
            _age = value;
            CheckAge();
            
          }
    }

   public void CheckAge(){

         if (Age < 18){
           Console.WriteLine("You're not be able to buy any article");
       } else 
       {
           Console.WriteLine("Yoo're able to buy any article");
       }
   }

      public void AddArticles(Articles articles){

        this.ArticlesList = new List<Articles>();

        ArticlesList.Add(articles);

    }

    public void Search(){
        
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


class Customers {

    private List<Customer> _Customerlist;

    public Customers(){
        this._Customerlist = new List<Customer>();
    }

    public void AddCustomer(Customer customer){

        this._Customerlist.Add(customer);
    }

    public void RemoveCustomer(Customer customer){
        this._Customerlist.Remove(customer);
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
     
     

 public Article(string description,int stock, double price){
     Stock = stock;
     Price = price;
     Description = description;
 }

public void Articles(){
    Console.WriteLine($"Well done! your article is {this.Description},{this.Price}");
}


public void Verify(int age){       
      if(age<18)
    {
       Console.WriteLine("You're not be able to buy any article!!This message was sent by Class Article!");
    }else                                                                                                                   
    {
        Console.WriteLine("You're able to add any article to cart!!!This message was sent by Class Article!");
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
 public void Destroy(){
    
     Console.WriteLine($"yor id has been eliminate {this.Id} {this.Price}");
 }

 public void Retrieve(){

        Console.WriteLine($"You id has been restore {this.Id} {this.Price}");
 }
 }

class Cart{
    private int _Id;
    private int _IdArticle;
    private int _IdUsers;
    private int _Quantity;

    public void buy(Articles articles){
        
    }
    public void EmptyCart(){

    }
    public void ListCart(){

    }
}

class Articles {
    private int _Id;
    private string _Description;
    private double _Price;
    private int _Stock;
    private List<Articles> ArticlesList;
    public int Vat;

  
public string Description{
    set {
            _Description = value;
    }
}
    public Articles( string description,double price,int stock){
        _Stock = stock;
        _Price = price;
        _Description = description;

    }

    public void Search(){
        
    }
    

public void CreateArticleList(){
    this.ArticlesList = new List<Articles>();
}

    public void CreateArticles(){
                
                
    }
    public void ReadArticles(){

    }
    public void UpdateArticle(){

    }

    public void Delete(){

    }
    public void List(){

    }
}

class OrderDetail{
    private int _Id;
    public int IdOrder;
    public int IdArticle;
    private double Price;
    private int Quantity;

}

class Admin{
    private string _Administrator;
    public void loginAdmin(){

    }
    public void OrderManagement(){

    }
    public void ArticleManagement(){

    }
    public void CustomerManagement(){
        
    }
}

}