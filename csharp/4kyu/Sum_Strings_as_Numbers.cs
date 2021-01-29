using System;
public static class Kata
{
    public static string sumStrings(string a, string b)
    {
      string wa, wb;
      int ia, ib;
      int up;
      int sd;
      string result = "";
      
      if (a.Length >= b.Length){
        wa = a;
        wb = b;
      }else{
        wa = b;
        wb = a;
      }
      
      up = 0;
      
      for(int i = 0; i < wa.Length; i++){
        
        ia = (int)Char.GetNumericValue(wa[wa.Length -1 - i]);
        
        if( wb.Length > i ){
          ib = (int)Char.GetNumericValue(wb[wb.Length -1 - i]);  
        }
        else{
          ib = 0;
        }
        
        sd = ia + ib + up;
        
        
        if( sd > 9 ){
          up = 1;
          sd = sd - 10;
        }else{
          up = 0;
        }
        result = sd.ToString() + result;
      }
      
      result = (up == 1)? up.ToString() + result : result;
      
      bool prezero = true;
      int ii = 0;
      while(prezero){
        if(result[ii] != '0'){
          prezero = false;
        }
        else ii++;
      
      }
      result = result.Substring(ii);
      
      return result;
    }
}