Create Database HerbalHealthSolutionSystem;

CREATE TABLE Users (
    Username nvarchar(100) PRIMARY KEY,
	Password nvarchar(100) NOT NULL,
	Role nvarchar(100) NOT NULL
);

CREATE TABLE Herbs (
    ID int IDENTITY(1,1) PRIMARY KEY,
	Type nvarchar(50),
	Name nvarchar(MAX),
	Price int,
	Description nvarchar(MAX),
	Image varbinary(MAX),
    VendorContact nvarchar(20),
    VendorEmail nvarchar(50)
);

CREATE TABLE Patients (
    ID int IDENTITY(1,1) PRIMARY KEY,
	UserID nvarchar(100),
	FName nvarchar(200),
	LName nvarchar(200),
    Contact nvarchar(20),
    Email nvarchar(50),
	DateOfBirth nvarchar(50)
);

CREATE TABLE Doctors (
    ID int IDENTITY(1,1) PRIMARY KEY,
	UserID nvarchar(100),
	TibbId nvarchar(100),
	FName nvarchar(200),
	LName nvarchar(200),
	AvailabilityTimeFrom nvarchar(200),
	AvailabilityTimeTo nvarchar(200),
	AvailabilityDays nvarchar(500),
	Specialty nvarchar(200),
	Experience nvarchar(200),
    Contact nvarchar(20),
    Email nvarchar(50),
    Address nvarchar(250),
	Image varbinary(MAX),
	DateOfBirth nvarchar(50)
);

CREATE TABLE Feedbacks(
	ID int IDENTITY(1,1) PRIMARY KEY,
	PatientID int,
	DoctorID int,
	Comment nvarchar(MAX),
	Date datetime
);

CREATE TABLE Appointments(
	ID int IDENTITY(1,1) PRIMARY KEY,
	PatientID int,
	DoctorID int,
	ConsultancyReason nvarchar(300),
	DiseaseIssue nvarchar(300),
	HealthIssue nvarchar(MAX),
	AppointmentTime nvarchar(200),
	DoctorResponse nvarchar(MAX),
	Fee int,
	Status nvarchar(100),
	Date datetime
);

CREATE TABLE DoctorTips(
	ID int IDENTITY(1,1) PRIMARY KEY,
	DoctorID int,
	Subject nvarchar(500),
	Description nvarchar(MAX),
	Date datetime
);

CREATE TABLE DoctorPrescriptions(
	ID int IDENTITY(1,1) PRIMARY KEY,
	DoctorID int,
	Subject nvarchar(500),
	Description nvarchar(MAX),
	Date datetime
);

INSERT INTO Users(Username, Password, Role) VALUES('admin@gmail.com', '12345', 'Admin')
Select * from Users;
Select * from Doctors;
Select * from DoctorPrescriptions;
Select * from DoctorTips;
Select * from Herbs;
Select * from Users where Username = 'doctor1';
Select * from Doctors where UserID = 'doctor1';
Select * from Users;
Select * from Doctors;
Select * from Patients;
Select * from Appointments;
Select * from Feedbacks;



update Appointments set DoctorResponse = '', Price = ''

Delete Patients where UserID = 'doctor2'