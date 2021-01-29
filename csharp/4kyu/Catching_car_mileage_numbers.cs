using System;
using System.Collections.Generic;

public static class Kata
    {
        public static int IsInteresting(int number, List<int> awesomePhrases)
        {
             // Happy Coding :)
          int i;
          bool result = false;
          
          if( number < 98) return 0;
          for(i = 0; i< 3; i++){
            if( (number + i ) > 99 && 
                ( isAmazing(number + i, awesomePhrases)    
              || isAllZero(number + i)  
              || isSameDigit(number + i)
              || isSeq(number + i)  
              || isDSeq(number + i)  
              || isPal(number + i)  
              ) ){
              result = true;
              
              break;
            }
          }
          
          return (!result) ? 0 : (i == 0)? 2 : 1;
          
        }
  
        public static bool isAmazing(int number, List<int> awesomePhrases)
        {
          foreach(int ap in awesomePhrases){
            if(number == ap) return true;
          }
          return false;
        }  
  
        public static bool isAllZero(int number){
          string strNum = number.ToString();
          for(int i = 1; i < strNum.Length; i++){
            if(strNum[i] != '0') return false;
          }
          return true;
        }
        
        public static bool isSameDigit(int number){
          string strNum = number.ToString();
          for(int i = 1; i < strNum.Length; i++){
            if(strNum[i] != strNum[0]) return false;
          }
          return true;
        }
  
        public static bool isSeq(int number){
          string strNum = number.ToString();
          for(int i = 1; i < strNum.Length; i++){
            if(Char.GetNumericValue(strNum[i]) != (Char.GetNumericValue(strNum[i-1])+1)%10) return false;
          }
          return true;
        }
  
        public static bool isDSeq(int number){
          string strNum = number.ToString();
          for(int i = 1; i < strNum.Length; i++){
            if(Char.GetNumericValue(strNum[i]) != (Char.GetNumericValue(strNum[i-1])-1)%10) return false;
          }
          return true;
        }
  
        public static bool isPal(int number){
          string strNum = number.ToString();
          for(int i = 0; i < (strNum.Length/2.0); i++){
            if(strNum[i] != strNum[strNum.Length-i-1]) return false;
          }
          return true;
        }
        
  
    }