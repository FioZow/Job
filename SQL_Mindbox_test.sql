--Creat tables

CREATE TABLE Products(
	Id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	Name varchar(100) NOT NULL
);

CREATE TABLE Categories(
	Id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	Name varchar(100) NOT NULL
);

CREATE TABLE Product_Category(
	Id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	Product_id int NOT NULL,
	Category_id int NOT NULL
);

-- Set Foreigh keys

ALTER TABLE Product_Category  
ADD CONSTRAINT FK_Product_Category_Product_Product_id 
FOREIGN KEY(Product_id)
REFERENCES Products (Id);

ALTER TABLE Product_Category
ADD CONSTRAINT FK_Product_Category_Category_Category_id 
FOREIGN KEY(Category_id)
REFERENCES Categories (Id);

--Full tables

INSERT INTO Products
VALUES
	('Iphone'),
	('BMW'),
	('Kia-RIO'),
	('Acer'),
	('Ball'),
	('Milk'),
	('Lenovo');

INSERT INTO Categories
VALUES
	('Phone'),
	('Laptop'),
	('CarModel'),
	('Transport');

INSERT INTO Product_Category
VALUES
	(1, 1),
	(2, 3),
	(3, 3),
	(4, 2),
	(7, 2),
	(2, 4),
	(3, 4);

-- Execute the request

SELECT p.Name AS ProductName, c.Name AS CategoryName
FROM Products p
LEFT JOIN Product_Category pc ON pc.Product_id = p.Id
LEFT JOIN Categories c ON pc.Category_id = c.Id
ORDER BY p.Name, c.Name