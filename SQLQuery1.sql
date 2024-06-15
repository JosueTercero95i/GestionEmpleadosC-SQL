USE EMPLEADOSRESP;
GO

IF OBJECT_ID('Cargos', 'U') IS NOT NULL
    DROP TABLE Cargos;
GO

CREATE TABLE Cargos (
    id_cargo INT PRIMARY KEY IDENTITY(1,1),
    nombre_cargo VARCHAR(100) NOT NULL
);
GO

INSERT INTO Cargos (nombre_cargo)
VALUES
('Ingeniero de Software'),
('Programador Backend'),
('Programador Frontend'),
('Diseñador UX/UI'),
('Product Manager'),
('Ingeniero DevOps'),
('QA Tester'),
('Analista de Datos'),
('Gerente de Proyecto'),
('Director de Tecnología');
GO
