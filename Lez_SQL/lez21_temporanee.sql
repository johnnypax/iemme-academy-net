-- DDL
CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY,
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50),
    Salary DECIMAL(10, 2)
);

CREATE TABLE Sales (
    SaleID INT IDENTITY(1,1) PRIMARY KEY,
    EmployeeRIF INT,
    SaleDate DATE,
    SalesAmount DECIMAL(10, 2),
	FOREIGN KEY (EmployeeRIF) REFERENCES Employees(EmployeeID) ON DELETE CASCADE
);

--DML
INSERT INTO Employees (EmployeeID, FirstName, LastName, Salary) VALUES
(1, 'John', 'Doe', 50000),
(2, 'Jane', 'Smith', 60000),
(3, 'Emily', 'Jones', 70000);

INSERT INTO Sales (EmployeeRIF, SaleDate, SalesAmount) VALUES
(1, '2024-03-01', 1200.00),
(1, '2024-03-02', 1500.00),
(2, '2024-03-01', 800.00),
(3, '2024-03-03', 2300.00),
(2, '2024-03-04', 400.00),
(3, '2024-03-02', 1600.00);

-- Tutte le vendite effettuate da tutti i dipendenti
--SELECT *
--	FROM Employees
--	JOIN Sales ON Employees.EmployeeID = Sales.EmployeeRIF;

-- Calcoliamo il totale degli ordini per dipendente

CREATE PROCEDURE GetTotalSales
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			CREATE TABLE #TotalSales(
				EmployeeID INT NOT NULL,
				Total DECIMAL(10,2) DEFAULT 0
			);

			INSERT #TotalSales(EmployeeID, Total)
				SELECT EmployeeRIF, SUM(SalesAmount) 
					FROM Sales
					GROUP BY EmployeeRIF

			SELECT * FROM #TotalSales;
			DROP TABLE #TotalSales;
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		ROLLBACK;

		PRINT 'Errore di esecuzione'
	END CATCH
END;

EXEC GetTotalSales;


CREATE PROCEDURE GetTotalSalesFullName
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			CREATE TABLE #TotalSalesDue(
				FullName VARCHAR(250) NOT NULL,
				Total DECIMAL(10,2) DEFAULT 0
			);

			INSERT #TotalSalesDue(FullName, Total)
				SELECT FirstName + ' ' + LastName, SUM(SalesAmount) 
					FROM Sales
					JOIN Employees ON Sales.EmployeeRIF = Employees.EmployeeID
					GROUP BY FirstName, LastName

			SELECT * FROM #TotalSalesDue;
			DROP TABLE #TotalSalesDue;
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		ROLLBACK;

		PRINT 'Errore di esecuzione'
	END CATCH
END;

EXEC GetTotalSalesFullName;