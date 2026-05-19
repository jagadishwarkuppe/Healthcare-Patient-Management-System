# Healthcare-Patient-Management-System
Healthcare patient and claims management system built using ASP.NET Core Web API, SQLite, and Entity Framework.
# Healthcare Patient Management System

A healthcare patient and claims management system built using **ASP.NET Core Web API**, **C#**, **SQLite**, and **Entity Framework Core**. This project simulates healthcare workflows such as patient registration, claim tracking, and CRUD operations.

## Project Overview

This application was developed to practice backend development concepts and healthcare domain workflows similar to healthcare revenue cycle systems.

The system allows:

- Patient management
- Healthcare claims tracking
- REST API development
- Database persistence using SQLite
- CRUD operations
- API testing using Swagger

---

## Tech Stack

- **Backend:** ASP.NET Core Web API (.NET)
- **Language:** C#
- **Database:** SQLite
- **ORM:** Entity Framework Core
- **API Testing:** Swagger / OpenAPI
- **Version Control:** Git & GitHub

---

## Features

### Patient Management
- Add new patients
- View all patients
- View patient by ID
- Update patient details
- Delete patient

### Claims Management
- Add healthcare claims
- View all claims
- Link claims to patients
- Track claim amount
- Track claim status
- Track submission date

---

## API Endpoints

### Patients API

| Method | Endpoint | Description |
|---------|------------|-------------|
| GET | `/api/Patients` | Get all patients |
| GET | `/api/Patients/{id}` | Get patient by ID |
| POST | `/api/Patients` | Add new patient |
| PUT | `/api/Patients/{id}` | Update patient |
| DELETE | `/api/Patients/{id}` | Delete patient |

### Claims API

| Method | Endpoint | Description |
|---------|------------|-------------|
| GET | `/api/Claims` | Get all claims |
| POST | `/api/Claims` | Add claim |

---

## Database Structure

### Patient Table

| Column | Type |
|---------|------|
| Id | Integer |
| Name | String |
| Age | Integer |
| Gender | String |
| InsuranceProvider | String |

### Claim Table

| Column | Type |
|---------|------|
| ClaimId | Integer |
| PatientId | Integer |
| ClaimAmount | Decimal |
| ClaimStatus | String |
| SubmissionDate | DateTime |

---

## Project Structure

```txt
HealthcareClaimsSystem
│
├── BackendAPI
│   ├── Controllers
│   │   ├── PatientsController.cs
│   │   └── ClaimsController.cs
│   │
│   ├── Models
│   │   ├── Patient.cs
│   │   └── Claim.cs
│   │
│   ├── Data
│   │   └── AppDbContext.cs
│   │
│   ├── Migrations
│   ├── healthcare.db
│   ├── Program.cs
│   └── appsettings.json
│
└── README.md
```

---

## How to Run the Project

### Clone repository

```bash
git clone https://github.com/YOUR_USERNAME/Healthcare-Patient-Management-System.git
```

### Go to project folder

```bash
cd HealthcareClaimsSystem/BackendAPI
```

### Install dependencies

```bash
dotnet restore
```

### Run migration

```bash
dotnet ef database update
```

### Run application

```bash
dotnet run
```

### Open Swagger

```txt
http://localhost:5292/swagger
```

---

## Future Improvements

- React frontend integration
- Authentication & authorization
- JWT token security
- Dashboard for claim analytics
- MSSQL integration
- Cloud deployment

---

## Author

**Jagadish Kuppe**

GitHub: https://github.com/YOUR_USERNAME
