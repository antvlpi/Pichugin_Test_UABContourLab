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

SELECT em1.chief_id ID_������������, em1.name ���, em1.salary ��, de.name ����� FROM Employee AS em1
INNER JOIN Employee AS em2
ON em1.chief_id = em2.id
INNER JOIN Department AS de
ON em1.department_id = de.id
WHERE (em1.chief_id = em2.id and em1.salary > em2.salary);