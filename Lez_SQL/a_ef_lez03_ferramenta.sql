CREATE TABLE Reparto(
	repartoID INT PRIMARY KEY IDENTITY(1,1),
	repartoCOD VARCHAR(250) NOT NULL UNIQUE,
	nome VARCHAR(250) NOT NULL, 
	fila VARCHAR(10) NOT NULL,
	UNIQUE(nome, fila)
);

CREATE TABLE Prodotto(
	prodottoID INT PRIMARY KEY IDENTITY(1,1),
	codiceBarre VARCHAR(250) NOT NULL UNIQUE,
	nome VARCHAR(250) NOT NULL,
	descrizione TEXT,
	prezzo DECIMAL(5,3),
	quantita INT NOT NULL CHECK (quantita >= 0),
	repartoRIF INT NOT NULL,
	FOREIGN KEY (repartoRIF) REFERENCES Reparto(repartoID) ON DELETE CASCADE
);

INSERT INTO Reparto (repartoCOD, nome, fila)
VALUES
    ('FRU01', 'Frutta', 'A1'),
    ('VER02', 'Verdura', 'B2'),
    ('LAT03', 'Latticini', 'C1'),
    ('CAR04', 'Carne', 'D2'),
    ('PES05', 'Pesce', 'E1'),
    ('SUR06', 'Surgelati', 'F2'),
    ('PAN07', 'Pane', 'G1'),
    ('BEA08', 'Bevande', 'H2'),
    ('COS09', 'Cosmetici', 'I1'),
    ('CAS10', 'Casalinghi', 'J2');

INSERT INTO Prodotto (codiceBarre, nome, descrizione, prezzo, quantita, repartoRIF)
VALUES
    ('1234567890123', 'Mele', 'Mele rosse biologiche', 1.99, 50, 1),
    ('2345678901234', 'Pomodori', 'Pomodori ciliegino', 2.50, 30, 2),
    ('3456789012345', 'Latte', 'Latte intero fresco', 1.20, 100, 3),
    ('4567890123456', 'Manzo', 'Filetto di manzo', 25.00, 10, 4),
    ('5678901234567', 'Salmone', 'Salmone affumicato', 18.99, 20, 5),
    ('6789012345678', 'Pizza', 'Pizza Margherita', 4.99, 150, 6),
    ('7890123456789', 'Pane', 'Pane integrale', 1.50, 80, 7),
    ('8901234567890', 'Coca-Cola', 'Coca-Cola classica', 1.00, 200, 8),
    ('9012345678901', 'Shampoo', 'Shampoo per capelli secchi', 5.99, 50, 9),
    ('0123456789012', 'Detersivo', 'Detersivo per piatti', 2.99, 100, 10);