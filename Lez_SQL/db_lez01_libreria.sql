CREATE TABLE Libro(
	libroID INTEGER PRIMARY KEY IDENTITY(1,1),
	titolo VARCHAR(250) NOT NULL,
	autore VARCHAR(250) NOT NULL,
	pagine INTEGER NOT NULL DEFAULT 1,
	editore VARCHAR(250) NOT NULL DEFAULT 'N.D.',
	isbn CHAR(13) NOT NULL UNIQUE
);

INSERT INTO Libro (titolo, autore, pagine, editore, isbn) VALUES
('Il Signore degli Anelli', 'J.R.R. Tolkien', 1178, 'Bompiani', '9788845292610'),
('Harry Potter e la Pietra Filosofale', 'J.K. Rowling', 309, 'Salani', '9780747532699'),
('Il Codice da Vinci', 'Dan Brown', 523, 'Mondadori', '9788804532836'),
('Cento anni di solitudine', 'Gabriel García Márquez', 422, 'Mondadori', '9788804567029'),
('Orgoglio e Pregiudizio', 'Jane Austen', 332, 'Einaudi', '9788806171330'),
('Il Grande Gatsby', 'F. Scott Fitzgerald', 180, 'Mondadori', '9788804680216'),
('1984', 'George Orwell', 328, 'Mondadori', '9788804704103'),
('Moby Dick', 'Herman Melville', 635, 'Feltrinelli', '9788807900830'),
('Amleto', 'William Shakespeare', 312, 'Garzanti', '9788811811656'),
('La Divina Commedia', 'Dante Alighieri', 798, 'Feltrinelli', '9788807900656'),
('Don Chisciotte della Mancia', 'Miguel de Cervantes', 1056, 'Einaudi', '9788806167463'),
('Il Nome della Rosa', 'Umberto Eco', 536, 'Bompiani', '9788845247879'),
('Lo Hobbit', 'J.R.R. Tolkien', 310, 'Bompiani', '9788845291209'),
('I Promessi Sposi', 'Alessandro Manzoni', 720, 'Feltrinelli', '9788807901073'),
('Anna Karenina', 'Lev Tolstoj', 864, 'Einaudi', '9788806225698'),
('Il Piccolo Principe', 'Antoine de Saint-Exupéry', 96, 'Bompiani', '9788845298994'),
('Guerra e Pace', 'Lev Tolstoj', 1225, 'Mondadori', '9788804610847'),
('Il Conte di Montecristo', 'Alexandre Dumas', 1312, 'Einaudi', '9788806196578'),
('Frankenstein', 'Mary Shelley', 280, 'Garzanti', '9788811687459'),
('Dracula', 'Bram Stoker', 448, 'Feltrinelli', '9788806225682');

SELECT * FROM Libro;
