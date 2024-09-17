CREATE DATABASE a_lez06_otm_carte;
USE a_lez06_otm_carte;

DROP TABLE IF EXISTS Carta;
DROP TABLE IF EXISTS Persona;

CREATE TABLE Persona(
	personaID INTEGER PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(250) NOT NULL,
	cognome VARCHAR(250) NOT NULL,
	email VARCHAR(250)
	);

CREATE TABLE Carta(
	cartaID INTEGER PRIMARY KEY IDENTITY(1,1),
	codice VARCHAR(10) NOT NULL UNIQUE,
	negozio VARCHAR(50) NOT NULL,
	personaRIF INTEGER NOT NULL,
	FOREIGN KEY(personaRIF) REFERENCES Persona(personaID) ON DELETE CASCADE
);

INSERT INTO Persona(nome, cognome, email) VALUES
('Giovanni', 'Pace', 'gio@pace.com'),
('Valeria', 'Verdi', 'val@verdi.com'),
('Mario', 'Rossi', 'mar@ros.com');

INSERT INTO Persona(nome, cognome, email) VALUES
('MArika', 'Mariko', 'mrk@mrk.com');


INSERT INTO Carta(codice, negozio, personaRIF) VALUES
('AB1234', 'Coap', 1),
('AB1235', 'Coap', 3),
('AB1236', 'Coap', 2),
('CC123', 'Cojnad', 1),
('CC124', 'Cojnad', 2),
('ES345', 'EuroSpino', 3),
('ES346', 'EuroSpino', 2);

SELECT * FROM Persona;
SELECT * FROM Carta;

-- DELETE FROM Persona WHERE personaID = 1;

SELECT * 
	FROM Persona 
	JOIN Carta ON Persona.personaID = Carta.personaRIF
	WHERE personaID = 1;

SELECT nome, cognome, codice, negozio 
	FROM Carta
	JOIN Persona ON Carta.personaRIF = Persona.personaID
	WHERE cartaID = 6;

-- Seleziona tutti gli utentib con tutte le relative carte e tutti gli utenti che non ne hanno
SELECT * 
	FROM Persona 
	LEFT JOIN Carta ON Persona.personaID = Carta.personaRIF;