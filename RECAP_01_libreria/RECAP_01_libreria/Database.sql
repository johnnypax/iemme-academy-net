
CREATE TABLE Utente(
	utenteId INT PRIMARY KEY IDENTITY (1,1),
	codUtente VARCHAR (50) DEFAULT NEWID(),
	nome VARCHAR (250) NOT NULL,
	cognome VARCHAR (250) NOT NULL,
	email VARCHAR (250) NOT NULL UNIQUE, 
);


CREATE TABLE Libro (
	libroId INT PRIMARY KEY IDENTITY (1,1),
	codLibro VARCHAR (50) DEFAULT NEWID (),
	titolo VARCHAR (50) NOT NULL,
	annoPub INT CHECK (annoPub <=YEAR (GETDATE())),
	statoDis BIT NOT NULL DEFAULT 1,
);

CREATE TABLE Prestito (
	prestitoId INT PRIMARY KEY IDENTITY (1,1),
	dataPres DATE NOT NULL,
	dataRit DATE,
	utenteRIF INT,
	libroRIF INT,
	FOREIGN KEY (utenteRIF) REFERENCES  Utente (utenteId) ON DELETE CASCADE, 
	FOREIGN KEY (libroRIF) REFERENCES Libro (libroId) ON DELETE CASCADE,
	-- CONSTRAINT CHK_PrestitoRitorno CHECK (dataRit>dataPres),
);

INSERT INTO Utente (nome, cognome, email) VALUES 
('Mario', 'Rossi', 'mario.rossi@email.com'),
('Luca', 'Bianchi', 'luca.bianchi@email.com'),
('Giulia', 'Verdi', 'giulia.verdi@email.com'),
('Sara', 'Neri', 'sara.neri@email.com'),
('Francesco', 'Gialli', 'francesco.gialli@email.com'),
('Elena', 'Viola', 'elena.viola@email.com'),
('Paolo', 'Marroni', 'paolo.marroni@email.com'),
('Alessandra', 'Azzurri', 'alessandra.azzurri@email.com'),
('Marco', 'Grigi', 'marco.grigi@email.com'),
('Lucia', 'Blu', 'lucia.blu@email.com');

INSERT INTO Libro (titolo, annoPub, statoDis) VALUES 
('Il Signore degli Anelli', 1954, 1),
('1984', 1949, 1),
('Il Nome della Rosa', 1980, 1),
('La Divina Commedia', 1320, 1),
('Orgoglio e Pregiudizio', 1813, 1),
('Il Grande Gatsby', 1925, 1),
('Moby Dick', 1851, 1),
('Don Chisciotte', 1605, 1),
('Guerra e Pace', 1869, 1),
('La Coscienza di Zeno', 1923, 1);
INSERT INTO Prestito (dataPres, dataRit, utenteRIF, libroRIF) VALUES 
('2024-09-01', '2024-09-15', 1, 1), -- Mario prende "Il Signore degli Anelli"
('2024-09-02', '2024-09-12', 2, 2), -- Luca prende "1984"
('2024-09-05', '2024-09-20', 3, 3), -- Giulia prende "Il Nome della Rosa"
('2024-09-07', '2024-09-17', 4, 4), -- Sara prende "La Divina Commedia"
('2024-09-08', '2024-09-18', 5, 5), -- Francesco prende "Orgoglio e Pregiudizio"
('2024-09-09', '2024-09-22', 6, 6), -- Elena prende "Il Grande Gatsby"
('2024-09-10', '2024-09-25', 7, 7), -- Paolo prende "Moby Dick"
('2024-09-11', '2024-09-27', 8, 8), -- Alessandra prende "Don Chisciotte"
('2024-09-12', '2024-09-29', 9, 9), -- Marco prende "Guerra e Pace"
('2024-09-13', '2024-09-30', 10, 10); -- Lucia prende "La Coscienza di Zeno"

SELECT * FROM Libro;
SELECT * FROM Utente;

SELECT * FROM Utente
	JOIN Prestito ON Utente.utenteId = Prestito.utenteRIF
	JOIN Libro ON Prestito.libroRIF = Libro.libroId
	WHERE email = 'mario.rossi@email.com';