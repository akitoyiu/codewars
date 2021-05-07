using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public static class Kata
{
  public static int MaxSequence(int[] arr) 
  { 
    //TODO : create code
    
    List<int> iList = arr.ToList();
    int curr_sum = 0;
    int max_sum = 0;
    
    
    for( int i = 0; i < iList.Count; i++){
      curr_sum += iList[i];
      if ( curr_sum < 0 ) curr_sum = 0;
      if ( curr_sum > max_sum) max_sum = curr_sum;
    }
    
    return max_sum;
  }
}