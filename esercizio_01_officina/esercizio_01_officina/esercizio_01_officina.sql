--DROP TABLE IF EXISTS Intervento;
--DROP TABLE IF EXISTS Cliente;

CREATE TABLE Cliente(
	clienteID INT PRIMARY KEY IDENTITY(1,1),
	codice CHAR(36) NOT NULL DEFAULT NEWID() UNIQUE,
	nome VARCHAR(250) NOT NULL,
	cognome VARCHAR(250) NOT NULL,
	indirizzo VARCHAR(250),
	telefono VARCHAR(250),
	email VARCHAR(250)
);

CREATE TABLE Intervento(
	interventoID INT PRIMARY KEY IDENTITY(1,1),
	codice CHAR(36) NOT NULL DEFAULT NEWID() UNIQUE,
	targa VARCHAR(50) NOT NULL,
	modello VARCHAR(50) NOT NULL,
	marca VARCHAR(50) NOT NULL,
	anno INT,
	prezzo DECIMAL(10,2) CHECK (prezzo >= 0),
	stato VARCHAR(50) CHECK (stato IN ('in corso', 'completato', 'da fare')),
	data_ingresso DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
	clienteRIF INT NOT NULL,
	FOREIGN KEY (clienteRIF) REFERENCES Cliente(clienteID) ON DELETE CASCADE
);

INSERT INTO Cliente (nome, cognome, indirizzo, telefono, email)
VALUES
    ('Marco', 'Rossi', 'Via Roma 123', '3331234567', 'marco.rossi@example.com'),
    ('Anna', 'Verdi', 'Via Verdi 456', '3456789012', 'anna.verdi@example.com'),
    ('Luca', 'Bianchi', 'Via Garibaldi 789', '3219876543', 'luca.bianchi@example.com'),
    ('Sofia', 'Neri', 'Piazza del Popolo 10', '3691234567', 'sofia.neri@example.com'),
    ('Davide', 'Gialli', 'Corso Vittorio Emanuele 20', '3876543210', 'davide.gialli@example.com'),
    ('Elisa', 'Bruni', 'Viale della Liberazione 30', '3965432109', 'elisa.bruni@example.com'),
    ('Andrea', 'Rossi', 'Via Roma 123', '3331234568', 'andrea.rossi@example.com'),
    ('Marta', 'Verdi', 'Via Verdi 456', '3456789013', 'marta.verdi@example.com'),
    ('Paolo', 'Bianchi', 'Via Garibaldi 789', '3219876544', 'paolo.bianchi@example.com'),
    ('Sara', 'Neri', 'Piazza del Popolo 10', '3691234568', 'sara.neri@example.com');

INSERT INTO Intervento (targa, modello, marca, anno, prezzo, stato, clienteRIF)
VALUES
    ('AB123CD', 'Panda', 'Fiat', 2015, 250.00, 'completato', 1),
    ('EF456GH', 'Yaris', 'Toyota', 2018, 300.00, 'in corso', 2),
    ('IJ789KL', '500', 'Fiat', 2020, 350.00, 'da fare', 3),
    ('MN012OP', 'Golf', 'Volkswagen', 2017, 400.00, 'completato', 5),
    ('QR345ST', 'Punto', 'Fiat', 2016, 280.00, 'in corso', 4),
    ('UV678WX', 'A3', 'Audi', 2019, 500.00, 'da fare', 6),
    ('YZ901AB', 'Corsa', 'Opel', 2018, 320.00, 'completato', 7),
    ('CD456EF', 'Fiesta', 'Ford', 2017, 290.00, 'in corso', 8),
    ('GH789IJ', 'Megane', 'Renault', 2019, 380.00, 'da fare', 9),
    ('KL012MN', '500X', 'Fiat', 2016, 310.00, 'completato', 1),
    ('OP345QR', 'Yaris', 'Toyota', 2015, 270.00, 'in corso', 2),
    ('ST678UV', 'Focus', 'Ford', 2018, 340.00, 'da fare', 3),
    ('WX901YZ', 'Astra', 'Opel', 2019, 360.00, 'completato', 4),
    ('AB012CD', 'Polo', 'Volkswagen', 2017, 330.00, 'in corso', 5),
    ('EF123GH', 'Clio', 'Renault', 2016, 295.00, 'da fare', 6),
    ('IJ234KL', '208', 'Peugeot', 2018, 315.00, 'completato', 7),
    ('MN345OP', 'Ibiza', 'Seat', 2017, 285.00, 'in corso', 8),
    ('QR456ST', 'Micra', 'Nissan', 2019, 305.00, 'da fare', 9),
    ('UV567WX', '308', 'Peugeot', 2018, 325.00, 'completato', 10),
    ('YZ678AB', 'Juke', 'Nissan', 2017, 295.00, 'in corso', 1);

-- Tutti gli interventi effettuati da tutti i cliente
SELECT * FROM Cliente
	JOIN Intervento ON Cliente.clienteID = Intervento.clienteRIF;

CREATE VIEW ClienteIntervento AS
	SELECT nome, cognome, Intervento.codice, targa, data_ingresso, stato FROM Cliente
		JOIN Intervento ON Cliente.clienteID = Intervento.clienteRIF;

SELECT * FROM ClienteIntervento;

USE eser_ef_01_officina;
SELECT * FROM Cliente;