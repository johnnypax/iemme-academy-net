CREATE TABLE Impiegato(
	impiegatoID INT NOT NULL IDENTITY(1,1),
	nome VARCHAR(250) NOT NULL,
	salario DECIMAL(10,2)
); 


-- Creare una stored procedure per l'inserimento di un impiegato. Attenzione al salario negativo!

CREATE PROCEDURE InserisciImpiegato 
	@varNome VARCHAR(250),
	@varSala DECIMAL(10,2)
AS
BEGIN
	IF @varSala >= 0
	BEGIN
		INSERT INTO Impiegato(nome, salario) VALUES (@varNome, @varSala);
		PRINT 'INSERIMENTO EFFETTUATO CON SUCCESSO'
	END
	ELSE
	BEGIN
		PRINT 'ERRORE'
	END
END

EXEC InserisciImpiegato @varNome = 'Giovanni', @varSala = '890';





BEGIN TRANSACTION
	INSERT INTO Impiegato(nome, salario) VALUES ('Marco', 910);
	SELECT impiegatoID 
		FROM Impiegato 
		ORDER BY impiegatoID DESC 
		OFFSET 0 ROWS
		FETCH FIRST 1 ROWS ONLY;
COMMIT TRANSACTION;














-- Voglio l'ID della persona inserita

DROP PROCEDURE IF EXISTS InserisciImpiegatoEDaiId;
CREATE PROCEDURE InserisciImpiegatoEDaiId 
	@varNome VARCHAR(250),
	@varSala DECIMAL(10,2)
AS
BEGIN
	DECLARE @ultimoID INT = 0;

	BEGIN TRY
		BEGIN TRANSACTION
		INSERT INTO Impiegato(nome, salario) VALUES (@varNome, @varSala);
		SELECT @ultimoID = impiegatoID
			FROM Impiegato 
			ORDER BY impiegatoID DESC 
			OFFSET 0 ROWS
			FETCH FIRST 1 ROWS ONLY;
		COMMIT TRANSACTION;
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH

	RETURN @ultimoID;
END

DECLARE @risultato INT;
EXEC @risultato = InserisciImpiegatoEDaiId @varNome = 'Giovanni', @varSala = '890';
PRINT @risultato;
EXEC InserisciOrdine @prodotto = 'pasta', @impiegato = @risultato;