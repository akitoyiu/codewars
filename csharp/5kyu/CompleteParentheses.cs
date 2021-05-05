using System;

public class Parentheses
{
    public static bool ValidParentheses(string input)
    {
        // Your code here
        int open = 0;
        Console.WriteLine(input);
        for( int i = 0; i < input.Length; i++)
        {
          if (input[i] == '(') 
          {
            open += 1;
          }
          else if( input[i] == ')')
          { 
            open -= 1; 
          }
          //Console.WriteLine(input[i]);  
          if(  open < 0 ) {
            return false;
          }
        }
      
        if( open == 0){
          return true;
        }
        else{
          return false;
        }
    }
}