CREATE TABLE Albergo(
	albergoID INT PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(250) NOT NULL,
	indirizzo VARCHAR(250) NOT NULL,
	stelle INT NOT NULL DEFAULT 3 CHECK (stelle BETWEEN 1 AND 5)
);

CREATE TABLE Camera(
	cameraID INT PRIMARY KEY IDENTITY(1,1),
	codice VARCHAR(250) NOT NULL,
	posti INT NOT NULL DEFAULT 1,
	descrizione TEXT,
	albergoRIF INT NOT NULL,
	FOREIGN KEY(albergoRIF) REFERENCES Albergo(albergoID) ON DELETE CASCADE,
	UNIQUE(albergoRIF, codice)
);

INSERT INTO Albergo (nome, indirizzo, stelle) VALUES
('Hotel Bellavista', 'Via Roma 12, Milano', 4),
('Albergo Centrale', 'Piazza Duomo 8, Firenze', 5),
('Grand Hotel', 'Corso Italia 21, Venezia', 5),
('Hotel Serenità', 'Via Mazzini 42, Napoli', 3),
('Albergo Paradiso', 'Via del Mare 10, Palermo', 4),
('Hotel Sole', 'Via Verdi 15, Torino', 3),
('Albergo Stella', 'Via Dante 7, Bologna', 4),
('Hotel Laghetto', 'Via Lago 2, Como', 5),
('Hotel Montagna', 'Via Alpina 99, Cortina', 4),
('Albergo Lido', 'Lungomare Colombo 35, Rimini', 3);

INSERT INTO Camera (codice, posti, descrizione, albergoRIF) VALUES
('101', 2, 'Camera con vista sul mare', 1),
('102', 2, 'Camera matrimoniale con balcone', 1),
('201', 3, 'Suite presidenziale', 2),
('202', 1, 'Camera singola con vista sulla città', 2),
('301', 4, 'Suite con terrazza privata', 3),
('302', 2, 'Camera doppia con bagno privato', 3),
('401', 2, 'Camera matrimoniale con vista mare', 4),
('402', 1, 'Camera singola con bagno in comune', 4),
('501', 3, 'Camera tripla con vista giardino', 5),
('502', 2, 'Camera doppia con balcone', 5),
('101', 1, 'Camera singola economica', 6),
('102', 2, 'Camera matrimoniale con bagno privato', 6),
('201', 2, 'Camera doppia con vista giardino', 7),
('202', 3, 'Camera tripla con terrazza', 7),
('301', 4, 'Suite familiare', 8),
('302', 2, 'Camera doppia con vista lago', 8),
('401', 2, 'Camera matrimoniale con vista montagna', 9),
('402', 1, 'Camera singola con colazione inclusa', 9),
('101', 1, 'Camera singola vista mare', 10),
('102', 2, 'Camera matrimoniale con balcone', 10);

SELECT * 
	FROM Albergo 
	JOIN Camera ON Albergo.albergoID = Camera.albergoRIF
	WHERE nome = 'Grand Hotel';