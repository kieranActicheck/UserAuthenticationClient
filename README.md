# UserAuthenticationConsoleApp

ClientApp is a console application that communicates with an API to retrieve user information. This application demonstrates how to use HttpClient to send HTTP requests and process responses in a .NET environment.

## Prerequisites
Before you begin, ensure you have met the following requirements:

•	You have installed .NET SDK (version 5.0 or later).

•	You have an API running that provides user information. The API should have an endpoint like https://localhost:7265/api/user/{id}.

## Usage
To use the ClientApp, follow these steps:
1.	Ensure the API is Running:
Make sure your API project is running and accessible at https://localhost:7265/.
2.	Run the Client Application (dotnet run).


The application will send a GET request to the API to retrieve user information and display it in the console.


## Configuration
The Program.cs file contains the main logic for the client application. You can modify the GetUserByIdAsync method to change the API endpoint or add additional logic as needed.
