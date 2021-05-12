using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public static class Kata
{
  public static string GroupByCommas(int n)
  {
    //throw new NotImplementedException();
    
    // Easiest!   return n.ToString("N0");
    
    // go for manual method
    string sn = n.ToString();
    List<char> result = new List<char>();
    int c = 1;
    for (int i = sn.Length -1; i >= 0; i--){
      result.Add(sn[i]);
      if( c % 3 == 0 && i > 0) result.Add(',');
      c += 1;
    }
    
    result.Reverse();
    
    return String.Join("", result);
  }
}