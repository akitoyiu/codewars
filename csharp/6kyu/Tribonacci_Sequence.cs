using System;
using System.Collections.Generic;

public class Xbonacci
{
  public double[] Tribonacci(double[] signature, int n)
  {
    // hackonacci me
    int i, j;
    double [] empty = new double [] {};
    
    if (signature.Length < 3 || n <= 0) return empty;
    
    List<double> result = new List<double>();
    
    for(i = 0; i < Math.Min(3,n); i++) result.Add(signature[i]);
    
    j = 3;
    
    while (j < n){
      
      result.Add(result[j-3] + result[j-2] + result[j-1]);
      j++;
      
    }
    
    return result.ToArray();
    
  }
}