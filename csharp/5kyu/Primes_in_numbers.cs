using System;
using System.Collections.Generic;

public class PrimeDecomp {

  public static string factors(int lst) {
    List<int> pList = new List<int>();
    int dTemp, j, k;
    int rep;
    string result = "";
    pList.Add(2);
    pList.Add(3);
    pList.Add(5);
    pList.Add(7);
    pList.Add(11);
    pList.Add(13);
    
    dTemp = lst;
    k = 0;
      
      while (dTemp != 1 && dTemp != -1){
        for(j = k; j < pList.Count; j++){
          if(dTemp % pList[j] == 0){
            rep = 0;
            while( (dTemp % pList[j]) == 0 ){
              dTemp = dTemp / pList[j];
              rep++;
              }
            result = result + "(" + pList[j].ToString();
            
            if( rep > 1){
              result = result + "**" + rep.ToString(); 
            }
            result = result + ")";
            //Console.WriteLine($"reducing dTemp: {dTemp}");
          }
        }
        if (j == pList.Count){ 
          nextPrime(pList);
          k = j;
          }
                              
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