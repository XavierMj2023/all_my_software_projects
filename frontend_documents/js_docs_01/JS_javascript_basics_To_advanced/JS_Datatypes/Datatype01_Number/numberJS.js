//Number Eg 1:
document.getElementById("numeg1").innerHTML = 6;

//Number Eg 2:
document.getElementById("numeg2").innerHTML = 60.89;

//Number Eg 3: - Extra large or extra small numbers can be written with scientific (exponent) notation
let exponum = 123e5;
document.getElementById("numeg3").innerHTML = exponum;

//Number Eg 4: - Extra large or extra small numbers can be written with scientific (exponent) notation
let exponum2 = 123e-5;
document.getElementById("numeg4").innerHTML = exponum2;

//Number Eg 5: - Smallest positive number greater than zero that JavaScript can represent.
var smallPositiveNumber = Number.MIN_VALUE;
document.getElementById("numeg5").innerHTML = smallPositiveNumber;

//Number Eg 6: - Largest positive number that JavaScript can represent.
var largePositiveNumber = Number.MAX_VALUE;
document.getElementById("numeg6").innerHTML = largePositiveNumber;

//Number Eg 7: - Log the maximum safe integer.
var rangeNumber = Number.MAX_SAFE_INTEGER;
document.getElementById("numeg7").innerHTML = rangeNumber;



//Number Eg 8: - Infinity (or -Infinity) is the value JavaScript will return if you calculate a 
//               number outside the largest possible number..
var infin_val = 2;
var txt = " ";
while(infin_val != Infinity){
    infin_val = infin_val * infin_val;
    txt = txt + infin_val + "<br/>"
}
document.getElementById("numeg9").innerHTML = txt; 

//Number Eg 9: Infinity Type returns Number.
document.getElementById("numeg10").innerHTML = "Return Type of Infinity : "+typeof(Infinity);

//Number Eg 10: Numeric constants as hexadecimal if they are preceded by 0x.
var hexaNum = 0xFF;
document.getElementById("numeg11").innerHTML = "Hexadecimal : "+hexaNum;

//Number Eg 11: Numbers can also be defined as objects with the keyword new.
let numnew = new Number(345);
document.getElementById("numeg12").innerHTML = "Newly Created Number object type  is : "+typeof(numnew) + " and the number is : "+numnew;

//Number Eg 12: NaN is a number: typeof NaN returns number.
document.getElementById("numeg13").innerHTML = typeof(NaN);