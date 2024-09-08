//---------------------Constructor Method with Parent Class Constructor Intro------------------------------------------
class CompanyName{
    constructor(){
        this.CompanyName = "Aegis";
    }
    tryout(){
        console.log("Method from companyname class")
    }
}
class Employee extends CompanyName{
    constructor(id, name){
        super();
        this.id = id;
        this.name = name;
    }
}
var emp = new Employee(1, "John");
document.getElementById("cometh1").innerHTML = emp.id + emp.name + emp.CompanyName;
emp.tryout();

//---------------------------Constructor Method------------------------------------------
class CompanyName2{
    constructor(CompanyName){
        this.CompanyName = CompanyName;
    }
}
var emp2 = new CompanyName2("Aegis Startrek");
document.getElementById("cometh3").innerHTML = emp2.CompanyName;