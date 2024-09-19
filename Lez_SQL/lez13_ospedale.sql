CREATE TABLE Reparto(
	repartoID INT PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(250) NOT NULL,
	numero INT NOT NULL CHECK (numero >= 0),
	piano INT NOT NULL
); 

CREATE TABLE Paziente(
	pazienteID INT PRIMARY KEY IDENTITY(1,1),
	nominativo VARCHAR(250) NOT NULL,
	codice VARCHAR(10) NOT NULL UNIQUE
);

CREATE TABLE Ricovero(					-- Tabella d'appoggio Reparto_Paziente
	ricoveroID INT PRIMARY KEY IDENTITY(1,1),
	repartoRIF INT NOT NULL,
	pazienteRIF INT NOT NULL,
	motivo TEXT,
	data_ingr DATETIME DEFAULT CURRENT_TIMESTAMP,
	data_usci DATETIME,
	FOREIGN KEY(repartoRIF) REFERENCES Reparto(repartoID) ON DELETE CASCADE,
	FOREIGN KEY(pazienteRIF) REFERENCES Paziente(pazienteID) ON DELETE CASCADE
);

CREATE TABLE Medico(
	medicoID INT PRIMARY KEY IDENTITY(1,1),
	nominativo VARCHAR(250) NOT NULL,
	specializzazione VARCHAR(250) NOT NULL,
	identificativo INT NOT NULL UNIQUE,
	repartoRIF INT NOT NULL,
	FOREIGN KEY (repartoRIF) REFERENCES Reparto(repartoID) ON DELETE CASCADE
);

CREATE TABLE Visita(
	visitaID INT PRIMARY KEY IDENTITY(1,1),
	medicoRIF INT NOT NULL,
	pazienteRIF INT NOT NULL,
	data_visita DATETIME DEFAULT CURRENT_TIMESTAMP,
	note TEXT,
	FOREIGN KEY(medicoRIF) REFERENCES Medico(medicoID) ON DELETE CASCADE,
	FOREIGN KEY(pazienteRIF) REFERENCES Paziente(pazienteID) ON DELETE CASCADE
);

CREATE TABLE Esame(
	esameID INT PRIMARY KEY IDENTITY(1,1),
	tipo VARCHAR(20) NOT NULL,
	esito TEXT NOT NULL,
	pazienteRIF INT NOT NULL,
	FOREIGN KEY(pazienteRIF) REFERENCES Paziente(pazienteID) ON DELETE CASCADE,
);

INSERT INTO Reparto (nome, numero, piano) VALUES 
('Cardiologia', 101, 1),
('Neurologia', 102, 1),
('Ortopedia', 201, 2),
('Ginecologia', 202, 2),
('Pediatria', 301, 3),
('Dermatologia', 302, 3),
('Oncologia', 401, 4),
('Chirurgia', 402, 4),
('Urologia', 501, 5),
('Otorinolaringoiatria', 502, 5);

INSERT INTO Paziente (nominativo, codice) VALUES
('Mario Rossi', 'PZ001'),
('Luigi Bianchi', 'PZ002'),
('Anna Verdi', 'PZ003'),
('Giulia Gialli', 'PZ004'),
('Paolo Neri', 'PZ005'),
('Elena Blu', 'PZ006'),
('Marco Viola', 'PZ007'),
('Sara Rosa', 'PZ008'),
('Alessandro Grigi', 'PZ009'),
('Francesca Celeste', 'PZ010');

INSERT INTO Ricovero (repartoRIF, pazienteRIF, motivo, data_ingr, data_usci) VALUES
(1, 1, 'Infarto acuto', 2024-09-10, 2024-09-20),
(2, 1, 'Ischemia cerebrale', 2024-09-11, NULL),
(3, 2, 'Frattura femore', 2024-09-15, 2024-09-25),
(4, 2, 'Gravidanza a rischio', 2024-09-12, NULL),
(5, 3, 'Polmonite pediatrica', 2024-09-13, 2024-09-20),
(6, 3, 'Psoriasi grave', 2024-09-14, NULL),
(7, 4, 'Chemioterapia', 2024-09-15, 2024-09-30),
(8, 4, 'Appendicectomia', 2024-09-16, NULL),
(9, 5, 'Prostatite', 2024-09-17, 2024-09-25),
(10, 5, 'Infezione alle orecchie', 2024-09-18, NULL);

