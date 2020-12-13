using System;
using System.Linq;
using System.Collections.Generic;


namespace ExLinq{
    class ListOfCity{

            public static void Cities(string NameOfCity){

                var city = new List<string>();
                city.Add("Arezzo");
                city.Add("Pisa");
                city.Add("Lucca");        
                city.Add("Firenze");
                city.Add("Siena");

               IEnumerable<string> query = from Cities in city
                                           where Cities == NameOfCity
                                           select NameOfCity;

                
                
                foreach (var item in query)

                {
                  
                  Console.WriteLine($"The value that you've searched is: {item}");
                
                }
                    
            }
    } 

    class Peaks{
         
         public static void SearchMountains(string mountains, string[] search){
             
           string trimmed = mountains.Trim(' '); //Delete blank spaces from start and end
           char [] values = new char[]{';',','};
           string[] splitted = trimmed.Split(values,StringSplitOptions.RemoveEmptyEntries); //Split string and remove blank lines

           IEnumerable<string> query = from  names in splitted 
                                       from  places in search  //Search a specific terms
                                       where names == places
                                       select places;
              
              foreach (var item in query)
              {    
                 Console.WriteLine($"You've searched the select term: {item}");  //Extract places or what do you eant from the string
                
              }
            
          }
    }
}    


