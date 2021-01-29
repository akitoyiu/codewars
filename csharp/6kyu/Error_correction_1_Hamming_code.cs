using System;
using System.Text;
using System.Collections.Generic;

public class CodeWars {
  public static string encode(string text) {
    string bits = "";
    string tbits = "";
    
    byte[] ascValue = Encoding.ASCII.GetBytes(text);
    foreach( var ascV in ascValue ){
      bits = bits + (Convert.ToString(ascV, 2).PadLeft(8, '0'));
    }
    
    foreach (var bit in bits){
      tbits = tbits + new string(bit, 3);
    }
    
    return tbits;   
  }
  public static string decode(string bits) {
    
    string text = "";
    string cbits = "";
    int ascVal;
    int i;
    int check;
    
    for(i = 0; i < bits.Length; i += 3){
      check = (int)Char.GetNumericValue(bits[i]) 
              + (int)Char.GetNumericValue(bits[i+1]) 
              + (int)Char.GetNumericValue(bits[i+2]);
      
      if( check > 1 ) cbits = cbits + "1";
      else  cbits = cbits + "0";
      
    }
    
    for(i = 0; i < cbits.Length; i += 8){
      bits = cbits.Substring(i, 8);
      Console.WriteLine(bits);
      ascVal=(Convert.ToInt32(bits, 2));
      text = text + Convert.ToChar(ascVal);
    }
      
    return text;
  }
}