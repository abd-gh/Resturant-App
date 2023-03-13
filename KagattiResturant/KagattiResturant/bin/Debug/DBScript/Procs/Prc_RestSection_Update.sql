if  exists (select * from sysobjects where name='Prc_RestSection_Update')
	drop PROCEDURE Prc_RestSection_Update

Go
Create proc [dbo].[Prc_RestSection_Update]
		@GUID	uniqueidentifier,		
		@Name	nvarchar(250),
		@Printer	nvarchar(250),
		@IsProduct bit

		

as
	update [dbo].[RestSection]
	set 
		Printer=@Printer,
		Name=@Name,
		IsProduct=@IsProduct
		
	where GUID=@GUID

