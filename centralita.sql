CREATE DATABASE Centralita;

USE Centralita;

CREATE TABLE llamadas (
    id INT PRIMARY KEY IDENTITY(1,1),
    numero_origen VARCHAR(15),
    numero_destino VARCHAR(15),
    duracion FLOAT,
    tipo VARCHAR(20), 
    franja INT NULL,  
    precio FLOAT
);

INSERT INTO llamadas (numero_origen, numero_destino, duracion, tipo, franja, precio)
VALUES 
('8496382070', '8095555555', 5.0, 'local', NULL, 5.0 * 0.15),
('8095555555', '8496382070', 10.0, 'local', NULL, 10.0 * 0.15),
('8496382070', '8095555555', 3.5, 'local', NULL, 3.5 * 0.15),

('8496382070', '8095555555', 4.0, 'provincial', 1, 4.0 * 0.20),
('8095555555', '8496382070', 7.0, 'provincial', 2, 7.0 * 0.25),
('8496382070', '8095555555', 6.0, 'provincial', 3, 6.0 * 0.30);


SELECT * FROM llamadas;

SELECT COUNT(*) AS total_llamadas FROM llamadas;

SELECT SUM(precio) AS total_facturado FROM llamadas;