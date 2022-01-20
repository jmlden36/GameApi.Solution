<br>
<p align="center">
  <u><big>|| <b>Game Api</b> ||</big></u>
</p>
<p align="center">
    <!-- Skylar Avatar/Logo -->
    <br>
    <a href="https://github.com/Skylar-Brockbank">
        <img src="https://avatars.githubusercontent.com/u/91647723?v=4" alt= "skylar brockbank profile" width="100" height="100" style="border-radius:50%">
    </a>
    <a href="https://github.com/jmlden36">
        <img src="https://avatars.githubusercontent.com/u/90112126?v=4" alt= "Matt Luker Profile" width="100" height="100" style="border-radius:50%">
    </a>
    <p align="center">
      ___________________________
    </p>
    <!-- GitHub Link -->
    <p align="center">
        <a href="https://github.com/jmlden36">
            <strong>Matt Luker's GitHub</strong>
        </a>
    </p>
    <p align="center">
        <a href="https://www.linkedin.com/in/james-matt-luker/">
            <img src="https://img.shields.io/badge/-LinkedIn-black.svg?style=plastic&logo=linkedin&colorB=2867B2">
        </a>
    </p>
    <p align="center">
        <a href="https://github.com/Skylar-Brockbank">
            <strong>Skylar Brockbank's GitHub</strong>
        </a>
    </p>
    <p align="center">
        <a href="https://www.linkedin.com/in/skylar-brockbank/">
            <img src="https://img.shields.io/badge/-LinkedIn-black.svg?style=plastic&logo=linkedin&colorB=2867B2">
        </a>
    </p> 
    <!-- Project Shields -->
        
</p>

<p align="center">
  <small>Initiated January 18th, 2021.</small>
</p>

<!-- Project Links -->
<p align="center">
    <a href="https://github.com/jmlden36/GameApi.Solution#readme"><big>Project Docs</big></a> ·
    <a href="https://github.com/jmlden36/GameApi.Solution/issues"><big>Report Bug</big></a> ·
    <a href="https://github.com/jmlden36/GameApi.Solution/issues"><big>Request Feature</big></a>
</p>
------------------------------

### <u>Table of Contents</u>
* <a href="#-about-the-project">About the Project</a>
    * <a href="#-description">Description</a>
    * <a href="#-known-bugs">Known Bugs</a>
    * <a href="#-built-with">Built With</a>
* <a href="#-getting-started">Getting Started</a>
    * <a href="#-prerequisites">Prerequisites</a>
    * <a href="#-setup-and-use">Setup and Use</a>
* <a href="#-api-documentation">API Documentation</a>
* <a href="#-license">License</a>
    
------------------------------
## 📚 About the Project

### Description
An API that functions as a player and map database for a multi player video game.  A user can create, read, update and delete player and map objects from the database using postman to send GET and POST requests.

### Known Bugs

* There are no known bugs at this time.

### Built With
* [Visual Studio Code](https://code.visualstudio.com/)
* [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
* [ASP.NET Core MVC](https://docs.microsoft.com/en-us/aspnet/core/mvc/overview?view=aspnetcore-3.1)
* [MySQL](https://dev.mysql.com/)
* [Entity Framework Core 2.2.6](https://docs.microsoft.com/en-us/ef/core/)
* [Postman](postman.com)

------------------------------

## Getting Started

### Prerequisites

#### Install .NET Core
* On macOS Mojave or later
  * [Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) to download the .NET Core SDK from Microsoft Corp for macOS.
* On Windows 10 x64 or later
  * [Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer) to download the 64-bit .NET Core SDK from Microsoft Corp for Windows.

#### Install dotnet script
 Enter the command ``dotnet tool install -g dotnet-script`` in Terminal for macOS or PowerShell for Windows.

#### Install MySQL Workbench
 [Download and install the appropriate version of MySQL Workbench](https://dev.mysql.com/downloads/workbench/).

#### Install Postman
(Optional) [Download and install Postman](https://www.postman.com/downloads/).

#### Code Editor

  To view or edit the code, you will need an code editor or text editor. I recommend VisualStudio Code.

  1) Code Editor Download:[VisualStudio Code](https://www.npmjs.com/)
  2) Click the download most applicable to your OS and system.
  3) Wait for download to complete, then install -- Windows will run the setup exe and macOS will drag and drop into applications.
  4) Optionally, create a [GitHub Account](https://github.com)

### Setup and Use

  #### Cloning

  1) Navigate to the [Game Api API repository here]https://github.com/jmlden36/GameApi.Solution).
  2) Click 'Clone or download' to reveal the HTTPS url ending with .git and the 'Download ZIP' option.
  3) Open up your system Terminal or GitBash, navigate to your desktop with the command: `cd Desktop`, or whichever location suits you best.
  4) Clone the repository to your desktop: `$ git clone https://github.com/jmlden36/GameApi.Solution`
  5) Run the command `cd GameApi.Solution` to enter into the project directory.
  6) View or Edit:
      * Code Editor - Run the command `code .` to open the project in VisualStudio Code for review and editing.
      * Text Editor - Open by double clicking on any of the files to open in a text editor.

  #### Download

  1) Navigate to the [Game Api API repository here](https://github.com/jmlden36/GameApi.Solution).
  2) Click 'Clone or download' to reveal the HTTPS url ending with .git and the 'Download ZIP' option.
  3) Click 'Download ZIP' and unextract.
  4) Open by double clicking on any of the files to open in a text editor.

  #### AppSettings

  1) Create a new file in the GameApi.Solution directory named `appsettings.json`
  2) Add in the following code snippet to the new appsettings.json file:
  
  ```
{
    "Logging": {
        "LogLevel": {
        "Default": "Warning"
        }
    },
    "AllowedHosts": "*",
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=game_api;uid=root;pwd=YourPassword;"
    }
}
  ```
  3) Change the server, port, and user id as necessary. Replace 'YourPassword' with relevant MySQL password (set at installation of MySQL).

