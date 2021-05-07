using System.Collections.Generic;

public class Kata
{
  public static int GetLengthOfMissingArray(object[][] arrayOfArrays)
  {
    List<int> result = new List<int>();
    
    if( arrayOfArrays == null || arrayOfArrays.Length == 0  ) return 0;
    
    for(int i = 0; i < arrayOfArrays.Length; i++){
      if( arrayOfArrays[i] == null || arrayOfArrays[i].Length == 0) return 0;
      result.Add(arrayOfArrays[i].Length);
    }
    
    result.Sort();
    
    int baseLength = result[0];
    int missing = 0;
    
    for(int i = 1; i < result.Count; i++){
      if ( result[i] != baseLength + i) { 
        missing = baseLength + i;
        break;
        }
    }
    
    return missing;
  }
}