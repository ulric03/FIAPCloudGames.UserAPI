USE master;
GO

-- Verifica se o banco de dados j� existe, se n�o existir, cria
IF NOT EXISTS(SELECT name FROM sys.databases WHERE name = 'FIAPCloudGames')
BEGIN
    PRINT 'Criando banco de dados FIAPCloudGames...';
    CREATE DATABASE [FIAPCloudGames];
    PRINT 'Banco de dados FIAPCloudGames criado com sucesso!';
END
ELSE
BEGIN
    PRINT 'Banco de dados FIAPCloudGames j� existe.';
END
GO