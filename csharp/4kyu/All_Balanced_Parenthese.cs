using System;
using System.Collections.Generic;
using System.Linq;

public class Balanced
{
    public static List<string> BalancedParens(int n)
    {
      List<string> result = new List<string>();
      
      void Add(int o, int c, string s)
      {
        if ( o > 0) Add(o-1, c+1, s + "(");
        if ( c > 0) Add(o, c-1, s + ")");
        if ( o + c == 0) result.Add(s);
      }
      
      Add(n, 0, "");
      
      return result;
    }   
}