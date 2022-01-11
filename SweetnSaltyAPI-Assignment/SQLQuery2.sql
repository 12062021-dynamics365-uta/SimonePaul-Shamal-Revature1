SELECT * FROM Person;
SELECT * FROM Flavor; 
SELECT * FROM PersonFlavorJunction;



CREATE DATABASE SweetnSaltyDB;


CREATE TABLE Person
(
	person_Id BIGINT(10) NOT NULL AUTO_INCREMENT,
	person_FName VARCHAR(255) NOT NULL,
	person_LName VARCHAR(255) NOT NULL,
    PRIMARY KEY (person_Id) );



CREATE TABLE Flavor
(

	flavor_Id BIGINT(10) NOT NULL AUTO_INCREMENT,
	flavor_Name VARCHAR(255) NOT NULL,
    PRIMARY KEY (flavor_Id) );



CREATE TABLE PersonFlavorJunction
(
		flavor_Id BIGINT(10), person_Id BIGINT(10),
       CONSTRAINT FK_PersonFlavorJunction FOREIGN KEY (person_Id)
	   REFERENCES Person(person_Id),
	   CONSTRAINT FK_FlavorPersonJunction FOREIGN KEY (flavor_Id)
	   REFERENCES Flavor(flavor_Id)
        
	);
 INSERT INTO Person VALUES (1, 'Jane', 'Doe');
 INSERT INTO Person VALUES (NULL, 'Jane', 'Doe');
 INSERT INTO Flavor VALUES (1, 'Sweet');
 INSERT INTO Flavor VALUES (NULL, 'Salty');
 INSERT INTO Flavor VALUES (NULL, 'SweetNSalty');
 
 

    
