CREATE TABLE Brands (
  BrandId INT NOT NULL, 
  BrandName NVARCHAR(30) NOT NULL,
  PRIMARY KEY (BrandId),  
);
INSERT INTO Brands
    (BrandId, BrandName)
VALUES 
    (10, 'Mercedes'),
    (20, 'Audi'),
    (30, 'Honda'),
    (40, 'BMW'),
    (50, 'Kia'),
    (60, 'Jaguar'),
    (70, 'Hyundai');

CREATE TABLE Cars (
  Id INT NOT NULL, 
  BrandId INT NOT NULL,
  ColorId NVARCHAR(10) NOT NULL, 
  ModelYear INT NOT NULL,
  DailyPrice INT NOT NULL, 
  Description ntext NOT NULL,
  PRIMARY KEY (Id),  
);
INSERT INTO Cars
    (Id, BrandId, ColorId, ModelYear, DailyPrice, Description)
VALUES 
    (1, 10, '#FF0000', 1996, 300, 'Guzel'),
    (2, 20, '#00FF00', 2006, 350, 'Guvenilir'),
    (3, 30, '#0000FF', 2009, 300, 'Temiz'),
    (4, 40, '#FFFF00', 2017, 750, 'Sifir gibi'),
    (5, 50, '#000000', 2013, 380, 'Balancelari iyi degil'),
    (6, 60, '#00FFFF', 2020, 1000, 'Motoru cok guclu'),
    (7, 70, '#800080', 2000, 200, 'yolu iyi kavriyo');

CREATE TABLE Colors (
  ColorId NVARCHAR(10) NOT NULL,  
  ColorName NVARCHAR(30) NOT NULL,
  PRIMARY KEY (ColorId),  
);
INSERT INTO Colors
    (ColorId, ColorName)
VALUES 
    ('#FF0000', 'Red'),
    ('#00FF00', 'Green'),
    ('#0000FF', 'Blue'),
    ('#FFFF00', 'Yellow'),
    ('#000000', 'Black'),
    ('#00FFFF', 'Aqua'),
    ('#800080', 'Purple');