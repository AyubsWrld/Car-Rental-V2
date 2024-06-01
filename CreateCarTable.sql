CREATE TABLE CarTypes (
    carTypeID INT PRIMARY KEY,
	carEngine VARCHAR(50),
    carType VARCHAR(50),
	carTrim VARCHAR(50),
    dailyCost DECIMAL(10, 2),
    weeklyCost DECIMAL(10, 2),
    monthlyCost DECIMAL(10, 2)
);

CREATE TABLE Car (
    carVIN VARCHAR(17) PRIMARY KEY,
    carTypeID INT,
	brand VARCHAR(50),
    model VARCHAR(50),
    year INT,
    color VARCHAR(20),
    mileage INT,
    lastTuneUp INT,
    condition VARCHAR(20),
	branchPickup INT,
    FOREIGN KEY (carTypeID) REFERENCES CarTypes(carTypeID)
);

CREATE TABLE Branches (
    branchNum INT PRIMARY KEY,
    name VARCHAR(100),
    contactNum VARCHAR(15),
    street VARCHAR(100),
    city VARCHAR(50),
    province VARCHAR(50),
    postalCode VARCHAR(10),
    country VARCHAR(50)
);

CREATE TABLE Employees (
    employeeNum INT PRIMARY KEY,
    fname VARCHAR(50),
	lname VARCHAR(50),
	DOB VARCHAR(50),
    contactNum VARCHAR(15),
    street VARCHAR(100),
    city VARCHAR(50),
    province VARCHAR(50),
    postalCode VARCHAR(10),
    country VARCHAR(50),
	password VARCHAR(50),
	workAtBranchNum INT
);

CREATE TABLE Customers (
    cusID INT PRIMARY KEY,
	operatorID VARCHAR(50),
    fname VARCHAR(50),
	lname VARCHAR(50),
	DOB VARCHAR(50),
    contactNum VARCHAR(15),
    street VARCHAR(100),
    city VARCHAR(50),
    province VARCHAR(50),
    postalCode VARCHAR(10),
    country VARCHAR(50),
	password VARCHAR(50)
);

CREATE TABLE RentalTransactions (
    transID INT PRIMARY KEY,
	rentalCost INT,
    rentedFromDate DATE,
    returnToDate DATE,
    employeeNum INT,
    cusID INT,
    carVIN VARCHAR(17),
    branchNum INT,
	branchDropoff INT,
    FOREIGN KEY (employeeNum) REFERENCES Employees(employeeNum),
    FOREIGN KEY (cusID) REFERENCES Customers(cusID),
    FOREIGN KEY (carVIN) REFERENCES Car(carVIN),
    FOREIGN KEY (branchNum) REFERENCES Branches(branchNum)
);
