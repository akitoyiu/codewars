using System;
using System.Collections;


public class Scramblies 
{
    
    public static bool Scramble(string str1, string str2) 
    {
        // your code
      Hashtable hstr1 = hashString(str1);
      Hashtable hstr2 = hashString(str2);
      
      bool result = true;
      
      //Console.WriteLine($"Word1: {str1}, Word2: {str2}");
      
      foreach(DictionaryEntry word in hstr2){
        //Console.WriteLine($"Key: {word.Key}, str1 count: {hstr1[word.Key]}, str2 count: {word.Value}");
        if((!hstr1.ContainsKey(word.Key)) || ( (int)hstr1[word.Key] < (int)word.Value)) result = false;
      }      
      
      return result;
    }
  
    public static Hashtable hashString(string str){
      Hashtable hstr = new Hashtable();
      
      str = str.Trim();
      for(int i = 0; i < str.Length; i++){
        if( hstr.ContainsKey(str[i])){
          hstr[str[i]] = (int)hstr[str[i]] + 1;
        }else{
          hstr.Add(str[i], 1);
        }  
      }
      
      return hstr;
      
    }

}