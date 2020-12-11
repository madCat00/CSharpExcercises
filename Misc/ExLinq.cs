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

              var query =  from Cities in city
                            where Cities == NameOfCity
                            select NameOfCity;

                
                foreach (var item in query)
                {
                   
                     Console.WriteLine($"The value that you've aerched is: {item}");
                
                    
                }


            }

    }
}