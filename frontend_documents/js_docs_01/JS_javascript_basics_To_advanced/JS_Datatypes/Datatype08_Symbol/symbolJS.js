//Symbol Value 1 
let sVal = Symbol('foo');
let sV1 = "<p>The Data is : "+sVal.toString()+"</p>";
let sV2 = "<p>The Type is : "+typeof(sVal)+"</p>";
document.getElementById("symVal1").innerHTML = sV1 + sV2;
console.log(sVal);
console.log(sVal.toString());
console.log(typeof(sVal));

//Symbol Value 2
//--------------------------------------------------
//Creating a symbol
let symdemo = Symbol('firstName');

//Creating an object with a symbol property
let WeatherReport = {
    [symdemo] : 'Marie',
    lastName : 'Sonia Veridigueria',
    age : 34 
};

// Accessing the symbol property
strAccessSymbol = WeatherReport[symdemo];

let st1 = "<p> The Value from the object is : "+strAccessSymbol+"</p>";
let st2 = "<p> The Type  is : "+typeof(strAccessSymbol)+"</p>";
let st3 = "<p> The Value of the Symbol is : "+symdemo.toString()+"</p>";
let st4 = "<p> The Type is : "+typeof(symdemo)+"</p>";

document.getElementById("symVal2").innerHTML = st1 + st2 + st3 + st4;