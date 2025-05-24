-- Database Creation
create database Foodhub;

-- Creating tables

-- Customer table
create table Customer (
   customer_id    int primary key,
   customer_name  varchar(100) NOT NULL,
   contact_no     varchar(15) unique,
   nic            varchar(11) unique,
   dob            date check (dob < GETDATE())
);

select * from Customer;


-- Location table (customer delivery address)
create table Location (
   location_id    int identity(1,1) primary key,
   customer_id    int NOT NULL,
   location_no    varchar(50) NOT NULL,
   lane           varchar(50) NOT NULL,
   street         varchar(50) NOT NULL,
   city           varchar(50) NOT NULL,
   constraint FK_Location_Customer
     foreign key(customer_id) references customer(customer_id)
);

select * from Location;

-- Rider table
create table Rider (
   employee_no    int identity(1,1) primary key,
   first_name     varchar(50)  NOT NULL,
   middle_name    varchar(50)  NULL,
   last_name      varchar(50)  NOT NULL,
   nic            varchar(15)  NOT NULL unique,
   dob            date         NOT NULL check(dob < GETDATE()),
   license_no     varchar(20)  NOT NULL,
   shift          varchar(20)  NOT NULL,
   address        varchar(255) NOT NULL,
   contact_no     varchar(15)  NOT NULL
);

select * from Rider;

-- Dependent table (the weak entity of Rider)
create table Dependent (
   employee_no    int          NOT NULL,
   dependent_name varchar(100) NOT NULL,
   relationship   varchar(50)  NOT NULL,
   dob            date         NOT NULL check(dob < GETDATE()),
   constraint PK_Dependent primary key(employee_no, dependent_name),
   constraint FK_Dependent_Rider
     foreign key(employee_no) references Rider(employee_no)
);

select * from Dependent;

-- Motorbike table
create table Motorbike(
   registration_no    varchar(20) primary key,
   registration_date  date        NOT NULL,
   engine_no          varchar(50) NOT NULL,
   brand              varchar(50) NOT NULL,
   model              varchar(50) NOT NULL,
   color              varchar(10) NOT NULL
);

select * from Motorbike;

-- Assign (associative table for Rider-Motorbike)
create table Assign (
   employee_no         int         NOT NULL,
   registration_no     varchar(20) NOT NULL,
   assign_date         date        NOT NULL,
   m_reader_at_assign  int         NOT NULL check(m_reader_at_assign >= 0),
   m_reader_at_return  int         NULL check(m_reader_at_return >= 0),
   constraint PK_Assign primary key(employee_no, registration_no, assign_date),
    constraint FK_Assign_Rider
      foreign key(employee_no) references Rider(employee_no),
    constraint FK_Assign_Motorbike
      foreign key(registration_no) references Motorbike(registration_no)
);

select * from Assign;

-- Item table
create table Item (
    item_no     int            identity(1,1) primary key,
    item_name   varchar(100)   NOT NULL,
    category    varchar(50)    NOT NULL,
    price       decimal(10,2)  NOT NULL check(price >= 0)
);

select * from Item;

-- Ingredient (this is a multi‐valued attribute)
create table Ingredient (
    item_no    int          NOT NULL,
    ingredient varchar(50)  NOT NULL,
    constraint PK_Ingredient primary key(item_no, ingredient),
    constraint FK_Ingredient_Item
      foreign key(item_no) references Item(item_no)
);

select * from Ingredient;

-- Orders table
create table Orders (
    order_no        int            identity(1,1) primary key,
    customer_id     int            NOT NULL,
    employee_no     int            NOT NULL,
    order_date      date           NOT NULL,
    order_time      time           NOT NULL,
    order_amount    decimal(10,2)  NOT NULL check(order_amount >= 0),
    payment_method  varchar(50)    NOT NULL,
    status          varchar(50)    NOT NULL,
    location_id     int            NOT NULL,
    dispatch_time   time           NULL,
    constraint FK_Orders_Customer
      foreign key(customer_id) references Customer(customer_id),
    constraint FK_Orders_Rider
      foreign key(employee_no) references Rider(employee_no),
    constraint FK_Orders_Location
      foreign key(location_id) references Location(location_id)
);

select * from Orders;

-- Order_Item (associative table for the Orders–Items table)
create table Order_Item (
    order_no     int            NOT NULL,
    item_no      int            NOT NULL,
    quantity     int            NOT NULL check(quantity > 0),
    unit_price   decimal(10,2)  NOT NULL check(unit_price >= 0),
    constraint PK_OrderItem primary key(order_no, item_no),
    constraint FK_OrderItem_Orders
      foreign key(order_no) references Orders(order_no),
    constraint FK_OrderItem_Item
      foreign key(item_no) references Item(item_no)
);

