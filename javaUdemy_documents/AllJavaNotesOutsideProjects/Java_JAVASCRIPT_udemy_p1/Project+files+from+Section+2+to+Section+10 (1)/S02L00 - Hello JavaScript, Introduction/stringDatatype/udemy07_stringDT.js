//String Datatype - string - case 1
let brand = "Study '' Easy";
let founder = "Chaand";
console.log(brand);//Study '' Easy

//String Datatype - string - case 2
// + - Concatenation of the strings
let x = "The Brand" + brand + 'is founded by' + founder;

//String Datatype - string - case 3
//The spaces after the plus is not encountered and reflected in output
console.log( "The" + brand + 'is founded by' + founder)

//String Datatype - string - case 4
//The spaces after the plus is not encountered and reflected in output
console.log( "The " + brand + ' is founded by ' + founder)

//String Datatype - string - case 5
//The spaces after the plus is not encountered and reflected in output
console.log( "The Brand " + brand + ' is founded by ' + founder)

//String Datatype - string - case 6
console.log( x)

//Access string character
console.log(x[0]);//T

//Access string character - space character
console.log(x[3]);//space

//Access string character - 12
console.log(x[12]);//d

//Property - Gives a value - Length
console.log(x.length);//41