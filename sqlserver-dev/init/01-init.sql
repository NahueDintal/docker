-- 01-init.sql
-- Script genérico de inicialización para SQL Server en Docker
-- No depende de una base de datos específica

USE master;
GO

-- Creamos una base de datos "TestDB" vacía (opcional)
SELECT name FROM sys.databases
GO

-- Mensaje de confirmación (aparece en los logs)
PRINT '✅ SQL Server inicializado correctamente';
GO
