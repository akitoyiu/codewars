using System.Collections.Generic;  

public class Kata
{
  public static string DuplicateEncode(string word)
  {
    char [] carray = word.ToLower().ToCharArray();
    Dictionary<char, char> cDict = new Dictionary<char, char>();
    
    foreach(char c in carray){
      if( cDict.ContainsKey(c)){
        cDict[c] = ')';
      }else
      {
        cDict.Add(c, '(');  
      }
    }
    
    string result = "";
    
    foreach(char c in carray){
      result = result + cDict[c];
    }
      
    return result;
  }
}