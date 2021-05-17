using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace Kata
{
  public static class Kata
  {
    public static int[] UpArray(int[] num)
    {
      //Do your thing
      if( num == null || num.Length == 0 ) return null;
      
      List<int> LNum = new List<int> ();
      for( int i = num.Length - 1; i >= 0; i--){
        if( num[i] > 9 || num[i] < 0) return null;
        LNum.Add(num[i]);
      }
      
      
      int nextTier = 1;
      for (int i = 0; i < LNum.Count; i++){
        if( nextTier == 0) break;
        LNum[i] += nextTier;
        nextTier = 0;
        
        if( LNum[i] == 10 ){
          LNum[i] = 0;
          nextTier = 1;
        }
      }
      
      if( nextTier == 1) LNum.Add(1);
      
      LNum.Reverse();
      return LNum.ToArray();
      
    }
  }
}