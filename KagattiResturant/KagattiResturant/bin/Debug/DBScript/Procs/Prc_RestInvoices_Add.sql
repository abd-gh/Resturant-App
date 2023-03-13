if  exists (select * from sysobjects where name='Prc_RestInvoices_Add')
	drop PROCEDURE Prc_RestInvoices_Add

Go
Create proc [dbo].[Prc_RestInvoices_Add]
		@GUID	uniqueidentifier,	
		@Title	nvarchar(250),
		@Price float,
		@Notes nvarchar(250),
		@Date smalldatetime,
		@Users uniqueidentifier
		

as
	Declare @number     int
	
	Set @number=(select isNull(MAX(isnull(number,0))+1,1) from RestInvoices )

	insert into [dbo].[RestInvoices](GUID, Number, Title,Price,Notes,Users,Date)
			values(@GUID,@number,@Title,@Price,@Notes,@Users,@Date)


GO


