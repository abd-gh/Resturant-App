IF EXISTS( SELECT name FROM  sysobjects
	WHERE  name = 'prcAddFld' AND type = 'P')
    DROP PROCEDURE prcAddFld

Go

CREATE PROC prcAddFld
	@TableName	VARCHAR(50),
	@FldName	VARCHAR(50),
	@DefValue	VARCHAR(50)
AS

DECLARE @SQL VARCHAR(2000)

SET @SQl = '
	IF NOT EXISTS (
		SELECT co.Name AS ColName, Ob.Name AS ObName 
		FROM SysColumns AS Co INNER JOIN SysObjects AS Ob ON ob.Id = co.id 
		WHERE ob.xType = ''U'' 
		AND Ob.Name = ''' + @TableName + ''' AND Co.Name = ''' + @FldName + ''')
	BEGIN
		ALTER TABLE ' + @TableName+ ' ADD ' + @FldName + ' ' + @DefValue + '
	END'
EXEC (@SQL)
GO
-- Exec prcAddFld 'Parts' , 'Code33', 'VarChar(100) COLLATE ARABIC_CI_AI DEFAULT ('''') ' 
