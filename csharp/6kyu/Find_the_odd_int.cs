namespace Solution
{
  using System;
  using System.Collections.Generic;
  using System.Linq;
  
  class Kata
    {
    public static int find_it(int[] seq) 
      {
        var li = seq.ToList();
        var g = li.GroupBy( i => i);
      
      
      foreach(var grp in g){
        //Console.WriteLine($"Key: {grp.Key}, Count: {grp.Count()}");
        if (grp.Count() % 2 == 1) return grp.Key;  
        
      }
      return -1;
      }
       
    }
}