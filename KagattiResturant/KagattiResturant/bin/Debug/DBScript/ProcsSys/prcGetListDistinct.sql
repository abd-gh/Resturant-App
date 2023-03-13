IF EXISTS( SELECT name FROM  sysobjects
	WHERE  name = 'prcGetListDistinct' AND type = 'P')
    DROP PROCEDURE prcGetListDistinct

Go

CREATE PROC prcGetListDistinct
	@TableName	VARCHAR(50),
	@FldName	VARCHAR(50)
AS

DECLARE @SQL VARCHAR(2000)

SET @SQl = '
		SELECT Distinct '+@FldName+' 
		FROM '+@TableName 

print @SQL
EXEC (@SQL)
GO
-- Exec prcGetListDistinct 'POSMats' , 'Unit1'

