//I placed the console obj in a variable c
var c = console;

c.log('Hello, from console in a variable!');

var v1 = 10;
var v2 = "name";
var v3 = 'Zachary';
var v4 = [0, "Z", 15, 0.9];
var v5 = function () {
    return "Hello again";
};
//we dont always need to use the term var to create a variable
v6 = {
    firstName: "Zachary",
    lastName: "Jones",
    age: 29,
    relationalStatus: "Single"
}

var caseMatters = "Upper Matters";
var Casematters = "Upper Case";

c.log(v6.firstName + " is " + v6.relationalStatus);
c.log(v5());
//Variables must start with a letter (or $ and _ but only use those if you know what you are doing)

//if a variable does not have a value initialized to it, its type will be undefined
var isUndefined; //is undefined