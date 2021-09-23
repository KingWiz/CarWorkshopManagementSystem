create database CarWorkshopManagementSystem

use CarWorkshopManagementSystem

//tables
create table CustomersData
(
	CustomerID			int primary key identity(1,1),
	CustomerFirstName	nvarchar(20)	not null,
	CustomerLastName	nvarchar(20)	not null,
	CustomerGender		nvarchar(10)	not null,
	CustomerPhoneNo		nvarchar(10)	not null		unique,
	CustomerEmail		nvarchar(30)	null			unique,
	CustomerAddress		nvarchar(20)	not null,
	CustomerCity		nvarchar(20)	not null,
	CustomerState		int				not null
)
create table CarsData
(
	CarID			int primary key identity(1,1),
	CarModel		nvarchar(20)	not null,
	CarNumber		nvarchar(20)	not null		unique,
	CarType			nvarchar(20)	not null,
	CarColor		nvarchar(30)	null,
	CarProblem		nvarchar(255)	not null,
	CarAssignDate	date			not null,
	CarReleaseDate	date			null,
	CarStatus		nvarchar(10)	null
)
create table UsersData
(
	UserID			int primary key identity(1,1),
	UserFirstName	nvarchar(20)	not null,
	UserLastName	nvarchar(20)	not null,
	UserEmail		nvarchar(30)	not null		unique,
	UserPassword	nvarchar(30)	not null,
	UserGender		nvarchar(10)	not null,
	UserPhoneNo		int				not null		unique,
	DOB				date			not null,
	UserAddress		nvarchar(20)	not null,
	UserCity		nvarchar(20)	not null,
	UserState		int				not null
)
create table Tasks
(
	TaskID		int primary key identity(1,1),
	CustomerID	int			not null,
	CarID		int			not null
	foreign key(CustomerID) references CustomersData(CustomerID),
	foreign key(CarID) references CarsData(CarID)
)

select * from CustomersData
select * from CarsData
select * from UsersData
select * from tasks

drop table CustomersData
drop table CarsData
drop table UsersData
drop table Tasks

SELECT * FROM CustomersData WHERE CustomerID=(SELECT MAX(CustomerID) FROM CustomersData);
SELECT c.CarModel, c.CarNumber, c.CarColor, c.CarType, c.CarAssignDate,c.CarReleaseDate,c.CarStatus,c.CarProblem, cu.CustomerFirstName+' '+cu.CustomerLastName AS CustomerName, cu.CustomerPhoneNo, cu.CustomerAddress FROM Tasks AS t  FULL OUTER JOIN CarsData AS c ON c.CarID = t.CarID FULL OUTER JOIN CustomersData AS cu ON cu.CustomerID = t.CustomerID
SELECT c.CarID, c.CarModel, c.CarNumber, c.CarColor, c.CarType, c.CarAssignDate,c.CarReleaseDate,c.CarStatus,c.CarProblem, cu.CustomerFirstName+' '+cu.CustomerLastName AS CustomerName, cu.CustomerPhoneNo, cu.CustomerAddress FROM Tasks AS t FULL OUTER JOIN CarsData AS c ON t.CarID = c.CarID FULL OUTER JOIN CustomersData AS cu ON t.CustomerID = cu.CustomerID