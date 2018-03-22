<h1>URL Parsing</h1>

The following project contains a component to parse Urls using strings in C#. This project has been developed in Microsoft Visual Studio Code.

The main program can be found in the file <strong>"MyUrlLibrary/Class1.cs"</strong>. In this file, I simply extract each component (such as scheme, user, password, etc) and then extract the rest of the components by analysing only the rest of the url.

To test whether the program is correct or not, I have used the Unit Testing MsTest. The tests can be found in the file <strong>MyUrlLibrary.MsTest/UnitTest1.cs</strong>.

<h2>Higher Runtime Performance</h2>

It is important to mention that it is possible to improve the runtime of the whole program by using the unbuilt class Uri. I used it in my program to check if the URL is valid only, but once that it confirms the URL is valid, it is possible to get all its components directly. 
