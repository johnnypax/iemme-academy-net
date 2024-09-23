CREATE TABLE Albergo(
	albergoID INT PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(250) NOT NULL,
	indi VARCHAR(250) NOT NULL,
	valu VARCHAR(5) NOT NULL CHECK (valu IN ('*', '**', '***', '****', '*****')) 
);

CREATE TABLE Cliente(
	clienteID INT PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(250) NOT NULL,
	cogn VARCHAR(250) NOT NULL,
	tele VARCHAR(250) NOT NULL UNIQUE
);

CREATE TABLE Camera(
	cameraID INT PRIMARY KEY IDENTITY(1,1),
	nume VARCHAR(250) NOT NULL,
	tipo VARCHAR(250) NOT NULL CHECK (tipo IN ('suite', 'matrimoniale', 'singola')),
	capa INT NOT NULL DEFAULT 0 CHECK (capa > 0),
	tari DECIMAL(5,2),
	albergoRIF INT NOT NULL,
	FOREIGN KEY (albergoRIF) REFERENCES Albergo(albergoID) ON DELETE CASCADE,
	UNIQUE(albergoRIF, nume)
);

CREATE TABLE Prenotazione(
	prenotazioneID INT PRIMARY KEY IDENTITY(1,1),
	chin DATE NOT NULL,
	chou DATE NOT NULL,
	clienteRIF INT NOT NULL,
	cameraRIF INT NOT NULL,
	FOREIGN KEY (clienteRIF) REFERENCES Cliente(clienteID) ON DELETE CASCADE,
	FOREIGN KEY (cameraRIF) REFERENCES Camera(cameraID) ON DELETE CASCADE
);

ALTER TABLE Prenotazione ADD CONSTRAINT CHK_Data CHECK (chou >= chin);

INSERT INTO Albergo (nome, indi, valu) VALUES 
('Hotel Paradiso', 'Via Roma, 10', '*****'),
('Hotel Bellavista', 'Via Milano, 45', '****'),
('Hotel Mareblu', 'Corso Italia, 22', '***'),
('Hotel Sole', 'Piazza del Popolo, 5', '****'),
('Hotel Luna', 'Via dei Fiori, 7', '**'),
('Hotel Aurora', 'Viale dei Tigli, 12', '***'),
('Hotel Stella', 'Via Verdi, 18', '*****'),
('Hotel Lago', 'Via del Mare, 55', '****'),
('Hotel Montagna', 'Via Monti, 2', '***'),
('Hotel Oasi', 'Via Alberi, 1', '*****');

INSERT INTO Cliente (nome, cogn, tele) VALUES
('Mario', 'Rossi', '1234567890'),
('Luigi', 'Bianchi', '0987654321'),
('Anna', 'Verdi', '1122334455'),
('Paolo', 'Neri', '6677889900'),
('Giulia', 'Blu', '4455667788'),
('Elena', 'Gialli', '9988776655'),
('Alessandro', 'Grigi', '3344556677'),
('Marco', 'Viola', '5566778899'),
('Francesca', 'Rosa', '1231231234'),
('Sara', 'Marroni', '9876543210');

INSERT INTO Camera (nume, tipo, capa, tari, albergoRIF) VALUES
('101', 'suite', 4, 300.00, 1),
('102', 'matrimoniale', 2, 150.00, 1),
('103', 'singola', 1, 80.00, 1),
('201', 'suite', 4, 280.00, 2),
('202', 'matrimoniale', 2, 140.00, 2),
('301', 'singola', 1, 75.00, 3),
('401', 'suite', 4, 290.00, 4),
('501', 'matrimoniale', 2, 130.00, 5),
('601', 'singola', 1, 70.00, 6),
('701', 'matrimoniale', 2, 120.00, 7);

INSERT INTO Prenotazione (chin, chou, clienteRIF, cameraRIF) VALUES
('2024-09-10', '2024-09-15', 1, 1),
('2024-09-12', '2024-09-18', 2, 2),
('2024-09-14', '2024-09-20', 3, 3),
('2024-09-15', '2024-09-19', 4, 4),
('2024-09-16', '2024-09-21', 5, 5),
('2024-09-18', '2024-09-22', 6, 6),
('2024-09-19', '2024-09-23', 7, 7),
('2024-09-20', '2024-09-24', 8, 8),
('2024-09-21', '2024-09-25', 9, 9),
('2024-09-22', '2024-09-27', 10, 10);

INSERT INTO Prenotazione (chin, chou, clienteRIF, cameraRIF) VALUES
('2024-09-23', '2024-09-28', 1, 4),
('2024-09-24', '2024-09-29', 2, 5),
('2024-09-25', '2024-09-30', 3, 6),
('2024-09-26', '2024-10-01', 4, 7),
('2024-09-27', '2024-10-02', 5, 8),
('2024-09-28', '2024-10-03', 6, 9),
('2024-09-29', '2024-10-04', 7, 10),
('2024-09-30', '2024-10-05', 8, 1),
('2024-10-01', '2024-10-06', 9, 2),
('2024-10-02', '2024-10-07', 10, 3);

DECLARE @data_inizio DATE = '2024-09-08';
DECLARE @data_fine  DATE = '2024-09-12';
DECLARE @prenotazioni_attive INT;


SELECT @prenotazioni_attive = COUNT(*) FROM Prenotazione
	WHERE cameraRIF = 1
    AND @data_inizio BETWEEN chin AND chou
    OR @data_fine BETWEEN chin AND chou
    OR chin BETWEEN @data_inizio AND @data_fine
    OR chou BETWEEN @data_inizio AND @data_fine;

PRINT @prenotazioni_attive;

/*

	IF @prenotazioni_attive = 0
		INSERISCI LA PRENOTAZIONE
	ELSE
		PRENOTAZIONE NON POSSIBILE
*/

CREATE PROCEDURE InserisciPrenotazione
	@data_inizio DATE,
	@data_fine DATE,
	@camera INT,
	@cliente INT
AS
BEGIN
	DECLARE @prenotazioni_attive INT;

	SELECT @prenotazioni_attive = COUNT(*) FROM Prenotazione
	WHERE cameraRIF = 1
    AND @data_inizio BETWEEN chin AND chou
    OR @data_fine BETWEEN chin AND chou
    OR chin BETWEEN @data_inizio AND @data_fine
    OR chou BETWEEN @data_inizio AND @data_fine;

	IF @prenotazioni_attive > 0
		BEGIN
			SELECT 'ERROR' AS STATUS;
			PRINT 'Non è possibile prenotare, camera occupata!';
		END
	ELSE
		BEGIN
			BEGIN TRY
				-- DML all'interno di un TRY CATCH
				INSERT INTO Prenotazione(chin, chou, cameraRIF, clienteRIF) VALUES
				(@data_inizio, @data_fine, @camera, @cliente);

				SELECT 'SUCCESS' AS STATUS
				PRINT 'Inserimento effettuato con successo';
			END TRY
			BEGIN CATCH
				SELECT 'ERROR' AS STATUS
				PRINT 'Errore di inserimento';
			END CATCH
		END
END;

EXEC InserisciPrenotazione 
			@data_inizio = '2024-08-08', 
			@data_fine = '2024-08-12', 
			@camera = 1, 
			@cliente = 1;