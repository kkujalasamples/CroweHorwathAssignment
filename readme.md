# CroweHorwath HelloWorld Assignment
'Hello World' program for the Crowe Horwath technical assignment.

## Instructions 
Write a ‘Hello World’ program.
1.  The program has 1 current business requirement – write “Hello World” to
the console/screen.
2. The program should have an API that is separated from the program logic
to eventually support mobile applications, web applications, or console
applications, or windows services.
3. The program should support future enhancements for writing to a
database, console application, etc.
   - Use common design patterns (inheritance, e.g.) to account for
these future concerns.  
   - Use configuration files or another industry-standard mechanism for
determining where to write the information to.
Write unit tests to support the API.  

## Explanations
* **HelloWorld.API** - This is a .net core api to get a message from different possible sources. 
I used an interface(IMessageService) that is implemented inside the web api - for now this messageservice just returns "HelloWorld" message statically.
This api can be consumed by any kind of application either mobile or web or console or windows service.
* **HelloWorld.API.Tests** - This is xUnit Test Project for Api. Here we are testing the controller by mocking the IMessageService.
* **HelloWorld.Writer** - The writer is a library, I used an interface IWriter which is implemented by the ConsoleWriter and the DatabaseWriter class.
* **HelloWorld.Client** - This is a .net core console application which is an interface to write the message to console. This client app invokes api using httpclient(Used RestSharp library) to get the message and it uses "HelloWorld.Writer" library to write the message to console. I used .net core dependency injection extension to inject Writer into the console application, for now we are injecting ConsoleWriter based on settings in appsettings.json. We can modify this functionality to inject databsewriter in future.