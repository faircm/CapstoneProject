CREATE DATABASE IF NOT EXISTS C969db;
USE c969db;
CREATE TABLE country(
	countryId INT PRIMARY KEY,
	country VARCHAR(50),
	createDate DATETIME,
	createdBy Varchar(40),
	lastUpdate TIMESTAMP,
	lastUpdateBy VARCHAR(40)
);
CREATE TABLE city(
	cityId INT PRIMARY KEY,
	city VARCHAR(50),
	countryId INT,
	createDate DATETIME,
	createdBy VARCHAR(40),
	lastUpdate TIMESTAMP,
	lastUpdateBy VARCHAR(40),
	FOREIGN KEY(countryId) REFERENCES country(countryId)
);
CREATE TABLE address(
	addressId INT PRIMARY KEY,
    address VARCHAR(50),
    address2 VARCHAR(50),
    cityId INT,
    postalCode VARCHAR(10),
    phone VARCHAR(20),
    createDate DATETIME,
    createdBy VARCHAR(40),
    lastUpdate TIMESTAMP,
    lastUpdateBy VARCHAR(40),
    FOREIGN KEY(cityId) REFERENCES city(cityId)
);
CREATE TABLE customer(
	customerId INT PRIMARY KEY,
	customerName VARCHAR(45),
	addressId INT,
	active TINYINT,
	createDate DATETIME,
	createdBy VARCHAR(40),
	lastUpdate TIMESTAMP,
	lastUpdateBy VARCHAR(40),
	FOREIGN KEY (addressId) REFERENCES address(addressId)
);
CREATE TABLE user(
	userId INT PRIMARY KEY,
	userName VARCHAR(50),
	password VARCHAR(50),
	active TINYINT,
	createDate DATETIME,
	createdBy VARCHAR(40),
	lastUpdate TIMESTAMP,
	lastUpdateBy VARCHAR(40)
);
CREATE TABLE appointment(
	appointmentId INT PRIMARY KEY,
	customerId INT,
	userId INT,
	title VARCHAR(255),
	description TEXT,
	location TEXT,
	contact TEXT,
	type TEXT,
    url VARCHAR(255),
    start DATETIME,
    end DATETIME,
    createDate DATETIME,
    createdBy VARCHAR(40),
    lastUpdate TIMESTAMP,
    lastUpdateBy VARCHAR(40),
    FOREIGN KEY (customerId) REFERENCES customer(customerId),
    FOREIGN KEY (userId) REFERENCES user(userId)
);

################### START OF SCRIPT #################################
 
-- Replace <schema name> with your schema name on the USE line Below:
 
USE C969db;
 
--
-- populate table `country`
--
INSERT INTO `country` VALUES 
(1,'US','2019-01-01 00:00:00','test','2019-01-01 00:00:00','test'),
(2,'Canada','2019-01-01 00:00:00','test','2019-01-01 00:00:00','test'),
(3,'Norway','2019-01-01 00:00:00','test','2019-01-01 00:00:00','test');
--
-- populate table `city`
--
INSERT INTO `city` VALUES 
(1,'New York',1,'2019-01-01 00:00:00','test','2019-01-01 00:00:00','test'),
(2,'Los Angeles',1,'2019-01-01 00:00:00','test','2019-01-01 00:00:00','test'),
(3,'Toronto',2,'2019-01-01 00:00:00','test','2019-01-01 00:00:00','test'),
(4,'Vancouver',2,'2019-01-01 00:00:00','test','2019-01-01 00:00:00','test'),
(5,'Oslo',3,'2019-01-01 00:00:00','test','2019-01-01 00:00:00','test');
--
-- populate table `address`
--
INSERT INTO `address` VALUES 
(1,'123 Main','',1,'11111','555-1212','2019-01-01 00:00:00','test','2019-01-01 00:00:00','test'),
(2,'123 Elm','',3,'11112','555-1213','2019-01-01 00:00:00','test','2019-01-01 00:00:00','test'),
(3,'123 Oak','',5,'11113','555-1214','2019-01-01 00:00:00','test','2019-01-01 00:00:00','test');
--
-- populate table `customer`
--
INSERT INTO `customer` VALUES 
(1,'John Doe',1,1,'2019-01-01 00:00:00','test','2019-01-01 00:00:00','test'),
(2,'Alfred E Newman',2,1,'2019-01-01 00:00:00','test','2019-01-01 00:00:00','test'),
(3,'Ina Prufung',3,1,'2019-01-01 00:00:00','test','2019-01-01 00:00:00','test');
--
-- populate table `user`
--
INSERT INTO `user` VALUES 
(1,'test','test',1,'2019-01-01 00:00:00','test','2019-01-01 00:00:00','test');
--
-- populate table `appointment`
--
INSERT INTO `appointment` VALUES 
(1,1,1,'not needed','not needed','not needed','not needed','Presentation','not needed','2019-01-01 00:00:00','2019-01-01 00:00:00','2019-01-01 00:00:00','test','2019-01-01 00:00:00','test'),
(2,2,1,'not needed','not needed','not needed','not needed','Scrum','not needed','2019-01-01 00:00:00','2019-01-01 00:00:00','2019-01-01 00:00:00','test','2019-01-01 00:00:00','test');
 
 
######################### END OF SCRIPT #############################