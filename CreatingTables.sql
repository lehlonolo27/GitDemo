--Creating Tables
--Mostly common used data types (VARCHAR,DATETIME,INT,MONEY)
CREATE DATABASE ClassDB
ON
(
NAME =ClassDataFile,
FILENAME='C:\MyFolder\Data\ClassDataFile.mdf',
SIZE=5MB,
FILEGROWTH=1%,
MAXSIZE=UNLIMITED
),
FILEGROUP SECONDARY
(
NAME =ClassDataFile1,
FILENAME='C:\MyFolder\Data\ClassDataFile1.ndf',
SIZE=5MB,
FILEGROWTH=1%,
MAXSIZE=UNLIMITED
)

LOG ON
(NAME =ClassLogData,
FILENAME='C:\MyFolder\Data\ClassLogData.ldf',
SIZE=1MB,
FILEGROWTH=1%,
MAXSIZE=UNLIMITED
)

USE ClassDB
CREATE TABLE Department
(
Nr INT IDENTITY(1,1) PRIMARY KEY,
[Name] VARCHAR(20) DEFAULT('Sales'),
[Floor] VARCHAR(3) NOT NULL
)
GO
CREATE TABLE Employee
(
ID INT IDENTITY(1,1) PRIMARY KEY,
[Name] VARCHAR(20) NOT NULL,
LastName VARCHAR(20) NOT NULL,
AGE INT CHECK(age BETWEEN 18 and 65), --You cannot be an employee with the age below 18 and above 65,
DateHired DATETIME DEFAULT(getdate()),
Street VARCHAR(20),
Suburb VARCHAR(20),
City VARCHAR(10),
PostalCode VARCHAR(4),
PhoneNumber VARCHAR(10) NOT NULL UNIQUE,
DepartmentNr INT REFERENCES Department(Nr)
)
GO
CREATE TABLE Qualification
(
ID INT IDENTITY(1,1) PRIMARY KEY,
[Name] VARCHAR(30) NOT NULL
)
--Composite key (Combining two foreign keys)
GO
CREATE TABLE EmployeeQualification
(
EmployeeID INT REFERENCES Employee(ID),
QualificationID INT REFERENCES Qualification(ID),
DateCompleted DATETIME DEFAULT(getDate())
PRIMARY KEY(EmployeeID,QualificationID)
)