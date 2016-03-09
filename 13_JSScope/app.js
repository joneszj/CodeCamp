//this variable is in the global scope
//meaning this variable can be accessed to anywhere in ths app
//even scripts not in this script
var isGlobal = true;

function newScope() {
    //this variable has its scope set to this function
    //this is generally best practice
    var inFunctionScope = true;

    //the isGlobal variable is available here
    isGlobal = "is available here";
    
    //JS will creep up looking for a variable that is declared without the var keyword
    //if it cannot find it, it CREATES IT IN THE GLOBAL SCOPE, be aware of this
    hoistedVariable = 10;
    var nonHoistedVariable = 20;
};

//inFunctionScope is not available here
//hoistedVariable is available here
//nonHoistedVariable is not available here

//not understanding scope one may accidently call nonHoistedVariable expecting 20 but instead
//will find it is undefined (and at that created in the global namespace)