select * from Order_Item;

-- Data Manipulation and Querying (DML) 
    -- Data Population using INSERT Command

-- Customers table
INSERT INTO Customer (customer_id, customer_name, nic, dob, contact_no)
VALUES
  (1, 'Savin Nihan', '8012345601V', '1980-01-01', '0712345678'),
  (2, 'Kavini Sihara', '9078901212V', '1990-05-12', '0776543210'),
  (3, 'Muthumala Perera', '8523456789V', '1985-11-23', '0719876543'),
  (4,'Pasan Udana', '9812886903V', '1998-07-22', '0758700515');

select * from Customer;

-- Locations table
INSERT INTO Location (customer_id, location_no, lane, street, city)
VALUES
  (1,'5A', 'Woodwork', 'Main Avenue', 'Colombo'),
  (2,'4B', 'Araliya', 'Second Street', 'Kandy'),
  (1,'16C', 'Kurunduwaththa', 'Beach Road', 'Galle'),
  (3,'7D', 'Samanala', 'Garden Road', 'Kalutara');

select * from Location;

-- Riders table
INSERT INTO Rider (first_name, middle_name, last_name, nic, dob, license_no, shift, address, contact_no)
VALUES
  ('Mavin','Madduma','Leshara','8522233302V','1985-02-02','LIC98765','Morning','123 Delivery Lane','0771112223'),
  ('Eshan','Kavindu','Silva','9011122210V','1990-10-10','LIC12345','Evening','456 Distribution Rd','0773334445'),
  ('Nisha','Priyanka','Fernando', '9922233344V', '2000-06-15', 'LIC54321', 'Morning', '789 Fast Lane', '0775556667');

select * from Rider;

-- Dependents table
INSERT INTO Dependent (employee_no, dependent_name, relationship, dob)
VALUES
  (1, 'Devindi Rukshani', 'Daughter', '2010-07-15'),
  (1, 'Sanith Pasindu',  'Son',     '2012-09-10');

select * from Dependent;

-- Motorbikes table
INSERT INTO Motorbike (registration_no, registration_date, engine_no, brand, model, color)
VALUES
  ('MB100','2020-01-01','EN12345','Yamaha','R15','Red-Black'),
  ('MB101','2021-03-15','EN54321','Honda','CBR','Blue-White'),
  ('MB102','2022-06-23','EN56789','Honda','R70','Green'),
  ('MB103','2023-09-26','EN45349','Bajaj','Z5o','Maroon'),
  ('MB104','2024-02-20','EN54678','Bajaj','Pulz','Black');

select * from Motorbike;

-- Assignments table
INSERT INTO Assign (employee_no, registration_no, assign_date, m_reader_at_assign, m_reader_at_return)
VALUES
  (1,'MB100','2025-04-12',1200,1250),
  (2,'MB101','2025-04-14',2300,2375);

select * from Assign;

-- Items table
INSERT INTO Item (item_name, category, price)
VALUES
  ('Veggie Burger','Main',150.00),
  ('Chicken Wrap','Main',300.00),
  ('Fries','Side',75.00);

UPDATE Item SET
  item_name = 'Fish Burger',
  category  = 'Main',
  price     = 200.00
WHERE item_no = 4;

-- 2) Update item_no = 5
UPDATE Item SET
  item_name = 'Mushroom Soup',
  category  = 'Starter',
  price     = 120.00
WHERE item_no = 5;

-- 3) Update item_no = 6
UPDATE Item SET
  item_name = 'Chocolate Shake',
  category  = 'Beverage',
  price     = 180.00
WHERE item_no = 6;

select * from Item;

-- Ingredients table
INSERT INTO Ingredient (item_no, ingredient)
VALUES
  (1,'Lettuce'),(1,'Tomato'),(1,'Patty'),
  (2,'Chicken'),(2,'Lettuce'),(2,'Sauce'),
  (3,'Potato'),(3,'Salt');

select * from Ingredient;

-- Orders table
INSERT INTO Orders (customer_id, employee_no, order_date, order_time, order_amount, payment_method, status, location_id, dispatch_time)
VALUES
  (1, 1,'2025-04-12','12:30',225.00,'Cash','Delivered',1,'12:45'),
  (2, 2,'2025-04-14','18:05',375.00,'Credit Card','In Transit',2,NULL),
  (1,1,CONVERT(date, GETDATE()),CONVERT(time, GETDATE()),250.00,'Cash','Pending',1,NULL),
  (2,1,CONVERT(date, GETDATE()),CONVERT(time, GETDATE()),500.00,'Credit Card','Pending',1,NULL);

select * from Orders;

