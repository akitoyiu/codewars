using System;

public class LongestConsecutives 
{
    
    public static String LongestConsec(string[] strarr, int k) 
    {
        // your code
      string result = "";
      string tempstr = "";
      int i = 0;
      
      if((strarr.Length > 0) && (k <= strarr.Length) && (k > 0)){
        
        while( i + k <= strarr.Length){
          tempstr = "";
          for(int j = 0; j < k; j++ ){
            tempstr += strarr[i+j];
          }
          if(tempstr.Length > result.Length) result = tempstr;
          
          i++;
        }
      }
      
      return result;
      
    }
}