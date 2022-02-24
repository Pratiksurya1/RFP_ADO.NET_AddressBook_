CREATE PROCEDURE [dbo].[AddressBookProcedure]
@firstName varchar(10),
@lastName varchar(15),
@address varchar(50),
@city varchar(15),
@state varchar(15),
@zip varchar(7),
@mobileNo varchar(10),
@email varchar(30)
AS 
BEGIN

INSERT INTO contact_info(firstName,lastName,address,city,state,zip,mobileNo,email)VALUES(@firstName,@lastName,@address,@city,@state,@zip,@mobileNo,@email)

SELECT ERROR_NUMBER() AS ERRORNUMBER, ERROR_MESSAGE() AS ERRORMESSAGE
END