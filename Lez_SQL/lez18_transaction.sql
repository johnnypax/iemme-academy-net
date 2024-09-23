DROP TABLE IF EXISTS Ordine;
DROP TABLE IF EXISTS Prodotto;

CREATE TABLE Prodotto(
	prodottoID INT PRIMARY KEY IDENTITY(1,1),
	codice VARCHAR(250) NOT NULL DEFAULT NEWID() UNIQUE,
	nome VARCHAR(250) NOT NULL,
	quantita_dis INT CHECK (quantita_dis >= 0)
);

CREATE TABLE Ordine(
	ordineID INT PRIMARY KEY IDENTITY(1,1),
	codice VARCHAR(250) NOT NULL DEFAULT NEWID() UNIQUE,
	cliente VARCHAR(250) NOT NULL,
	prodottoRIF INT NOT NULL,
	quantita_ord INT NOT NULL CHECK (quantita_ord > 0)
	FOREIGN KEY (prodottoRIF) REFERENCES Prodotto(prodottoID) ON DELETE CASCADE
);

INSERT INTO Prodotto(nome, quantita_dis) VALUES
('Tavolo', 52),
('Sedia', 12),
('Lampada', 3);

CREATE PROCEDURE CreateOrdine
	@varNominativo VARCHAR(250),
	@varNomeProdotto VARCHAR(250),
	@varQuantita INT
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			IF @varQuantita < 0
				THROW 50001, 'Quantità non consentita', 1

			UPDATE Prodotto
				SET quantita_dis = quantita_dis - @varQuantita
				WHERE nome = @varNomeProdotto

			IF @@ROWCOUNT = 0
				THROW 50002, 'Errore, prodotto non trovato o quantità troppo elevata', 1

			INSERT INTO Ordine(cliente, quantita_ord, prodottoRIF) VALUES
			(@varNominativo, @varQuantita, (SELECT prodottoID FROM Prodotto WHERE nome = @varNomeProdotto));

			IF @@ROWCOUNT = 0
				THROW 50003, 'Errore, inserimento non riuscito', 1

			PRINT 'STAPPOOOOOOOOO'
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION

		PRINT 'Errore: ' + ERROR_MESSAGE()
	END CATCH
END;

EXEC CreateOrdine @varNominativo = 'Giovanni', @varNomeProdotto = 'Lampada', @varQuantita = 2;
SELECT * FROM Prodotto;
SELECT * FROM Ordine;