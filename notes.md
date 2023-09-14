C sharp with ASP.NET
youtube.com/watch?v=BfEjDD8mWYg

Aim: create a CRUD application with a database

##What is ASP.NET Core?
-Microsoft's C# tool to build web applications
-Alternatives: Java Spring, PHP Laravel, Python Flask, Node.js Express
-.NET - Microsoft's Software Development Platform
-Active Server Pages - dynamic web page
-CORE - open source, cross-platform version of ASP

-.NET is the framework - runtime engine and libraries for executing programs written in a -compliant language

-Dynamic ASP.NET page is a page that contains a mix of HTML markup and dynamic ASP markup
ASP.NET is run on the server combining the static HTML code, and updating the dynamic ASP 

-Full stack (Database, Business Logic, HTML)
-Can be combined with popular front-end serviced (REact, Vue, Angular)
-Mobile Apps

ASP.-
#Why ASP.NET?
1997, desktop apps to web apps
replaces Classic ASP tech
similar to JAVA in that it complies in one platform and can run in many platforms
.NET is the complied environment


##Getting Started on VS Code
Reference (https://code.visualstudio.com/docs/languages/dotnet)
-Install C# Dev Kit Extension
-Download .NET Code Pack

Start a new MVC project
- in your terminal, run

    `dotnet new MVC`

  This will create a your MVC templates
- in VS code, run a debug, a window till pop out asking to create missing files -Yes
- This will create a .vscode folder with a tasks.json
- in this file, run a debug. This will run the localhost
-Run your program using
    `dotnet run`

# MVC Structure
#Model
- Represents shape of the data
- A class in C# used to describe model
- represents the tables in your database
#View
- User interface (html, css)
#Controller
- Process the business logic and interface between model and view

# Routing
- URl pattern for routing is:
    `domain/controller/action/id`
- (see app.MapControllerRoute in Program.cs to find default)
- example:
  Controllers > HomeController.cs
    You'll see a class `HomeController` with a default base class `Controller`
    There are 2 action methods: IActionResult Index and Privacy
    The action method calls to a view associated (Views > Home > .cshtml)
  
## Views
# Views > Shared
- This folder contains the shared styling and layouts what are called across different views
- it contains a `@renderbody` which will render what ever Views > Home defines
# Views > Home
- This folder contains the content of each page that is than rendered onto the shared layouts.
# Views >_ViewImports.cshtml
- Global namespace which you want to access across all pages
- Tag helpers are provided by the .NET core team that look like html tags:
  `asp-action` ect
# Views > _ViewStart.cshtml
- define a default master layout page for your app
- if you want to set a different master page for a particular page, you can do that on the content page

## Controller
# Controller > HomeController.cs
- This where you can define the routing

## Tag Helpers
- Introduced with ASP.NET Core
- sever-side code to participate in creating and rendering HTML elements in RAzor files
- focused around html elements
eg. 
    HTML Helper:
        `@Html.Label("FirstName","First"Name : ", new { @class = 'form-control'})
    Tag Helper:
        `<label class="form-control" asp-for="FirstName"></label>`

# Action Result
- in MVC app and Razor Page app (IActionResult)
- you can make the return type more explicit by using (ViewResult, and PageREsult respectively)
- result of action method.page or return types of action methods/page handlers
parent class for many of the derived classes that have associated helpers
- IActionResult is appropriate when many action types are possible (i.e. control flow for different types of action)
- Action result sin Razor Pages:
  1 ContentResult - Content - takes string and returns text/plainContent-type header by default. you can specify content-type such as html or json foe example
  2 FileContentResult - File - returns file from byte array, stream, virtual path
  3 NotFoundResult - NotFound - returns http 404 indicating request not found
  4 PageResult - Page - return result of current page
  5 PartialResult - Partial - returns partial page
  6 RedirectToPageResult - Redirects user to specified page
  7 ViewComponentResult - returns result of executing a ViewComponent

- Action result in MVC
  1 ViewREsult - renders view a webpage
  2 PartialViewResult e- renders partial view which defines a section of a view that can be rendered inside another view
  3 RedirectResult - redirects to another action by URL
  RedirectToRouteResult - Redirects to another action method
  ContentResult - returns user-defined content type
  JsonResult - return serialized JSON object
  JavaScriptResult - returns a script that can be executed on the client
  fileResult - returns binary output to write response
  EmptyResult - represents a return value that is used if the action method must return a null result

## Database
-you may need to download a package for entity framework
- eg. for SQLite you will need to use: `dotnet add package Microsoft.EntityFrameworkCore.Sqlite`
- `dotnet tool install --global dotnet-ef`

- add migrations with the following `dotnet ef migrations add yourMigrationName`
- update a migration/database `dotnet ef database update`