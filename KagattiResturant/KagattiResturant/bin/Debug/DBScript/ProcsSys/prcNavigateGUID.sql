if  exists (select * from sysobjects where name='prcNavigateGUID')
	drop PROCEDURE prcNavigateGUID

Go

Create  PROCEDURE [dbo].[prcNavigateGUID]
	@tbl AS [NVARCHAR](128), 
	@dir AS [INT], -- 0: First, 1: Next, 2: Prev, 3: End, 4: Next10, 5: Prev10
	@g AS [UNIQUEIDENTIFIER], 
	@FldNum AS [NVARCHAR](128) = 'Number',
	@bFirstAndLastOnly AS [BIT] = 0	,
	@CurFldNumber AS [INT]
AS 
	SET NOCOUNT ON 
	DECLARE @str AS [NVARCHAR](max)
	DECLARE @CurFldNum AS [NVARCHAR](128)
	set  @CurFldNum = CONVERT(varchar(128), @CurFldNumber) 
	CREATE TABLE [#RESULT]( [FirstGUID] [UNIQUEIDENTIFIER], [GUID] [UNIQUEIDENTIFIER], [LastGUID] [UNIQUEIDENTIFIER])
	SET @str = '
		INSERT INTO [#RESULT]( [FirstGUID]) SELECT TOP 1 [GUID] FROM ' + @tbl + ' ORDER BY [' + @FldNum + '], [GUID]
		UPDATE [#RESULT] SET [LastGUID] = ( SELECT TOP 1 [GUID] FROM ' + @tbl+ ' ORDER BY [' + @FldNum + '] DESC, [GUID] DESC) '
	
	IF @bFirstAndLastOnly = 0
	BEGIN 
		IF @dir = 0 -- First 
			SET @str = @str + '	UPDATE [#RESULT] SET [GUID] = [FirstGUID] '
		IF @dir = 3 -- Last 
			SET @str = @str + '	UPDATE [#RESULT] SET [GUID] = [LastGUID] '
		DECLARE @CurGUID AS [NVARCHAR](50) 
		SET @CurGUID = '''' + CAST( @g AS [NVARCHAR](40)) + '''' 
		
		IF ((@dir = 1 /*Next*/) OR  (@dir = 2 /*Prev*/))
		BEGIN 
			SET @str = @str + ' 
				DECLARE @CurFld AS [INT]  
				SET @CurFld = ' + @CurFldNum + '
				UPDATE [#RESULT] 
				SET [GUID] = ( 
					SELECT 
						TOP 1 [GUID] 
					FROM 
						' + @tbl + ' 
					WHERE 
						(([' + @FldNum + '] = @CurFld) AND ([GUID] ' + (CASE @dir WHEN 1 /*Next*/ THEN '>' ELSE /*Prev*/ '<' END) + @CurGUID + '))
						OR 
						([' + @FldNum + '] ' + (CASE @dir WHEN 1 /*Next*/ THEN '>' ELSE /*Prev*/ '<' END) + ' @CurFld)
					ORDER BY [' + @FldNum + '] ' + (CASE @dir WHEN 1 /*Next*/ THEN '' ELSE /*Prev*/ 'DESC' END) + ', [GUID] ' + (CASE @dir WHEN 1 /*Next*/ THEN '' ELSE /*Prev*/ 'DESC' END) + ') '
		END 
		IF ((@dir = 4 /*Next10*/) OR  (@dir = 5 /*Prev10*/))
		BEGIN 
			SET @str = @str + ' 
				DECLARE @CurFld AS [INT]  
				SET @CurFld = ' + @CurFldNum + '
				UPDATE [#RESULT] 
				SET [GUID] = ISNULL ( 
					( SELECT 
						TOP 1 [GUID]  ' + '
					FROM 
						' + @tbl + ' 
					WHERE 
						([' + @FldNum + '] ' + (CASE @dir WHEN 4 /*Next10*/ THEN '>' ELSE /*Prev10*/ '<' END) + '= @CurFld ' + (CASE @dir WHEN 4 /*Next10*/ THEN '+' ELSE /*Prev10*/ '-' END) + ' 10 )
					ORDER BY [' + @FldNum + '] ' + (CASE @dir WHEN 4 /*Next10*/ THEN '' ELSE /*Prev10*/ 'DESC' END) + ', [GUID] ' + (CASE @dir WHEN 4 /*Next10*/ THEN '' ELSE /*Prev10*/ 'DESC' END) + '), '
					+ (CASE @dir WHEN 4 THEN '[LastGUID]' ELSE '[FirstGUID]' END) + ') '
		
		END 
	END 
	EXECUTE (@str) 
	IF ((@bFirstAndLastOnly = 0) AND EXISTS (SELECT * FROM [#RESULT] WHERE ISNULL( [GUID], 0x0) = 0x0))
	BEGIN 
		IF ((@dir = 1)/*Next*/ OR (@dir = 4)/*Next10*/ ) 
			UPDATE [#RESULT] SET [GUID] = [LastGUID]
		IF ((@dir = 2)/*Prev*/ OR (@dir = 5)/*Prev10*/) 
			UPDATE [#RESULT] SET [GUID] = [FirstGUID]
	END 
	
	SELECT * FROM [#RESULT]
