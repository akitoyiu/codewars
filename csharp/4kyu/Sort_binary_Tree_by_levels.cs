using System;
using System.Collections.Generic;

class Kata
{
  public static List<int> TreeByLevels(Node node)
  {
    //off ya go!
    List<int> result = new List<int>();
    List<Node> cL = new List<Node>();
    List<Node> nL;
    
    if(node == null) return result;
    
    cL.Add(node);
    while(cL.Count > 0){
      nL = new List<Node>();
      while(cL.Count > 0){
        if (cL[0].Left != null) nL.Add(cL[0].Left);
        if (cL[0].Right != null) nL.Add(cL[0].Right);
        
        result.Add(cL[0].Value);
        cL.RemoveAt(0);
      }
      
      cL = nL;
      nL = null;
    }
    
    return result;
  }
}