CREATE TABLE Customers (
    CustomerId INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100),
    Email NVARCHAR(100),
    Phone NVARCHAR(20)
);

CREATE TABLE Tickets (
    TicketId INT PRIMARY KEY IDENTITY(1,1),
    CustomerId INT,
    Subject NVARCHAR(200),
    Description NVARCHAR(MAX),
    Status NVARCHAR(50),
    FOREIGN KEY (CustomerId) REFERENCES Customers(CustomerId)
);

INSERT INTO Customers(Name, Email, Phone)
VALUES
('Rahul Sharma','rahul@example.com','9876543210'),
('Priya Mehta','priya@example.com','9876501234');

INSERT INTO Tickets(CustomerId, Subject, Description, Status)
VALUES
(1,'Login Issue','Unable to login','Open'),
(2,'Payment Issue','Payment failed','In Progress');
