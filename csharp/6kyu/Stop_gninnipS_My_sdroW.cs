using System.Collections.Generic;
using System.Linq;
using System;

public class Kata
{
  public static string SpinWords(string sentence)
  {
    string [] sent = sentence.Split(" ");
    List<string> result = new List<string>();
    char[] cArray;
    
    foreach(var i in sent){
      if ( i.Length >= 5){
        cArray = i.ToCharArray();
        Array.Reverse(cArray);
        result.Add( new string ( cArray ) );
      }else result.Add(i);
            
    }
    return string.Join(" ", result);
    
    
  }
}