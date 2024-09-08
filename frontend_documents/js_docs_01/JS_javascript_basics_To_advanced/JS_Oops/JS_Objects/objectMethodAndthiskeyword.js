//------------------------Accessing Object methods------------------------------------
const pertMethod = {
    first : "Mj",
    last : "Desh",
    full : function(){
        return this.first + " " +this.last; 
    }
};
document.getElementById("obj1").innerHTML = pertMethod.full;

document.getElementById("obj2").innerHTML = pertMethod.full();

//--------------------Displaying JS objects using Object.values() and JSON.stringfy()------------------------------
const pertMethod2 = {
   id : 501,
   paid : "A001",
   name : "Sandra Hellman"
};
document.getElementById("js_objval").innerHTML = "Object.values() : "+Object.values(pertMethod2);

document.getElementById("js_jsoval").innerHTML = "JSON.stringfy() : "+JSON.stringify(pertMethod2);

//--------------------Object Accessors -Getters and Setters------------------------------
const pertMethod3 = {
    id : 6701,
    name : "John Cena",
    age : 60,
    addres : {
        street : "St John",
        state : "California",
        country : "USA",
        pincode : "23-64-700"
    },
    profession : "Actor, wrestler",

    //Using Getter
    get det(){
        return this.age;
    },
 };
document.getElementById("js_get").innerHTML = "Accessing Object and getting age property value using getter : "+pertMethod3.det;


const pertMethod4 = {
    id : 6701,
    name : "John Cena",
    age : "",
    addres : {
        street : "St John",
        state : "California",
        country : "USA",
        pincode : "23-64-700"
    },
    profession : "Actor, wrestler",

    //Using Setter
    set jage(agedet){
        this.age = agedet;
    }
 };
document.getElementById("js_set1").innerHTML = "Original value of age is  : "
+pertMethod4.age;

pertMethod4.age = 54;

document.getElementById("js_set2").innerHTML = "New Value fof age after calling setting is  : "
+pertMethod4.age;

//---------------------------Object.defineProperty()-------------------------------------
const obj5 = {counter : 5};
Object.defineProperty(obj5, "reset",{
    get : function(){
        this.counter = 0;
    }
});
Object.defineProperty(obj5, "increment",{
    get : function(){
        this.counter++;
    }
});
Object.defineProperty(obj5, "decrement",{
    get : function(){
        this.counter--;
    }
});
Object.defineProperty(obj5, "add",{
    set : function(value){
        this.counter += value;
    }
});
Object.defineProperty(obj5, "subtract",{
    set : function(value){
        this.counter -= value;
    }
});
//Play with counter
document.getElementById("defineProperty1").innerHTML = "The Intial Value : "+obj5.counter;

obj5.reset;

document.getElementById("defineProperty2").innerHTML = "After calling reset() : "+obj5.counter;

obj5.add = 10;

document.getElementById("defineProperty3").innerHTML = "After calling add() : "+obj5.counter;