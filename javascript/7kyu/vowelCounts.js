function getCount(str) {
    var vowelsCount = 0;
    
    // enter your majic here
    var i;
    for(i = 0; i < str.length; i++){
      switch(str[i].toLowerCase()){
          case "a":
          case "e":
          case "i":
          case "o":
          case "u":
            vowelsCount++;
            break;
      }
    }
    
    return vowelsCount;
  }