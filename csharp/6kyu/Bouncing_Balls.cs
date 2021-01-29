public class BouncingBall {
  
  public static int bouncingBall(double h, double bounce, double window) {
      // your code
      
    int result = 1;
    
    if ((h <= 0) || (window >= h) || (window <= 0)
       || (bounce <= 0) || (bounce >= 1)) result = -1;
    
    
    
    while ((result > 0) && (h = h * bounce) > window){
      result += 2; 
    }
    return result;
  }
}