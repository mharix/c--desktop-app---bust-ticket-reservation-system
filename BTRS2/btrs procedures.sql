USE BTRS
--THIS PROCEDURE IS USED T INSERT EMPLOYEE DATA INTO EMP TABLE
go
drop proc INSERT_EMP
go
CREATE PROCEDURE INSERT_EMP
@ENAME VARCHAR(50),@EPHONE bigint,@EADDRESS VARCHAR(150),
@EQUALIFICATION VARCHAR(15),@EAGE TINYINT,@EEMAIL VARCHAR(50),
@EUSERNAME VARCHAR(20),@EPASSWORD VARCHAR(16),@ELOCATION VARCHAR(30),
@JOBTYPE VARCHAR(10)
AS
BEGIN
INSERT INTO EMP VALUES(@ENAME,@EPHONE,@EADDRESS ,@EQUALIFICATION ,@EAGE,@EEMAIL,@EUSERNAME ,@EPASSWORD ,@ELOCATION ,@JOBTYPE);
END
go
--INSERT RECORD THROUGH PROCEDURE
 INSERT_EMP'ALI',03007012345,'C-34/4 AFZALTOWN KARACHI PAKISTAN','MATRIC',21,'ALI.STD@GMAIL.COM','ALI','123','KARACHI','EMPLOYEE';

 go
 INSERT_EMP'HARIS',03007012345,'C-34/4 AFZALTOWN KARACHI PAKISTAN','MATRIC',21,'ALI.STD@GMAIL.COM','HARIS','123','KARACHI','ADMIN';

 GO
 drop procedure LOGIN_CHECK
 go
 --THIS PRCO CHECK USERNAME AND PASSWORD AND RETURN JOBE TYPE OF EMPLOYEE TO APPLICATION
 CREATE PROCEDURE LOGIN_CHECK
@EUSERNAME VARCHAR(20),@EPASSWORD VARCHAR(16)
AS
BEGIN
SELECT JOBTYPE,ENAME,EUSERNAME  FROM EMP WHERE EUSERNAME=@EUSERNAME AND EPASSWORD=@EPASSWORD;
END


 GO
 --this proc is used to return or select employee witch match the condition. for update purposes
 go
 drop proc admin_find_emp
 go
 CREATE PROCEDURE admin_find_emp
@text VARCHAR(100)
AS
BEGIN
SELECT * FROM EMP WHERE EMPNO LIKE'%'+@text+'%' OR ENAME LIKE'%'+@text+'%'  OR  EPHONE LIKE'%'+@text+'%' OR  EADDRESS LIKE'%'+@text+'%' OR EQUALIFICATION LIKE'%'+@text+'%' OR EAGE LIKE'%'+@text+'%' OR EEMAIL LIKE'%'+@text+'%'OR  EUSERNAME LIKE'%'+@text+'%' OR EPASSWORD LIKE'%'+@text+'%' OR ELOCATION LIKE'%'+@text+'%' OR JOBTYPE LIKE'%'+@text+'%';
END


	

SELECT * FROM EMP
go
drop proc   admin_delete_emp
go
--THIS PROC IS USED TO DELETE RECORD IN EMP 
 CREATE PROCEDURE admin_delete_emp
@usrname VARCHAR(20)
AS
BEGIN
delete emp where EUSERNAME=@usrname;
END

 
 go
 DROP PROCEDURE admin_update_emp
 go
  CREATE PROCEDURE admin_update_emp
@ENAME VARCHAR(50),@EPHONE bigint,@EADDRESS VARCHAR(150),
@EQUALIFICATION VARCHAR(15),@EAGE TINYINT,@EEMAIL VARCHAR(50),
@EUSERNAME VARCHAR(20),@EPASSWORD VARCHAR(16),@ELOCATION VARCHAR(30),
@JOBTYPE VARCHAR(10)
AS
BEGIN
update emp 
set ENAME=@ENAME,EPHONE=@EPHONE,EADDRESS=@EADDRESS,
EQUALIFICATION=@EQUALIFICATION,EAGE=@EAGE,
EEMAIL=@EEMAIL ,
EPASSWORD=@EPASSWORD ,ELOCATION=@ELOCATION ,
JOBTYPE=@JOBTYPE
where EUSERNAME=@EUSERNAME ;
END



--UPDATE EMP SET JOBTYPE='ADMIN' WHERE empno=100

