//https://nodejs.org/api/readline.html
//imports cin functionality
const readline = require('readline');

const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});

function prompt(prompt) {
    rl.question(prompt + '\n', function (input) {
        //do something
        debugger;
        rl.close();
    });
}

prompt('How old are you?');

//the browser is an event driven environment as opposed to procedurally driven
//https://en.wikipedia.org/wiki/Event-driven_programming