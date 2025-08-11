use Testing;

--CREATE TABLE LoanApplicationInfo (
--    -- Loan Information
--    id INT PRIMARY KEY IDENTITY(1,1),	
--    loanNumber AS ('LN' + RIGHT('000' + CAST(id AS VARCHAR(3)), 3)) PERSISTED,
--    name NVARCHAR(50),
--    loanType NVARCHAR(100),
--    officer NVARCHAR(100),
--    amount INT DEFAULT 0,

--    -- Witness Information
--    witnessType NVARCHAR(100),
--    witnessName NVARCHAR(100),
--    country NVARCHAR(100),
--    city NVARCHAR(100),
--    nationalID NVARCHAR(100),
--    phone BIGINT,  -- changed from INT to BIGINT for phone numbers
--    email NVARCHAR(100),
--    postalCode NVARCHAR(100),
--    ResidentialAddress NVARCHAR(100),

--    -- Timestamp
--    date DATETIME DEFAULT GETDATE()
--);

--CREATE TABLE Users (
--    id INT PRIMARY KEY IDENTITY(1,1),
--    username NVARCHAR(50) UNIQUE NOT NULL,
--    password NVARCHAR(50) NOT NULL,
--    email NVARCHAR(100) UNIQUE NOT NULL,
--    Role NVARCHAR(50) NOT NULL DEFAULT 'User',
--    created_at DATETIME DEFAULT GETDATE()
--);
--INSERT INTO Users (username, password,Role, email)
--VALUES ('Admin', 'admin123', 'admin', 'admins@gmail.com');



--INSERT INTO LoanApplicationInfo 
--(name, loanType, officer, amount, witnessType, witnessName, country, city, nationalID, phone, email, postalCode, ResidentialAddress)
--VALUES 
--('John Doe', 'Personal Loan', 'Officer Smith', 10000, 'Friend', 'Jane Roe', 'Cambodia', 'Phnom Penh', 'KH12345678', 85512345678, 'john@example.com', '12000', '123 Main St');


select * from LoanApplicationInfo;
select * from Users;
CREATE DATABASE Library_Management;
--DROP TABLE LoanApplicationInfo;
--DROP TABLE Users;

