EmployeeAdminPortal

Project Overview

EmployeeAdminPortal is a .NET-based web application designed for managing employee records efficiently. The portal allows users to add, edit, delete, and view employee details with an intuitive user interface.

Features

Employee management (CRUD operations: Create, Read, Update, Delete)
User authentication and authorization
Responsive UI for better user experience
RESTful API integration
Database support using SQL Server
Logging and exception handling

Technologies Used

Backend: ASP.NET Core MVC, C#
Frontend: HTML, CSS, JavaScript (Optional: React or Angular if used)
Database: SQL Server 
IDE: Visual Studio 2022
Version Control: Git
Dependency Management: NuGet

Prerequisites

Before running the project, ensure you have the following installed:

.NET 6.0 or later
SQL Server 
SQL Server Management Studio (SSMS) 20.2
Visual Studio 2022
Git (optional for version control)

Setup Instructions

Clone the repository (if applicable):

git clone https://github.com/your-repo/EmployeeAdminPortal.git

Open the solution in Visual Studio

Restore dependencies:

dotnet restore

Set up the database:

Install SQL Server and SQL Server Management Studio (SSMS) if not installed.

Update appsettings.json with your SQL Server connection string.

Apply migrations (if using Entity Framework):

dotnet ef database update

Alternatively, create the database manually in SQL Server:

CREATE DATABASE EmployeeAdminPortal;

Create a table structure for employees:

CREATE TABLE Employees (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100) UNIQUE NOT NULL,
    Position NVARCHAR(50),
    Department NVARCHAR(50),
    DateHired DATE
);

Run the application:

dotnet run

Open http://localhost:5000 in your browser.

API Endpoints (If applicable)

Method

Endpoint

Description

GET

/api/employees

Fetch all employees

GET

/api/employees/{id}

Get employee by ID

POST

/api/employees

Add a new employee

PUT

/api/employees/{id}

Update an employee

DELETE

/api/employees/{id}

Delete an employee

Deployment

To deploy the application:

Build the project:

dotnet publish -c Release -o ./publish

Deploy the publish folder to a web server or cloud platform (Azure, AWS, etc.).

Contributing

Fork the repository

Create a feature branch (git checkout -b feature-branch)

Commit changes (git commit -m "Your message")

Push to the branch (git push origin feature-branch)

Open a pull request

License

This project is licensed under the MIT License - see the LICENSE file for details.
