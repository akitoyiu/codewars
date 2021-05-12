namespace Solution
{
    class FileNameExtractor
    {
        public static string ExtractFileName(string dirtFileName)
        {
            // Your code here
            
            int i = 0;
            string remaining;
            
            for( i = 0; i < dirtFileName.Length; i++){
              if( dirtFileName[i] == '_') break;
            }
            
            remaining = dirtFileName.Substring( i+ 1);
          
            string [] rParts = remaining.Split(".");
          
            return rParts[0] + "." + rParts[1];
        }
    }
}