--this proc simply show buses detils in grid
drop proc admin_bus_view
go
drop proc admin_bus_view
go
 CREATE PROCEDURE admin_bus_view
AS
BEGIN
select * from bus;
END

select * from bus
go
drop proc admin_bus_add
go
 CREATE PROCEDURE admin_bus_add
@BUS_NO VARCHAR(6),
@BUS_TYPE VARCHAR(15),
@CURRENT_STATION VARCHAR(30)
AS
BEGIN
insert into bus values(@BUS_NO,@BUS_TYPE,@CURRENT_STATION);
END


go
drop proc admin_bus_remove
go


 CREATE PROCEDURE admin_bus_remove
@BUS_NO VARCHAR(6)
AS
BEGIN
delete bus where bus_no=@BUS_NO;
END
go
drop proc admin_bus_check
go
--this proc is used to check bus is already exist or not
 CREATE PROCEDURE admin_bus_check
@BUS_NO VARCHAR(6)
AS
BEGIN
select * from  bus where bus_no=@BUS_NO;
END





--inserting schedule for busesin schedule table
go
drop proc admin_bus_schedule_insert
go
 CREATE PROCEDURE admin_bus_schedule_insert
 @BUS_NO VARCHAR(6) ,
@DEPT_DATE VARCHAR(50),
@ARR_DATE VARCHAR(50),
@TO_PLACE VARCHAR(30),
@FROM_PLACE VARCHAR(30),
@seats tinyint,@price int
AS
BEGIN
insert into schedule values( @BUS_NO,@DEPT_DATE,@ARR_DATE,@TO_PLACE,@FROM_PLACE,@seats,@price);
END


select * from schedule;



go
DROP PROC admin_bus_schedule_busno
go
 CREATE PROCEDURE admin_bus_schedule_busno
@BUS_TYP VARCHAR(13)
AS
BEGIN
select BUS_NO,BUS_TYPE from bus where BUS_TYPE=@BUS_TYP and  BUS_NO NOT IN(select BUS_NO from schedule);
END

go

drop proc admin_bus_schedule_check
go
--we use this proc to check wether this bus is sccheduled or notto avoid same bus to schedule on same date
 CREATE PROCEDURE admin_bus_schedule_check
@BUS_NO VARCHAR(6)
AS
BEGIN
select BUS_NO from bus where BUS_NO=@BUS_NO;
END




GO
--CLEAR CHARGES TABLE
DROP PROC admin_bus_CHARGES_DELETE
go
 CREATE PROCEDURE admin_bus_CHARGES_DELETE
AS
BEGIN
delete CHARGES where 1=1;
END

go
drop proc admin_TICKET_charges
--THIS PROC STORE CHAGES WRT  AGE AND  REIMBURSMENT
go
 CREATE PROCEDURE admin_TICKET_charges
@INFANT TINYINT ,
@CHILD TINYINT,
@ADULT TINYINT,
@OLD TINYINT,
@DAY2 TINYINT,
@DAY1 TINYINT,
@DAY0 TINYINT
AS
BEGIN

insert into charges values(@INFANT  ,@CHILD ,@ADULT ,@OLD ,@DAY2 ,@DAY1 ,@DAY0 );
END


-- form here employee or uer procedures  starts----------------------------------------------------------------------------------------------------------------
go

DROP PROC emp_chnagepasss
go
 CREATE PROCEDURE emp_chnagepasss
 @newpass varchar(16),
 @user varchar(20)
AS
BEGIN
update emp set EPASSWORD=@newpass where EUSERNAME=@user;
END


--call from booking to check which bus is available on that day of departure
go
drop proc emp_book_ticket_busess
go
 CREATE PROCEDURE emp_book_ticket_busess
 @bustype varchar(15),@to varchar(30),@from varchar(30),@ddate VARCHAR(50),@ardate VARCHAR(50)
AS
BEGIN
select s.BUS_NO,s.seats,s.price,s.SCHEDULE_NO from schedule s ,bus b where s.BUS_NO=b.BUS_NO AND b.BUS_TYPE= @bustype AND TO_PLACE=@to and FROM_PLACE=@from and DEPT_DATE=@ddate  and ARR_DATE=@ardate;
END

go
SELECT * FROM schedule;

go

--check no of seatss in bus
go
 CREATE PROCEDURE emp_check_noOfSeats
 @BUS_NO  varchar(16), @bustype varchar(15),@to varchar(30),@from varchar(30),@ddate VARCHAR(50),@ardate VARCHAR(50)
