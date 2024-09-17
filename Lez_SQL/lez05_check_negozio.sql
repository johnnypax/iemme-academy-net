-- DDL
CREATE DATABASE a_lez05_check_negozio;
USE a_lez05_check_negozio;

DROP TABLE IF EXISTS Prodotto;
CREATE TABLE Prodotto(
	prodottoID INTEGER IDENTITY(1,1),
	nome VARCHAR(150) NOT NULL,
	descrizione TEXT,
	categoria VARCHAR(50) DEFAULT 'Non definito',
	codice VARCHAR(10) NOT NULL,
	prezzo DECIMAL(5, 2) CHECK (prezzo >= 0),
	data_scadenza DATE CHECK (data_scadenza BETWEEN '2000-01-01' AND '2100-01-01'),
	data_inserimento DATETIME DEFAULT CURRENT_TIMESTAMP,
	PRIMARY KEY(prodottoID),
	UNIQUE(codice),
	-- CONSTRAINT CHK_Prezzo CHECK (prezzo >= 0),
	-- CONSTRAINT CHK_DataScad CHECK (data_scadenza BETWEEN '2000-01-01' AND '2100-01-01')
);

-- Rimozione ed inserimento Constraint
/*
ALTER TABLE Prodotto DROP CONSTRAINT CHK_Prezzo;

ALTER TABLE Prodotto 
	ADD CONSTRAINT CHK_Categoria 
	CHECK(categoria IN ('Illuminazione', 'Alimento', 'Bricolage', 'Non definito'));

ALTER TABLE Prodotto ADD CONSTRAINT CHK_Prezzo CHECK(prezzo >= 0);
*/

-- ---------------------------------------------------------------------

CREATE TABLE Prodotto(
	prodottoID INT IDENTITY(1,1) PRIMARY KEY,
	nome VARCHAR(250) NOT NULL,
	descrizione TEXT,
	prezzo DECIMAL(5,2) CHECK(prezzo >= 0),
	categoria VARCHAR(50) CHECK(categoria IN ('Illuminazione', 'Alimento', 'Bricolage', 'Non definito')),
	data_scadenza DATE CHECK(data_scadenza BETWEEN '1900-01-01' AND '2100-01-01')
);

SELECT * FROM Prodotto;
