using System;

public class Kata
{
  public static int DuplicateCount(string str)
  {
    char [] carray = str.ToLower().ToCharArray();
    Array.Sort(carray);
    
    char lc = '¥';
    int counter = 0;
    int rc = 0;
    
    foreach(char c in carray){
      if(c == lc){
        rc++;
        if(rc == 1) counter++;
      }else{
        rc = 0;
        lc = c;
      }
    }
    return counter;
  }
}