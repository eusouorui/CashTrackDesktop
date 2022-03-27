DROP DATABASE IF EXISTS cashtrackdb;
CREATE DATABASE  IF NOT EXISTS cashtrack_db;
USE cashtrack_db;


DROP TABLE IF EXISTS company;
CREATE TABLE company (
  id int(11) NOT NULL AUTO_INCREMENT,
  isEnabled tinyint(4) NOT NULL,
  name varchar(255) NOT NULL,
  PRIMARY KEY (id)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

DROP TABLE IF EXISTS location;
CREATE TABLE location (
  id int(11) NOT NULL AUTO_INCREMENT,
  city varchar(255) DEFAULT NULL,
  address varchar(255) DEFAULT NULL,
  zipcode varchar(10) DEFAULT NULL,
  PRIMARY KEY (id)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

DROP TABLE IF EXISTS client;
CREATE TABLE client (
  id int(10)  NOT NULL AUTO_INCREMENT,
  isEnabled tinyint(4) NOT NULL DEFAULT '1',
  firstName varchar(255) NOT NULL,
  lastName varchar(255) DEFAULT NULL,
  birthDate date NOT NULL,
  email varchar(255) NOT NULL,
  password varchar(30) NOT NULL,
  createdAt timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  updatedAt timestamp NOT NULL,
  locationID int(10)  NOT NULL,
  PRIMARY KEY (id),
  UNIQUE KEY email_UNIQUE (email),
  CONSTRAINT fk_locationID FOREIGN KEY (locationID) REFERENCES location (id)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

DROP TABLE IF EXISTS transactioncategory;
CREATE TABLE transactioncategory (
  id int(11) NOT NULL AUTO_INCREMENT,
  isEnabled tinyint(4) NOT NULL DEFAULT '1',
  description varchar(50) NOT NULL,
  PRIMARY KEY (id)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

DROP TABLE IF EXISTS transactiontype;
CREATE TABLE transactiontype (
  id int(11) NOT NULL AUTO_INCREMENT,
  transactionType varchar(45) NOT NULL,
  PRIMARY KEY (id)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

DROP TABLE IF EXISTS transaction;
CREATE TABLE transaction (
  id int(10)  NOT NULL AUTO_INCREMENT,
  isEnabled tinyint(4) NOT NULL DEFAULT '1',
  clientID int(11) NOT NULL,
  transactionTypeId int(10)  NOT NULL,
  companyID int(11) NOT NULL,
  transactionCategoryID int(11) NOT NULL,
  value double NOT NULL DEFAULT '0',
  transactionDate datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  description varchar(255) DEFAULT NULL,
  PRIMARY KEY (id),
  KEY fk_clientID (clientID),
  KEY fk_transactionTypeID (transactionTypeId),
  KEY fk_transactionCategory_idx (transactionCategoryID),
  KEY fk_Company_idx (companyID),
  CONSTRAINT fk_CompanyID FOREIGN KEY (companyID) REFERENCES company (id),
  CONSTRAINT fk_clientID FOREIGN KEY (clientID) REFERENCES client (id),
  CONSTRAINT fk_transactionCategoryID FOREIGN KEY (transactionCategoryID) REFERENCES transactioncategory (id),
  CONSTRAINT fk_transactionTypeID FOREIGN KEY (transactionTypeId) REFERENCES transactionType(id)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
