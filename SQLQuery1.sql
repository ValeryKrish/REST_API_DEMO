create database User_Data;

create table tblRequesTest(
Id int identity primary key ,
UserName varchar(250) , 
PatronymicName  varchar(250),
SurnameName varchar(250),
PolicyNumber varchar (max),
DateOfBirth date 
)

insert into tblRequesTest values ('�������', '���������', '������' , '7023655000213658' , '1990-12-31' );
insert into tblRequesTest values ('��������', '�������������', '������' , '6650023325574123' , '1995-10-22' );
insert into tblRequesTest values ('��������', '�������', '������' , '8800320325877412' , '1989-09-07' );

select * from tblRequesTest

