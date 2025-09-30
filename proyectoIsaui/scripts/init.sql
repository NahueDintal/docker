IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = 'MiBaseDatos')
BEGIN
    CREATE DATABASE MiBaseDatos;
END
GO

USE MiBaseDatos;
GO

IF NOT EXISTS(SELECT * FROM sys.tables WHERE name = 'Clientes')
BEGIN
    CREATE TABLE Clientes (
        Id INT IDENTITY(1,1) PRIMARY KEY,
        Nombre NVARCHAR(100) NOT NULL,
        Email NVARCHAR(100),
        FechaCreacion DATETIME2 DEFAULT GETDATE()
    );

    INSERT INTO Clientes (Nombre, Email) VALUES 
    ('Juan Pérez', 'juan@email.com'),
    ('María García', 'maria@email.com');
END
GO
