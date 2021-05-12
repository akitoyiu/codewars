using System;

public partial class Node
{
  public int Data;
  public Node Next;
  
  public Node(int data)
  {
    this.Data = data;
    this.Next = null;
  }
  
  public static int Length(Node head)
  {
    
    int result = 0;
    Node nnext = head;
    
    while( nnext != null){
      result += 1;
      nnext = nnext.Next;
    }
    return result;
  }
  
  public static int Count(Node head, Predicate<int> func)
  {
    //throw new NotImplementedException();
    int result = 0;
    Node nnext = head;
    
    while( nnext != null){
      if( func(nnext.Data) ) result += 1;
      nnext = nnext.Next;
    }
    return result;
  }
}