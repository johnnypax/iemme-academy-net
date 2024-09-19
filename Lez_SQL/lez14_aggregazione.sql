CREATE TABLE Impiegato(
	impiegatoID INT PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(250) NOT NULL,
	cognome VARCHAR(250) NOT NULL,
	email VARCHAR(250) NOT NULL,
	mansione VARCHAR(250) NOT NULL,
	dipartimento VARCHAR(250) NOT NULL,
	data_inizio DATE,
	salario DECIMAL(10,2)
);

INSERT INTO Impiegato (nome, cognome, email, mansione, dipartimento, data_inizio, salario) VALUES
('James', 'Smith', 'james.smith@example.com', 'Software Engineer', 'Engineering', '2019-03-01', 150000),
('Maria', 'Garcia', 'maria.garcia@example.com', 'Project Manager', 'Marketing', '2018-06-15', 150000),
('Robert', 'Johnson', 'robert.johnson@example.com', 'Database Administrator', 'IT', '2017-05-29', 120000),
('Patricia', 'Miller', 'patricia.miller@example.com', 'Product Manager', 'Sales', '2020-02-17', 60000),
('Michael', 'Davis', 'michael.davis@example.com', 'Web Developer', 'Engineering', '2021-08-23', 120000),
('Linda', 'Martinez', 'linda.martinez@example.com', 'Graphic Designer', 'Design', '2016-04-11', 150000),
('Elizabeth', 'Hernandez', 'elizabeth.hernandez@example.com', 'Sales Associate', 'Sales', '2019-07-19', 150000),
('William', 'Brown', 'william.brown@example.com', 'Systems Analyst', 'IT', '2018-09-03', 153000),
('Jennifer', 'Wilson', 'jennifer.wilson@example.com', 'Consultant', 'Customer Service', '2017-12-08', 154000),
('David', 'Anderson', 'david.anderson@example.com', 'Quality Assurance', 'Engineering', '2020-05-01', 78000),
('Susan', 'Thomas', 'susan.thomas@example.com', 'HR Specialist', 'Human Resources', '2018-03-23', 78000),
('Joseph', 'Moore', 'joseph.moore@example.com', 'Finance Analyst', 'Finance', '2019-11-30', 16000),
('Margaret', 'Taylor', 'margaret.taylor@example.com', 'Content Writer', 'Marketing', '2021-01-15', 78000),
('Charles', 'Lee', 'charles.lee@example.com', 'UX Designer', 'Design', '2017-07-09', 78000),
('Christopher', 'Harris', 'christopher.harris@example.com', 'Network Engineer', 'IT', '2018-08-21', 60000),
('Jessica', 'Clark', 'jessica.clark@example.com', 'Social Media Manager', 'Marketing', '2020-06-05', 60000),
('Daniel', 'Lewis', 'daniel.lewis@example.com', 'Business Analyst', 'Business Development', '2019-04-12', 20000),
('Sarah', 'Walker', 'sarah.walker@example.com', 'Recruiter', 'Human Resources', '2021-09-20', 60000),
('Thomas', 'Robinson', 'thomas.robinson@example.com', 'Technical Support', 'Customer Service', '2017-11-13', 64000),
('Nancy', 'Rodriguez', 'nancy.rodriguez@example.com', 'Legal Advisor', 'Legal', '2018-01-29', 61000);

-- Conta tutti gli impiegati
SELECT COUNT(*) AS contatore
	FROM Impiegato;

-- Conta tutti gli impiegati che appartengono al dipartimento Human Resources
SELECT COUNT(*) AS contatore
	FROM Impiegato
	WHERE dipartimento = 'Human Resources';

-- Conta tutti i dipendenti raggruppati per dipartimento
SELECT COUNT(*) as contatore, dipartimento
	FROM Impiegato
	GROUP BY dipartimento
	ORDER BY contatore DESC;

-- Conta tutti i dipendenti raggruppati per dipartimento e visualizza quelli che ne hanno più di 2
SELECT COUNT(*) as contatore, dipartimento
	FROM Impiegato
	GROUP BY dipartimento
	HAVING COUNT(*) > 2
	ORDER BY contatore DESC;

-- La somma di tutti i salari
SELECT SUM(salario) AS 'Somma salari'
	FROM Impiegato;

-- Somma i salari per dipartimento
SELECT mansione, SUM(salario) AS somma
	FROM Impiegato
	GROUP BY mansione
	HAVING SUM(salario) > 50000
	ORDER BY somma DESC;

-- Qual è il salario massimo
SELECT MAX(salario) FROM Impiegato;

-- Qual è il salario minimo
SELECT MIN(salario) FROM Impiegato;

-- Media dei salari
SELECT AVG(salario) FROM Impiegato;