INSERT INTO Medico (nominativo, specializzazione, identificativo, repartoRIF) VALUES
('Dr. Luca Conti', 'Cardiologia', 1001, 1),
('Dr.ssa Marta Ricci', 'Neurologia', 1002, 2),
('Dr. Gianni Ferrari', 'Ortopedia', 1003, 3),
('Dr.ssa Laura Fabbri', 'Ginecologia', 1004, 4),
('Dr. Andrea Moretti', 'Pediatria', 1005, 5),
('Dr.ssa Silvia Bruni', 'Dermatologia', 1006, 6),
('Dr. Roberto Galli', 'Oncologia', 1007, 7),
('Dr.ssa Alessia Fontana', 'Chirurgia', 1008, 8),
('Dr. Marco Leone', 'Urologia', 1009, 9),
('Dr. Sara De Luca', 'Otorinolaringoiatria', 1010, 10);

SELECT * FROM Medico;

INSERT INTO Visita (medicoRIF, pazienteRIF, data_visita, note) VALUES
(1, 1, 2024-09-10, 'Controllo post-infarto'),
(2, 1, 2024-09-11, 'Esami neurologici in corso'),
(3, 2, 2024-09-15, 'Controllo frattura femore'),
(4, 2, 2024-09-12, 'Gravidanza in miglioramento'),
(5, 3, 2024-09-13, 'Polmonite sotto controllo'),
(6, 3, 2024-09-14, 'Psoriasi cronica in trattamento'),
(7, 4, 2024-09-15, 'Chemioterapia prima sessione'),
(8, 4, 2024-09-16, 'Visita post-appendicectomia'),
(9, 5, 2024-09-17, 'Prostatite migliorata'),
(10, 5, 2024-09-18, 'Orecchie migliorate');

INSERT INTO Esame (tipo, esito, pazienteRIF) VALUES
('ECG', 'Normale', 1),
('Risonanza magnetica', 'Ischemia cerebrale riscontrata', 2),
('Radiografia', 'Frattura composta', 3),
('Ecografia', 'Gravidanza monitorata', 4),
('TAC toracica', 'Polmonite visibile', 5),
('Biopsia cutanea', 'Psoriasi in fase avanzata', 6),
('PET', 'Tumore in remissione', 7),
('TAC addominale', 'Appendicite acuta', 8),
('Esame urine', 'Prostatite diagnosticata', 9),
('Esame audiometrico', 'Perdita uditiva lieve', 10);

-- Tutti gli esami fatti da un paziente (a scelta)
SELECT *
	FROM Paziente AS p
	JOIN Esame AS e ON p.pazienteID = e.esameID
	WHERE codice = 'PZ003';

-- Voglio conoscere i reparti interessati da dei ricoveri che 
-- coinvolgono pazienti interessati dall'esame Radiografia

SELECT * 
	FROM Esame
	JOIN Paziente ON Esame.pazienteRIF = Paziente.pazienteID
	JOIN Ricovero ON Paziente.pazienteID = Ricovero.pazienteRIF
	JOIN Reparto ON Ricovero.repartoRIF = Reparto.repartoID
	JOIN Medico ON Reparto.repartoID = Medico.repartoRIF
	WHERE tipo = 'Radiografia';

-- Seconda operazione non ottimizzata
SELECT *
	FROM Reparto
	JOIN Ricovero ON Reparto.repartoID = Ricovero.repartoRIF
	JOIN Paziente ON Ricovero.pazienteRIF = Paziente.pazienteID
	JOIN Esame ON Paziente.pazienteID = Esame.pazienteRIF
	WHERE tipo = 'Radiografia';

-- Dato il ricoveroID 1, voglio sapere tutte le visite da esso subite
SELECT * 
	FROM Ricovero
	JOIN Paziente ON Ricovero.pazienteRIF = Paziente.pazienteID
	JOIN Visita ON Paziente.pazienteID = Visita.pazienteRIF
	WHERE ricoveroID = 2;

SELECT Reparto.*, Medico.*
	FROM Ricovero
	JOIN Reparto ON Ricovero.repartoRIF = Reparto.repartoID
	JOIN Medico ON Reparto.repartoID = Medico.repartoRIF
	JOIN Visita ON Medico.medicoID = Visita.medicoRIF
	WHERE ricoveroID = 2;