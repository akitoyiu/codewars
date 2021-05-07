using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public string[] StreetFighterSelection(string[][] fighters, int[] position, string[] moves)
    {
      
        List<string> result = new List<string>();
        
        for(int i = 0; i < moves.Length; i++){
          switch( moves[i].ToLower() ){
              case "up":
                position[0] -= 1;
                if ( position[0] < 0 ) position[0] = 0;
                break;
              case "down":
                position[0] += 1;
                if ( position[0] > (fighters.Length - 1) ) position[0] = fighters.Length - 1;
                break;
              case "left":
                position[1] -= 1;
                if (position[1] < 0 ) position[1] = fighters[position[0]].Length - 1;
                break;
              case "right":
                position[1] += 1;
                if (position[1] > (fighters[position[0]].Length - 1)) position[1] = 0;
                break;
          }
          
          result.Add(fighters[position[0]][position[1]]);
          
        }
      
        return result.ToArray();
      
    }
}