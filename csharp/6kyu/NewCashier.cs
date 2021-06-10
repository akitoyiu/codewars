using System;
using System.Collections.Generic;

public static class Kata
{
  public static string GetOrder(string input)
  {	
    List<string> Menu = new List<string>();
    List<string> result = new List<string>();
    List<string> result2 = new List<string>();
    Menu.Add("burger");
    Menu.Add("fries");
    Menu.Add("chicken");
    Menu.Add("pizza");
    Menu.Add("sandwich");
    Menu.Add("onionrings");
    Menu.Add("milkshake");
    Menu.Add("coke");
    
    string ti = "";
    
    for(int i = 0; i < input.Length; i++){
      ti = ti + input[i];
      if( Menu.Contains(ti)){
        result.Add( Menu.IndexOf(ti).ToString() + char.ToUpper(ti[0]) + ti.Substring(1));
        ti = "";
      }
      
    }
    
    result.Sort();
    
    foreach( string v in result) result2.Add(v.Substring(1));
    
  	return String.Join(" ", result2.ToArray());
  }
}