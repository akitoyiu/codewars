using System;

public class Kata {
  public static int[][] Pyramid(int n) {
    
    if ( n == 0 ) return new int[][] {};
    
    int [][] result = new int[n][];
    
    for( int i = 0; i < n; i++){
      result[i] = new int[i+1];
      Array.Fill(result[i], 1);
    }
    
    return result;
    // your code here
  }
}