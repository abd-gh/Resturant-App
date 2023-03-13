if  exists (select * from sysobjects where name='Prc_RestInvoices_Update')
	drop PROCEDURE Prc_RestInvoices_Update

Go
Create proc [dbo].[Prc_RestInvoices_Update]
		@GUID	uniqueidentifier,	
		@Title	nvarchar(250),
		@Price float,
		@Notes nvarchar(250),
		@Date smalldatetime,
		@Users uniqueidentifier
		

as
	update [dbo].[RestInvoices]
	set 
			
		Date=@Date,
		Title=@Title,
		Price=@Price,
		Notes=@Notes,
		Users=@Users
		
	where GUID=@GUID

