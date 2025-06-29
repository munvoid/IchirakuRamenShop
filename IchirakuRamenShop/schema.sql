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
    Pid INT PRIMARY KEY IDENTITY(1,1),
    PName NVARCHAR(100),
    Price DECIMAL(10,2),
	Image Image,
    Description NVARCHAR(255)
);

CREATE TABLE Cart (
    Cartid INT PRIMARY KEY IDENTITY(1,1)
); 

CREATE TABLE Payment (
    Payid INT PRIMARY KEY,
    TotalBill DECIMAL(10,2)
);

--CREATE TABLE Manages (
--    Aid INT FOREIGN KEY REFERENCES Admin(Aid),
--    Pid INT FOREIGN KEY REFERENCES Product(Pid),
--    PRIMARY KEY (Aid, Pid)
--);

--CREATE TABLE Updates (
--    Sid INT FOREIGN KEY REFERENCES Stuff(Sid),
--    Pid INT FOREIGN KEY REFERENCES Product(Pid),
--    PRIMARY KEY (Sid, Pid)
--);

--CREATE TABLE Browses (
--    Cid INT FOREIGN KEY REFERENCES Customer(Cid),
--    Pid INT FOREIGN KEY REFERENCES Product(Pid),
--    PRIMARY KEY (Cid, Pid)
--);

CREATE TABLE Has (
    Cid INT FOREIGN KEY REFERENCES Customer(Cid),
    Cartid INT FOREIGN KEY REFERENCES Cart(Cartid),
    PRIMARY KEY (Cid, Cartid)
);

CREATE TABLE Stores (
    Cartid INT FOREIGN KEY REFERENCES Cart(Cartid) ON DELETE CASCADE,
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
(1, 'rahim01', 'Admin', 'Rahim', '1234'),
(2, 'karim02', 'Stuff', 'Karim', 'abcd'),
(3, 'mina03', 'Customer', 'Mina', 'pass');

-- Admin
INSERT INTO Admin (Aid, Uid)
VALUES (100, 1);

-- Stuff
INSERT INTO Stuff (Sid, Salary, Uid)
VALUES (200, 30000, 2);

-- Customer
INSERT INTO Customer (Cid, PhoneNum, Uid)
VALUES (300, '01712345678', 3);

-- Product (Ramen names)
INSERT INTO Product (PName, Price, Description)
VALUES 
('Miso Ramen', 250.00, 'Miso Ramen'),
('Soya Ramen', 220.50, 'Soya Ramen');
INSERT INTO Product (PName, Price, Description, Image) VALUES ('Tonkotsu Ramen', 350.00, 'Creamy pork broth ramen', NULL);
INSERT INTO Product (PName, Price, Description, Image) VALUES ('Miso Ramen', 300.00, 'Rich miso-based ramen', NULL);
INSERT INTO Product (PName, Price, Description, Image) VALUES ('Shoyu Ramen', 280.00, 'Soy sauce flavored ramen', NULL);
INSERT INTO Product (PName, Price, Description, Image) VALUES ('Spicy Ramen', 320.00, 'Spicy red chili ramen', NULL);
INSERT INTO Product (PName, Price, Description, Image) VALUES ('Seafood Ramen', 400.00, 'Ramen with shrimp and squid', NULL);
INSERT INTO Product (PName, Price, Description, Image) VALUES ('Vegetable Ramen', 250.00, 'Vegan-friendly vegetable ramen', NULL);
INSERT INTO Product (PName, Price, Description, Image) VALUES ('Naruto Ramen', 420.00, 'Special Ichiraku Naruto favorite', NULL);
INSERT INTO Product (PName, Price, Description, Image) VALUES ('Chicken Ramen', 290.00, 'Grilled chicken with soy broth', NULL);
INSERT INTO Product (PName, Price, Description, Image) VALUES ('Beef Ramen', 370.00, 'Beef strips with spicy soy broth', NULL);
INSERT INTO Product (PName, Price, Description, Image) VALUES ('Cold Ramen', 260.00, 'Chilled ramen with sesame sauce', NULL);

-- Cart
INSERT INTO Cart DEFAULT VALUES;

-- Payment
INSERT INTO Payment (Payid, TotalBill)
VALUES (500, 470.50);



-- Has
INSERT INTO Has (Cid, Cartid)
VALUES 
(300, 1);

-- Stores
INSERT INTO Stores (Cartid, Pid, Quantity)
VALUES 
(1, 1, 1),
(1, 2, 1);

-- Confirms
INSERT INTO Confirms (Cartid, Payid)
VALUES 
(1, 500);

-- =======================================
-- Done
-- =======================================
