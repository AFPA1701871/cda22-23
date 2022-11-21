CREATE DATABASE IF NOT EXISTS test;
USE test;
-- DROP TABLE IF EXISTS Utilisateurs;
CREATE TABLE Utilisateurs(
   idUtilisateur INT AUTO_INCREMENT NOT NULL PRIMARY KEY,
   nomUtilisateur VARCHAR(50)  NOT NULL,
   dateDebut DATE ,
   dateFin DATE ,
   email VARCHAR(50) NOT NULL UNIQUE
);
ALTER TABLE Utilisateurs ADD COLUMN prenom VARCHAR(50) AFTER nomUtilisateur;