-- Order_Item table
INSERT INTO Order_Item (order_no, item_no, quantity, unit_price)
VALUES
  (2, 1, 1, 150.00),
  (2, 3, 1,  75.00),
  (3, 2, 1, 300.00),
  (3, 3, 1,  75.00);

select * from Order_Item;

-- SELECT / WHERE Examples

-- list customers in Colombo who placed orders between April 10 and April 20, 2025.

SELECT c.customer_name,
       o.order_no,
       o.order_date
FROM Customer AS c
JOIN Orders   AS o ON c.customer_id = o.customer_id
JOIN Location AS l ON o.location_id  = l.location_id
WHERE l.city = 'Colombo'
  AND o.order_date BETWEEN '2025-04-10' AND '2025-04-20';

-- identify riders under 30

SELECT 
  first_name + ' ' + last_name AS rider_name, 
  DATEDIFF(YEAR, dob, GETDATE())      AS age
FROM Rider
WHERE DATEDIFF(YEAR, dob, GETDATE()) < 30;

-- UPDATE Examples

-- Updating existing records keeps the system in sync with real-time events. 

-- Mark order 6 as delivered — update only status & dispatch_time
UPDATE Orders
SET
  status        = 'Delivered',
  dispatch_time = CONVERT(time, GETDATE())
WHERE order_no = 6;

-- Verify the update
SELECT order_no, status, dispatch_time
FROM Orders
WHERE order_no = 6;

select * from Orders;

-- BETWEEN for date ranges
SELECT order_no, order_date, status, dispatch_time
FROM Orders
WHERE order_date BETWEEN '2025-04-01' AND '2025-05-30';

-- IN Example
-- filtering specific riders

SELECT order_no, employee_no, status
FROM Orders
WHERE employee_no IN (1, 2);

-- GROUP BY … HAVING Examplpe
-- to aggregate revenue by payment method,showing only totals above Rs. 500

SELECT payment_method,
       SUM(order_amount) AS total_amount
FROM Orders
GROUP BY payment_method
HAVING SUM(order_amount) > 300;

-- ORDER BY Example
-- list highest-value orders first

SELECT TOP 5 order_no, order_amount
FROM Orders
ORDER BY order_amount DESC;


-- earliest order dates first
-- within the same date, smallest amounts first
SELECT order_no,
       order_date,
       order_amount
FROM Orders
ORDER BY
  order_date ASC,
  order_amount  ASC;

-- New values added to the Ingredient table
INSERT INTO Ingredient (item_no, ingredient) VALUES
  (4, 'Fish Fillet'),(4, 'Lettuce'),(4, 'Tartar Sauce'),
  (5, 'Mushrooms'),(5, 'Cream'),(5, 'Thyme'),
  (6, 'Milk'),(6, 'Cocoa Powder'),(6, 'Sugar');

select * from Ingredient
WHERE item_no IN (4, 5, 6)
ORDER BY item_no, ingredient;

SELECT 
  employee_no,
  SUM(order_amount) AS total_sales,
  COUNT(*)         AS orders_count
FROM Orders
GROUP BY employee_no
HAVING SUM(order_amount) > 400;


SELECT 
  order_no,
  order_time,
  order_amount
FROM Orders
WHERE order_time BETWEEN '12:00:00' AND '14:00:00';

SELECT 
  c.customer_name,
  l.city,
  l.street
FROM Customer AS c
JOIN Location AS l 
  ON c.customer_id = l.customer_id
WHERE l.city IN ('Colombo', 'Galle');


INSERT INTO Orders (customer_id, employee_no, order_date, order_time, order_amount, payment_method, status, location_id, dispatch_time)
VALUES
  (3, 1, '2025-05-15', '13:00:00', 150.00, 'Cash',        'Delivered', 3, '13:15:00'),
  (2, 2, '2025-05-15', '14:30:00', 100.00, 'Online Pay', 'Delivered', 2, '14:45:00');

select * from Orders;

-- Link each new order with items
INSERT INTO Order_Item (order_no, item_no, quantity, unit_price)
VALUES
  (10, 1, 1, 150.00),
  (11, 3, 2,  75.00);

select * from Order_Item;

-- Arithmatic calculations

SELECT SUM(order_amount) AS total_revenue 
FROM Orders
WHERE order_date BETWEEN '2025-04-01' AND '2025-05-31';

SELECT AVG(order_amount) AS avg_order_value
FROM Orders
WHERE status = 'Delivered';

SELECT TOP 1 i.item_name, SUM(oi.quantity) AS total_qty
FROM Order_Item oi
JOIN Item i ON oi.item_no = i.item_no
GROUP BY i.item_name
ORDER BY total_qty DESC;

SELECT AVG(DATEDIFF(MINUTE, order_time, dispatch_time)) AS avg_delay_mins
FROM Orders
WHERE dispatch_time IS NOT NULL;