using System;

public class Kata
{
  public static string PigIt(string str)
  {
    string [] words = str.Split(" ");
    int i;
    string ts;
    string result = "";
    
    foreach(var word in words){
      i = 0;
      while((Char.IsPunctuation(word[i])) && (i < word.Length)){
        i++;
      }
      if( i < word.Length){
        if( i > 0){
          ts = word.Substring(0, i) + word.Substring(i+1) + word[i] + "ay";
        }else{
          ts = word.Substring(1) + word[0] + "ay";
        }
      }else{
        ts = word;
      }
            
      result = result + " " + ts;
      
    }
    
    return result.Trim();
  }
}