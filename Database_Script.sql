--*********************************************************************************************************
-- Crear Base de Datos
--*********************************************************************************************************
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'DBCursos')
BEGIN
	CREATE DATABASE DBCursos;	
END

GO

USE DBCursos

--*********************************************************************************************************
-- Eliminar Tablas
--*********************************************************************************************************
IF OBJECT_ID('CursoEstudiante', 'U') IS NOT NULL
	DROP TABLE CursoEstudiante;
	
IF OBJECT_ID('Curso', 'U') IS NOT NULL
	DROP TABLE Curso;
	
IF OBJECT_ID('Estudiante', 'U') IS NOT NULL
	DROP TABLE Estudiante;
	
IF OBJECT_ID('Ciudad', 'U') IS NOT NULL
	DROP TABLE Ciudad;

IF OBJECT_ID('Departamento', 'U') IS NOT NULL
	DROP TABLE Departamento;

-- //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
-- Tabla de Departamento
-- //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
CREATE TABLE Departamento (
  Id INT IDENTITY(1,1) NOT NULL,
  NombreDepartamento NVARCHAR(100) NOT NULL
);

-- Llave primaria
ALTER TABLE Departamento ADD CONSTRAINT pk_Departamento PRIMARY KEY (Id);

INSERT INTO Departamento (NombreDepartamento) VALUES ('Antioquia');
INSERT INTO Departamento (NombreDepartamento) VALUES ('Valle del Cauca');
INSERT INTO Departamento (NombreDepartamento) VALUES ('Cundinamarca');

--//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
-- Tabla de Ciudad
-- //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
CREATE TABLE Ciudad (
  Id INT IDENTITY(1,1) NOT NULL,
  NombreCiudad NVARCHAR(1000) NOT NULL,
  IdDepartamento INT NOT NULL
);

-- Llave primaria
ALTER TABLE Ciudad ADD CONSTRAINT pk_Ciudad PRIMARY KEY (Id);

-- Llave foranea de la categoria
ALTER TABLE Ciudad ADD CONSTRAINT fk_Ciudad_IdDepartamento FOREIGN KEY (IdDepartamento) REFERENCES Departamento(Id);

INSERT INTO Ciudad (NombreCiudad, IdDepartamento) VALUES ('Medellín', 1);
INSERT INTO Ciudad (NombreCiudad, IdDepartamento) VALUES ('Envigado', 1);
INSERT INTO Ciudad (NombreCiudad, IdDepartamento) VALUES ('Itagui', 1);
INSERT INTO Ciudad (NombreCiudad, IdDepartamento) VALUES ('Bello', 1);
INSERT INTO Ciudad (NombreCiudad, IdDepartamento) VALUES ('Cali', 2);
INSERT INTO Ciudad (NombreCiudad, IdDepartamento) VALUES ('Tuluá', 2);
INSERT INTO Ciudad (NombreCiudad, IdDepartamento) VALUES ('Bogotá', 3);

--//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
-- Tabla de Estudiante
-- //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
CREATE TABLE Estudiante (
  Cedula INT NOT NULL,
  Nombre NVARCHAR(250) NOT NULL,
  Apellidos NVARCHAR(250) NULL,
  Correo NVARCHAR(100) NULL,
  Genero BIT NOT NULL DEFAULT 0,
  CiudadNacimiento INT NOT NULL
);

-- Llave primaria
ALTER TABLE Estudiante ADD CONSTRAINT pk_Estudiante PRIMARY KEY (Cedula);

-- Llave foranea de la categoria
ALTER TABLE Estudiante ADD CONSTRAINT fk_Estudiante_CiudadNacimiento FOREIGN KEY (CiudadNacimiento) REFERENCES Ciudad(Id);

--//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
-- Tabla de Curso
-- //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
CREATE TABLE Curso (
  Id INT IDENTITY(1,1) NOT NULL,
  NombreCurso NVARCHAR(250) NOT NULL
);

-- Llave primaria
ALTER TABLE Curso ADD CONSTRAINT pk_Curso PRIMARY KEY (Id);

--//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
-- Tabla de CursoEstudiante
-- //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
CREATE TABLE CursoEstudiante (
  IdCurso INT NOT NULL,
  CedulaEstudiante INT NOT NULL,
  Cancelada BIT NOT NULL DEFAULT 0
);

-- Llave primaria
ALTER TABLE CursoEstudiante ADD CONSTRAINT pk_CursoEstudiante PRIMARY KEY (IdCurso, CedulaEstudiante);

-- Llave foranea del CursoEstudiante
ALTER TABLE CursoEstudiante ADD CONSTRAINT fk_CursoEstudiante_IdCurso FOREIGN KEY (IdCurso) REFERENCES Curso(Id);
ALTER TABLE CursoEstudiante ADD CONSTRAINT fk_CursoEstudiante_CedulaEstudiante FOREIGN KEY (CedulaEstudiante) REFERENCES Estudiante(Cedula);