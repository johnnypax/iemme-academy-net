-- DDL
CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50),
    Salary DECIMAL(10, 2)
);

CREATE TABLE Impiegato(
	impiegatoID INT PRIMARY KEY IDENTITY(1,1),
	nominativo VARCHAR(250) NOT NULL,
	compenso  DECIMAL(10, 2) CHECK (compenso >=0)
);

-- DML
INSERT INTO Employees(FirstName, LastName, Salary) VALUES
('Giovanni', 'Pace', 100000),
('Valeria', 'Verdi', 120000),
('Mario', 'Rossi', 90000);



DECLARE EmployeeCursor CURSOR FOR
	SELECT FirstName + ' ' + LastName, Salary FROM Employees;

OPEN EmployeeCursor;

	DECLARE @nominativo VARCHAR(250);
	DECLARE @salario DECIMAL(10,2);

	FETCH NEXT FROM EmployeeCursor INTO @nominativo, @salario

	WHILE @@FETCH_STATUS = 0
	BEGIN
		PRINT 'Ho selezionato: ' + @nominativo + ' con salario: ' + CAST(@salario AS VARCHAR);

		INSERT INTO Impiegato(nominativo, compenso) VALUES 
		(@nominativo, @salario);

		FETCH NEXT FROM EmployeeCursor INTO @nominativo, @salario
	END

CLOSE EmployeeCursor;

-----------------------------------------------------------------------------

DECLARE EmployeeCursorSalari CURSOR FOR
	SELECT FirstName + ' ' + LastName, Salary FROM Employees;

DECLARE @sommatoriaSalari DECIMAL(10,2) = 0;

OPEN EmployeeCursorSalari;

	DECLARE @nominativo VARCHAR(250);
	DECLARE @salario DECIMAL(10,2);

	FETCH NEXT FROM EmployeeCursorSalari INTO @nominativo, @salario

	WHILE @@FETCH_STATUS = 0
	BEGIN
		PRINT 'Ho selezionato: ' + @nominativo + ' con salario: ' + CAST(@salario AS VARCHAR);
		SET @sommatoriaSalari = @sommatoriaSalari + @salario;

		FETCH NEXT FROM EmployeeCursorSalari INTO @nominativo, @salario
	END

CLOSE EmployeeCursorSalari;

PRINT 'LA SOMMA è: ' + CAST(@sommatoriaSalari AS VARCHAR);

SELECT * FROM Impiegato;