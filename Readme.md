The following project contains a component to parse Urls using strings in C#. This project has been developed in Microsoft Visual Studio Code.

The main program can be found in the file "MyUrlLibrary/Class1.cs". In this file, I simply extract each component (such as scheme, user, password, etc) and then extract the rest of the components by analysing only the rest of the url.

To test whether the program is correct or not, I have used the Unit Testing MsTest. The tests can be found in the file MyUrlLibrary.MsTest/UnitTest1.cs.
