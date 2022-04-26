using System;

namespace inputSwap
{   
    class inputSwap{
        static public void Main(string[]args){
            System.Console.WriteLine("Skriv in något !");
            string input = Console.ReadLine();
            System.Console.WriteLine(swapString(input));

        }
        static string swapString(String input){
            
            char[] charA= input.ToCharArray(); 
            Array.Reverse(charA);
            return  new string(charA);

        }
    }
    
}