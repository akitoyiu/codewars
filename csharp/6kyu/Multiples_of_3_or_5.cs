public static class Kata
{
  public static int Solution(int value)
  {
    // Magic Happens
    int magic = 0;
    if (value <= 0){
      return 0;
    }else{
      for(int i = 1; i < value; i++){
        if ((i % 3 == 0) || (i % 5 == 0)){
          magic = magic + i;
        }
      }
    
    }
    
    return magic;
  }
}