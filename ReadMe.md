# Harry Potter - Hogwarts School of Witchcraft and Wizardry

---
### Deployed on Azure!

[project url here]()

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

### Overview of Recent Posts
![Overview of Recent Posts](https://via.placeholder.com/500x250)

### Creating a Post
![Post Creation](https://via.placeholder.com/500x250)

### Enriching a Post
![Enriching Post](https://via.placeholder.com/500x250)

### Viewing Post Details
![Details of Post](https://via.placeholder.com/500x250)

---
## Data Flow (Frontend, Backend, REST API)
***[Add a clean and clear explanation of what the data flow is. Walk me through it.]***
![Data Flow Diagram](/assets/img/Flowchart.png)

---

## Change Log
***[The change log will list any changes made to the code base. This includes any changes from TA/Instructor feedback]***  
1.4: *Added OAuth for MySpace* - 23 Jan 2003  
1.3: *Changed email handler to Alta Vista, fixed issue with styling on Netscape Navigator browser.* - 21 Dec 1999  
1.2: *Fixed bug where pages would not load due to temp data* - 16 Jun 1998  
1.1: *Added ability for user to change photos on a post* - 12 May 1998  

---

## Authors
Sue Tarazi

---

For more information on Markdown: https://www.markdownguide.org/cheat-sheet
