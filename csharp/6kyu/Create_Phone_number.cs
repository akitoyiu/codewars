public class Kata
{
  public static string CreatePhoneNumber(int[] numbers)
  {
    string result = "(";
    for (int i = 0; i < numbers.Length; i++){
      result += numbers[i];
      if(i == 2) result += ") ";
      if(i == 5) result += "-";
    }
    
    return result;
  }
}