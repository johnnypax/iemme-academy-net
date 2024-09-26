DROP TABLE IF EXISTS Rivista;
DROP TABLE IF EXISTS Giocattolo;

CREATE TABLE Rivista(
	rivistaID INT PRIMARY KEY IDENTITY(1,1),
	codice VARCHAR(250) NOT NULL DEFAULT NEWID(),
	prezzo DECIMAL(5,2) NOT NULL DEFAULT 0,
	titolo VARCHAR(250) NOT NULL,
	casaed VARCHAR(250) NOT NULL,
	CONSTRAINT CHK_Rivista_prezzo CHECK(prezzo >= 0)
);

CREATE TABLE Giocattolo(
	giocattoloID INT PRIMARY KEY IDENTITY(1,1),
	codice VARCHAR(250) NOT NULL DEFAULT NEWID(),
	prezzo DECIMAL(5,2) NOT NULL DEFAULT 0,
	etamin INT NOT NULL DEFAULT 0 CHECK (etamin >= 0),
	materi VARCHAR(250) NOT NULL DEFAULT 'N.D.',
	CONSTRAINT CHK_Giocattolo_prezzo CHECK(prezzo >= 0)
);

INSERT INTO Rivista (titolo, casaed, prezzo) VALUES ('Vogue', 'Condé Nast', 9.99);
INSERT INTO Rivista (titolo, casaed, prezzo) VALUES ('National Geographic', 'National Geographic Partners', 12.50);
INSERT INTO Rivista (titolo, casaed, prezzo) VALUES ('Time', 'Time USA LLC', 7.99);
INSERT INTO Rivista (titolo, casaed, prezzo) VALUES ('Forbes', 'Forbes Media', 8.50);
INSERT INTO Rivista (titolo, casaed, prezzo) VALUES ('Scientific American', 'Springer Nature', 10.00);
INSERT INTO Rivista (titolo, casaed, prezzo) VALUES ('Nature', 'Springer Nature', 15.00);
INSERT INTO Rivista (titolo, casaed, prezzo) VALUES ('Wired', 'Condé Nast', 6.99);
INSERT INTO Rivista (titolo, casaed, prezzo) VALUES ('The Economist', 'The Economist Group', 14.50);
INSERT INTO Rivista (titolo, casaed, prezzo) VALUES ('Popular Science', 'Bonnier Corporation', 5.99);
INSERT INTO Rivista (titolo, casaed, prezzo) VALUES ('Fortune', 'Fortune Media IP Limited', 11.20);
INSERT INTO Rivista (titolo, casaed, prezzo) VALUES ('Harper s Bazaar', 'Hearst Communications', 9.00);
INSERT INTO Rivista (titolo, casaed, prezzo) VALUES ('Cosmopolitan', 'Hearst Communications', 8.75);
INSERT INTO Rivista (titolo, casaed, prezzo) VALUES ('New Scientist', 'Daily Mail and General Trust', 13.50);
INSERT INTO Rivista (titolo, casaed, prezzo) VALUES ('Rolling Stone', 'Penske Media Corporation', 9.50);
INSERT INTO Rivista (titolo, casaed, prezzo) VALUES ('Vanity Fair', 'Condé Nast', 11.00);
INSERT INTO Rivista (titolo, casaed, prezzo) VALUES ('GQ', 'Condé Nast', 7.25);
INSERT INTO Rivista (titolo, casaed, prezzo) VALUES ('Esquire', 'Hearst Communications', 8.99);
INSERT INTO Rivista (titolo, casaed, prezzo) VALUES ('Men s Health', 'Hearst Communications', 6.75);
INSERT INTO Rivista (titolo, casaed, prezzo) VALUES ('Reader s Digest', 'Trusted Media Brands', 4.50);
INSERT INTO Rivista (titolo, casaed, prezzo) VALUES ('Good Housekeeping', 'Hearst Communications', 7.50);

INSERT INTO Giocattolo (prezzo, etamin, materi) VALUES (15.99, 3, 'Plastica');
INSERT INTO Giocattolo (prezzo, etamin, materi) VALUES (24.50, 5, 'Legno');
INSERT INTO Giocattolo (prezzo, etamin, materi) VALUES (9.99, 2, 'Gomma');
INSERT INTO Giocattolo (prezzo, etamin, materi) VALUES (19.99, 4, 'Plastica');
INSERT INTO Giocattolo (prezzo, etamin, materi) VALUES (29.99, 6, 'Metallo');
INSERT INTO Giocattolo (prezzo, etamin, materi) VALUES (14.99, 3, 'Tessuto');
INSERT INTO Giocattolo (prezzo, etamin, materi) VALUES (12.50, 1, 'Pelliccia sintetica');
INSERT INTO Giocattolo (prezzo, etamin, materi) VALUES (39.99, 8, 'Legno');
INSERT INTO Giocattolo (prezzo, etamin, materi) VALUES (49.99, 9, 'Metallo');
INSERT INTO Giocattolo (prezzo, etamin, materi) VALUES (7.99, 3, 'Plastica');
INSERT INTO Giocattolo (prezzo, etamin, materi) VALUES (5.99, 1, 'Plastica');
INSERT INTO Giocattolo (prezzo, etamin, materi) VALUES (16.99, 5, 'Legno');
INSERT INTO Giocattolo (prezzo, etamin, materi) VALUES (8.99, 2, 'Gomma');
INSERT INTO Giocattolo (prezzo, etamin, materi) VALUES (23.50, 4, 'Metallo');
INSERT INTO Giocattolo (prezzo, etamin, materi) VALUES (21.99, 6, 'Plastica');
INSERT INTO Giocattolo (prezzo, etamin, materi) VALUES (13.99, 3, 'Tessuto');
INSERT INTO Giocattolo (prezzo, etamin, materi) VALUES (17.50, 2, 'Pelliccia sintetica');
INSERT INTO Giocattolo (prezzo, etamin, materi) VALUES (28.99, 7, 'Legno');
INSERT INTO Giocattolo (prezzo, etamin, materi) VALUES (35.99, 9, 'Metallo');
INSERT INTO Giocattolo (prezzo, etamin, materi) VALUES (9.50, 3, 'Plastica');

SELECT * FROM Rivista;

