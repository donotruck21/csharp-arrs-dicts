using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
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

            // Console.WriteLine(boolArray);
            Console.WriteLine("[{0}]", string.Join(", ", boolArray));
        }
    }
}
