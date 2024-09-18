CREATE TABLE Studente(
	studenteID INT PRIMARY KEY IDENTITY(1,1),
	nominativo VARCHAR(250) NOT NULL,
	matricola VARCHAR(10) NOT NULL UNIQUE
);

CREATE TABLE Esame(
	esameID INT PRIMARY KEY IDENTITY(1,1),
	titolo  VARCHAR(250) NOT NULL,
	data_esame DATETIME NOT NULL,
	crediti INT NOT NULL
);

CREATE TABLE Studente_Esame(
	studenteRIF INT NOT NULL,
	esameRIF INT NOT NULL,
	FOREIGN KEY(studenteRIF) REFERENCES Studente(studenteID) ON DELETE CASCADE,
	FOREIGN KEY(esameRIF) REFERENCES Esame(esameID) ON DELETE CASCADE,
	UNIQUE(studenteRIF, esameRIF)
);

-- DML
INSERT INTO Studente(nominativo, matricola) VALUES
('Giovanni Pace', 'AB1234'),
('Valeria Verdi', 'AB1235'),
('Mario Rossi', 'AB1236');

INSERT INTO Esame(titolo, data_esame, crediti) VALUES
('Analisi I', '2020-01-01 09:00', 6),
('Analisi I', '2020-02-01 10:00', 6),
('Basi di dati', '2020-03-01 09:00', 6),
('Basi di dati', '2020-01-02 10:00', 6),
('Basi di dati', '2020-04-01 09:00', 6),
('Programmazione', '2020-01-01 09:00', 9);

INSERT INTO Studente_Esame(studenteRIF, esameRIF) VALUES
(1,	2),
(1,	4),
(2,	2),
(2,	5),
(1,	6),
(2,	6);

-- Tutti gli esami a cui è iscritto Giovanni Pace
SELECT *
	FROM Studente
	JOIN Studente_Esame ON Studente.studenteID = Studente_Esame.studenteRIF
	JOIN Esame ON Studente_Esame.esameRIF = Esame.esameID
	WHERE matricola = 'AB1234';

-- Voglio sapere tutti gli iscritti all'esame Programmazione
SELECT *
	FROM Esame
	JOIN Studente_Esame ON Esame.esameID = Studente_Esame.esameRIF
	JOIN Studente ON Studente_Esame.studenteRIF = Studente.studenteID
	WHERE Esame.titolo = 'Programmazione';

-- GLi esami a cui sono iscritti tutti gli studenti e gli studenti non iscritti a nessun esame
SELECT * 
	FROM Studente 
	LEFT JOIN Studente_Esame ON Studente.studenteID = Studente_Esame.studenteRIF
	LEFT JOIN Esame ON Studente_Esame.esameRIF = Esame.esameID;

-- GLi esami a cui sono iscritti tutti gli studenti e gli esami senza iscrizioni
SELECT * 
	FROM Studente 
	RIGHT JOIN Studente_Esame ON Studente.studenteID = Studente_Esame.studenteRIF
	RIGHT JOIN Esame ON Studente_Esame.esameRIF = Esame.esameID;

-- Tutti gli studenti iscritti agli esami + studenti non iscritti + esami senza iscritti
SELECT * 
	FROM Studente 
	LEFT JOIN Studente_Esame ON Studente.studenteID = Studente_Esame.studenteRIF
	LEFT JOIN Esame ON Studente_Esame.esameRIF = Esame.esameID
UNION
	SELECT * 
		FROM Studente 
		RIGHT JOIN Studente_Esame ON Studente.studenteID = Studente_Esame.studenteRIF
		RIGHT JOIN Esame ON Studente_Esame.esameRIF = Esame.esameID;

-- Tutti gli iscritti all'esame di Programmazione - Partenza Esame
SELECT *
	FROM Esame
	JOIN Studente_Esame ON Esame.esameID = Studente_Esame.esameRIF
	JOIN Studente ON Studente_Esame.studenteRIF = Studente.studenteID
	WHERE titolo = 'Programmazione';