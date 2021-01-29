using System;
using System.Text.RegularExpressions;
using System.Text;

public class MorseCodeDecoder
{
    public static string DecodeBits(string bits)
    {
      Console.WriteLine("bits:" + bits);
      bits = bits.Trim();
      // check unit
      int shortbit = 99;
      int longbit = 0;
      int firstone = -1;
      
      int bitLen = 0;
      int i;
      bool lastone = false;
      string result = "";
      
      for(i=0; i<bits.Length; i++){
        if(bits[i] == '1'){
          
          if(lastone){
            bitLen++;
          }else{
            if(firstone == -1) firstone = i;
            else{
              if(shortbit > bitLen) shortbit = bitLen;
              if(longbit < bitLen) longbit = bitLen;
            }
            bitLen = 1;
            lastone = true;
          }
          
        }else{
          if(lastone){
            lastone = false;
            if(shortbit > bitLen) shortbit = bitLen;
            if(longbit < bitLen) longbit = bitLen;
            bitLen = 1;
          }else{
            if(firstone != -1) bitLen++;
          }
        }
      }
      bits = bits.Substring(firstone);
      
      if (shortbit == longbit){
        //if(shortbit >= 3) shortbit = shortbit / 3;
      }
      
      lastone = false;
      bitLen = 0;
      
      for(i = 0; i < bits.Length; i++){
        if(bits[i] == '1'){
          if(lastone){
            bitLen++;      
          }else{
            if(bitLen > 0){
              result = result + addCode(lastone, bitLen, shortbit);
              bitLen = 0;
            }
            bitLen=1;
            lastone = true;
          }
        }else{
          if(lastone){
            
            
            result = result + addCode(lastone, bitLen, shortbit);
            lastone = false;
            bitLen = 1;
          }else{
            bitLen++;
          }
        }
        
      }
      
      
      result = result + addCode(lastone, bitLen, shortbit);
      Console.WriteLine("code: |" + result + "|");
      
      return result.Trim();
    }
  
    public static string addCode(bool one, int bitLen, int shortbit){
              
      if(!one){
        if(bitLen > (shortbit * 4)) return "   ";
        else if (bitLen > (shortbit * 2) && bitLen <= (shortbit * 4)) return " ";
        else return "";
      }else{
        if(bitLen >= (shortbit * 3 )) return "-";
            else return ".";
      }
      
      //return "";
    }
  

    public static string DecodeMorse(string morseCode)
    {
        
      morseCode = morseCode.Replace("   ", " w ");
      
      string [] words = morseCode.Split(" ");
      string result = "";
      
      foreach(var word in words){
        if(word == "w"){
          result = result + " ";
        }else{
          result = result + MorseCode.Get(word);
        }
          
      }
      return result; 
    }
}