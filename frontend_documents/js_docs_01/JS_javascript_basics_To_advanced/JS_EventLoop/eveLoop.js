//Event Loop
function first(){
    console.log("First");
}
function second(){
    setTimeout(() => {
        console.log("second");
    });
}
function third(){
    Promise.resolve(1).then(() => {
        console.log("third");
    });
}
function fourth(){
    console.log("fourth");
}

//Call functions
first();
second();
third();
fourth();