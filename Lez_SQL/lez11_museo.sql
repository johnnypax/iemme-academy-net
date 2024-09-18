CREATE TABLE Museo(
	museoID INT PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(250) NOT NULL,
	citta VARCHAR(250) NOT NULL,
	indirizzo VARCHAR(250) NOT NULL,
	direttore VARCHAR(250) NOT NULL,
	UNIQUE(nome, citta)
);

CREATE TABLE Artista(
	artistaID INT PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(250) NOT NULL,
	nazionalita CHAR(3) NOT NULL,
	data_nascita DATE NOT NULL,
	data_morte DATE
);

CREATE TABLE Personaggio(
	personaggioID INT PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(250) NOT NULL
);

CREATE TABLE Dipinto(
	dipintoID INT PRIMARY KEY IDENTITY(1,1),
	codice VARCHAR(10) NOT NULL UNIQUE,
	anno_creazion DATE NOT NULL,
	titolo VARCHAR(250) NOT NULL,
	tipo_pittura VARCHAR(250) NOT NULL,
	altezza FLOAT NOT NULL CHECK (altezza > 0),
	larghezza FLOAT NOT NULL CHECK (larghezza > 0),
	museoRIF INT,
	FOREIGN KEY(museoRIF) REFERENCES Museo(museoID) ON DELETE SET NULL
);

CREATE TABLE Scultura(
	sculturaID INT PRIMARY KEY IDENTITY(1,1),
	codice VARCHAR(10) NOT NULL UNIQUE,
	anno_creazion DATE NOT NULL,
	titolo VARCHAR(250) NOT NULL,
	materiale VARCHAR(250) NOT NULL,
	altezza FLOAT NOT NULL CHECK (altezza > 0),
	peso FLOAT NOT NULL CHECK (peso > 0),
	museoRIF INT,
	FOREIGN KEY(museoRIF) REFERENCES Museo(museoID) ON DELETE SET NULL
);

CREATE TABLE Scultura_Artista(
	sculturaRIF INT NOT NULL,
	artistaRIF INT NOT NULL,
	FOREIGN KEY (sculturaRIF) REFERENCES Scultura(sculturaID) ON DELETE CASCADE,
	FOREIGN KEY (artistaRIF) REFERENCES Artista(artistaID) ON DELETE CASCADE,
	PRIMARY KEY (sculturaRIF, artistaRIF)
);

CREATE TABLE Dipinto_Artista(
	dipintoRIF INT NOT NULL,
	artistaRIF INT NOT NULL,
	FOREIGN KEY (dipintoRIF) REFERENCES Dipinto(dipintoID) ON DELETE CASCADE,
	FOREIGN KEY (artistaRIF) REFERENCES Artista(artistaID) ON DELETE CASCADE,
	PRIMARY KEY (dipintoRIF, artistaRIF)
);

CREATE TABLE Scultura_Personaggio(
	sculturaRIF INT NOT NULL,
	personaggioRIF INT NOT NULL,
	FOREIGN KEY (sculturaRIF) REFERENCES Scultura(sculturaID) ON DELETE CASCADE,
	FOREIGN KEY (personaggioRIF) REFERENCES Personaggio(personaggioID) ON DELETE CASCADE,
	PRIMARY KEY (sculturaRIF, personaggioRIF)
);

CREATE TABLE Dipinto_Personaggio(
	dipintoRIF INT NOT NULL,
	personaggioRIF INT NOT NULL,
	FOREIGN KEY (dipintoRIF) REFERENCES Dipinto(dipintoID) ON DELETE CASCADE,
	FOREIGN KEY (personaggioRIF) REFERENCES Personaggio(personaggioID) ON DELETE CASCADE,
	PRIMARY KEY (dipintoRIF, personaggioRIF)
);

