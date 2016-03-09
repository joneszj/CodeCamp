console.log('Functions Yay!!!');
//when I think javascript, I think functions and objects!

//functions allow us to call resusable code!

//how do we make a function?
//{function} {name optional} ({parameters}) { 
//    { body } 
//    { return optional - if leftout the function returns undefined }
//}

function hello() {
    return "Hello";
};

//functions only return one value. If we need to retun multiple values we can return an array of those values

//how can I call a function?
hello();

//how do we pass variables to function parameters?
function sum(a, b) {
    var c = a + b;
    return c;
}

var result = sum(1, 5);

//what if we didn't pass one of the expect value to a parameter in a function? JS will insert undefined for the missing parameter(s)
var result = sum(1); // will return 1 + undefined which is NaN

//the built in arguments param in functions
//we can pass any number of arguments to functions and if we exceed the number or parameters for the function, and excess parameters are assigned to the arguments object
//we can use this to our advantage. ex:
function superSum() {
    var result;
    for (var i = 0; i < arguments.length; i++) {
        result += arguments[i];
    };
}

//anonymous functions
//anonymous funstions are functions without a name
//http://thoughtsonscripts.blogspot.com/2012/01/javascript-anonymous-functions.html

//callbacks
//when passing a function to a function, the passed function is called a callback function
//immediate functions
// ({function})()
//functions that return functions
//redefining functions
//closures
//http://stackoverflow.com/questions/111102/how-do-javascript-closures-work
//https://www.youtube.com/watch?v=yiEeiMN2Khs
//https://www.youtube.com/watch?v=ZqGFKcCcO-Y
//https://www.youtube.com/watch?v=71AtaJpJHw0