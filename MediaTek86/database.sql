CREATE DATABASE mediatek86;

USE mediatek86;

CREATE TABLE responsable (
    login VARCHAR(64),
    pwd VARCHAR(64)
);

INSERT INTO responsable (login, pwd) VALUES ('admin', SHA2('password', 256));

CREATE TABLE service (
    idservice INT AUTO_INCREMENT PRIMARY KEY,
    nom VARCHAR(50)
);

INSERT INTO service (nom) VALUES ('administratif'), ('médiation culturelle'), ('prêt');

CREATE TABLE motif (
    idmotif INT AUTO_INCREMENT PRIMARY KEY,
    libelle VARCHAR(50)
);

INSERT INTO motif (libelle) VALUES ('vacances'), ('maladie'), ('motif familial'), ('congé parental');

CREATE TABLE personnel (
    idpersonnel INT AUTO_INCREMENT PRIMARY KEY,
    nom VARCHAR(50),
    prenom VARCHAR(50),
    tel VARCHAR(15),
    mail VARCHAR(50),
    profil VARCHAR(20)
);

INSERT INTO personnel (nom, prenom, tel, mail, profil) VALUES
('Dupont', 'Jean', '0102030405', 'jean.dupont@example.com', 'admin'),
('Martin', 'Sophie', '0102030406', 'sophie.martin@example.com', 'user'),
('Dubois', 'Marie', '0102030408', 'marie.dubois@example.com', 'admin');

CREATE TABLE absence (
    idabsence INT AUTO_INCREMENT PRIMARY KEY,
    idpersonnel INT,
    datedebut DATE,
    datefin DATE,
    motif VARCHAR(50),
    FOREIGN KEY (idpersonnel) REFERENCES personnel(idpersonnel)
);

INSERT INTO absence (idpersonnel, datedebut, datefin, motif) VALUES
(1, '2023-01-01', '2023-01-10', 'vacances'),
(2, '2023-02-01', '2023-02-15', 'maladie'),
(3, '2023-03-01', '2023-03-10', 'motif familial');
