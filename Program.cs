using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // array challenges
            Console.WriteLine("Hello World!");
            int[] numArray = new int[10];
            string[] nameArray = {"Tim", "Martin", "Nikki", "Sara"};
            bool[] boolArray = new bool[10];

            for(int i = 0; i < boolArray.Length; i++){
                if(i % 2 == 0){
                    boolArray[i] = true;
                } else {
                    boolArray[i] = false;
                }
            }

            Console.WriteLine("[{0}]", string.Join(", ", boolArray));


            // 10 by 10 multiplication table
            int [,] array2D = new int[10,10];

            for(int y = 0; y < 10; y++){
                for(int x = 0; x < 10; x++){
                    array2D[y,x] = (x+1) * (y+1);
                }
            }

            Console.WriteLine(array2D[7,7]);


            // dictionary challenges
            Dictionary<string,string> tim = new Dictionary<string,string>();
            
            tim.Add("name", "Tim");
            tim.Add("favSports", "Football");
            tim.Add("numPets", "1");
            tim.Add("likesIceCream", "true");

            Dictionary<string,string> martin = new Dictionary<string,string>();
            
            martin.Add("name", "Martin");
            martin.Add("favSports", "Baseball");
            martin.Add("numPets", "3");
            martin.Add("likesIceCream", "true");

            Dictionary<string,string> nikki = new Dictionary<string,string>();
            
            nikki.Add("name", "Nikki");
            nikki.Add("favSports", "Basketball");
            nikki.Add("numPets", "1");
            nikki.Add("likesIceCream", "true");

            Dictionary<string,string> sara = new Dictionary<string,string>();
            
            sara.Add("name", "Sara");
            sara.Add("favSports", "Football");
            sara.Add("numPets", "0");
            sara.Add("likesIceCream", "true");

            List<Dictionary<string,string>> myFriends = new List<Dictionary<string,string>>();
            myFriends.Add(tim);
            myFriends.Add(martin);
            myFriends.Add(nikki);
            myFriends.Add(sara);

            foreach( var friend in myFriends){
                foreach( var info in friend){
                    Console.WriteLine(info.Key + " - " + info.Value);
                }
            }
        }
    }
}
