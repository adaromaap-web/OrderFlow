# OrderFlow

A REST API for order management built with ASP.NET Core and PostgreSQL.

## About the Project

OrderFlow is a backend project developed to practice and demonstrate modern .NET development skills. It provides the foundation for managing customer orders and storing order data in a PostgreSQL database.

## Tech Stack

* C#
* ASP.NET Core Web API
* Entity Framework Core
* PostgreSQL
* Npgsql
* Swagger / OpenAPI

## Current Features

* Order data model
* PostgreSQL database integration
* Entity Framework Core database migrations
* API documentation with Swagger

## Getting Started

### Prerequisites

* .NET 10 SDK
* PostgreSQL

### Configuration

Configure the `DefaultConnection` connection string using .NET User Secrets:

```bash
dotnet user-secrets set "ConnectionStrings:DefaultConnection" "Host=localhost;Port=5432;Database=orderflow;Username=YOUR_USERNAME;Password=YOUR_PASSWORD"
```

Replace `YOUR_USERNAME` and `YOUR_PASSWORD` with your local PostgreSQL credentials.

### Run the Application

```bash
dotnet restore
dotnet ef database update
dotnet run
```

Open the Swagger UI URL shown in the application output to explore the API.

## Project Status

The project is under active development. More order management features, validation, automated tests, and containerization are planned.
