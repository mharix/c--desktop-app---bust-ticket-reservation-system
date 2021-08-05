CREATE DATABASE BTRS

USE BTRS
go




drop table emp
go
--THIS TABLE CONTAIN COMLPETE INFORMATION OF EMPLOYEE
CREATE TABLE EMP(
EMPNO INT IDENTITY(100,1) PRIMARY KEY,
ENAME VARCHAR(50),
EPHONE bigint,
EADDRESS VARCHAR(150),
EQUALIFICATION VARCHAR(15),
EAGE TINYINT,
EEMAIL VARCHAR(50),
EUSERNAME VARCHAR(20) unique,
EPASSWORD VARCHAR(16),
ELOCATION VARCHAR(30),
JOBTYPE VARCHAR(10)
);

SELECT * FROM EMP
go
drop table bus
go
create table bus
(
BUS_NO VARCHAR(6) primary key,
BUS_TYPE VARCHAR(15),
CURRENT_STATION VARCHAR(30)
)
SELECT * FROM bus

go
drop table schedule
go
create  table schedule
(
SCHEDULE_NO INT IDENTITY(0,1) PRIMARY KEY,
BUS_NO VARCHAR(6) REFERENCES bus(BUS_NO) on delete cascade,
DEPT_DATE VARCHAR(50),
ARR_DATE VARCHAR(50),
TO_PLACE VARCHAR(30),
FROM_PLACE VARCHAR(30),
seats tinyint,
price int
)
go
SELECT * FROM bus
go
SELECT * FROM schedule;
go
drop table charges
go
--select BUS_NO,BUS_TYPE from bus where BUS_TYPE='VOLVO(AC)' and  BUS_NO NOT IN(select BUS_NO from schedule);

CREATE TABLE CHARGES
(
ID INT identity(0,1) PRIMARY KEY,
INFANT TINYINT ,
CHILD TINYINT,
ADULT TINYINT,
OLD TINYINT,
DAY2 TINYINT,
DAY1 TINYINT,
DAY0 TINYINT
)
go
SELECT * FROM CHARGES
go
-- form here employee or uer tables  starts----------------------------------------------------------------------------------------------------------------
drop table customer 
go
create table customer
(
cno int identity(0,1) primary key,
booking_time varchar(50),
cname varchar(50),
age tinyint,
cnic varchar(13),
phone varchar(11)
)
select * from customer

go
drop table booking
go

create table booking
(
ticketno int identity(0,1) primary key,
cno int references customer(cno) on delete cascade,
SCHEDULE_NO INT references schedule(SCHEDULE_NO)on delete cascade ,
ticket_price int,
seat_no tinyint
)

go



drop proc enquiry
go
create proc enquiry
@DEPT_DATE VARCHAR(50),@ARR_DATE VARCHAR(50),@TO_PLACE VARCHAR(30),@FROM_PLACE VARCHAR(30)
as
begin
declare @ss int
select SCHEDULE_NO,BUS_NO ,FROM_PLACE,DEPT_DATE,TO_PLACE ,ARR_DATE ,price ,(seats-( select dbo.f_count(SCHEDULE_NO) from dual)   )from SCHEDULE  where DEPT_DATE=@DEPT_DATE and ARR_DATE=@ARR_DATE and TO_PLACE=@TO_PLACE and FROM_PLACE=@FROM_PLACE
end; 

go


------------------------------------------------------------------------------------------
drop function f_count
go
CREATE FUNCTION f_count(@ss INT)
RETURNS INT
AS 
BEGIN 
    DECLARE @returnvalue INT;

    SELECT @returnvalue = COUNT(schedule_no) 
    FROM booking where SCHEDULE_NO=@ss;
    RETURN(@returnvalue);
END
-----------------------------------------------------------------------------------------------
--select count(schedule_no) from booking where SCHEDULE_NO=@sno);
	  