# BSBookingQuery

BSBookingQuery is a hotel booking system backend application that allows users to search for hotels, book rooms, and manage various entities such as rooms, room types, guests, and staff etc.

## Features

- Search for hotels by name, location, and filter by ratings.
- Create, read, update, and delete (CRUD) operations for entities.
- Commenting system for hotels, allowing users and hotel staff to interact.

## Technologies Used

![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)![MicrosoftSQLServer](https://img.shields.io/badge/Microsoft%20SQL%20Server-CC2927?style=for-the-badge&logo=microsoft%20sql%20server&logoColor=white)![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white)![Visual Studio](https://img.shields.io/badge/Visual%20Studio-5C2D91.svg?style=for-the-badge&logo=visual-studio&logoColor=white)

- .NET Core 7.0 - Backend development framework
- MSSQL - Relational database management system
- Entity Framework Core - Object-Relational Mapping (ORM) tool
- Unit of Work & Repository pattern - For data access layer abstraction
- API - For communication with the frontend or other systems
- Multi-tier Architecture - Separation of concerns and modularity

## Getting Started

### Prerequisites

- .NET Core SDK [Install .NET Core](https://dotnet.microsoft.com/download) or [Install Visual Studio 2022 Community Edition](https://visualstudio.microsoft.com/thank-you-downloading-visual-studio/?sku=Community&channel=Release&version=VS2022&source=VSLandingPage&passive=false&cid=2030)
- Microsoft SQL Server [Install SQL Server](https://www.microsoft.com/sql-server)

### Installation

1. Clone the repository:
   ![](https://badgen.net/badge/icon/terminal?icon=terminal&label)

```bash
git clone https://github.com/your-username/BSBookingQuery.git
```

2. Use the **BSBookingQuery.sql** or the **BSBookingQuery.bak** to create the database in your local server
3. Update the connection string in the **appsettings.json** file with your SQL Server details:

```json
"ConnectionStrings": {
    "DbConnection": "Server=<Server Name>;Initial Catalog=<DB Name>;Persist Security Info=False;User ID=<login ID>;Password=<password>;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Connection Timeout=30"
  }
```

4. Build and run the application using the SDK or Visual Studio

## API Endpoints

### Booking

**GET/api​/Booking** - get all bookings

**POST/api​/Booking** - create new booking

**PUT​/api​/Booking** - update a booking

**DELETE​/api​/Booking** - delete a booking

### City

**GET/api​/City** - get all cities

**POST/api​/City** - create new city

**PUT​/api​/City** - update a city

**DELETE​/api​/City** - delete a city

### Comment

**GET/api​/Comment** - get all comments

**POST/api​/Comment** - create new comment

**PUT​/api​/Comment** - update a comment

**DELETE​/api​/Comment** - delete a comment

### Country

**GET/api​/Country** - get all countries

**POST/api​/Country** - create new country

**PUT​/api​/Country** - update a country

**DELETE​/api​/Country** - delete a country

### Guest

**GET/api​/Guest** - get all guests

**POST/api​/Guest** - create new guest

**PUT​/api​/Guest** - update a guest

**DELETE​/api​/Guest** - delete a guest

### Hotel

**GET/api​/Hotel** - get all hotels

**POST/api​/Hotel** - create new hotel

**PUT​/api​/Hotel** - update a hotel

**DELETE​/api​/Hotel** - delete a hotel

**GET/api​/Hotel/FilterHotels** - search hotels by name, location & rating

### Position

**GET/api​/Position** - get all positions

**POST/api​/Position** - create new position

**PUT​/api​/Position** - update a position

**DELETE​/api​/Position** - delete a position

### Rating

**GET/api/Rating** - get all ratings

**POST/api/Rating** - create new rating

**PUT/api/Rating** - update a rating

**DELETE/api/Rating** - delete a rating

### Room

**GET/api​/Room** - get all rooms

**POST/api​/Room** - create new room

**PUT​/api​/Room** - update a room

**DELETE​/api​/Room** - delete a room

### Room

**GET/api​/RoomType** - get all roomtypes

**POST/api​/RoomType** - create new roomtype

**PUT​/api​/RoomType** - update a roomtype

**DELETE​/api​/RoomType** - delete a roomtype

### Staff

**GET/api​/Staff** - get all staffs

**POST/api​/Staff** - create new staff

**PUT​/api​/Staff** - update a staff

**DELETE​/api​/Staff** - delete a staff

## Out of Scope

1. Payment and rates
2. User rating based ranking
3. Agent system

## Contact Information

For any inquiries or questions, please contact:

Sabbir Ahmed - hire@sabbirahmed.net
