USE master
GO

CREATE DATABASE Kursovaya_Polina ON
( NAME = Kursovaya_Polina,
  FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ Kursovaya_Polina.mdf',
  SIZE = 3072KB, 
  MAXSIZE = UNLIMITED,
  FILEGROWTH = 1024KB )

LOG ON
( NAME= Kursovaya_Polina_log,
  FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ Kursovaya_Polina_log.ldf',
  SIZE = 1024KB,
  MAXSIZE = 2048GB, 
  FILEGROWTH = 10% )

GO

USE Kursovaya_Polina
GO

CREATE TABLE TypeUsers
( IdTypeUser int IDENTITY (1,1) PRIMARY KEY,
  NameType varchar(50) NOT NULL UNIQUE )
GO

CREATE TABLE Users
( IdUser int IDENTITY (1,1) PRIMARY KEY,
  Login varchar(20) NOT NULL UNIQUE,
  Password varchar(20) NOT NULL UNIQUE,
  FIO varchar(50) NOT NULL UNIQUE,
  TypeUser int NOT NULL FOREIGN KEY REFERENCES TypeUsers(IdTypeUser) ON DELETE CASCADE )
GO

CREATE TABLE Administrators
( IdAdministrator int IDENTITY (1,1) PRIMARY KEY,
  FIO varchar(50) NOT NULL UNIQUE )
GO

CREATE TABLE Specializations
( IdSpecialization int IDENTITY (1,1) PRIMARY KEY,
  Name varchar(50) NOT NULL UNIQUE )
GO

CREATE TABLE Doctors
( IdDoctor int IDENTITY (1,1) PRIMARY KEY,
  FIO varchar(50) NOT NULL UNIQUE,
  IdSpecialization int NOT NULL FOREIGN KEY REFERENCES Specializations(IdSpecialization) ON DELETE CASCADE )
GO

CREATE TABLE Services
( IdService int IDENTITY (1,1) PRIMARY KEY,
  Name varchar(50) NOT NULL UNIQUE,
  Price int NOT NULL )
GO

CREATE TABLE Diagnoses
( IdDiagnose int IDENTITY (1,1) PRIMARY KEY, 
  Name varchar(500) NOT NULL UNIQUE )
GO

CREATE TABLE Patients
( IdPatient int IDENTITY (1,1) PRIMARY KEY,
  FIO varchar(50) NOT NULL UNIQUE,
  Birthdate date NOT NULL,
  PhoneNumber varchar(11) NOT NULL UNIQUE )
GO

CREATE TABLE Appointments
( IdAppointment int IDENTITY (1,1) PRIMARY KEY,
  IdDoctor int NOT NULL FOREIGN KEY REFERENCES Doctors(IdDoctor) ON DELETE CASCADE,
  DateTime datetime NOT NULL,
  IdPatient int FOREIGN KEY REFERENCES Patients(IdPatient) ON DELETE CASCADE,
  Complaints varchar(500),
  Recommendations varchar(500) )
GO

CREATE TABLE Suppliers
( IdSupplier int IDENTITY (1,1) PRIMARY KEY,
  Name varchar(50) NOT NULL UNIQUE )
GO

CREATE TABLE DosageForms
( IdForm int IDENTITY (1,1) PRIMARY KEY, 
  Name varchar(50) NOT NULL UNIQUE )
GO

CREATE TABLE Medicaments
( IdMedicament int IDENTITY (1,1) PRIMARY KEY, 
  Name varchar(50) NOT NULL,
  DosageForm int NOT NULL FOREIGN KEY REFERENCES DosageForms(IdForm) ON DELETE CASCADE,
  Price int NOT NULL,
  Quantity int NOT NULL,
  IdSupplier int NOT NULL FOREIGN KEY REFERENCES Suppliers(IdSupplier) ON DELETE CASCADE )
GO

CREATE TABLE Orders
( IdOrder int IDENTITY (1,1) PRIMARY KEY,
  Date date NOT NULL,
  IdPatient int FOREIGN KEY REFERENCES Patients(IdPatient) ON DELETE CASCADE,
  TotalPrice int NOT NULL )
GO

CREATE TABLE ServicesDoctors
( IdService int NOT NULL FOREIGN KEY REFERENCES Services(IdService) ON DELETE CASCADE,
  IdDoctor int NOT NULL FOREIGN KEY REFERENCES Doctors(IdDoctor) ON DELETE CASCADE )
GO

CREATE TABLE AppointmentsMedicaments
( IdAppointment int NOT NULL FOREIGN KEY REFERENCES Appointments(IdAppointment) ON DELETE CASCADE,
  IdMedicament int NOT NULL FOREIGN KEY REFERENCES Medicaments(IdMedicament) ON DELETE CASCADE )
GO

CREATE TABLE AppointmentsServices
( IdAppointment int NOT NULL FOREIGN KEY REFERENCES Appointments(IdAppointment) ON DELETE CASCADE,
  IdService int NOT NULL FOREIGN KEY REFERENCES Services(IdService) ON DELETE CASCADE )
GO

CREATE TABLE AppointmentsDiagnoses
( IdAppointment int NOT NULL FOREIGN KEY REFERENCES Appointments(IdAppointment) ON DELETE CASCADE,
  IdDiagnose int NOT NULL FOREIGN KEY REFERENCES Diagnoses(IdDiagnose) ON DELETE CASCADE )
GO

CREATE TABLE OrdersMedicaments
( IdOrder int NOT NULL FOREIGN KEY REFERENCES Orders(IdOrder) ON DELETE CASCADE,
  IdMedicament int NOT NULL FOREIGN KEY REFERENCES Medicaments(IdMedicament) ON DELETE CASCADE,
  Quantity int NOT NULL )
GO