using System;
using System.Collections.Generic;
using System.Linq;

class Permutations
{
  
  public static List<string> ts; 
  
   public static List<string> SinglePermutations(string s)
   {
       // Your code here!
    
     ts = new List<string>();
     //List<string> ts = new List<string>();
     permu(0, s, s.Length - 1);
     
     string [] resultArr = ts.ToArray();
     
     
     //Console.WriteLine("Array Length: " + ts.Count);
     
     IEnumerable<string> myEn = (IEnumerable<string>)ts;
     myEn = myEn.Distinct();
     
     return (List<string>)myEn.ToList();
   }
  
  
  public static void permu(int start, string str, int end){
    
    char tempc;
    char[] tsArray;
    
    if(start == end){
      //Console.WriteLine("Adding: " + str);
      ts.Add(str);
    }else
    {
      for(int i = start; i <= end; i++){
        
        tsArray = str.ToCharArray();
        tempc = tsArray[start];
        tsArray[start] = tsArray[i];
        tsArray[i] = tempc;
        //Console.WriteLine("in loop: " + new string(tsArray));
        permu(start+1, new string(tsArray), end);
      }  
      
    }
  }
}