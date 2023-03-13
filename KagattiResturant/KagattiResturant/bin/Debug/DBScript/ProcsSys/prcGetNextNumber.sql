IF EXISTS( SELECT name FROM  sysobjects
	WHERE  name = 'prcGetNextNumber' AND type = 'P')
    DROP PROCEDURE prcGetNextNumber

Go

CREATE PROC prcGetNextNumber
	@TableName	VARCHAR(50),
	@FldName	VARCHAR(50),
	@Filter		varchar(250)=''
AS

DECLARE @SQL VARCHAR(2000)

SET @SQl = '
		SELECT isnull(MAX(isnull('+@FldName+',0))+1,1) as Number '++' 
		FROM '+@TableName 
if	@Filter<>''
	set @SQL=@SQL+' '+@Filter


print @SQL
EXEC (@SQL)
GO
-- Exec prcGetNextNumber 'POSBill' , 'id'

