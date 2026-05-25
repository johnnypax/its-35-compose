CREATE DATABASE ict_35_blog;
USE ict_35_blog;

CREATE TABLE Post(
	Id INTEGER PRIMARY KEY IDENTITY(1,1),
	Titolo VARCHAR(255) NOT NULL,
	Testo VARCHAR(MAX)
);

CREATE TABLE Commento(
	Id INTEGER PRIMARY KEY IDENTITY(1,1),
	Utente VARCHAR(255) NOT NULL,
	Testo VARCHAR(MAX),
	postRif INTEGER NOT NULL,
	FOREIGN KEY (postRif) REFERENCES Post(Id)
);

INSERT INTO Post (Titolo, Testo)
VALUES
('Primo post', 'Questo è il contenuto del primo post.'),
('Secondo post', 'Questo è il contenuto del secondo post.');

INSERT INTO Commento (postRif, Utente, Testo)
VALUES
(1, 'Mario', 'Ottimo articolo!'),
(1, 'Luca', 'Molto interessante.'),
(2, 'Anna', 'Grazie per la condivisione.');