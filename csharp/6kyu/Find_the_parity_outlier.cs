using System.Collections.Generic;
using System.Linq;
using System;

public class Kata
{
  public static int Find(int[] integers)
  {
    
    int totalEvenNums = integers.Count( n => n%2==0);
    int mod;
    
    if( totalEvenNums == 1 ) mod = 0;
    else mod = 1;
    
    for (int i = 0; i < integers.Length; i++){
      if( integers[i] % 2 == mod ) return integers[i];
    }
    
    
    return -1;
  }
}