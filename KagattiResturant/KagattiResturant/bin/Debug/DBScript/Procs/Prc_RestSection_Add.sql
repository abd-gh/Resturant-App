if  exists (select * from sysobjects where name='Prc_RestSection_Add')
	drop PROCEDURE Prc_RestSection_Add

Go
Create proc [dbo].[Prc_RestSection_Add]
		@GUID	uniqueidentifier,	
		@Name	nvarchar(250),
		@Printer	nvarchar(250),
		@IsProduct bit
		

as
	Declare @number     int
	
	Set @number=(select isNull(MAX(isnull(number,0))+1,1) from RestSection )

	insert into [dbo].[RestSection](GUID, Number, Name,Printer,IsProduct)
			values(@GUID,@number,@Name,@Printer,@IsProduct)


GO


