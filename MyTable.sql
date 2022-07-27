CREATE TABLE Brands (
    BrandId int NOT NULL,
    BrandName varchar(255) NOT NULL,
  
);

CREATE TABLE Colors (
    ColorId int NOT NULL,
    ColorName varchar(255) NOT NULL,
    
);

CREATE TABLE Cars (
    CarId int NOT NULL,
    BrandId int NOT NULL,
    ColorId int NOT NULL,
    CarName varchar(255) NOT NULL,
    ModelYear varchar(255) NOT NULL,
    DailyPrice decimal(18) NOT NULL,
    Description varchar(255) NOT NULL,
    MinFindeksScore int DEFAULT 0,
);

CREATE TABLE Users (
    Id int NOT NULL,
    FirstName varchar(255) NOT NULL,
    LastName varchar(255) NOT NULL,
    Email varchar(255) NOT NULL,
    PasswordSalt varbinary(500) NOT NULL,
    PasswordHash varbinary(500) NOT NULL,
    Status bit NOT NULL,
    
);

CREATE TABLE Customers (
    CustomerId int NOT NULL,
    UserId int NOT NULL,
    CompanyName varchar(255) NOT NULL,
    FindeksScore int DEFAULT 0,
);

CREATE TABLE Rentals (
    RentalId int NOT NULL,
    CarId int NOT NULL,
    CustomerId int NOT NULL,
    RentDate datetime NOT NULL,
    ReturnDate datetime DEFAULT NULL,
);