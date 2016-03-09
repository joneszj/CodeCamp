var b1 = true;
while (b1) {
    b1 = false;
};

while (b1) {
    b1 = false;
};

var n1 = 0;
do {
    n1++;
}
while (n1 < 10);

for (var i = 0; i < 5; i++) {
    console.log(i);
};

//hmmmm... nothing shows
for (var i in obj) {
    console.log(i);
};

//notice obj is created after it is called in the for in loop?
//this by design in JS, all variables will be placed in their parent function or global scope
var obj = {
    prop1: true,
    prop2: false,
    prop3: 10,
    prop6: function () {
        return 100 * 3.14;
    }
}

for (var i in obj) {
    console.log(i);
};

console.log('done');