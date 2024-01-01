---- Summary for SaaS Product Imports ----

Program.cs

File names and respective paths are passed in the main program function which parses both capterra and softwareadvice with the help of Importer class which contains the logic for identification for the name, path and type of resource. 

ProductsImporter.cs

It contains logic for importing products from different sources (capterra, softwareAdvice, future sources) which can be scaled-up by adding different sources in switch case statement. It simulates storing data using the Storage class (until real data persistence is implemented).

Storage.cs

Mock class that simulates storing imported data (printing what it's doing, for instance).

Tests>UnitTests.cs

Contains unit tests for the ProductsImporter class to ensure correct import functionality. It has 1 function each for validating files from capterra and softwareadvice. 

----

Installation Steps:
Download the code.
Ensure you have .NET installed.
Open the project in Visual Studio.

----

How to Run the Code / Tests:
To run the code, execute the dotnet run command within the directory.
To run tests, execute dotnet test in the Tests directory.

----

Code Location:
The code can be found here: https://github.com/Nand480/saas-products-import.git

----

Experience with Testing:
Yes, I've written unit tests using various .net framework before. It's essential for ensuring code reliability and functionality.

----

Improvements with More Time:
Given more time, I'd focus on:

Implementing real data persistence.
Handling the future provider's CSV URL format.
Enhancing error handling and edge case scenarios (missing, duplicate, corrupted etc. files).
Adding more comprehensive unit tests to cover various cases.

----

Thank you :)
