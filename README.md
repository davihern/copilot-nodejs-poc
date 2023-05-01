# Activate GitHub Copilot using Nodejs 

Demo project for running labs to evaluate Copilot viability

## Pre-requisites

**CoPilot access**

A 60 day trial can be requested here: https://github.com/github-copilot/signup

**VisualStudio Code**

https://code.visualstudio.com/



## Goal

The goal of a GitHub Copilot Activate is to learn how to use it, using an exercise that consist of building a web server using Nodejs with different functionalities.

 Copilot is an AI-powered code assistant that helps developers write better code faster. It uses machine learning models trained on billions of lines of code to suggest whole lines or entire functions based on the context of what you’re working on. By using Copilot, you can learn how to write better code and improve your productivity.

Remember:

- As you type GitHub Copilot will make suggestions, you can accept them by pressing Tab.
- If nothing shows up after Copilot write some lines , press enter and wait a couple of seconds.
- On Windows or Linux, press Ctrl + Enter, then click Open GitHub Copilot.

## Instructions

- Download to local the exercicefile folder

Choose one of the two options (Node or .net) based on your preferred programming language or the language you would like to learn:

- Option A (Node):

Follow this instructions to set up the project and then continue with the instructions below (Exercise section): https://github.com/davihern/copilot-nodejs-poc/blob/main/SetupNodeproject.md

- Option B (.net):

Follow this instructions to set up the project and then continue with the instructions below (Exercise section): https://github.com/davihern/copilot-nodejs-poc/blob/main/exercisefiles/net/README.md

## Exercise

The exercise consist of building various functionality.

We will create automated tests to check that the functionality is correctly implemented.

The requests/methods that the application must attend are the following:

- **/Get** : 

Return a hello world message

- **/DaysBetweenDates**: 

Calculate days between two dates

receive by (querystring/parameters) **date1** and **date2** , and calculate the days that are between those two dates.

- **/Validatephonenumber**: 

Receive by (querystring/parameters) **phoneNumber** 
validate phoneNumber with Spanish format, for example +34666777888
if phoneNumber is valid return "valid"
if phoneNumber is not valid return "invalid"

- **/ValidateSpanishDNI**:

Receive by (querystring/parameters) **dni**
calculate DNI letter
if DNI is valid return "valid"
if DNI is not valid return "invalid"



- **/ReturnColorCode**:

Receive by (querystring/parameters) **color**

read colors.json file and return the rgba field

get color var from querystring

iterate for each color in colors.json to find the color

return the code.hex field

- **/TellMeAJoke**:

Make a call to the joke api and return a random joke using axios
        

- **/MoviesByDirector**:

(this will require to browse to https://www.omdbapi.com/apikey.aspx and request a FREE API Key)

Receive by (querystring/parameters) **director**

Make a call to the movie api  and return a list of movies of that director using axios

Return the full list of movies

- **/ParseUrl**:

Receive by (querystring/parameters) **someurl**

Parse the url and return the protocol, host, port, path, querystring and hash

Return the parsed host

- **/ListFiles**:

Get the current directory

Get the list of files in the current directory

Return the list of files

- **/GetFullTextFile**:

Read sample.txt and return lines that contains the word "Fusce"

(becareful with this implementation, since this normally reads the full content of the file before analizing it, so memory usage is high and may fail when files are too big, next method will read file in a different way)

- **/GetLineByLinefromtTextFile**:

Read sample.txt line by line

Create a promise to read the file line by line, and return a list of lines that contains the word "Fusce"

Return the list of lines

- **/CalculateMemoryConsumption**:

Return the memory consumption of the process in GB, rounded to 2 decimals

- **/MakeZipFile**:

Using (zlib for node, or ZipFile for .net) create a zip file called (sample.gz/sample.zip) that contains sample.txt

- **/RandomEuropeanCountry**:

Make an array of european countries and its iso codes

Return a random country from the array

Return the country and its iso code


## GitHub Copilot Labs exercises

These tasks can be performed with the Copilot labs add-in, currently PREVIEW functionality, expect some bugs.


Make sure to install the GitHub Copilot labs extension: https://marketplace.visualstudio.com/items?itemName=GitHub.copilot-labs

Open GitHub Copilot extension to see all the available functionality.

- **Explain**

Select the line that has the regex in the validatePhoneNumber method, in EXPLAIN section click "Ask Copilot". You will see an explanation detailing what does each different notations in the regular expression.

- **Language translation**

Select some source code, like this line:

    var randomCountry = countries[Math.floor(Math.random() * countries.length)];

In "LANGUAGE TRANSLATION" section select python and click "As Copilot" button, you should see new code in python (sometimes you'll need to click twice in the button).

- **Readable**

Select the content of MakeZipFile

In the BRUSHES section, click in "Readable", see how comments are added and also variables that have short names are renamed to a more understandable name.


-- **Add Types**

TBD

-- **Fix Bug**

In the exercise, there should be no bugs, since most of the code will be done by CoPilot. We can force some errors and then test the debug functionality.

Force some errors like:

In a for loop change the beginning to (change the 0 for a 1):

    for (var i = 1

select the text and in the "BRUSHES" section press the "Fix Bug" button.

-- **Debug**

Select some lines of text that contains variables, like:

    var queryData = url.parse(req.url, true).query;
    var color = queryData.color;
    var colorFound = "not found";

select the text and in the "BRUSHES" section press the "Debug" button.


-- **Clean**

TBD


-- **List steps**

Select some lines of code that do not have comments and in the  "BRUSHES" section press the "List steps" button.


-- **Make robust**

Select some text that comes from input, for example variables that come from querystring:

        var queryData = url.parse(req.url, true).query;
        var date1 = queryData.date1;
        var date2 = queryData.date2;

In the  "BRUSHES" section press the "Make robust" button, you will see that additional validation is added.

-- **Chunk**

TBD

-- **Document**

Select some line (e.g. a method or the beggining of the if clause)

    else if (req.url.startsWith('/GetFullTextFile')) 

In the  "BRUSHES" section press the "Document" button, you will see that comments explaining what the code does are added before the line.


-- **Test Generation**

TBD
