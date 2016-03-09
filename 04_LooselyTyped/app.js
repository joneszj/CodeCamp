var c = console;

var number = 5;
var stringNumber = '5';
var whatAmI = number + stringNumber;
c.log(whatAmI);
var whatAmINow = number - stringNumber;
c.log(whatAmINow);
var obj = { v: 1, b: 2 }
var whatAmIAgain = obj + whatAmINow;
c.log(whatAmIAgain);

var x;               // Now x is undefined
x = 5;           // Now x is a Number
x = "John";      // Now x is a String
