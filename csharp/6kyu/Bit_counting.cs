using System;

public class Kata
{
  public static int CountBits(int n)
  {
    string binary = Convert.ToString(n, 2);
    int count = 0;
    foreach(var s in binary){
        if( s == '1' ) count++;
    }
    
    return count;
  }
}