using System;

public class Number
{
  public int DigitalRoot(long n)
  {
    // Your awesome code here!
    string tn;
    
    
    while(n>9){
      tn = n.ToString();
      n = 0;
      for(int i = 0; i < tn.Length; i++){
        n += (int)char.GetNumericValue(tn[i]);
        Console.WriteLine(n);
      }
    }

    return Convert.ToInt32(n);
  }
}