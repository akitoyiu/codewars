using System.Collections.Generic;
using System.Linq;
using System;

public class Consecutives
{
  public static List<int> SumConsecutives(List<int> s) 
  {
      // your code
      List<int> result = new List<int>();
      if( s.Count == 0 ) return null;
      int lastNum = s[0];
      int tmpSum = s[0];
      for( int i = 1; i < s.Count; i++){
        if ( s[i] == lastNum ) tmpSum += s[i];
        else{
          result.Add(tmpSum);
          tmpSum = s[i];
          lastNum = s[i];
        }
      }
      result.Add(tmpSum);
    
    
      //foreach(var v in result) Console.WriteLine(v);
      return result;
  }

}