-- DDL
CREATE DATABASE a_lez01_introduzione;
-- DROP DATABASE a_lez01_introduzione;

USE a_lez01_introduzione;

CREATE TABLE Persona(
	nome VARCHAR(250) NOT NULL, 
	cognome VARCHAR(250) NOT NULL,
	telefono VARCHAR(250),
	cod_fis CHAR(16) NOT NULL UNIQUE,
	email VARCHAR(250)
	);

-- DROP TABLE Persona;

-- DML

INSERT INTO Persona(nome, cognome, telefono, cod_fis, email) VALUES
('Giovanni', 'Pace', '123456', 'PCAGNN', 'gio@pace.com');
INSERT INTO Persona(nome, cognome, telefono, cod_fis, email) VALUES
('Valeria', 'Verdi', '123457', 'VLRVRD', 'val@ver.com');

INSERT INTO Persona(nome, cognome, cod_fis) VALUES
('Mario', 'Rossi', 'MRRRSS');

-- QL
SELECT * FROM Persona;