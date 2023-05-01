# Set up Node project

**Install Node and npm**

 https://docs.npmjs.com/downloading-and-installing-node-js-and-npm


**Install mocha**

run:

 npm install --global mocha
 
 npm install axios

**Install Docker**

https://docs.docker.com/engine/install/

---

- Open NodeServer.js and begin by writing a Nodejs server, check the first suggestions based on the initial text
- Open test.js file and analyze the current test
- Open a command prompt and run the test 


      mocha test.js


- See the result, it should display something like:

---
mocha test.js
server is listening on port 3000

  Node Server
    
    √ should return "key not passed" if key is not passed

  1 passing (34ms)

---

- In the NodeServer.js develop the rest of the methods described in the Exercise described in the section below (do not forget to open color.json file in Visual Studio Code, so CoPilot get all the context to make better recommendations)
- In the Test.js file add the methods to test the funcionality
- Run the tests to verify that all is working 
- Open the dockerfile file, and fill it, in order to create a docker container with a node image that can run the web server
- Create command to run docker in port 4000
- Test that the application is working in port 4000
- In the nodeserver.js file, you can type a new line like //run a curl command to test the server

So we can see how CoPilot based on the current file produces a curl command, to be executed in command line
- Also you can be more specific like: //run a curl command to test the daysBetweenDates method

So it generates a test for a specific method 