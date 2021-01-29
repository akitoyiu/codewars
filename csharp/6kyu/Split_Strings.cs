using System;
using System.Collections.Generic;

public class SplitString
{
  public static string[] Solution(string str)
  {
    List<string> lStr = new List<string>();
    string tStr = null;
    
    for(int i = 0; i < str.Length; i += 2){
      if(str.Length >= i + 3){
        tStr = str.Substring(i, 2);
      }else{
        tStr = str.Substring(i);
      }
      if(tStr.Length == 1){
        tStr = tStr + '_';
      }
      lStr.Add(tStr);
    }
    
    
    return lStr.ToArray();
  }
}