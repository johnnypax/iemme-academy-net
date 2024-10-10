CREATE TABLE Videoteca(
	videotecaID INT PRIMARY KEY IDENTITY(1,1),
	codice VARCHAR(250) NOT NULL DEFAULT NEWID(),
	nome VARCHAR(250) NOT NULL,
	indirizzo VARCHAR(500)
);

CREATE TABLE Supporto(
	supportoID INT PRIMARY KEY IDENTITY(1,1),
	codice VARCHAR(250) NOT NULL DEFAULT NEWID(),
	titolo VARCHAR(250) NOT NULL,
	anno INT,
	disponibilita BIT DEFAULT 1,
	tipo VARCHAR(250) NOT NULL,
	videotecaRIF INT NOT NULL,
	FOREIGN KEY (videotecaRIF) REFERENCES Videoteca(videotecaID) ON DELETE CASCADE
);

INSERT INTO Videoteca (nome, indirizzo) VALUES
('Videoteca Alfa', 'Via Roma 1'),
('Videoteca Beta', 'Via Verdi 2'),
('Videoteca Gamma', 'Via Garibaldi 3'),
('Videoteca Delta', 'Via Dante 4'),
('Videoteca Epsilon', 'Via Petrarca 5'),
('Videoteca Zeta', 'Via Tasso 6'),
('Videoteca Eta', 'Via Ariosto 7'),
('Videoteca Theta', 'Via Leopardi 8'),
('Videoteca Iota', 'Via Manzoni 9'),
('Videoteca Kappa', 'Via Foscolo 10');

INSERT INTO Supporto (titolo, anno, disponibilita, tipo, videotecaRIF) VALUES
('Il Signore degli Anelli - La Compagnia dell''Anello', 2001, 1, 'DVD', 1),
('Il Signore degli Anelli - Le Due Torri', 2002, 1, 'DVD', 1),
('Il Signore degli Anelli - Il Ritorno del Re', 2003, 1, 'DVD', 1),
('Star Wars - Episodio IV - Una Nuova Speranza', 1977, 1, 'DVD', 1),
('Star Wars - Episodio V - L''Impero Colpisce Ancora', 1980, 1, 'DVD', 1),
('Star Wars - Episodio VI - Il Ritorno dello Jedi', 1983, 1, 'DVD', 1),
('Il Padrino', 1972, 1, 'DVD', 1),
('Il Padrino - Parte II', 1974, 1, 'DVD', 1),
('Il Padrino - Parte III', 1990, 1, 'DVD', 1),
('Pulp Fiction', 1994, 1, 'DVD', 1);

SELECT * FROM Videoteca;