public class Kata
{
  public static bool IsValidWalk(string[] walk)
  {
    //insert brilliant code here
    int x = 0;
    int y = 0;
    int count = 0;
    
    foreach(string s in walk){
      count += 1;
      switch(s){
          case "n": y += 1;
                    break;
          case "s": y -= 1;
                    break;
          case "e": x += 1;
                    break;
          case "w": x -= 1;
                    break;
      }
      
    }
    
    if( count == 10 && x == 0 && y == 0){
      return true;
    }
    else return false;
    
    
  }
}