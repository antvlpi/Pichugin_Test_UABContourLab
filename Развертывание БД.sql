CREATE DATABASE MyCompany;

USE MyCompany;

CREATE TABLE Department
(
	id INT IDENTITY(1,1) PRIMARY KEY,  
	name VARCHAR(100) NOT NULL
);

CREATE TABLE Employee
(
	id INT IDENTITY(1,1) PRIMARY KEY,  
	department_id INT NOT NULL,
	chief_id INT NOT NULL,
	name VARCHAR(100) NOT NULL,
	salary INT NOT NULL,
	CONSTRAINT FK_Department_ID FOREIGN KEY (department_id) REFERENCES Department(id),
	CONSTRAINT FK_Chief_ID FOREIGN KEY (department_id) REFERENCES Employee(id)
);