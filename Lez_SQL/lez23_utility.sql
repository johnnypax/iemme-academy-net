-- DDL
CREATE TABLE Impiegato (
    impiegatoID INT PRIMARY KEY IDENTITY(1,1),
    nome VARCHAR(50) NOT NULL,
    cognome VARCHAR(50) NOT NULL,
    compenso DECIMAL(10, 2),
	dipartimento VARCHAR(250),
);

BEGIN TRANSACTION
	INSERT INTO Impiegato (nome, cognome, compenso, dipartimento)
	VALUES ('Mario', 'Rossi', 35000.00, 'Finanza');
	INSERT INTO Impiegato (nome, cognome, compenso, dipartimento)
	VALUES ('Luca', 'Bianchi', 45000.00, 'Marketing');
	INSERT INTO Impiegato (nome, cognome, compenso, dipartimento)
	VALUES ('Giulia', 'Verdi', 50000.00, 'Vendite');
COMMIT TRANSACTION;

INSERT INTO Impiegato (nome, cognome, compenso, dipartimento) VALUES
('Anna', 'Neri', 40000.00, 'Finanza'),
('Francesco', 'Blu', 60000.00, 'Vendite'),
('Valeria', 'Verdi', 80000.00, 'Marketing');

-- --------------------------------------------------------------------

-- Voglio tutti i dipartimenti non ripetuti
SELECT DISTINCT dipartimento
	FROM Impiegato;

-- Voglio i primi tre impiegati in ordine di compenso
SELECT TOP(3) *
	FROM Impiegato
	ORDER BY compenso DESC;

SELECT *
	FROM Impiegato
	ORDER BY compenso DESC
	OFFSET 0 ROWS
	FETCH FIRST 3 ROWS ONLY;