AS
BEGIN
select seats from schedule where BUS_NO=@BUS_NO  AND TO_PLACE=@to and FROM_PLACE=@from and DEPT_DATE=@ddate and ARR_DATE=@ardate;
END



go

--this proc return charges
DROP PROC emp_age_charges_return
go
 CREATE PROCEDURE emp_age_charges_return
AS
BEGIN
select * from charges;
END

go
--this insert data to cutomer and booking table
drop proc emp_insert_customer
go
create procedure emp_insert_customer
@cname varchar(50),
@age tinyint,
@cnic varchar(13),
@phone varchar(11),
@schedule_no int,
@price int,
@seat_no tinyint
as
begin
declare  @time varchar(50)=CURRENT_TIMESTAMP;
insert into customer values(CURRENT_TIMESTAMP,@cname,@age,@cnic,@phone)
 insert into booking values((select MAX(cno) from customer),@schedule_no,@price,@seat_no)
end;
select * from schedule
SELECT * FROM BOOKING
SELECT * FROM CUSTOMER
GO
----------------------------------------------------------------------------------------------------------------------------
use btrs
drop proc emp_CUSTOMER_SEARCH
go
CREATE PROC emp_CUSTOMER_SEARCH
@BUSNO VARCHAR(6),
@FROM VARCHAR(30),
@TO VARCHAR(30),
@NAME VARCHAR(50),
@AGE TINYINT,
@arr varchar(50),
@dep varchar(50)

AS
BEGIN
SELECT S.BUS_NO,C.CNAME,C.AGE,C.cnic,C.phone,S.DEPT_DATE,S.FROM_PLACE,S.ARR_DATE,S.TO_PLACE FROM schedule S,BOOKING B,customer C WHERE B.cno=C.cno AND B.SCHEDULE_NO=S.SCHEDULE_NO 
AND S.BUS_NO=@BUSNO AND S.FROM_PLACE=@FROM AND S.TO_PLACE=@TO AND C.cname=@NAME AND C.age=@AGE AND S.ARR_DATE=@arr AND S.DEPT_DATE=@dep;
END;
-----------------------------------------------------------------------------------------------------------------
--SEARCHH BY NAME
go
drop proc EMP_CUSTOMER_SEARCH_NAME
go
CREATE PROC EMP_CUSTOMER_SEARCH_NAME

@SEARCH VARCHAR(50)
AS
BEGIN
SELECT S.BUS_NO,C.CNAME,C.AGE,C.cnic,C.phone,S.DEPT_DATE,S.FROM_PLACE,S.ARR_DATE,S.TO_PLACE FROM schedule S,BOOKING B,customer C WHERE B.cno=C.cno AND B.SCHEDULE_NO=S.SCHEDULE_NO 
AND C.cname LIKE '%'+@SEARCH +'%'
END;
go
drop proc EMP_CUSTOMER_SEARCH_AGE
go
CREATE PROC EMP_CUSTOMER_SEARCH_AGE

@SEARCH VARCHAR(50)
AS
BEGIN
SELECT S.BUS_NO,C.CNAME,C.AGE,C.cnic,C.phone,S.DEPT_DATE,S.FROM_PLACE,S.ARR_DATE,S.TO_PLACE FROM schedule S,BOOKING B,customer C WHERE B.cno=C.cno AND B.SCHEDULE_NO=S.SCHEDULE_NO 
AND C.age LIKE '%'+@SEARCH +'%'
END;


go
drop proc EMP_CUSTOMER_SEARCH_TO
go
CREATE PROC EMP_CUSTOMER_SEARCH_TO

@SEARCH VARCHAR(50)
AS
BEGIN
SELECT S.BUS_NO,C.CNAME,C.AGE,C.cnic,C.phone,S.DEPT_DATE,S.FROM_PLACE,S.ARR_DATE,S.TO_PLACE FROM schedule S,BOOKING B,customer C WHERE B.cno=C.cno AND B.SCHEDULE_NO=S.SCHEDULE_NO 
AND S.TO_PLACE LIKE '%'+@SEARCH +'%'
END;

go
drop proc EMP_CUSTOMER_SEARCH_FROM
go
CREATE PROC EMP_CUSTOMER_SEARCH_FROM

