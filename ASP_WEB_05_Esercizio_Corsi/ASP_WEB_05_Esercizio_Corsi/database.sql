CREATE TABLE Amministratore(
	amministratoreID INT PRIMARY KEY IDENTITY(1,1),
	usern VARCHAR(250) NOT NULL UNIQUE,
	passw VARCHAR(250) NOT NULL
);

CREATE TABLE Corso(
	corsoID INT PRIMARY KEY IDENTITY(1,1),
	codice VARCHAR(36) NOT NULL UNIQUE DEFAULT NEWID(),
	nome VARCHAR(250) NOT NULL,
	descrizione TEXT,
	prezzo DECIMAL(5,2) CHECK (prezzo >= 0),
	num_part INTEGER CHECK (num_part >= 0),
	data_corso DATETIME NOT NULL
);

-- ALTER TABLE Corso ALTER COLUMN prezzo DECIMAL(5,2);

CREATE TABLE Iscrizione(
	iscrizioneID INT PRIMARY KEY IDENTITY(1,1),
	codice VARCHAR(36) NOT NULL UNIQUE DEFAULT NEWID(),
	nome VARCHAR(250) NOT NULL,
	cognome VARCHAR(250) NOT NULL,
	email VARCHAR(250) NOT NULL,
	data_iscr DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
	disicr_codi VARCHAR(36) NOT NULL UNIQUE DEFAULT NEWID(),
	corsoRIF INT NOT NULL,
	FOREIGN KEY(corsoRIF) REFERENCES Corso(corsoID) ON DELETE CASCADE,
	UNIQUE(email, corsoRIF)
);

-- Inserimento nella tabella Amministratore
INSERT INTO Amministratore (usern, passw) 
VALUES ('admin1', 'password1'), 
       ('admin2', 'password2');

-- Inserimento nella tabella Corso
INSERT INTO Corso (nome, descrizione, prezzo, num_part, data_corso) 
VALUES ('Corso di Programmazione', 'Corso base di programmazione in C#', 150.00, 20, '10-11-2024 09:00:00'),
       ('Corso di Data Science', 'Introduzione alla data science e machine learning', 200.00, 15, '15-11-2024 09:00:00');

SELECT * FROM Corso;
-- Inserimento nella tabella Iscrizione (almeno 2 iscrizioni per utente)
INSERT INTO Iscrizione (nome, cognome, email, corsoRIF) 
VALUES ('Giovanni', 'Rossi', 'giovanni.rossi@email.com', 5),
       ('Giovanni', 'Rossi', 'giovanni.rossi@email.com', 6),
       ('Maria', 'Bianchi', 'maria.bianchi@email.com', 5),
       ('Luca', 'Verdi', 'luca.verdi@email.com', 6);