#### Database
  1) Navigate to GameApi.Solution directory using the MacOS Terminal or Windows Powershell (e.g. `cd Desktop/GameApi.Solution`).
  2) Run the command `dotnet ef database update` to generate the database through Entity Framework Core.
  3) (Optional) To update the database with any changes to the code, run the command `dotnet ef migrations add <MigrationsName>` which will use Entity Framework Core's code-first principle to generate a database update. After, run the previous command `dotnet ef database update` to update the database.

  #### Launch the API
  1) Navigate to GameApi.Solution directory using the MacOS Terminal or Windows Powershell (e.g. `cd Desktop/GameApi.Solution`).
  2) Run the command `dotnet run` to have access to the API in Postman or browser.
  


  #### Player Endpoints

  

  ## API Documentation
  Explore the API endpoints in Postman or a browser.

  ### Note on CORS
  CORS is a W3C standard that allows a server to relax the same-origin policy. It is not a security feature, CORS relaxes security. It allows a server to explicitly allow some cross-origin requests while rejecting others. An API is not safer by allowing CORS.
  For more information or to see how CORS functions, see the [Microsoft documentation](https://docs.microsoft.com/en-us/aspnet/core/security/cors?view=aspnetcore-2.2#how-cors).

  
  ### Endpoints
  Base URL: `https://localhost:5000`
  
  __________________________________________
  __*** Available Components ***__

  * Player
  __________________________________________
  
   #### HTTP Request Structure
  ```
  GET /api/{component}
  POST /api/{component}
  GET /api/{component}/{id}
  PUT /api/{component}/{id}
  DELETE /api/{component}/{id}
  GET /api/{component}/prox
  GET /api/{component}/con/{id}
  GET /api/{component}/map
  ```

  #### Example Query
  ```
  https://localhost:5000/api/Players/13
  ```
  
  #### Sample JSON Response
  ```
  {
      "playerId": 1,
      "name": "Hector The Well Fed Fella",
      "x": 5,
      "y": 2,
      "z": 0
  }
  ```

  ### Api/Players/prox parameters

  | Parameter | Type | Default | Required | Description |
  | :---: | :---: | :---: | :---: | --- |
  | x | int | none | true | Target x coordinate
  | Y | int | none | true | Target y coordinate |
  | z | int | none | true | Target z coordinate |
  | range | int | none | true | Distance from specified point (This is a 2D range). |


    This route allows you to get a list of all players on the same z level
    in a square that is 2*range+1 units wide and tall
  
  #### Example Query
  ```
  https://localhost:5000/api/Players/prox/?x=2&y=3&z=0&range=2
  ```
  ### Api/Players/con/{id} parameters
  | Parameter | Type | Default | Required | Description |
  | :---: | :---: | :---: | :---: | --- |
  | n| bool | none | true | Whether the north key is pressed |
  | s | bool | none | true | Whether the south key is pressed |
  | e | bool | none | true | Whether the east key is pressed |
  | w | bool | none | true | Whether the west key is pressed |

    
    This route tells the server how the player would like to move their character
    (The server will check to see if that is possible and send back the player specified by id)
    

  #### Example Query
  ```
  https://localhost:5000/api/Players/con/1?n=true&s=false&e=false&w=false
  ```
------------------------------


### License

This project is licensed under the [MIT License](https://opensource.org/licenses/MIT). Copyright (C) 2021 Matt Luker and Skylar Brockbank. All Rights Reserved.

```
MIT License

Copyright (c) 2021 Matt Luker and Skylar Brockbank.

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
```

------------------------------