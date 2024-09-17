-- DROP DATABASE a_lez02_struttura;
-- CREATE DATABASE a_lez02_struttura;
USE a_lez02_struttura;

DROP TABLE IF EXISTS Persona;
CREATE TABLE Persona(
	nome VARCHAR(250) NOT NULL, 
	cognome VARCHAR(250) NOT NULL,
	telefono VARCHAR(250),
	cod_fis CHAR(16) NOT NULL UNIQUE
	);

-- Aggiungi una colonna
ALTER TABLE Persona ADD email VARCHAR(250) NOT NULL;

-- Elimina una colonna
-- ALTER TABLE Persona DROP COLUMN email;

-- Modifica una colonna
-- ALTER TABLE Persona ALTER COLUMN email VARCHAR(150);

-- DML

INSERT INTO Persona(nome, cognome, cod_fis, telefono, email) VALUES
('Giovanni', 'Pace', 'PCAGNN', '1234', 'gio@pace.com');
INSERT INTO Persona(nome, cognome, cod_fis, telefono, email) VALUES
('Valeria', 'Verdi', 'VLRVRD', '1235', 'val@ver.com');
INSERT INTO Persona(nome, cognome, cod_fis, telefono, email) VALUES
('Mario', 'Rossi', 'MRRRSS', '1236', 'mar@ros.com');
INSERT INTO Persona(nome, cognome, cod_fis, telefono, email) VALUES
('Giovanna', 'Pace', 'PCAGNA', '1238', 'gio@van.com');

INSERT INTO Persona(nome, cognome, cod_fis, telefono, email) VALUES
('Giovanni', 'Pace', 'PCAGNN', '1234', 'gio@pace.com'),
('Valeria', 'Verdi', 'VLRVRD', '1235', 'val@ver.com'),
('Mario', 'Rossi', 'MRRRSS', '1236', 'mar@ros.com'),
('Giovanna', 'Pace', 'PCAGNA', '1238', 'gio@van.com');

-- Eliminazione dati
-- DELETE FROM Persona WHERE cod_fis = 'PCAGNN';

-- Modifica dati
/*
UPDATE Persona SET 
	nome = 'Marika', 
	cognome = 'Mariko' 
	WHERE cod_fis = 'MRRRSS';
*/
-- QL
SELECT * FROM Persona;
SELECT * FROM Persona WHERE cognome = 'Pace';

-- Proiezione
SELECT * FROM Persona;
SELECT nome, cod_fis FROM Persona;
SELECT nome, cod_fis FROM Persona WHERE email = 'gio@pace.com';


SELECT * FROM Persona WHERE cod_fis = 'MRRRSS';