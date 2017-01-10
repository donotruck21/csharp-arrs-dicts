using System;

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


            
        }
    }
}
