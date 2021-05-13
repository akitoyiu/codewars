using System;

class Rainfall 
{
    public static double Mean(string town, string strng) 
    {
        int? cIndex = null;
        string [] byCountry = strng.Split("\n");
        
        for( int i = 0; i < byCountry.Length; i++){
          
          if( town.ToLower() == byCountry[i].Split(":")[0].Trim().ToLower() ){
            cIndex = i;
            break;
          }
        }
        
        double SumTotal = 0.0;
        
        string [] monthlyData;
      
        if ( cIndex != null ){
              monthlyData = byCountry[(int)cIndex].Split(":")[1].Trim().Split(",");
              for( int i = 0; i < monthlyData.Length; i++){
                SumTotal += Double.Parse(monthlyData[i].Split(" ")[1].Trim());
              }
              return SumTotal / monthlyData.Length;
        }
        else return -1;
      
    }
    
    public static double Variance(string town, string strng) 
    {
        // your code
      double cMean = Mean(town, strng);
      
      int? cIndex = null;
        string [] byCountry = strng.Split("\n");
        
        for( int i = 0; i < byCountry.Length; i++){
          
          if( town.ToLower() == byCountry[i].Split(":")[0].Trim().ToLower() ){
            cIndex = i;
            break;
          }
        }
        
        double SumTotal = 0.0;
        
        string [] monthlyData;
      
        if ( cIndex != null ){
              monthlyData = byCountry[(int)cIndex].Split(":")[1].Trim().Split(",");
              for( int i = 0; i < monthlyData.Length; i++){
                SumTotal += Math.Pow( Double.Parse(monthlyData[i].Split(" ")[1].Trim()) - cMean, 2);
              }
              return SumTotal / monthlyData.Length;
        }
        else return -1;
    }
}