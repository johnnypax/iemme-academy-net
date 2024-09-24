CREATE TABLE Dipendente(
	dipententeID INT PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(250) NOT NULL,
	cognome VARCHAR(250) NOT NULL,
	dipartimento VARCHAR(250) DEFAULT 'N.D.',
	identificativo VARCHAR(250) NOT NULL DEFAULT NEWID() UNIQUE,
	salario INTEGER DEFAULT 0
);

INSERT INTO Dipendente (nome, cognome, dipartimento, salario)
VALUES ('Mario', 'Rossi', 'Amministrazione', 30000);

INSERT INTO Dipendente (nome, cognome, dipartimento, salario)
VALUES ('Luca', 'Bianchi', 'Amministrazione', 28000);

INSERT INTO Dipendente (nome, cognome, dipartimento, salario)
VALUES ('Laura', 'Verdi', 'IT', 45000);

INSERT INTO Dipendente (nome, cognome, dipartimento, salario)
VALUES ('Giulia', 'Neri', 'Marketing', 35000);

INSERT INTO Dipendente (nome, cognome, dipartimento, salario)
VALUES ('Francesco', 'Russo', 'Vendite', 40000);

INSERT INTO Dipendente (nome, cognome, dipartimento, salario)
VALUES ('Anna', 'Gialli', 'IT', 46000);

INSERT INTO Dipendente (nome, cognome, dipartimento, salario)
VALUES ('Roberto', 'Esposito', 'Amministrazione', 32000);

INSERT INTO Dipendente (nome, cognome, dipartimento, salario)
VALUES ('Elena', 'Marini', 'Marketing', 36000);

INSERT INTO Dipendente (nome, cognome, dipartimento, salario)
VALUES ('Stefano', 'Bruni', 'Vendite', 39000);

INSERT INTO Dipendente (nome, cognome, dipartimento, salario)
VALUES ('Simona', 'Ferri', 'Amministrazione', 31000);

SELECT * FROM Dipendente;

SELECT dipententeID, nome, cognome, dipartimento, identificativo, salario 
	FROM Dipendente 
	WHERE dipententeID = 4;


CREATE TABLE Asset(
	assetID INT PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(250) NOT NULL,
	quantita INT NOT NULL DEFAULT 1
);