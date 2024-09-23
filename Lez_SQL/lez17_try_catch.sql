SELECT NEWID();


-- DDL
DROP TABLE IF EXISTS Impiegato;
CREATE TABLE Impiegato(
	impiegatoID INTEGER PRIMARY KEY IDENTITY(1,1),
	codice VARCHAR(250) NOT NULL DEFAULT NEWID() UNIQUE,
	nome VARCHAR(250) NOT NULL,
	cognome VARCHAR(250) NOT NULL,
	compenso DECIMAL(10,2)
);

--DML
INSERT INTO Impiegato(nome, cognome, compenso) VALUES 
('Giovanni', 'Pace', 1000),
('Valeria', 'Verdi', 2000),
('Marika', 'Mariko', 3000);

-- QL
SELECT impiegatoID FROM Impiegato WHERE codice = '378CA1A4-0D9E-428E-80AD-319C69CD9232';

DELETE FROM Impiegato WHERE impiegatoID = (
	SELECT impiegatoID FROM Impiegato WHERE codice = '378CA1A4-0D9E-428E-80AD-319C69CD9232')

UPDATE Impiegato
		SET compenso = 1000
		WHERE codice = '1897A8FB-E8D1-4085-AD1B-1908870FBC6E';

SELECT * FROM Impiegato;



/*
	TRY
		Operazione 1
		Operazione 2
	CATCH
		Log errore
*/

-- Modifica il salario di una persona tramite il suo codice, attenzione ai numeri negativi!
CREATE PROCEDURE UpdateCompensoByCodice
	@varCodice VARCHAR(250),
	@varCompenso DECIMAL(10,2)
AS
BEGIN
	
	BEGIN TRY
		IF @varCompenso < 0
			THROW 50002, 'Compenso negativo!', 1

		UPDATE Impiegato
			SET compenso = @varCompenso
			WHERE codice = @varCodice;

		IF @@ROWCOUNT = 0
			THROW 50001, 'Non ho trovato impiegato', 1

		PRINT 'Istruzione eseguita con successo'
	END TRY
	BEGIN CATCH
		-- Gestisco l'errore
		PRINT 'Ho riscontrato errore: ' + ERROR_MESSAGE()
	END CATCH
END;

EXEC UpdateCompensoByCodice @varCodice = '1897A8FB-E8D1-4085-AD1B-1908870FBC6E', @varCompenso = 85000;
SELECT * FROM Impiegato;