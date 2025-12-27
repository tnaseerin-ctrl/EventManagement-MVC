# Event Management System (ASP.NET MVC)

A web-based Event Management System built using **ASP.NET MVC**.

 ## Folder & File Map:
-EventManagement (Project Root)
│
├── Controllers
│   ├── AccountController.cs      ← Handles Login
│   ├── BookingController.cs      ← Handles Event Booking, Final Summary, All Bookings, Cancel
│   ├── FoodController.cs         ← Handles Food Booking
│   └── LightingController.cs     ← Handles Lighting Booking
│
├── Models
│   ├── BookingMaster.cs          ← Stores BookingNo, Username, BookingDate, Approval
│   ├── BookingModel.cs           ← Event booking details: EventType, VenueType, NoOfGuest
│   ├── FoodModel.cs              ← Food details: FoodType, MealType, Dish
│   └── LightingModel.cs          ← Lighting details: LightType, Lights
│
├── Views
│   ├── Account
│   │   └── Login.cshtml          ← Login Page
│   ├── Booking
│   │   ├── BookEvent.cshtml      ← Event Booking Form
│   │   ├── FinalSummary.cshtml   ← Final Summary Page
│   │   └── AllBookings.cshtml    ← Display All Bookings
│   ├── Food
│   │   └── BookFood.cshtml       ← Food Booking Form
│   └── Lighting
│       └── BookLighting.cshtml  ← Lighting Booking Form
│
├── Content
│   ├── site.css                  ← Styling for pages
│   └── Images
│       ├── Event.jpeg            ← Event Image
│       ├── Food.jpeg             ← Food Image
│       └── Lighting.jpeg         ← Lighting Image
│
└── Views/Shared
    └── _Layout.cshtml           ← Master Page with Header, Footer, CSS, @RenderBody()
## Description
This project allows users to view, book, and manage events online. It includes an admin dashboard for managing events and bookings, and a user-friendly interface for visitors.  

## Features
- View upcoming events
- Book events online
- Admin panel to add, edit, or delete events
- Responsive and clean interface

## Technology Stack
- **Backend:** ASP.NET MVC, C#  
- **Frontend:** HTML, CSS, JavaScript  
- **Database:** SQL Server (optional)

## 🎥 Project Explanation Video:
 -👉 Watch the project demo video here:
 - https://drive.google.com/file/d/1j9oetCv3uM1B4rTDLwpL-9BLOmm1Zp3y/view?usp=drivesdk

## Folder Structure
- `Controllers` – Handles user requests and routes  
- `Models` – Business logic and data structures  
- `Views` – Frontend pages  
- `Scripts` – JavaScript files  
- `Content` – CSS, images, and other static files  
- `App_Start` – Configuration files  
- `App_Data` – Database files (if any)  
- `Properties` – Project properties  

## How to Run
1. Clone or download the repository.  
2. Open the solution file (`.sln`) in **Visual Studio**.  
3. Build the project to restore dependencies.  
4. Run using **IIS Express**.  
5. Open your browser and navigate to `http://localhost:port/` (Visual Studio will show the port).  

## Notes
- `Bin`, `Obj`, and `.csproj.user` files are excluded from the repository because they are auto-generated.  
- Make sure to restore NuGet packages if needed.
