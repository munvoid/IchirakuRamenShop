-- Drop tables if exist (for re-run)
BEGIN
    EXECUTE IMMEDIATE 'DROP TABLE Confirms CASCADE CONSTRAINTS';
    EXECUTE IMMEDIATE 'DROP TABLE Stores CASCADE CONSTRAINTS';
    EXECUTE IMMEDIATE 'DROP TABLE Has CASCADE CONSTRAINTS';
    EXECUTE IMMEDIATE 'DROP TABLE Browses CASCADE CONSTRAINTS';
    EXECUTE IMMEDIATE 'DROP TABLE Updates CASCADE CONSTRAINTS';
    EXECUTE IMMEDIATE 'DROP TABLE Manages CASCADE CONSTRAINTS';
    EXECUTE IMMEDIATE 'DROP TABLE Payment CASCADE CONSTRAINTS';
    EXECUTE IMMEDIATE 'DROP TABLE Cart CASCADE CONSTRAINTS';
    EXECUTE IMMEDIATE 'DROP TABLE Product CASCADE CONSTRAINTS';
    EXECUTE IMMEDIATE 'DROP TABLE Customer CASCADE CONSTRAINTS';
    EXECUTE IMMEDIATE 'DROP TABLE Stuff CASCADE CONSTRAINTS';
    EXECUTE IMMEDIATE 'DROP TABLE Admin CASCADE CONSTRAINTS';
    EXECUTE IMMEDIATE 'DROP TABLE User CASCADE CONSTRAINTS';
EXCEPTION WHEN OTHERS THEN NULL;
END;
/

-- =======================================
-- Create Tables
-- =======================================

CREATE TABLE User (
    Uid NUMBER PRIMARY KEY,
    Username VARCHAR2(50),
    Role VARCHAR2(20),
    Name VARCHAR2(100),
    Password VARCHAR2(100)
);

CREATE TABLE Admin (
    Aid NUMBER PRIMARY KEY,
    Uid NUMBER,
    CONSTRAINT fk_admin_user FOREIGN KEY (Uid) REFERENCES User(Uid)
);

CREATE TABLE Stuff (
    Sid NUMBER PRIMARY KEY,
    Salary NUMBER,
    Uid NUMBER,
    CONSTRAINT fk_stuff_user FOREIGN KEY (Uid) REFERENCES User(Uid)
);

CREATE TABLE Customer (
    Cid NUMBER PRIMARY KEY,
    PhoneNum VARCHAR2(20),
    Uid NUMBER,
    CONSTRAINT fk_customer_user FOREIGN KEY (Uid) REFERENCES User(Uid)
);

CREATE TABLE Product (
    Pid NUMBER PRIMARY KEY,
    PName VARCHAR2(100),
    Price NUMBER(10,2),
    Description VARCHAR2(255)
);

CREATE TABLE Cart (
    Cartid NUMBER PRIMARY KEY
);

CREATE TABLE Payment (
    Payid NUMBER PRIMARY KEY,
    TotalBill NUMBER(10,2)
);

CREATE TABLE Manages (
    Aid NUMBER,
    Pid NUMBER,
    CONSTRAINT fk_manages_admin FOREIGN KEY (Aid) REFERENCES Admin(Aid),
    CONSTRAINT fk_manages_product FOREIGN KEY (Pid) REFERENCES Product(Pid),
    CONSTRAINT pk_manages PRIMARY KEY (Aid, Pid)
);

CREATE TABLE Updates (
    Sid NUMBER,
    Pid NUMBER,
    CONSTRAINT fk_updates_stuff FOREIGN KEY (Sid) REFERENCES Stuff(Sid),
    CONSTRAINT fk_updates_product FOREIGN KEY (Pid) REFERENCES Product(Pid),
    CONSTRAINT pk_updates PRIMARY KEY (Sid, Pid)
);

CREATE TABLE Browses (
    Cid NUMBER,
    Pid NUMBER,
    CONSTRAINT fk_browses_customer FOREIGN KEY (Cid) REFERENCES Customer(Cid),
    CONSTRAINT fk_browses_product FOREIGN KEY (Pid) REFERENCES Product(Pid),
    CONSTRAINT pk_browses PRIMARY KEY (Cid, Pid)
);

CREATE TABLE Has (
    Cid NUMBER,
    Cartid NUMBER,
    CONSTRAINT fk_has_customer FOREIGN KEY (Cid) REFERENCES Customer(Cid),
    CONSTRAINT fk_has_cart FOREIGN KEY (Cartid) REFERENCES Cart(Cartid),
    CONSTRAINT pk_has PRIMARY KEY (Cid, Cartid)
);

CREATE TABLE Stores (
    Cartid NUMBER,
    Pid NUMBER,
    Quantity NUMBER,
    CONSTRAINT fk_stores_cart FOREIGN KEY (Cartid) REFERENCES Cart(Cartid),
    CONSTRAINT fk_stores_product FOREIGN KEY (Pid) REFERENCES Product(Pid),
    CONSTRAINT pk_stores PRIMARY KEY (Cartid, Pid)
);

CREATE TABLE Confirms (
    Cartid NUMBER,
    Payid NUMBER,
    CONSTRAINT fk_confirms_cart FOREIGN KEY (Cartid) REFERENCES Cart(Cartid),
    CONSTRAINT fk_confirms_payment FOREIGN KEY (Payid) REFERENCES Payment(Payid),
    CONSTRAINT pk_confirms PRIMARY KEY (Cartid, Payid)
);

-- =======================================
-- Insert sample data
-- =======================================

-- User
INSERT INTO User VALUES (1, 'john_doe', 'Admin', 'John Doe', 'pass123');
INSERT INTO User VALUES (2, 'jane_smith', 'Stuff', 'Jane Smith', 'pass456');
INSERT INTO User VALUES (3, 'bob_brown', 'Customer', 'Bob Brown', 'pass789');

-- Admin
INSERT INTO Admin VALUES (100, 1);

-- Stuff
INSERT INTO Stuff VALUES (200, 50000, 2);

-- Customer
INSERT INTO Customer VALUES (300, '0123456789', 3);

-- Product
INSERT INTO Product VALUES (1000, 'Laptop', 1000.00, 'Gaming laptop');
INSERT INTO Product VALUES (1001, 'Mouse', 25.50, 'Wireless mouse');

-- Cart
INSERT INTO Cart VALUES (400);

-- Payment
INSERT INTO Payment VALUES (500, 1025.50);

-- Manages
INSERT INTO Manages VALUES (100, 1000);
INSERT INTO Manages VALUES (100, 1001);

-- Updates
INSERT INTO Updates VALUES (200, 1000);

-- Browses
INSERT INTO Browses VALUES (300, 1000);
INSERT INTO Browses VALUES (300, 1001);

-- Has
INSERT INTO Has VALUES (300, 400);

-- Stores
INSERT INTO Stores VALUES (400, 1000, 1);
INSERT INTO Stores VALUES (400, 1001, 1);

-- Confirms
INSERT INTO Confirms VALUES (400, 500);

-- =======================================
-- Commit
-- =======================================
COMMIT;

-- =======================================
-- Done
-- =======================================
BEGIN
    DBMS_OUTPUT.PUT_LINE('✅ Database created and seeded successfully.');
END;
/