CREATE TABLE Persona(
	personaID INT PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(250) NOT NULL,
	cognome VARCHAR(250) NOT NULL
);

CREATE TABLE CodFis(
	codfisID INT PRIMARY KEY IDENTITY(1,1),
	codice CHAR(16) NOT NULL UNIQUE,
	scadenza DATE NOT NULL,
	personaRIF INT NOT NULL UNIQUE,
	FOREIGN KEY(personaRIF) REFERENCES Persona(personaID) ON DELETE CASCADE
);

INSERT INTO Persona(nome, cognome) VALUES
('Giovanni', 'Pace'),
('Valeria', 'Verdi');

INSERT INTO CodFis(codice, scadenza, personaRIF) VALUES
('PCAGNN', '2020-01-01', 1),
('VLRVRD', '2020-01-01', 2);

SELECT * 
	FROM Persona 
	JOIN CodFis ON Persona.personaID = CodFis.personaRIF
	WHERE nome = 'Giovanni';
