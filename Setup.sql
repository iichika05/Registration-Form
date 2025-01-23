--Dashboard
use Data3
create table imageDB (
listNo int identity(1,1) primary key,
firstname nvarchar(15) not null,
lastname nvarchar(100) not null,
passwrd nvarchar(15) unique not null,
emailUsername nvarchar(35) unique not null,
gender nvarchar(10) null,
IMG varbinary(max) null,
);

exec sp_configure 'show adavanced options';

use Data3
create table registration_formV2 (
CustomerID int identity(1,1) primary key,
CustomerName nvarchar(45) not null,
Gender nvarchar(15) null,
yearr nvarchar(15) not null,
course nvarchar(25) not null,
);

--Admin & User Login
