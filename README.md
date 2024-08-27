Traversal is a travel blog and tour guide web application developed using ASP.NET Core 7.0. This project enables users to learn about travel destinations, connect with guides, and share their own travel experiences.

Table of Contents
Features
Technologies Used
Installation
Database Structure
Project Architecture
Screenshots
Contributors
License
Features
User Management: User registration, login, password reset, and role-based authorization.
Blog Management: Management of blog posts created by users, including commenting and rating.
Guide Management: Profiles of travel guides and the ability to connect with them.
Destination Management: Listing of travel destinations and detailed information display.
Dynamic Pages: Dynamic content management and static page management.
Ajax and jQuery Usage: Loading data and processing forms without page refresh.
Technologies Used
ASP.NET Core 7.0
Entity Framework Core
MSSQL Server
Identity Framework: User management and authentication.
Fluent Validation: Input validation rules.
AutoMapper: Transformation between Data Transfer Objects (DTO) and entity models.
Razor Pages & MVC Pattern
Bootstrap: Responsive web design.
jQuery & Ajax: Dynamic and interactive web pages.
Installation
Requirements
.NET 7.0 SDK
Visual Studio 2022
MSSQL Server
Steps
Clone the Repository:

  
  
git clone https://github.com/SelimmAlpKamil/Traversal.git
cd Traversal
Set Up the Database:

Update the connection string in the appsettings.json file according to your MSSQL Server settings.
Apply the database migrations using the Package Manager Console (PMC) or CLI:
  
  
update-database
Run the Project:

Open the project in Visual Studio 2022 and run it (using IIS Express or Kestrel).
Database Structure
Users: User information, roles, and authorizations.
Blogs: Blog posts created by users.
Guides: Information about travel guides.
Destinations: List and details of travel destinations.
Comments: User comments on blog posts.
Project Architecture
The project is developed using N-Tier Architecture:

Presentation Layer: User interface (UI) and Razor Pages.
Business Layer: Business rules, validations, and data processing.
Data Access Layer: Database operations and Entity Framework Core usage.
Entity Layer: Entity classes corresponding to database tables.
Core Layer: Common components and services used across all layers.
Screenshots


Contributors
Selim Alp Kamil - Project Owner and Developer
License
This project is licensed under the MIT License. For more information, see the LICENSE file.
