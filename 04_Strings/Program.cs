string first = "The cars we sell are";
string second = "BMW, Lexus, Mercedes and Tesla.";

string concatenatedResult = first + " " + second;

Console.WriteLine(concatenatedResult);

string firstName = "Jenn";
string lastName = "Williams";

string compositeResult = string.Format("Her name is {0} {1}", firstName, lastName);

Console.WriteLine(compositeResult);
Console.WriteLine("Her name is {0} {1}", firstName, lastName);

string interpolationResult = $"Her name is still {firstName} {lastName}!";
Console.WriteLine(interpolationResult);

//Challenge

string love = "I love to";
string loveCont = "eat macaroni!";

string macaroni = love + " " + loveCont;
Console.WriteLine(macaroni);

string code = "learn about coding.";
string coding = love + " " + code;
Console.WriteLine(coding);

string dog = " pet my dog.";
string petDog = love + dog;
Console.WriteLine(petDog);

string myFirstName = "Hunter";
string myLastName = "Browning";
string myNameIs = string.Format("Hello! My name is {0} {1}", myFirstName, myLastName);
Console.WriteLine(myNameIs);

string height = "5 foot 11";
string myHeight = string.Format("{0} stands at {1}.", myFirstName, height);
Console.WriteLine(myHeight);

string clothing = "Clothing Brand";
string myDream = string.Format("One of {0}'s goals is to start a {1}.", myFirstName, clothing);
Console.WriteLine(myDream);

string pizza = "Pizza";
string work = $"{myFirstName} used to work at a {pizza} place.";
Console.WriteLine(work);

string twoJobs = "Big Lots, and Chandler's Chevrolet";
string currentJob = $"Currently, {myFirstName} is working at {twoJobs}.";
Console.WriteLine(currentJob);