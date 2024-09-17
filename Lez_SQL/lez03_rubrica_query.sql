CREATE DATABASE a_lez03_rubrica;
USE a_lez03_rubrica;

/*
CREATE TABLE Contatto(
	contattoID INTEGER IDENTITY(1,1),
	nome VARCHAR(250) NOT NULL,
	cognome VARCHAR(250) NOT NULL,
	email VARCHAR(250) NOT NULL,
	cod_fis CHAR(16) NOT NULL,
	UNIQUE(email),
	UNIQUE(cod_fis),
	PRIMARY KEY(contattoID)
);
*/

DROP TABLE IF EXISTS Contatto;
CREATE TABLE Contatto(
	contattoID INTEGER PRIMARY KEY IDENTITY(1000,5),
	nome VARCHAR(250) NOT NULL,
	cognome VARCHAR(250) NOT NULL,
	email VARCHAR(250) NOT NULL UNIQUE,
	cod_fis CHAR(16) NOT NULL UNIQUE
);

/*
-- ID Univoco, come funziona...
INSERT INTO Contatto(nome, cognome, email, cod_fis) VALUES 
('Giovanni', 'Pace', 'gio@pace.com', 'PCAGNN'),
('Valeria', 'Verdi', 'val@ver.com', 'VALVER'),
('Mario', 'Rossi', 'mario@ros.com', 'MARROS');

INSERT INTO Contatto(nome, cognome, email, cod_fis) VALUES 
('Valeria', 'Verdi', 'val@ver.com', 'VALVER');

DELETE FROM Contatto WHERE contattoID = 2;

SELECT * FROM Contatto;
*/

INSERT INTO Contatto(nome, cognome, email, cod_fis) VALUES
('Giovanni', 'Pace', 'gio@pace.com', 'PCAGNN');
INSERT INTO Contatto(nome, cognome, email, cod_fis) VALUES
('Valeria', 'Verdi', 'val@verdi.com', 'VLRVRD');
INSERT INTO Contatto(nome, cognome, email, cod_fis) VALUES
('Mario', 'Rossi', 'mar@rossi.com', 'MARRSS');
INSERT INTO Contatto(nome, cognome, email, cod_fis) VALUES
('Marika', 'Mariko', 'mar@mar.com', 'MARMAR');
INSERT INTO Contatto(nome, cognome, email, cod_fis) VALUES
('Mario', 'Mariottide', 'mar@td.com', 'MARMTD');
INSERT INTO Contatto(nome, cognome, email, cod_fis) VALUES
('Maria', 'Mariani', 'mar@mrn.com', 'MARMRN');
INSERT INTO Contatto(nome, cognome, email, cod_fis) VALUES
('Mariolino', 'Mariottide', 'mar@ted.com', 'MIOMTD');

-- QL
SELECT * FROM Contatto;

SELECT nome, cognome, email, cod_fis FROM Contatto;

-- ALIAS
SELECT 
	cod_fis AS 'Codice Fiscale',
	nome AS 'Nome', 
	cognome AS 'Cognome', 
	email AS 'Indirizzo E-Mail'
	FROM Contatto;

-- RICERCA
SELECT * FROM Contatto WHERE nome = 'Mario';

SELECT * FROM Contatto WHERE nome = 'Mario' AND cognome = 'Rossi';

SELECT * 
	FROM Contatto 
	WHERE nome = 'Mario' OR nome = 'Giovanni' OR nome = 'Marika';

SELECT *
	FROM Contatto 
	WHERE nome IN ('Mario', 'Giovanni', 'Marika');

SELECT * FROM Contatto WHERE nome <> 'Mario';

-- LIKE
-- Tutto ciò che inizia per Ma...
SELECT * FROM Contatto WHERE nome LIKE 'Ma%';

-- Tutto ciò che finisce per ...io;
SELECT * FROM Contatto WHERE nome LIKE '%io';

-- Tutto ciò che contiene ...io...
SELECT * FROM Contatto WHERE nome LIKE '%io%';

-- Ricerca puntuale
SELECT * FROM Contatto WHERE nome LIKE 'Mari_';

-- Ricerca puntuale
SELECT * FROM Contatto WHERE nome LIKE '__ri____o';
