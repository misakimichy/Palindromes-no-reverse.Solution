using System;

public class Check{

    public static void Main(){
        Console.WriteLine("Please enter a value");
        string input = Console.ReadLine().ToLower();
        Check check = new Check();
        if(check.isPalindrome(input)){
           Console.WriteLine("That is a palindrome");
        } else {
            Console.WriteLine("That is not a palindrome");
        }
    }

    public bool isPalindrome(string input){
        // char[] seperator = {''};
        // string[] chars = input.Split(seperator);
        double length = input.Length;
        for(int i = 0; i < (Math.Floor(length/2)); i++){
            if(!(input[i] == input[Convert.ToInt32(length - (i + 1))])){
                return false;
            }
        }
        return true;
    }
}
