public class Kata
{
  public static string Rgb(int r, int g, int b) 
  {
    
    return convert(r) + convert(g) + convert(b);
  }
  
  private static string convert(int s){
    
    if (s < 0) s = 0;
    if (s > 255) s = 255;
    
    string ts = "";
    
    ts = s.ToString("X");
    if (ts.Length == 1 ) ts = "0" + ts;
    
    return ts;
    
  }
  
}