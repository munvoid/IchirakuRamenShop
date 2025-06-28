
-- =======================================
-- Drop tables if they exist (in reverse order to handle FKs)
-- =======================================
IF OBJECT_ID('Confirms', 'U') IS NOT NULL DROP TABLE Confirms;
IF OBJECT_ID('Stores', 'U') IS NOT NULL DROP TABLE Stores;
IF OBJECT_ID('Has', 'U') IS NOT NULL DROP TABLE Has;
IF OBJECT_ID('Browses', 'U') IS NOT NULL DROP TABLE Browses;
IF OBJECT_ID('Updates', 'U') IS NOT NULL DROP TABLE Updates;
IF OBJECT_ID('Manages', 'U') IS NOT NULL DROP TABLE Manages;
IF OBJECT_ID('Payment', 'U') IS NOT NULL DROP TABLE Payment;
IF OBJECT_ID('Cart', 'U') IS NOT NULL DROP TABLE Cart;
IF OBJECT_ID('Product', 'U') IS NOT NULL DROP TABLE Product;
IF OBJECT_ID('Customer', 'U') IS NOT NULL DROP TABLE Customer;
IF OBJECT_ID('Stuff', 'U') IS NOT NULL DROP TABLE Stuff;
IF OBJECT_ID('Admin', 'U') IS NOT NULL DROP TABLE Admin;
IF OBJECT_ID('Users', 'U') IS NOT NULL DROP TABLE Users;

-- =======================================
-- Create tables
-- =======================================

CREATE TABLE Users (
    Uid INT PRIMARY KEY,
    Username NVARCHAR(50),
    Role NVARCHAR(20),
    Name NVARCHAR(100),
    Password NVARCHAR(100)
);

CREATE TABLE Admin (
    Aid INT PRIMARY KEY,
    Uid INT FOREIGN KEY REFERENCES Users(Uid)
);

CREATE TABLE Stuff (
    Sid INT PRIMARY KEY,
    Salary DECIMAL(10,2),
    Uid INT FOREIGN KEY REFERENCES Users(Uid)
);

CREATE TABLE Customer (
    Cid INT PRIMARY KEY,
    PhoneNum NVARCHAR(20),
    Uid INT FOREIGN KEY REFERENCES Users(Uid)
);

CREATE TABLE Product (
    Pid INT PRIMARY KEY,
    PName NVARCHAR(100),
    Price DECIMAL(10,2),
    Description NVARCHAR(255)
);

CREATE TABLE Cart (
    Cartid INT PRIMARY KEY
);

CREATE TABLE Payment (
    Payid INT PRIMARY KEY,
    TotalBill DECIMAL(10,2)
);

CREATE TABLE Manages (
    Aid INT FOREIGN KEY REFERENCES Admin(Aid),
    Pid INT FOREIGN KEY REFERENCES Product(Pid),
    PRIMARY KEY (Aid, Pid)
);

CREATE TABLE Updates (
    Sid INT FOREIGN KEY REFERENCES Stuff(Sid),
    Pid INT FOREIGN KEY REFERENCES Product(Pid),
    PRIMARY KEY (Sid, Pid)
);

CREATE TABLE Browses (
    Cid INT FOREIGN KEY REFERENCES Customer(Cid),
    Pid INT FOREIGN KEY REFERENCES Product(Pid),
    PRIMARY KEY (Cid, Pid)
);

CREATE TABLE Has (
    Cid INT FOREIGN KEY REFERENCES Customer(Cid),
    Cartid INT FOREIGN KEY REFERENCES Cart(Cartid),
    PRIMARY KEY (Cid, Cartid)
);

CREATE TABLE Stores (
    Cartid INT FOREIGN KEY REFERENCES Cart(Cartid),
    Pid INT FOREIGN KEY REFERENCES Product(Pid),
    Quantity INT,
    PRIMARY KEY (Cartid, Pid)
);

CREATE TABLE Confirms (
    Cartid INT FOREIGN KEY REFERENCES Cart(Cartid),
    Payid INT FOREIGN KEY REFERENCES Payment(Payid),
    PRIMARY KEY (Cartid, Payid)
);

-- =======================================
-- Insert sample data
-- =======================================

-- Users
INSERT INTO Users (Uid, Username, Role, Name, Password)
VALUES 
(1, 'john_doe', 'Admin', 'John Doe', 'pass123'),
(2, 'jane_smith', 'Stuff', 'Jane Smith', 'pass456'),
(3, 'bob_brown', 'Customer', 'Bob Brown', 'pass789');

-- Admin
INSERT INTO Admin (Aid, Uid)
VALUES (100, 1);

-- Stuff
INSERT INTO Stuff (Sid, Salary, Uid)
VALUES (200, 50000, 2);

-- Customer
INSERT INTO Customer (Cid, PhoneNum, Uid)
VALUES (300, '0123456789', 3);

-- Product
INSERT INTO Product (Pid, PName, Price, Description)
VALUES 
(1000, 'Laptop', 1000.00, 'Gaming laptop'),
(1001, 'Mouse', 25.50, 'Wireless mouse');

-- Cart
INSERT INTO Cart (Cartid)
VALUES (400);

-- Payment
INSERT INTO Payment (Payid, TotalBill)
VALUES (500, 1025.50);

-- Manages
INSERT INTO Manages (Aid, Pid)
VALUES 
(100, 1000),
(100, 1001);

-- Updates
INSERT INTO Updates (Sid, Pid)
VALUES 
(200, 1000);

-- Browses
INSERT INTO Browses (Cid, Pid)
VALUES 
(300, 1000),
(300, 1001);

-- Has
INSERT INTO Has (Cid, Cartid)
VALUES 
(300, 400);

-- Stores
INSERT INTO Stores (Cartid, Pid, Quantity)
VALUES 
(400, 1000, 1),
(400, 1001, 1);

-- Confirms
INSERT INTO Confirms (Cartid, Payid)
VALUES 
(400, 500);

-- =======================================
-- Done
-- =======================================
