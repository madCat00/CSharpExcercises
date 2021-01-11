using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Users
{
    class User
    {
        private int _age;
        public string name;
        private List<User> _listOfUser;
    
    public int Age
    {
        get => _age;

        set {
                 _age = value;

                if( this._age > 18)
                {
                   
                    Console.WriteLine("OK. Your age as been insert correctly");
                    
                } else
                {
                    Console.WriteLine("You can't insert your age");
                }
           }
    }

    public User(string Name)
    {
        this.name = Name;  //Initiaze costructor with the name;
    }
      public User()
    {
            this._listOfUser = new List<User>();
            
    }

    public void addUser(User user1)
    {
        _listOfUser.Add(user1);
        Console.WriteLine(_listOfUser.Count());
    }

    public void Extrapolate()
    {
        string path = @"C:\Users\franc\Desktop\CSharpExcercises\Userlist.csv";
       
        foreach(var users in _listOfUser)
        {
            if(users.name.Contains("C"))
            {
                Console.WriteLine(users.name);
                File.AppendAllText(path,users.name);
            }
        }
    }

    }

  
}