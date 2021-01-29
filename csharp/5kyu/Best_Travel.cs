using System;
using NUnit.Framework;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public static class SumOfK 
{
  
    
    public static int? chooseBestSum(int t, int k, List<int> ls) {
        // your code
        List<int> allCombi = getCombi(ls, k);
      
        //Console.WriteLine($"Allcombi Size: {allCombi.Count}");
        int minK = -1;
        int result = 0;
      
        foreach(var combi in allCombi){
          //Console.WriteLine($"Combi: {combi}, T: {t}");
          if( (t-combi) >= 0){
            
            if( minK == -1 || minK >= ( t - combi) ) {
              
              minK = t - combi;
              result = combi;
            }
          }
        }
      
      if (minK == -1) return null;
      else return result;
    }
  
    public static List<int> getCombi(List<int> ls, int k){
      List<int> allCombi = new List<int>();
      List<int> data = new List<int>();
      getCombiHelper(ls, k, data, 0, ref allCombi);
      
      return allCombi;
    }
  
    public static void getCombiHelper(List<int> ls, int k, List<int> data, int i, ref List<int> allCombi){
      int intData = 0;
      
      List<int> data2 = new List<int>();
      foreach(var ele in data){
        data2.Add(ele);
      }
      
      //Console.WriteLine($"DataCount: {data.Count}, LS Count: {ls.Count}");
      //Console.WriteLine($"here datacount: {data.Count}, k: {k}");
      if(data.Count == k){
        for (int l = 0; l < data.Count; l++){
          intData += data[l];
        }
        //Console.WriteLine(intData);
        allCombi.Add(intData);
        
        return;
        
      }
      
      if( i >= ls.Count ) return;
      
      getCombiHelper(ls, k, data2, i + 1, ref allCombi);
      
      data2.Add(ls[i]);
      getCombiHelper(ls, k, data2, i + 1, ref allCombi);
        
    }
}