//--------------------------Primtive Value------------------------------------
var prim = 34;
document.getElementById("primVal").innerHTML = prim;

//----------Create JS Object or Object Literal - List of name-value pairs inside {}-----------
const pee = {
    fi : "John",
    la : "Saga",
    age : 21
};
document.getElementById("objVal").innerHTML = pee;

//----------------Create Object and then add properties using new.-----------------------
const per = new Object();
per.fi = "Johnny";
per.la = "Mami";
per.age  = 22;
document.getElementById("objVal2").innerHTML = per;

//-------------------------Objects are Mutable------------------------------------------
const pert = {
    first : "Mj",
    last : "Desh",
    age : 51,
    id : "SD001HYU"
};
const dupobj = pert;
dupobj.age = 64;
document.getElementById("objVal3").innerHTML = "The age of object pert :"+pert.age;
document.getElementById("objVal4").innerHTML = "The age of object dupobj :"+dupobj.age;

//-------------------------Object Properties--------------------------------------------
const pert2 = {
    first : "Mj",
    last : "Desh",
    age : 51,
    id : "SD001HYU"
};
let txt = "";
for(let key in pert2){
    txt += pert2[key] + " ";
}
document.getElementById("objVal5").innerHTML = txt;

//--------------------------Add new properties----------------------------------------------
const pert3 = {
    first : "Mj",
    last : "Desh",
};
let txt2 = "";

//Adding property age using dot operator.
pert3.age = 37;

for(let propertyAccess1 in pert3){
    txt2 += pert3[propertyAccess1] + " ";
}
document.getElementById("objVal6").innerHTML = txt2;

//-------------------------delete keyword---------------------------------------------------
const pert4 = {
    first : "Mj",
    last : "Desh",
};

//Deleting property using delete keyword.
delete pert.last;

let txt3 = "";
for(let propertyAccess2 in pert4){
    txt3 += pert4[propertyAccess2]+" ";
}
document.getElementById("objVal7").innerHTML = pert.last;
document.getElementById("objVal8").innerHTML = txt3;

//-------------------------Nested Objects-----------------------------------------------------
const pert5 = {
    first : "Mj",
    last : "Desh",

    //Nested Object
    cars : {
        car1 : "Ford",
        car2 : "Bhutiu",
        car3 : "Audi"
    }
};
document.getElementById("objVal9").innerHTML = pert5.cars["car1"];
console.log(pert5.cars); 

//-------------------------Nested Array and Objects-----------------------------------------------------
let txt4 = "";
const perArrayAndObj = {
    first : "Mj",
    last : "Desh",

    //Array of objects in object
    carsExample : [
        { name : "Ford", models : ["Fiesta", "focus", "LP90"]},
        { name : "Fo", models : ["Fie", "FOS", "LP99"]},
        { name : "Meru", models : ["Mkl", "P90"]}
    ]
};
for(let i in perArrayAndObj.carsExample){
    txt4 += "<h2>"+perArrayAndObj.carsExample[i].name+"</h2>";
    for(let j in perArrayAndObj.carsExample[i].models){
        txt4 += perArrayAndObj.carsExample[i].models[j]+"<br>";
    }
}
document.getElementById("objVal11").innerHTML = txt4;