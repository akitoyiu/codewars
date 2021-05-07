using System;
using System.Collections.Generic;
using System.Linq;

namespace EncryptThis
{
    public class Kata
    {
        public static string EncryptThis(string input)
        {
            // Implement me! :)
          
          if (input == "") return "";
          
          List<string> Linput = input.Split(" ").ToList();
          List<string> result = new List<string>();
          
          foreach( var v in Linput){
            result.Add(EncWord(v));
          }
          
          return String.Join(" ", result);
        }
      
        public static string EncWord(string input){
          List<char> result = new List<char>();
          char ch = input[0];
          int ach = (int)ch;
          string sch = Convert.ToString(ach);
          
          for( int i = 0; i < sch.Length; i++)
            result.Add(sch[i]);
          
          if( input.Length > 1){
            result.Add(input[input.Length -1]);
          
            if (input.Length > 2){
              for( int i = 2; i < input.Length - 1; i++)
                result.Add(input[i]);
              
              result.Add(input[1]);
            }
            
          }
          
          return String.Join("", result);
          
        }
    }
}