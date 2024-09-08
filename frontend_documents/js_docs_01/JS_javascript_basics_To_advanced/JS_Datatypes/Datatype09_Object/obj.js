//Object Eg 1 - Object Defination
let objDemo = {year : 2024, class : "master", name : "Manoj" };
document.getElementById("objVal1").innerHTML = "The object is : "+objDemo+" and the type is : "+typeof(objDemo);

//Object Eg 2 - An object definition can span multiple lines.

//Object Eg 3 - Accessing Object Properties
sty1 = "<p>Syntax with objectName.propertyName (Property Access)</p>";
sty2 = "<p> Accessing the property class : "+objDemo.class+"</p>"
sty3 = "<p>The Type is : "+typeof(objDemo.class)+"</p>"

sty4 = sty1 + sty2 + sty3;
document.getElementById("objVal3").innerHTML = sty4;

//Object Eg 4 - Accessing Object Properties
sty1 = "<p>Syntax with objectName[propertyName] (Property Access)</p>";
sty2 = "<p> Accessing the property class : "+objDemo["class"]+"</p>"
sty3 = "<p>The Type is : "+typeof(objDemo["class"])+"</p>"

sty4 = sty1 + sty2 + sty3;
document.getElementById("objVal4").innerHTML = sty4;

//Object Eg 5 - Adding properties
//Properties can be added to an object by using dot notation or bracket notation.
objDemo.myStatus = true;
sty101 = "Property myStatus added . Accessing the value of myStatus in object objDemo is : "+objDemo.myStatus;
document.getElementById("objVal5").innerHTML = sty101;

//Object Eg 6 - Object methods

const objDemo2 = {
    year : 2024, 
    class : "Master", 
    name : "Manoj" , 
    fullStrRes : function(){
       var streturn = `The Rank secured in the year ${this.year} by ${this.name} is ${this.class}. `
       return streturn;
    } 
};
document.getElementById("objVal6").innerHTML = objDemo2.fullStrRes();