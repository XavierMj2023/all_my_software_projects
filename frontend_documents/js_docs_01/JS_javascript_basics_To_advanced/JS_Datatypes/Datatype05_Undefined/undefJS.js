//Undefined Eg 1:
let undefeg1;

let sundefeg1 = "The Value is : "+undefeg1;
let sundefeg2 = " and The Type Of is : "+typeof(undefeg1);
let sundefeg3 = sundefeg1 + sundefeg2;
document.getElementById("undefe1").innerHTML = sundefeg3;

//Undefined Eg 2: Any variable can be emptied, 
//                by setting the value to undefined. The type will also be undefined.
let engine = "CX1500";
engine = undefined;
document.getElementById("undefe2").innerHTML = "After variable getting emptied, the type is : "+typeof(engine)+" and the value is : "+engine;
