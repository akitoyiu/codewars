using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
  public static int[] ArrayDiff(int[] a, int[] b)
  {
    // Your brilliant solution goes here
    // It's possible to pass random tests in about a second ;)
    List<int> result = new List<int>();
    
    foreach(int i in a){
      if (!b.Contains(i)) result.Add(i);
    }
    return result.ToArray();
  }
}