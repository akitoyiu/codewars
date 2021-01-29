using System;

public class Kata
{
  public static string ToCamelCase(string str)
  {
    
    char[] dlc = {'_','-'};
    
    String [] words = str.Split(dlc);
    string tstr = null;
    str = null;
    bool firsttime = true;
    foreach(var word in words){
      
      tstr = (firsttime)? word : char.ToUpper(word[0]) + word.Substring(1);
      
      firsttime = false;
      
      str = str + tstr;
      
    }
    
    return str;
  }
}