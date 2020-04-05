
CREATE DATABASE Team13shop
---------------------------------------------------------------------------------------------------------------------------------------------------------------------
USE DB_A573D4_team13
---------------------------------------------------------------------------------------------------------------------------------------------------------------------
CREATE TABLE USERS
(
	[U_ID] INT PRIMARY KEY IDENTITY(1,1)
	,[U_Pass] char(16) NOT NULL
	,[U_FName] char(16)
	,[U_LName] char(16)
	,[U_Address] char(32)
	,[U_Country] char(16)
	,[U_Zipcode] char(6)
	,[U_Phone] CHAR(15)
	,[U_Email] char(50) UNIQUE
	,[U_Role] char(12)  NOT NULL
	CONSTRAINT ck_U_Role CHECK ([U_Role] IN('Master','Admin','Mod','Sale','Customer'))
);

CREATE TABLE PRODUCTS
(
	[P_ID] INT PRIMARY KEY IDENTITY(1,1)
	,[P_Name] char(50) NOT NULL
	,[P_Category] char(32) NOT NULL
	CONSTRAINT ck_P_Category CHECK ([P_Category] IN('Cat1','Cat2','Cat3','Cat4','Cat5'))
	,[P_Image] VarBinary(max)
	,[P_Price] int
	,[P_Description] varchar(max)
);

CREATE TABLE ORDERS
(
	[O_ID] INT PRIMARY KEY IDENTITY(1,1)
	,[O_Date] datetime
	,[O_UID] int FOREIGN KEY REFERENCES USERS(U_ID)
	,[O_PIDS] int
	,[O_Amount] int
	,[O_Status] char(12) NOT NULL
	CONSTRAINT ck_O_Status CHECK([O_Status] IN('Cart', 'Processing', 'Shipping', 'Delivered', 'Returning', 'Returned' ))
);

CREATE TABLE INVENTORY
(
	[I_ID] int PRIMARY KEY IDENTITY(1,1)
	,[I_PID] int FOREIGN KEY REFERENCES PRODUCTS(P_ID)
	,[I_Price] int
	,[I_Amount] int
	,[I_Status] char(12) NOT NULL
	CONSTRAINT ck_I_Status CHECK([I_Status] IN('In_stock', 'Out_of_stock', 'Ordering', 'Shipping', 'Will_not_restock'))
);

CREATE TABLE REVIEW
(
	[R_ID] int PRIMARY KEY IDENTITY(1,1)
	,[R_UID] int
	,[R_Title] char(50)
	,[R_Content] char(300)
	,[R_Star] int
);


