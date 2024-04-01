

BEGIN TRAN

USE ISID


CREATE TABLE Memployee(
    Employeeid varchar(20) NOT NULL  PRIMARY KEY ,
    FullName varchar(150),
    Birthdate  Date
    
);
