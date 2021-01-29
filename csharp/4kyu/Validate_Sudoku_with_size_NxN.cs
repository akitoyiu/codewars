using System;


class Sudoku
{
  
  public int[][] sudokuData;
  
  public Sudoku(int[][] _sudokuData)
  {
    //Constructor here
    this.sudokuData = _sudokuData;
  }

  public bool IsValid()
  { 
    int i, j, k, y, z, N, N2, mCheck, sCheck;
    string [] cArr;
    
    string mStr, cStr;
    
    N = sudokuData.Length;
    
    cArr = new string[N];
    
    if( (Math.Sqrt(N) % 1) != 0) return false;
    
    N2 = (int)(Math.Sqrt(N));
    
    mStr = "";
    mCheck = 0;
    sCheck = 0;
    for(i =0; i<N; i++){
      mStr = mStr + (i+1).ToString("D2");
      mCheck += (i + 1);
    }
    
    for(i = 0; i < N; i++){
      if( sudokuData[i].Length != N ) return false;
      
      sCheck = 0;
      for(j = 0; j < N; j++){
        cArr[j] = sudokuData[i][j].ToString("D2");
        sCheck += sudokuData[i][j];
      }
      Array.Sort(cArr);
      cStr = string.Join("", cArr);
      //Console.WriteLine($"mStr: {mStr}, cStr: {cStr}, mCheck: {mCheck}, sCheck{sCheck}");
      if ((mStr != cStr) || (sCheck != mCheck)) return false;
    }
    
    for(j = 0; j < N; j++){
      sCheck = 0;
      for(i = 0; i < N; i++){
        cArr[i] = sudokuData[i][j].ToString("D2");
        sCheck += sudokuData[i][j];
      }
      Array.Sort(cArr);
      cStr = string.Join("", cArr);
      //Console.WriteLine($"mStr: {mStr}, cStr: {cStr}, mCheck: {mCheck}, sCheck{sCheck}");
      if ((mStr != cStr) || (sCheck != mCheck)) return false;
    }
    
    for(z=0; z<N2; z++){
      for(y=0; y<N2; y++){
      k = 0;
      sCheck = 0;
      
      for(i=0; i<N2; i++){
        for(j=0; j<N2; j++){
          cArr[k] = sudokuData[(z*N2)+i][(y*N2)+j].ToString("D2");
          sCheck += sudokuData[(z*N2)+i][(y*N2)+j];
          k++;
        }
      }
      
      Array.Sort(cArr);
      cStr = string.Join("", cArr);
      //Console.WriteLine($"mStr: {mStr}, cStr: {cStr}, mCheck: {mCheck}, sCheck{sCheck}");
      if ((mStr != cStr) || (sCheck != mCheck)) return false;
    }
    }
    
    //Console.WriteLine($"N Size: {sudokuData.Length}, N1 Size: {sudokuData[0].Length}");
    
    return true;
    //throw new NotImplementedException();
  }
}