# Harry Potter - Hogwarts School of Witchcraft and Wizardry

---
### Deployed on Azure!

[https://harrypotterhogwarts.azurewebsites.net](https://harrypotterhogwarts.azurewebsites.net)

---
## Web & Mobile Application

The web and mobile application consists of a frontend written in Razor Pages, HTML, CSS,
Bootstrap and jQuery. The backend was written in C# using ASP.NET Core, Entity Framework Core, and the MVC framework.

This application is a fictitious 'acceptance' into Hogwarts School of Witchcraft and Wizardry and consumes an external API. The application hits several endpoints of the API and also queries API data in Services (in cases where there isn't an endpoint for the desired data) as the application guides the user through the world of Harry Potter. First, the user is encouraged to use the Sorting Hat to sort themselves into a house. Then, the user can view details about that house (or any other house). From the house page, they can drill down further to learn about the faculty, staff and students associated with that house. There is also another section of the application called Spells that returns all spells taught at Hogwarts. From the Spells page, a user can select from a pull down menu and narrow search results by spell type.  

---

## Tools Used
Microsoft Visual Studio Community 2019 (Version 16.7.3)

- C#
- ASP.Net Core
- Entity Framework
- MVC
- JQuery
- Bootstrap
- Azure
- Harry Potter API: [https://www.potterapi.com/](https://www.potterapi.com/)

---

## Recent Updates

---

## Getting Started

Clone this repository to your local machine.

```
$ git clone https://github.com/suetarazi/HarryPotter.git
```
Once downloaded, you can either use the dotnet CLI utilities or Visual Studio 2017 (or greater) to build the web application. The solution file is located in the AmandaFE subdirectory at the root of the repository.
```
cd YourRepo/YourProject
dotnet build
```
The dotnet tools will automatically restore any NuGet dependencies. 

---

## Usage

### Index (top portion of page)
![https://i.imgur.com/cQibrJR.png](https://i.imgur.com/cQibrJR.png)

### Index (bottom portion of page)
![https://i.imgur.com/3FsFiHW.png](https://i.imgur.com/3FsFiHW.png)

### Modal showing Sorting Hat Result 
![https://i.imgur.com/cjwp6zB.png](https://i.imgur.com/cjwp6zB.png)

### Viewing House Details
![https://i.imgur.com/bEoiIvF.png](https://i.imgur.com/bEoiIvF.png)

### Viewing Characters Associated with House 
![https://i.imgur.com/e1466wF.png](https://i.imgur.com/e1466wF.png)

### Viewing All Spells 
![https://i.imgur.com/13aJI71.png](https://i.imgur.com/13aJI71.png)

### Viewing Spells By Type
![https://i.imgur.com/SkMtpII.png](https://i.imgur.com/SkMtpII.png)

---
## Data Flow (Frontend, Backend, REST API)
The following is the ASP.NET Core architecture of the application, which then consumes the external Harry Potter API
![https://i.imgur.com/RSEypeX.jpeg](https://i.imgur.com/RSEypeX.jpeg)

---

## Change Log
1.1 fixed modal rendering 

---

## Authors
Sue Tarazi

Thank you to Andrew Casper for being a great resource when I got stuck on this project! 

---

For more information on Markdown: https://www.markdownguide.org/cheat-sheet
