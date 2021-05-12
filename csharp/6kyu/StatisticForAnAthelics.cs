using System;

public class Stat
    {   
    
        public static string stat(string strg)
        {
            // your code
          
          try{
          string [] arr_str = strg.Split(",");
          int [] arr_stat = new int[arr_str.Length];
          
          string [] arr_tmp;
          int sum_total = 0;
          
          for (int i = 0; i < arr_str.Length; i++){
            arr_tmp = arr_str[i].Trim().Split("|");
            arr_stat[i] = Int32.Parse(arr_tmp[0]) * 3600 + Int32.Parse(arr_tmp[1]) * 60 + Int32.Parse(arr_tmp[2]);
            sum_total += arr_stat[i];
          }
          
          Array.Sort(arr_stat);
          string result = "";
          
          result = "Range: " + statconvert(arr_stat[arr_stat.Length - 1] - arr_stat[0]);
          result = result + " Average: " + statconvert(sum_total / arr_stat.Length);
          
          int index = (arr_stat.Length - 1)/2;
          
          if( arr_stat.Length % 2 == 1){
            sum_total = arr_stat[index];
          }
          else
          {
            sum_total = (arr_stat[index] + arr_stat[index+1])/2;
          }
          
          result = result + " Median: " + statconvert(sum_total);
          return result;
          }
          catch(Exception e){
            
            Console.WriteLine("Exception: " + strg);
            
            return "";
          }
          
        }   
        
        public static string statconvert(int s)
        {
           int h;
           int m;
           int remain;
          
           h = s / 3600;
           remain = s - 3600 * h;
           m = remain / 60;
           remain = remain - 60 * m;
           
           return h.ToString("00") + "|" + m.ToString("00") + "|" + remain.ToString("00");
            
          
        }
  
    }