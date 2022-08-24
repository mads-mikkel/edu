USE Master
GO
DROP DATABASE IF EXISTS RpgDB;
CREATE DATABASE RpgDB;
USE RpgDB;
GO

CREATE TABLE Roles (
	Id INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	Name NVARCHAR(255) NOT NULL DEFAULT 'ingen'
);
CREATE TABLE Characters (
	Id INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	Name NVARCHAR(255) NOT NULL DEFAULT 'ingen'
);
CREATE TABLE CharacterRoles (
	CharacterId INT NOT NULL,
	RoleId INT NOT NULL
);
GO
ALTER TABLE CharacterRoles 
	ADD CONSTRAINT FK_CharacterRoles_Character
	FOREIGN KEY (CharacterId) REFERENCES Characters(Id);
ALTER TABLE CharacterRoles 
	ADD CONSTRAINT FK_CharacterRoles_Roles
	FOREIGN KEY (RoleId) REFERENCES Roles(Id);
GO

INSERT INTO Characters (Name)
	VALUES ('Mads'), ('Dea'), ('Henrik'), ('Jesper'), ('Preben'), ('Dima'), ('Ole');
INSERT INTO Roles (Name)
	VALUES ('Lærer'), ('SPV'), ('PJV'), ('Uddannelseschef');
INSERT INTO CharacterRoles 
	VALUES (1,1), (5,1), (6,1), (2,1), (2,2), (3,3), (4,2), (7,4);

--SELECT * FROM Characters; SELECT * FROM Roles; SELECT * FROM CharacterRoles;
SELECT c.Name as Navn, r.Name as Rolle FROM Characters c
	INNER JOIN CharacterRoles cr ON c.Id = cr.CharacterId
	INNER JOIN Roles r ON r.Id = cr.RoleId