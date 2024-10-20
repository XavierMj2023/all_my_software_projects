//String Method Introduction
let text = 'StudyEasy';
let x = text;
console.log(x);

//String Method Introduction - charAt - Give Index and give us character
let text2 = 'StudyEasy';
let y = text2.charAt(8);
console.log(y);//y

//String Method Introduction - concat - Concatenation of Strings
let text3 = 'StudyEasy';
let z = text3.concat("Hi!! There  ");
console.log(z);//StudyEasyHi!! There 

//String Method Introduction - endsWith - EndsWith - To check whether it end with the string or character
let text4 = 'StudyEasy';
let a = text4.endsWith("Easy");
console.log(a);//true

//String Method Introduction - endsWith - EndsWith - To check whether it end with the string or character
let text5 = 'StudyEasy';
let b = text5.endsWith("easy");
console.log(b);//false

//String Method Introduction - indexOf
let text6 = 'StudyEasy';
let c = text6.indexOf('y');
console.log(c);//4

//String Method Introduction - lastIndexOf
let text7 = 'StudyEasy';
let d = text7.lastIndexOf('y');
console.log(d);//8

//String Method Introduction - replace - replace string
let text8 = 'StudyEasy';
let e = text4.replace("Easy", "Hard");
console.log(e);//StudyHard

//String Method Introduction - replace - replace character
let text9 = 'StudyEasy';
let f = text9.replace('y', 'z');
console.log(f);//StudzEasy

//String Method Introduction - replaceAll - replace All
let text10 = 'StudyEasy';
let g = text10.replaceAll('y', 'z');
console.log(g);//StudzEasz

//Split
let txt1 = "Study, Easy, Hard";
let s = txt1.split(',');
console.log(s);//(3) ['Study', ' Easy', ' Hard']

//Split
let txt2 = "Study, Easy, Hard";
let s2 = txt2.split('y');
console.log(s2);//(3) ['Stud', ', Eas', ', Hard']

//Split
let txt3 = "StudyEasyHard";
let s3 = txt3.split('Easy');
console.log(s3);//(2) ['Study', 'Hard']

//Slice - 5th character is not included
let txt4 = "StudyEasy";
let s4 = txt4.slice(0, 5);
console.log(s4);//Study

//Slice
let txt5 = "StudyEasy";
let s5 = txt5.slice(1, 5);
console.log(s5);//tudy

//Slice
txt5 = "StudyEasy";
s5 = txt5.slice(5);
console.log(s5);//Easy

//Slice
txt5 = "StudyEasy";
s5 = txt5.slice(-4);
console.log(s5);//Easy

//Slice
txt5 = "StudyEasy";
s5 = txt5.slice(-2);
console.log(s5);//sy

//Substring -  Slice and SubString are similar, but it does not accept negative values
txt5 = "StudyEasy";
s5 = txt5.substring(5);
console.log(s5);//Easy

//Substring -  Slice and SubString are similar, but it does not accept negative values
txt5 = "StudyEasy";
s5 = txt5.substring(0, 5);
console.log(s5);//Study