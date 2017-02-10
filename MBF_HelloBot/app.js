/**
 * Bot Builder is a framework for building conversational applications (“Bots”) using Node.js
 */
var builder = require('botbuilder');

/**
 * The UniversalBot class implements all of logic to manage the bots’ conversations with users. You can bind the UniversalBot to a variety of channels using connectors.
 */
var connector = new builder.ConsoleConnector().listen();

/**
 * Bot Builder breaks conversational applications up into components called dialogs.

    If you think about building a conversational application in the way you’d think about building a web application, each dialog can be thought of as route within the conversational application.
 */
var bot = new builder.UniversalBot(connector);

bot.dialog('/1', function (session) {
    session.sendTyping();
    session.send('Can I assist you in finding a program?')
});

/*
    By passing an array of functions for our dialog handler a waterfall is setup where the results of the first function are passed to the input of the second function. We can chain together a series of these functions into steps that create waterfalls of any length.

    To actually wait for the users input we’re using one of the SDK’s built in prompts.
*/
bot.dialog('/', [
    function (session) {
        session.sendTyping();
        builder.Prompts.text(session, 'Hello, I am the BiskBot! I can assist you in finding any program you are interested in. What kind of program are you intested in?');
    },
    function (session, results) {
        session.send('Great! One moment while I find what I can about %s!', results.response);
    }
]);

bot.dialog('/programInformation', [
    function (session) {
        session.sendTyping();
        builder.Prompts.text(session, 'Hello, I am the BiskBot! I can assist you in finding any program you are interested in. What kind of program are you intested in?');
    },
    function (session, results) {
        session.send('Great! One moment while I find what I can about %s!', results.response);
    }
]);

bot.dialog('/programInformation', [
    function (session) {
        session.sendTyping();
        builder.Prompts.text(session, 'Hello, I am the BiskBot! I can assist you in finding any program you are interested in. What kind of program are you intested in?');
    },
    function (session, results) {
        session.send('Great! One moment while I find what I can about %s!', results.response);
    }
]);