using System;
using System.Collections.Generic;
using System.Linq;

public class DirReduction {
  
    public static string[] dirReduc(String[] arr) {
      
      bool hasFalse = true;
      List<String> Sarr = arr.ToList();
      
      while(hasFalse){
        hasFalse = false;
        for (int i = 0; i < Sarr.Count; i++){
          if ( i+1 < Sarr.Count ){
            if (( Sarr[i].ToLower() == "north" && Sarr[i+1].ToLower() == "south" )
                || ( Sarr[i].ToLower() == "south" && Sarr[i+1].ToLower() == "north" )
                || ( Sarr[i].ToLower() == "east" && Sarr[i+1].ToLower() == "west" )
                || ( Sarr[i].ToLower() == "west" && Sarr[i+1].ToLower() == "east" )
                )
              {
              hasFalse = true;
              Sarr.RemoveAt(i+1);
              Sarr.RemoveAt(i);
              
            }
          }
          
        }
        
      }
      return Sarr.ToArray();
    }
}