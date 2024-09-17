/*
Creare una tabella di libri caratterizzata da Titolo, l'autore ed il codice ISBN.
- Inserire almeno 6 libri
- Ricercare tutti i libri di un autore
- Ricercare tutti i libri che hanno la sequenza "an" al loro interno
- Ricerca per ISBN
*/

-- DDL 
CREATE DATABASE a_lez04_rubrica;
USE a_lez04_rubrica;

CREATE TABLE Libro(
	libroID INTEGER PRIMARY KEY IDENTITY(1,1),
	titolo VARCHAR(250) NOT NULL,
	autore VARCHAR(50) NOT NULL,
	isbn CHAR(13) NOT NULL UNIQUE,
	categoria VARCHAR(50) DEFAULT 'N.D.'
);

ALTER TABLE Libro ADD pagine INTEGER;

-- DML
INSERT INTO Libro(isbn, titolo, autore) VALUES
('ab1234', 'Il signore degli anelli', 'JRRT'),
('ab1235', 'Le due torri', 'JRRT');

INSERT INTO Libro(isbn, titolo, autore, categoria) VALUES
('ab1236', 'Il ritorno del re', 'JRRT', 'Fantasy'),
('ab1237', 'Come non rompere le scatole', 'Il gatto di Gio', null);


INSERT INTO Libro(isbn, titolo, autore) VALUES
('ab1238', 'Chi ha il gatto peggiore del secolo', 'Giovanni Pace');

-- QL
SELECT * FROM Libro;

SELECT * FROM Libro WHERE categoria IS NOT NULL;
SELECT * FROM Libro WHERE categoria IS NULL;

SELECT * FROM Libro WHERE autore = 'JRRT';
SELECT * FROM Libro WHERE isbn = 'ab1234';

SELECT * FROM Libro WHERE titolo LIKE '%an%' AND autore LIKE '%an%';