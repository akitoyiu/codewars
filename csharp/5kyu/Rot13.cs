using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System;

public class Kata
{
  public static string Rot13(string message)
  {
    string [] lowerC = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"};

    int cipher = 13;
    int nI;
    Hashtable lC = new Hashtable();
    Hashtable uC = new Hashtable();
    List<string> result = new List<string>();
    string ch;
    
    for( int I = 0; I < lowerC.Length; I++){
      nI = (I + cipher) % 26;
      lC.Add(lowerC[I], lowerC[nI]);
      uC.Add(lowerC[I].ToUpper(), lowerC[nI].ToUpper());
    }
    
    for(int i = 0; i < message.Length; i++){
        ch = Char.ToString(message[i]);
        //Console.WriteLine("Original: {0}, Cipher{1}", message[i], lC[ch]);
        if( Char.IsLower(message[i]))
        {
          result.Add((string)lC[ch]);
        }
        else if ( Char.IsUpper(message[i]))
        {
          result.Add((string)uC[ch]);
        }
        else{
          result.Add(ch);
        }
      
    }
    
    return string.Join("", result);
    // your code here
  }
}