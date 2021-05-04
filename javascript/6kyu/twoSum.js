function twoSum(numbers, target) {
    // ...
    
    var i, j;
    for( i = 0; i < numbers.length; i++){
      for( j = i+1; j < numbers.length; j++){
        if (  numbers[i] + numbers[j] == target ){
          return Array(i, j);
        }
      }
    }
  }