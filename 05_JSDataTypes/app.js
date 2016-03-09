"use strict"
var c = console;
c.log('JS has 6 primitive types and the object type.');
c.log('primitive types: boolean, null, undefined, number, string, symbol (ecma 6)');
c.log('object types: object, date, array, keyed collections (ecma 6)')
//anything that is not a primitive type, is an object
//more on primitive types https://developer.mozilla.org/en-US/docs/Web/JavaScript/Data_structures
//https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects

var isTrue = true;
var isFalse = false;
var isNull = null;
var n1 = 0;
var n2 = -20;
var n3 = 0.98765;
var s1 = "string";
var s2 = 'another string';
var obj = {
    prop1: true,
    prop2: false,
    prop3: isNull,
    prop4: n3,
    prop5: n1 + n2 + n3,
    prop6: function () {
        return 100 * 3.14;
    },
    prop7: s1 + s2
}

c.log('infinity');
//var infinite = 1e309;
c.log('NaN');
//You get  NaN when you try to perform an operation that assumes numbers but fails for some reason
var a = 10 * "f";
//a is NaN
//also, NaN == NaN is false. NaN doesn't equal anything

//floating point quirks
console.log(0.1 + 0.2);
console.log(0.1 + 0.2 == 0.3);
console.log(0.1 + 0.2);