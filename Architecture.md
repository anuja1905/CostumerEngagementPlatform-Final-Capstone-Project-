# System Architecture

![Architecture Diagram](ArchitectureDiagram.png)

# System Architecture

## Project Name

Customer Engagement & Service Analytics Platform

---

## Architecture Used

This project follows a **3-Tier ASP.NET Core MVC Architecture** consisting of:

* Presentation Layer
* Business Logic Layer
* Data Access Layer

Additional supporting layers include:

* Authentication & Authorization
* API & Security
* DevOps & Deployment

This layered architecture promotes separation of concerns, maintainability, scalability, and security.

---

## Users Layer

This is the entry point of the system.

The application is accessed through a web browser by two types of users:

### Admin

* Manage Customers
* Manage Tickets
* Access Admin Dashboard
* View Reports

### User

* Raise Support Tickets
* View Ticket Information
* Access User Dashboard

Users interact with the system through Razor-based web pages.

---

## 1. Presentation Layer

This layer contains the user interface of the application.

### Main Folders

* Views
* wwwroot

### Features

* Login Page
* Admin Dashboard
* User Dashboard
* Customer Management Pages
* Ticket Management Pages

### Technologies Used

* Razor Views
* Bootstrap 5
* Tag Helpers
* Model Validation

This layer is responsible for displaying data and collecting user input.

---

## 2. Business Logic Layer

This layer handles application logic and user requests.

### Main Folder

* Controllers

### Controllers Used

* CustomersController
* TicketsController
* AccountController
* CustomersApiController
* TicketsApiController
* AuthApiController

### Responsibilities

* Process user requests
* Perform CRUD operations
* Validate business rules
* Manage workflows
* Coordinate communication between UI and Database

This layer acts as the core processing unit of the application.

---

## 3. Data Access Layer

This layer handles database communication.

### Main Folders

* Models
* Data
* Migrations

### Main Files

* Customer.cs
* Ticket.cs
* ApplicationDbContext.cs

### Responsibilities

* Database Connectivity
* Entity Mapping
* LINQ Queries
* Data Persistence
* Database Migrations

The application uses **Entity Framework Core** with **SQL Server**.

---

## Database Layer

This layer stores all application data.

### Main Entities

#### Customer

Stores customer information such as:

* CustomerId
* Name
* Email
* Phone Number
* Created Date

#### Ticket

Stores customer support tickets:

* TicketId
* CustomerId
* Subject
* Status
* Priority
* Created Date

### Relationship

* One Customer can have multiple Tickets.
* Each Ticket belongs to one Customer.

This relationship helps track customer service requests efficiently.

---

## Authentication & Authorization

This layer ensures application security.

### Authentication

* Cookie-Based Login System
* JWT Token Generation for APIs

### Authorization

* Admin Role
* User Role
* Role-Based Access Control

### Access Rights

#### Admin

Can access:

* Admin Dashboard
* Customer Management
* Ticket Management
* Administrative Features

#### User

Can access:

* User Dashboard
* Ticket Viewing
* Limited User Features

Unauthorized users are redirected to the Access Denied page.

---

## API & Security Layer

The project exposes RESTful APIs for external access.

### APIs Available

* Customers API
* Tickets API
* Authentication API

### Security Features

* JWT Authentication
* Role-Based Authorization
* Input Validation

### Swagger Integration

Swagger is used for:

* API Documentation
* Endpoint Testing
* API Exploration

This layer enables secure communication between external systems and the application.

---

## DevOps & Deployment

The project incorporates modern DevOps practices.

### Version Control

* GitHub Repository

### CI/CD Support

* GitHub Actions Workflow

### Containerization

* Docker Support

### Cloud Deployment

* Azure App Service Ready

### Benefits

* Source Code Management
* Automated Build Processes
* Deployment Readiness
* Cloud Scalability

---

## Technologies Used

* ASP.NET Core MVC
* Entity Framework Core
* SQL Server
* Bootstrap 5
* Swagger / OpenAPI
* JWT Authentication
* Docker
* GitHub
* GitHub Actions
* Microsoft Azure

---

## Overall Workflow

### Web Application Flow

User/Admin

↓

Razor Views

↓

MVC Controllers

↓

Entity Framework Core

↓

SQL Server Database

### API Flow

User/Admin

↓

JWT Authentication

↓

API Controllers

↓

Business Logic

↓

Database

---

## Summary

The Customer Engagement & Service Analytics Platform follows a structured 3-Tier Architecture that separates the user interface, business logic, and database access into independent layers.

This architecture improves:

* Maintainability
* Scalability
* Security
* Reusability
* Performance
* Ease of Deployment

The design ensures that the application remains organized, secure, and easy to extend in the future.
