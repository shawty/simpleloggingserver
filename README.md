# simple logging server
An ultra simple remote log message server written in Blazor and Dotnet core 3

# what is it?
Exactly as the headline above says.

I needed a remote way of viewing console log and error output from a javascript project I've been working on.

The target device for the JS code was not a traditional desktop based environment, so no F12 tools, no console or anything like that, which meant every time an error occured the script would just stop and I'd have no visability what so ever of what was going on.

So I wrote this, ultra simple tool.

It's nothing fancy, it doesn't have loads of bells and whistles, it does exactly what it says on the tin.

You run it, then from your remote scripts/apps you post to it's logging endpoint, and a signalr hub built into the app pushes that message to the blazor client for display.

To send a log, you post the following JSON:

***{ "Category":"DEBUG", "Message":"Message text here..." }***

to

***/logger/postlogmessage***

Category can be one of:

ERROR
DEBUG
INFO
WARNING

These correspond to the 4 rules in the site.css file with the same names.

If you use a css name not present or make it an empty string, you'll get plain black text on a white background.

You can add your own categories and colouring by adding a rule in the css then using that rule name as your category.

# WARNING WARNING WARNING!!!!

The server has a completley open CORS setup (Wildcard star), and since the category is poked directly into the HTML when an entry is added to the log, then there exists the possability to send all sorts of nasty stuff in the post payload which will then be poked into the page without any checking what so ever.

I don't think I need to say this to most, but this is a huge security risk, so DO NOT put this on a public server with an I.P. facing out onto the general internet.

It's designed purely for use inside a local network while debugging, it's NOT DESIGNED to be left running on a public server to collect logs from production apps.

The server is intentionally very simple, it does one job, and only one job, you could if you wish fork it and secure it up to do other things, but it's intended for this one simple purpose that I needed it for, nothing else.

# what do I mean by MIT(ish)
You'll see the licence is MIT, this is the closest to the licence I want to use, which to be honest goes some thing like "I don't give a rat's ass what you do with this licence"

If you blow your leg off, or don't heed my warning above, it's your own fault, if it tries to climb out your PC and eat your pet hamster I accept no responsability and there is no warranty :-)

What you see is what you get, if you wanna fork it and use it to build a better logging server go ahead.  It would be nice if you do tip me a nod in any info/credits for anything you use it for but I'm not going to hold you to it, nor am I going to make you include this readme or licence text.

Pretty simple.

If I'm around on twitter  @shawty_ds  and you wanna ask me a question about it, and I'm not stupidly busy (As I usually am) then I may answer you, and I may answer issues/questions on here and such like if I have time, if you NEED AN URGENT FIX or require immediate support for the app then it's simple you contact me privately and we discuss my fee for doing a specific bit of paid work for you.

otherwise, enjoy...

shawty
