/*
Creare un sistema di gestione piatti di un ristorante.
Ogni piatto è caratterizzato da:
- Nome
- Descrizione
- Prezzo
- Se è vegan o no
- Se contiene glutine
- Categoria ("Primo", "Secondo", "Contorno)
 
Inserisci almeno 6 piatti e scrivere una query che:
- Restituisce tutti i piatti vegani
- Restituisce sia i piatti vegani che quelli senza glutine
- Restituisce i piatti vegani che costano meno di 20 euro
- Restituisce tutti i piatti vegani o senza glutine che costano meno di 15 Euro
- Restituisce tutti i piatti della categoria "Primi"
*/

CREATE DATABASE a_lez06_task_piatti;
USE a_lez06_task_piatti;

CREATE TABLE Piatto(
	piattoID INT PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(250) NOT NULL,
	descrizione TEXT,
	prezzo DECIMAL(5,2) CHECK (prezzo >= 0) DEFAULT 0,
	is_vegan BIT DEFAULT 0,
	has_glutine BIT DEFAULT 0,
	categoria VARCHAR(20) CHECK (categoria IN ('Primo', 'Secondo', 'Contorno'))
);

INSERT INTO Piatto (nome, descrizione, prezzo, is_vegan, has_glutine, categoria) VALUES 
('Spaghetti alla Carbonara', 'Pasta con uova, pecorino e guanciale', 12.50, 0, 1, 'Primo'),
('Risotto ai Funghi', 'Riso cremoso con funghi porcini freschi', 10.00, 1, 0, 'Primo'),
('Bistecca alla Fiorentina', 'Taglio di carne pregiata alla griglia', 25.00, 0, 0, 'Secondo'),
('Zucchine Grigliate', 'Zucchine grigliate condite con olio e sale', 5.00, 1, 0, 'Contorno'),
('Lasagne al Forno', 'Lasagne con ragù di carne e besciamella', 13.00, 0, 1, 'Primo'),
('Insalata Mista', 'Insalata fresca con pomodori, carote e cetrioli', 6.50, 1, 0, 'Contorno');

-- Restituisce tutti i piatti vegani
SELECT * FROM Piatto WHERE is_vegan = 1;

-- Restituisce sia i piatti vegani che quelli senza glutine
SELECT * FROM Piatto WHERE is_vegan = 1 OR has_glutine = 0;

-- Restituisce i piatti vegani che costano meno di 20 euro
SELECT * FROM Piatto WHERE is_vegan = 1 AND prezzo <= 20;

-- Restituisce tutti i piatti vegani o senza glutine che costano meno di 15 Euro
SELECT * FROM Piatto WHERE (is_vegan = 1 OR has_glutine = 0) AND prezzo <= 15;

-- Restituisce tutti i piatti della categoria "Primi"
SELECT * FROM Piatto WHERE categoria = 'Primo';