-- Insert per la tabella Museo
INSERT INTO Museo (nome, citta, indirizzo, direttore)
VALUES 
('Museo degli Uffizi', 'Firenze', 'Piazzale degli Uffizi', 'Eike Schmidt'),
('Louvre', 'Parigi', 'Rue de Rivoli', 'Laurence des Cars'),
('Museo del Prado', 'Madrid', 'Calle Ruiz de Alarcón', 'Miguel Falomir');

-- Insert per la tabella Artista
INSERT INTO Artista (nome, nazionalita, data_nascita, data_morte)
VALUES
('Leonardo da Vinci', 'ITA', '1452-04-15', '1519-05-02'),
('Pablo Picasso', 'ESP', '1881-10-25', '1973-04-08'),
('Michelangelo', 'ITA', '1475-03-06', '1564-02-18');

-- Insert per la tabella Personaggio
INSERT INTO Personaggio (nome)
VALUES
('Madonna'),
('San Giovanni'),
('Venere');

-- Insert per la tabella Dipinto
INSERT INTO Dipinto (codice, anno_creazion, titolo, tipo_pittura, altezza, larghezza, museoRIF)
VALUES
('D001', '1503-01-01', 'La Gioconda', 'Olio su tela', 77, 53, 2), -- Louvre
('D002', '1937-04-26', 'Guernica', 'Olio su tela', 349, 776, 1), -- Museo degli Uffizi
('D003', '1512-01-01', 'La Creazione di Adamo', 'Affresco', 280, 570, 3); -- Museo del Prado

-- Insert per la tabella Scultura
INSERT INTO Scultura (codice, anno_creazion, titolo, materiale, altezza, peso, museoRIF)
VALUES
('S001', '1504-01-01', 'David', 'Marmo', 517, 6000, 1), -- Museo degli Uffizi
('S002', '1624-01-01', 'Apollo e Dafne', 'Marmo', 243, 5200, 3); -- Museo del Prado

-- Insert per la tabella Scultura_Artista
INSERT INTO Scultura_Artista (sculturaRIF, artistaRIF)
VALUES
(1, 3), -- David - Michelangelo
(2, 2); -- Apollo e Dafne - Pablo Picasso (ipotesi)

-- Insert per la tabella Dipinto_Artista
INSERT INTO Dipinto_Artista (dipintoRIF, artistaRIF)
VALUES
(1, 1), -- La Gioconda - Leonardo da Vinci
(2, 2), -- Guernica - Pablo Picasso
(3, 3); -- La Creazione di Adamo - Michelangelo

-- Insert per la tabella Scultura_Personaggio
INSERT INTO Scultura_Personaggio (sculturaRIF, personaggioRIF)
VALUES
(1, 2), -- David - San Giovanni (ipotesi)
(2, 3); -- Apollo e Dafne - Venere (ipotesi)

-- Insert per la tabella Dipinto_Personaggio
INSERT INTO Dipinto_Personaggio (dipintoRIF, personaggioRIF)
VALUES
(1, 1), -- La Gioconda - Madonna (ipotesi)
(2, 2), -- Guernica - San Giovanni (ipotesi)
(3, 3); -- La Creazione di Adamo - Venere (ipotesi)

-- ------------------------------------------------------------------

-- Voglio conoscere tutte le sculture che stanno dentro al louvre
SELECT *
	FROM Museo
	JOIN Scultura ON Museo.museoID = Scultura.museoRIF
	JOIN Scultura_Artista ON Scultura.sculturaID = Scultura_Artista.sculturaRIF
	JOIN Artista ON Scultura_Artista.artistaRIF = Artista.artistaID
	WHERE Museo.nome = 'Museo degli Uffizi';

-- In quale scultura appare "Venere" ed in quale museo è ospitata
SELECT Personaggio.nome, titolo, Museo.nome
	FROM Personaggio
	JOIN Scultura_Personaggio ON Personaggio.personaggioID = Scultura_Personaggio.personaggioRIF
	JOIN Scultura ON Scultura_Personaggio.sculturaRIF = Scultura.sculturaID
	JOIN Museo ON Scultura.museoRIF = Museo.museoID
	WHERE Personaggio.nome = 'Venere';