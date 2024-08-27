Traversal - TravelCoreProject

Traversal is a travel blog and tour guide web application developed using ASP.NET Core 5.0. This project enables users to learn about travel destinations, connect with guides, and share their own travel experiences.

### Table of Contents

- Features
- Technologies Used
- Installation
- Database Structure
- Project Architecture
- Screenshots
- Contributors


### Features

- **User Management**: User registration, login, password reset, and role-based authorization.
- **Blog Management**: Management of blog posts created by users, including commenting and rating.
- **Guide Management**: Profiles of travel guides and the ability to connect with them.
- **Destination Management**: Listing of travel destinations and detailed information display.
- **Dynamic Pages**: Dynamic content management and static page management.
- **Ajax and jQuery Usage**: Loading data and processing forms without page refresh.

### Technologies Used

- **ASP.NET Core 5.0**
- **Entity Framework Core**
- **MSSQL Server**
- **Identity Framework**: User management and authentication.
- **Fluent Validation**: Input validation rules.
- **AutoMapper**: Transformation between Data Transfer Objects (DTO) and entity models.
- **Razor Pages & MVC Pattern**
- **Bootstrap**: Responsive web design.
- **jQuery & Ajax**: Dynamic and interactive web pages.

### Installation

#### Requirements

- .NET 5.0 SDK
- Visual Studio 2022
- MSSQL Server

#### Steps

1. **Clone the Repository**:

   ```bash
   git clone https://github.com/SelimmAlpKamil/Traversal.git
   cd Traversal
   ```

2. **Set Up the Database**:

   - Update the connection string in the `appsettings.json` file according to your MSSQL Server settings.
   - Apply the database migrations using the Package Manager Console (PMC) or CLI:
     ```bash
     update-database
     ```

3. **Run the Project**:

   - Open the project in Visual Studio 2022 and run it (using IIS Express or Kestrel).

### Database Structure

- **Users**: User information, roles, and authorizations.
- **Blogs**: Blog posts created by users.
- **Guides**: Information about travel guides.
- **Destinations**: List and details of travel destinations.
- **Comments**: User comments on blog posts.

### Project Architecture

The project is developed using N-Tier Architecture:

- **Presentation Layer**: User interface (UI) and Razor Pages.
- **Business Layer**: Business rules, validations, and data processing.
- **Data Access Layer**: Database operations and Entity Framework Core usage.
- **Entity Layer**: Entity classes corresponding to database tables.
- **Core Layer**: Common components and services used across all layers.

### Screenshots

![image](https://github.com/user-attachments/assets/2a79dbb4-fe9e-4149-a1b6-5efb87dcff5d)
![image](https://github.com/user-attachments/assets/4e1814d6-09c7-452b-9694-3d39105b3a01)
![image](https://github.com/user-attachments/assets/b8998666-26c3-4bc9-8e4a-ca9f64af8cb8)
![image](https://github.com/user-attachments/assets/908c12c4-064f-42bb-8fc2-af66928a1266)
![image](https://github.com/user-attachments/assets/2eed5bde-b713-4989-8bdb-4285dff0fe4c)
![image](https://github.com/user-attachments/assets/64d695d1-d7d0-4cf5-bc24-1e0fa3b0a161)
![image](https://github.com/user-attachments/assets/44a09de9-e14b-4d37-82c4-cee148916afc)
![image](https://github.com/user-attachments/assets/57c9cb5e-e05a-43ef-9227-31035e311ff3)
![image](https://github.com/user-attachments/assets/4da79e2e-a2d3-4b00-a221-10a122ad7aa9)
![image](https://github.com/user-attachments/assets/2e87fa9f-ce98-41ab-b6b2-35ec0f26aaa0)
![image](https://github.com/user-attachments/assets/519ca71e-e62a-4424-83c0-c714d6eaebd0)
![image](https://github.com/user-attachments/assets/6726bcda-1bce-412b-b6f9-2cea639fb0c2)
![image](https://github.com/user-attachments/assets/ff1c684c-f466-44c1-9a5b-7d75629eaf42)
![image](https://github.com/user-attachments/assets/87180fbf-9544-4462-a25a-831cfb9281b3)









### Contributors

- **Selim Alp Kamil** - Project Owner and Developer

