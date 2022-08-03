# Car Rental System
The project was developed in C# in accordance with the multi-layered architecture principle. OOP and AOP techniques were used using SOLID principles. Entity Framework was used as the ORM and CRUD operations were performed with it. MSSQL Localdb was used for database in the project.In addition, a Web API has been coded in service layer to communicate with the Front-End side of the project and other applications. I would like to tell you about the main features of the project.

## Layers
<b> 1-Entities Layer:</b> It is where the classes of objects to be used throughout the program are defined. Each of the classes in this layer corresponds to a table in the database ,additionally, there are DTO (Data Transfer Object) classes that contain joins of multiple tables.<br>
<b> 2-Business Layer:</b> It is the layer where business rules and validation rules are controlled. When a command comes to the program, what operations it should do and which set of rules it should go through are defined here. Control stages are performed using AOP techniques.<br>
<b> 3-Data Access Layer:</b> It is the layer on which database connections and operations are made. Required configuration for database connection is done here. Also, operations such as data extraction, addition, deletion, and updating are encoded in this layer.<br>
<b> 4-Core Layer:</b> It is the part where structures, cross-cutting concerns, aspects, extensions and tools used in all projects are coded.<br>
<b> 5-Console-UI Layer:</b> It is the layer that appears to the user, that the user interacts with and sends commands to the program.<br>
<b> 6-Service Layer (Web API):</b> It is the part where the services that enable the Front-End part and other platforms to communicate with the program and perform operations are written.<br>

## Used Technologies
- Restful API
- Result Types
- Interceptor
- Autofac
- AOP (Aspect Oriented Programming)
- Caching
- Performance
- Transaction
- Validation
- Fluent Validation
- Cache Management
- JWT Authentication
- Generic Repository Design Pattern
- Cross Cutting Concerns
- Caching
- Validation
- Extensions
- Claim
- Exception Middleware
- Service Collection
- Error Handling
- Validation Error Details
- Hashing
- Disposable Pattern

## Required Packages for Back-End


| Package Name  | Version |
| ------------- | ------------- |
| Autofac | 6.4.0  |
| Autofac.Extensions.DependencyInjection  | 8.0.0  |
| Autofac.Extras.DynamicProxy  | 6.0.1  |
| FluentValidation  | 11.1.0  |
| Microsoft.AspNetCore.Authentication.JwtBearer  | 3.1.12  |
| Microsoft.AspNetCore.Http  | 2.2.2 |
| Microsoft.AspNetCore.Http.Abstractions  | 2.2.0  |
| Microsoft.EntityFrameworkCore.SqlServer  | 3.1.11  |
| Microsoft.IdentityModel.Tokens  | 6.22.0  |
| System.IdentityModel.Tokens.Jwt | 6.22.0 |

<br>
