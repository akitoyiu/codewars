// TODO
Array.prototype.square = function () {
    let input = this;
    let result = Array();
    
    for (let i = 0; i < input.length; i++) {
        result.push ( Math.pow(input[i], 2) );
    }
    return result;
}

Array.prototype.cube = function () {
    let input = this;
    let result = Array();

    for (let i = 0; i < input.length; i++) {
        result.push ( Math.pow(input[i], 3) );
    }
    return result;
}

Array.prototype.sum = function () {
    let input = this;
    let result = 0;
  
  for (let i = 0; i < input.length; i++) {
        result += input[i]
    }

    return result;
}

Array.prototype.average = function () {
    let input = this;

    let result = 0;
  
  for (let i = 0; i < input.length; i++) {
        result += input[i]
    }

    return result / input.length;
}

Array.prototype.even = function () {
    let input = this;
    let result = Array();

    for (let i = 0; i < input.length; i++) {
        if( input[i] %2 == 0 ) result.push ( input[i]);
    }
    return result;
}

Array.prototype.odd = function () {
    let input = this;
let result = Array();

    for (let i = 0; i < input.length; i++) {
        if( input[i] %2 != 0 ) result.push ( input[i]);
    }
    return result;
}