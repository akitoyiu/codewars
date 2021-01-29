class MorseCodeDecoder
{
  public static string Decode(string morseCode)
  {
    
    string Decoded = "";
    
    morseCode = morseCode.Trim();
    
    morseCode = morseCode.Replace("   ", " # ");
      
    foreach(var character in morseCode.Split(' ')){
      if(character == "#"){
        Decoded = Decoded + ' ';
      }else{
        Decoded = Decoded + MorseCode.Get(character);
      }
    }
    
    
    return Decoded;
    
    throw new System.NotImplementedException("Please provide some code.");
  }
}