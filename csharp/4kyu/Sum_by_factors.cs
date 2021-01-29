using System;
using System.Collections.Generic;

public class SumOfDivided {
  
  public static string sumOfDivided(int[] lst) {
    List<int> pList = new List<int>();
    List<int> tList = new List<int>();
    List<int> lList = new List<int>();
    string result = "";
    int i, j, k, dTemp, rTemp;
    bool reOk;
    int pSum;
    
    pList.Add(2);
    rTemp = 0;
    for(i = 0; i < lst.Length; i++){
      lList.Add(lst[i]);
      rTemp += lst[i];
      dTemp = lst[i];
      //Console.WriteLine($"At first dTemp: {dTemp}");
      reOk = false;
      
      while (dTemp != 1 && dTemp != -1){
        for(j = 0; j < pList.Count; j++){
          if(dTemp % pList[j] == 0){
            while( (dTemp % pList[j]) == 0 )
              dTemp = dTemp / pList[j];
            if(!tList.Contains(pList[j])) tList.Add(pList[j]);
            //Console.WriteLine($"reducing dTemp: {dTemp}");
          }
        }
        if (j == pList.Count) nextPrime(pList);
      }
      
    }
    //for(i = 0; i<tList.Count; i++)
      //Console.WriteLine($"Final: {tList[i]}");
    tList.Sort();
    //Console.WriteLine(i);
    for(i = 0; i<tList.Count; i++){ 
      //Console.WriteLine(tList[i]);
        pSum = 0;
        for( j = 0; j < lList.Count; j++){
          if( (lList[j] % tList[i]) == 0 ){
              pSum = pSum + lList[j];
          }
        }
      result = result + "(" + tList[i].ToString() + " " + pSum.ToString() + ")";
    }
    
    
    return result;
  }
  
  public static void nextPrime(List<int> pList){
    int np, i;
    np = pList[pList.Count - 1] + 1;
    
    bool npok = false;
    
    while(!npok){
      for(i = 0; i<pList.Count; i++){
        if((np % pList[i]) == 0) break;
      }
      
      if(i != pList.Count) np += 1;
      else{
        npok = true;
        pList.Add(np);
      }
    }
    
  }
  
}