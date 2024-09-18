CREATE TABLE Persona(
	personaID INT PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(250) NOT NULL,
	cognome VARCHAR(250) NOT NULL,
	email VARCHAR(100) NOT NULL UNIQUE
);

CREATE TABLE Carta(
	cartaID INT PRIMARY KEY IDENTITY(1,1),
	codice VARCHAR(250) NOT NULL UNIQUE,
	negozio VARCHAR(250) NOT NULL,
	personaRIF INT NOT NULL,
	FOREIGN KEY(personaRIF) REFERENCES Persona(personaID) ON DELETE CASCADE
);

INSERT INTO Persona(nome, cognome, email) VALUES
('Giovanni', 'Pace', 'gio@pace.com'),
('Valeria', 'Verdi', 'val@ver.com'),
('Mario', 'Rossi', 'mar@rossi.com'),
('Marika', 'Mariko', 'mar@ko.com');

INSERT INTO Carta(codice, negozio, personaRIF) VALUES
('AB123', 'Coop',	1),
('AB124', 'Coop',	2),
('AB125', 'Coop',	3),
('CC123', 'Conad',	3),
('CC124', 'Conad',	1),
('CC125', 'Conad',	2),
('TT123', 'Tigotà',	1);

-- Tutte le carte di Valeria
SELECT * 
	FROM Persona 
	JOIN Carta ON Persona.personaID = Carta.personaRIF
	WHERE nome = 'Valeria' AND cognome = 'Verdi';


-- Seleziona il proprietario della carta AB125
SELECT *
	FROM Carta
	JOIN Persona ON Carta.personaRIF = Persona.personaID
	WHERE codice = 'AB125';

	
-- Tutte le carte possedute da qualcuno e quelle non possedute
SELECT * 
	FROM Persona 
	LEFT JOIN Carta ON Persona.personaID = Carta.personaRIF;

-- Tutte le carte possedute da qualcuno e quelle non possedute
SELECT nome, cognome, codice, negozio
	FROM Carta
	RIGHT JOIN Persona ON Carta.personaRIF = Persona.personaID
	ORDER BY negozio, codice DESC; -- ASC