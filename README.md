# _Local Business Lookup_ 

#### _C# API Solo Project For Epicodus_ 
#### _DATE 01.22.2021_

#### By _**Tawnee Harris**_

## Description

This application includes a custom built API with seeded data and full CRUD functionality via API endpoints.

## Setup/Installation Requirements

Software Requirements
* An internet browser of your choice; I prefer Chrome
* A code editor; I prefer VSCode
* .NET Core
* MySQL
* MySQL Workbench
* An API Client; I prefer Postman

Open by Downloading or Cloning
* Navigate to <https://github.com/tawneeh/LocalBiz.Solution.git>
* Download this repository to your computer by clicking the green Code button and 'Download Zip'
* Or clone the repository

AppSettings
* This project requires an AppSettings file. Create your `appsettings.json` file in the API project directory `APILocalBiz`. 
* Format your `appsettings.json` file as follows, including your unique password that was created at MySqlWorkbench installation:
```
{
  "Logging": {
    "LogLevel": {
      "Default": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=tawnee_harris_3;uid=root;pwd=<YourPassword>;"
  }
}
```
* Update the Server, Port, and User ID as needed.

Import Database using Entity Framework Core
* Navigate to LocalBiz.Solution/APILocalBiz and type `dotnet ef database update` into the terminal to create your database tables.

Launch this Application
* Navigate to LocalBiz.Solution/APILocalBiz and type `dotnet restore` into the terminal
* Then, in the same API project folder, type `dotnet build` into the terminal followed by `dotnet run`
* Peruse full CRUD functionality via Postman or other API Client

## Known Bugs

This application currently does not include a Client side project. 

## Support and contact details

Please feel free to reach out to me anytime at <tawneeh@icloud.com>

## Technologies Used

* C#
* Swagger UI
* Swashbuckle
* Entity Framework Core
* MySql
* MySql Workbench
* Postman

### License

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

Copyright (c) 2021 **_Tawnee Harris_**