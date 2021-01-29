using System;
using System.Linq;

class Epidem {

    public static int Epidemic(int tm, int n, int s0, int i0, double b, double a) {
        // your code
      
      int i;
      double [] S = new double[tm*n+1];
      double [] I = new double[tm*n+1];
      double [] R = new double[tm*n+1];
      
      S[0] = s0;
      I[0] = i0;
      R[0] = 0;
      
      double dt;
      dt = Convert.ToDouble(tm)/Convert.ToDouble(n);
      Console.WriteLine($"TM:{tm}, n:{n}, dt:{dt}");
      
      for( i = 1; i <= tm*n; i++){
        
          S[i] = S[i-1] - dt * b * S[i-1] * I[i-1];
          I[i] = I[i-1] + dt * (b * S[i-1] * I[i-1] - a * I[i-1]);
          R[i] = R[i-1] + dt * I[i-1] * a;
        
        //Console.WriteLine($"S{S[i]}, I{I[i]}, R{R[i]}");
        
      }
      
      Console.WriteLine($"TM: {tm}, S0: {s0}, result: {I.Max()}");
      
      
      return Convert.ToInt32(Math.Round(I.Max()));
    }
}