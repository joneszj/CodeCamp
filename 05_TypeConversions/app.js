"use strict"
//http://www.w3schools.com/js/js_type_conversion.asp
//Number() converts to a Number, String() converts to a String, Boolean() converts to a Boolean.
//we can use typeof to get the type of a variable or object
var c = console;
var n1 = 9876;
c.log(typeof (n1));
var isFalse = false;
c.log(typeof isFalse);
var notANumber = NaN;
c.log(typeof notANumber); //but its type is :p

var n1AsString = String(n1);
c.log('n1 value: ' + n1 + ', n1 type: ' + typeof n1);
c.log('ising String(n1) to n1AsString, value: ' + n1 + ', type: ' + typeof n1);
var trueString = 'true';
c.log(typeof trueString);
c.log('convert to bool: ' + typeof Boolean(trueString))

//parsing
parseInt()
parseFloat()
isNaN()
isFinite()
eval() //takes a string, and executes it as javascript

//parsing will attempt to convert a given string until it reaches an unexpected value... 
//so '123abc' in parseInt => 123, '123abc' in Number() => undefined

//http://stackoverflow.com/questions/4564158/what-is-the-difference-between-parseintstring-and-numberstring-in-javascript