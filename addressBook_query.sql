
CREATE DATABASE AddressBook

USE AddressBook

CREATE TABLE AddressBook(
bookID int IDENTITY PRIMARY KEY,
book_Name varchar(20)
)

CREATE TABLE contact_info(
book_Id INT FOREIGN KEY REFERENCES AddressBook(bookID),
contact_Id INT IDENTITY PRIMARY KEY,
firstName VARCHAR(10),
lastName VARCHAR(15),
address VARCHAR(50),
city VARCHAR(15),
state VARCHAR(15),
zip VARCHAR(7),
mobileNo VARCHAR(10),
email VARCHAR(30)
)

CREATE TABLE contact_type(
type_Id INT IDENTITY PRIMARY KEY,
contact_name VARCHAR (20),
)