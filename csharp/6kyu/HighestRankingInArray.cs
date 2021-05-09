using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
  public static int HighestRank(int[] arr)
  {
    Hashtable ranking = new Hashtable();
    
    for ( int i = 0; i < arr.Length; i++){
      if ( ranking.ContainsKey(arr[i])){
        ranking[arr[i]] = (int)ranking[arr[i]] + 1;
      }
      else{
        ranking.Add(arr[i], 1);
      }
    }
    
    int? currentMax = null;
    int? MaxKey = null;
    
    foreach( DictionaryEntry r in ranking){
      if ( MaxKey == null ){
        MaxKey = (int)r.Key;
        currentMax = (int)r.Value;
      }else{
        if( (int)r.Value == currentMax){
          if( (int)r.Key > MaxKey ) MaxKey = (int)r.Key;
        }
        else if( (int)r.Value > currentMax){
          MaxKey = (int)r.Key;
          currentMax = (int)r.Value;
        }
      }
    }
    
    return (int)MaxKey;
  }
}