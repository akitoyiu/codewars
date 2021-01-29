using System;

public class DigPow {
  public static long digPow(int n, int p) {
    // your code
    
    string tn = n.ToString();
    int ti = 0;
    
    
    
    for(int i = 0; i < tn.Length; i++){
      ti += (int)Math.Pow(Convert.ToDouble(tn.Substring(i,1)), p + i);
      //Console.Out.WriteLine(Convert.ToDouble(tn.Substring(i,1)));
    }
    
    
    return (ti % n == 0)? ti / n : -1;
  }
}