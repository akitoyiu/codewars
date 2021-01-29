using System;

public class CodeDecode
{
    public static string Code(string strng)
    {
      string result = string.Empty;
      string bits;
      
      foreach(var c in strng){
        bits = toBinary(c);
        result = result + new String('0', bits.Length - 1) + "1" + bits;
      }
      
      return result;
      
    }
  
    public static string toBinary(char str){
      string result = string.Empty;
      
      int digit = (int)Char.GetNumericValue(str);
      
      if(digit == 0) return "0";
      
      for(int i = 0; digit > 0; i++ ){
        result = digit % 2 + result;
        digit /= 2;
      }
      return result;
    }
  
    public static string toDigit(string str){
      
      int bInt = int.Parse(str);
      int digit = 0;
      int bRe;
      
      int b = 1;
      while(bInt > 0){
        bRe = bInt % 10;
        bInt /= 10;
        digit += bRe * b;
        b = b * 2;
      }
      
      return digit.ToString();
    }
  
    public static string Decode(string str)
    {
      int i=0;
      int bitCount;
      
      string bits;
      string result = string.Empty;
      
      while (i < str.Length){
        
        bitCount = 0;
        while(str[i] != '1'){
          ++bitCount;
          ++i;
        }
        ++i;
        if(bitCount > 0)
          bits = str.Substring(i, bitCount + 1);
        else
          bits = str[i].ToString();
        
        i = i + bitCount + 1;
        result = result + toDigit(bits);
        
      }
      return result;
    }
}