@SEARCH VARCHAR(50)
AS
BEGIN
SELECT S.BUS_NO,C.CNAME,C.AGE,C.cnic,C.phone,S.DEPT_DATE,S.FROM_PLACE,S.ARR_DATE,S.TO_PLACE FROM schedule S,BOOKING B,customer C WHERE B.cno=C.cno AND B.SCHEDULE_NO=S.SCHEDULE_NO 
AND S.FROM_PLACE LIKE '%'+@SEARCH +'%'
END;


go
drop proc EMP_CUSTOMER_SEARCH_ARR
go
CREATE PROC EMP_CUSTOMER_SEARCH_ARR

@SEARCH VARCHAR(50)
AS
BEGIN
SELECT S.BUS_NO,C.CNAME,C.AGE,C.cnic,C.phone,S.DEPT_DATE,S.FROM_PLACE,S.ARR_DATE,S.TO_PLACE FROM schedule S,BOOKING B,customer C WHERE B.cno=C.cno AND B.SCHEDULE_NO=S.SCHEDULE_NO 
AND S.ARR_DATE =@SEARCH 
END;

go
drop proc EMP_CUSTOMER_SEARCH_DEP
go
CREATE PROC EMP_CUSTOMER_SEARCH_DEP
@SEARCH VARCHAR(50)
AS
BEGIN
SELECT S.BUS_NO,C.CNAME,C.AGE,C.cnic,C.phone,S.DEPT_DATE,S.FROM_PLACE,S.ARR_DATE,S.TO_PLACE FROM schedule S,BOOKING B,customer C WHERE B.cno=C.cno AND B.SCHEDULE_NO=S.SCHEDULE_NO 
AND S.DEPT_DATE =@SEARCH 
END;

go
drop proc EMP_CUSTOMER_SEARCH_BUS
go
CREATE PROC EMP_CUSTOMER_SEARCH_BUS

@SEARCH VARCHAR(50)
AS
BEGIN
SELECT S.BUS_NO,C.CNAME,C.AGE,C.cnic,C.phone,S.DEPT_DATE,S.FROM_PLACE,S.ARR_DATE,S.TO_PLACE FROM schedule S,BOOKING B,customer C WHERE B.cno=C.cno AND B.SCHEDULE_NO=S.SCHEDULE_NO 
AND S.BUS_NO =@SEARCH 
END;
go
-------------------------------------------------------------------------------------------------------
drop proc delete_tickets
go
create proc delete_tickets
@cno int
as
begin
delete from booking where cno=@cno;
delete from customer where cno=@cno;
end;


go

drop proc getdatafordelete
go
create proc getdatafordelete
@busno varchar(6),
@ddate varchar(50),
@adate varchar(50),
@sno  tinyint
as
begin
select  c.cname,c.cnic,b.ticket_price,b.seat_no,b.schedule_no,c.CNO,S.DEPT_DATE from booking b, customer c,schedule s where  c.cno=c.cno and  b.SCHEDULE_NO=s.SCHEDULE_NO and s.BUS_NO=@busno and s.DEPT_DATE=@ddate and s.ARR_DATE=@adate and b.seat_no=@sno;
end;
select * from customer
SELECT * FROM schedule;
select * from booking

select  c.cname,c.cnic,b.ticket_price,b.seat_no,b.schedule_no,c.CNO,S.DEPT_DATE from booking b, customer c,schedule s where  c.cno=b.cno and  b.SCHEDULE_NO=s.SCHEDULE_NO and s.BUS_NO='C2323' and s.DEPT_DATE='Thursday, April 18, 2019' and s.ARR_DATE='Sunday, April 21, 2019' and b.seat_no='30';
go
--this proc i used to full grid in pricelist form
DROP PROC emp_price_list
go
 CREATE PROCEDURE emp_price_list
 @cdate varchar(50)
AS
BEGIN
select b.bus_type,s.bus_no,s.from_place,s.to_place,s.price from schedule s,bus b where s.DEPT_DATE>=@cdate and b.BUS_NO=s.BUS_NO;
END





go
--used to get booked seats in bus

drop proc getLeftSeats
go
create  proc getLeftSeats
@DEPT_DATE VARCHAR(50),@ARR_DATE VARCHAR(50)
as
begin
select b.seat_no from booking b,schedule s where s.SCHEDULE_NO=b.SCHEDULE_NO and s.DEPT_DATE=@DEPT_DATE and s.ARR_DATE=@ARR_DATE
end;
