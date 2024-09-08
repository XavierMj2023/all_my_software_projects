//Boolean Eg 1:
let boolTrue = true;
document.getElementById("booleg1").innerHTML = boolTrue;

//Boolean Eg 2:
let boolFalse = false;
document.getElementById("booleg2").innerHTML = boolFalse;

//Boolean Eg 3 - You can use the Boolean() function to find out if an expression (or a variable) is true.
let isBoolOrNot = Boolean(10 < 9);
document.getElementById("booleg3").innerHTML = isBoolOrNot;

//Boolean Eg 4 - Booleans as Objects
let BoolAsObj = new Boolean(false);
document.getElementById("booleg4").innerHTML = "Boolean as Object type is : "+typeof(BoolAsObj)+" and the value is : "+BoolAsObj;

//Boolean Eg 5 - Comparing two JavaScript objects always return false.
let x = new Boolean(false);
let y = new Boolean(false);
let BoolCompare2Objects = (x === y);
let strres1 = "<p>The Object 1 is : "+x+" and the type is : "+typeof(x) +"</p>";
let strres2 = "<p>The Object 2 is : "+y+" and the type is : "+typeof(y)+"</p>";
let strres3 = "<p>The result is : "+BoolCompare2Objects+"</p>";
document.getElementById("booleg5").innerHTML = strres1 + strres2 + strres3;

//Boolean Eg 6 - An empty string (“") will be converted to false, and any other string will be converted to true.
let emptyStrBool1 = "";
document.getElementById("booleg6").innerHTML = 
"The Type is : "+typeof(emptyStrBool1)
+"<br/>The value is : "+emptyStrBool1
+"<br/>The Boolean converted value is : "+Boolean(emptyStrBool1);
;

//Boolean Eg 7 - An empty string (“") will be converted to false, and any other string will be converted to true.
let emptyStrBool2 = "Manoj";
document.getElementById("booleg7").innerHTML = 
"The Type is : "+typeof(emptyStrBool2)
+"<br/>The value is : "+emptyStrBool2
+"<br/>The Boolean converted value is : "+Boolean(emptyStrBool2);
;

//Boolean Eg 8 - Numbers: Zero (0) and NaN (Not a Number) will be converted to false, and any other number will be converted to true.
let numBool = 0;
document.getElementById("booleg8").innerHTML = 
"The Type is : "+typeof(numBool)
+"<br/>The value is : "+numBool
+"<br/>The Boolean converted value is : "+Boolean(numBool);
;

//Boolean Eg 9 - Numbers: Zero (0) and NaN (Not a Number) will be converted to false, and any other number will be converted to true.
let nanBool = NaN;
document.getElementById("booleg9").innerHTML = 
"The Type is : "+typeof(nanBool)
+"<br/>The value is : "+nanBool
+"<br/>The Boolean converted value is : "+Boolean(nanBool);
;

//Boolean Eg 10 - Numbers: Zero (0) and NaN (Not a Number) will be converted to false, and any other number will be converted to true.
let nBool = 34;
document.getElementById("booleg10").innerHTML = 
"The Type is : "+typeof(nBool)
+"<br/>The value is : "+nBool
+"<br/>The Boolean converted value is : "+Boolean(nBool);
;

//Boolean Eg 11 - Numbers: Zero (0) and NaN (Not a Number) will be converted to false, and any other number will be converted to true.
let nMinusZero = -0;
document.getElementById("booleg11").innerHTML = 
"The Type is : "+typeof(nMinusZero)
+"<br/>The value is : "+nMinusZero
+"<br/>The Boolean converted value is : "+Boolean(nMinusZero);
;

//Boolean Eg 12 - Undefined will be converted to false.
let undBool;
document.getElementById("booleg12").innerHTML = 
"The Type is : "+typeof(undBool)
+"<br/>The value is : "+undBool
+"<br/>The Boolean converted value is : "+Boolean(undBool);
;