----------------------------------------------BEGIN USERS INSERT---------------------------------
INSERT INTO  USERS ([U_Pass],[U_FName],[U_LName],[U_Address],[U_Country],[U_Zipcode],[U_Phone],[U_Email],[U_Role] )
VALUES ('123456','admin','Team13','123 Houston','US','77057','8752146897','admin@gmail.com','Master');
INSERT INTO  USERS ([U_Pass],[U_FName],[U_LName],[U_Address],[U_Country],[U_Zipcode],[U_Phone],[U_Email],[U_Role] )
VALUES ('123456','Quang','Truong','123 Katy','US','77494','8322386527','quang@gmail.com','Admin');
INSERT INTO  USERS ([U_Pass],[U_FName],[U_LName],[U_Address],[U_Country],[U_Zipcode],[U_Phone],[U_Email],[U_Role] )
VALUES ('123456','Alonso','Munoz','123 Houston','US','77774','8322385893','alonso@gmail.com','Admin');
INSERT INTO  USERS ([U_Pass],[U_FName],[U_LName],[U_Address],[U_Country],[U_Zipcode],[U_Phone],[U_Email],[U_Role] )
VALUES ('123456','Jake',null,'123 Houston','US','77477','8322381457','jake@gmail.com','Admin');
INSERT INTO  USERS ([U_Pass],[U_FName],[U_LName],[U_Address],[U_Country],[U_Zipcode],[U_Phone],[U_Email],[U_Role] )
VALUES ('123456','Robbie','Hines','123 Houston','US','77071','8322321145','robbie@gmail.com','Admin');
INSERT INTO  USERS ([U_Pass],[U_FName],[U_LName],[U_Address],[U_Country],[U_Zipcode],[U_Phone],[U_Email],[U_Role] )
VALUES ('123456','Sim','ran','123 Houston','US','77072','8322382570','sim@gmail.com','Admin');
INSERT INTO  USERS ([U_Pass],[U_FName],[U_LName],[U_Address],[U_Country],[U_Zipcode],[U_Phone],[U_Email],[U_Role] )
VALUES ('123456','John','Kennedy','123 Some where','US','77845','8325647578','john@gmail.com','Sale');
INSERT INTO  USERS ([U_Pass],[U_FName],[U_LName],[U_Address],[U_Country],[U_Zipcode],[U_Phone],[U_Email],[U_Role] )
VALUES ('123456','Franky','Kennedy','123 Some where','US',null,'8325647854','franky@gmail.com','Mod');
INSERT INTO  USERS ([U_Pass],[U_FName],[U_LName],[U_Address],[U_Country],[U_Zipcode],[U_Phone],[U_Email],[U_Role] )
VALUES ('123456','Fluffy','Kennedy','123 Some where',null,'77845','8325647844','Fluffy@gmail.com','Mod');
INSERT INTO  USERS ([U_Pass],[U_FName],[U_LName],[U_Address],[U_Country],[U_Zipcode],[U_Phone],[U_Email],[U_Role] )
VALUES ('123456','Nami','Munchy','456 Some where this','US','77845','8325647154','nami@gmail.com','Sale');
INSERT INTO  USERS ([U_Pass],[U_FName],[U_LName],[U_Address],[U_Country],[U_Zipcode],[U_Phone],[U_Email],[U_Role] )
VALUES ('123456','Ussop','Oncepiece','234 Some where that','US','77845','8325647474','ussop@gmail.com','Customer');
INSERT INTO  USERS ([U_Pass],[U_FName],[U_LName],[U_Address],[U_Country],[U_Zipcode],[U_Phone],[U_Email],[U_Role] )
VALUES ('123456','Ben','Ken','546 there','FR','77845','8325647854',null,'Customer');
INSERT INTO  USERS ([U_Pass],[U_FName],[U_LName],[U_Address],[U_Country],[U_Zipcode],[U_Phone],[U_Email],[U_Role] )
VALUES ('123456','Jerry','Smith','14324223 this','US','77845','8325645874','jerry@yahoo.com','Customer');
INSERT INTO  USERS ([U_Pass],[U_FName],[U_LName],[U_Address],[U_Country],[U_Zipcode],[U_Phone],[U_Email],[U_Role] )
VALUES ('123456','Berry','Cherry','123432 that','UK','77845',null,'nerry@yahoo.com','Customer');
INSERT INTO  USERS ([U_Pass],[U_FName],[U_LName],[U_Address],[U_Country],[U_Zipcode],[U_Phone],[U_Email],[U_Role] )
VALUES ('123456','Abraham','Lincon',null ,'US',null,'8325645896','abraham@yahoo.com','Customer');
INSERT INTO  USERS ([U_Pass],[U_FName],[U_LName],[U_Address],[U_Country],[U_Zipcode],[U_Phone],[U_Email],[U_Role] )
VALUES ('123456','Ali','Muhamad','1432423 here',null,'77845','8875647854','ali@yahoo.com','Customer');
----------------------------------------------END USERS INSERT---------------------------------
---------------------------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------BEGIN PRODUCTS INSERT-----------------------------
INSERT INTO PRODUCTS ([P_Name], [P_Category], [P_Image], [P_Price], [P_Description])
Values('Bananas','cat1',NULL, NULL,NULL);
---------------------------------------------END PRODUCTS INSERT-----------------------------
---------------------------------------------------------------------------------------------------------------------------------------------------------------------
--------------------------------------------BEGIN ORDER INSERT-----------------------------------

--------------------------------------------END ORDER INSERT-----------------------------------
---------------------------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------BEGIN INVENTORY INSERT-------------------------------

---------------------------------------------END INVENTORY INSERT-------------------------------
---------------------------------------------------------------------------------------------------------------------------------------------------------------------
--------------------------------------------BEGIN REVIEW INSERT-------------------------------------
Insert Into REVIEW(R_UID, R_Title, R_Content, R_Star)
Values (1, 'Test', 'Product was great', 5);
Insert Into REVIEW(R_UID, R_Title, R_Content, R_Star)
Values (1, 'Test2', 'This is another test done by Robert', 1);
--------------------------------------------END REVIEW INSERT-------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------------------------------------


---------------------------------------------------------------------------------------------------------------------------------------------------------------------

SELECT * FROM USERS
SELECT * FROM PRODUCTS
SELECT * FROM ORDERS
SELECT * FROM INVENTORY
SELECT * FROM REVIEW

---------------------------------------------------------------------------------------------------------------------------------------------------------------------

DROP TABLE ORDERS
DROP TABLE USERS

---------------------------------------------------------------------------------------------------------------------------------------------------------------------
