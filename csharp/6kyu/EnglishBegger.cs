using System;


public class Kata
{
   public static int[] Beggars(int[] values, int n)
   {
       // show me the code!
       if( n == 0 ) return new int[] {};
     
       int [] result = new int [n];
     
       for( int i = 0; i < result.Length; i++) result[i] = 0;
     
       for( int i = 0; i < values.Length; i++) result[ i % n ] += values[i];
         
       return result;
     
   }
}