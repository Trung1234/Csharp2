-- Get a list of databases
SELECT name FROM sys.databases
GO

-- Create a new database called 'DatabaseName'
-- Connect to the 'master' database to run this snippet
USE master
GO
-- Create the new database if it does not exist already
IF NOT EXISTS (
    SELECT name
        FROM sys.databases
        WHERE name = N'Test'
)
CREATE DATABASE Test
GO

-- Create a new table called 'TableName' in schema 'SchemaName'
-- Drop the table if it already exists
IF OBJECT_ID('SchemaName.TableName', 'U') IS NOT NULL
DROP TABLE SchemaName.TableName
GO
-- Create the table in the specified schema



INSERT TRUONGHOC.dbo.HOCSINH
VALUES  ( 'CS008' , -- MAHS - char(5)
          N'TRANG' , -- TEN - nvarchar(30)
          1 , -- NAM - bit
          '19941230', -- NGAYSINH - datetime
          'HANOI' , -- DIACHI - varchar(20)
          8.6  -- DIEMTB - float
        )

SELECT * FROM TRUONGHOC.dbo.HOCSINH ORDER BY DIEMTB DESC