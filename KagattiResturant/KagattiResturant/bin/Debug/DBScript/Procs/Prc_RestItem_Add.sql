if  exists (select * from sysobjects where name='Prc_RestItem_Add')
	drop PROCEDURE Prc_RestItem_Add

Go
Create proc [dbo].[Prc_RestItem_Add]
		@GUID	uniqueidentifier,
		@Price	float,
		@Name	nvarchar(250),		
		@Section_Name	uniqueidentifier,
		@Quantity int 

as
	Declare @number     int
	
	Set @number=(select isNull(MAX(isnull(number,0))+1,1) from RestItem )

	insert into [dbo].[RestItem](GUID, Number, Price, Name, Section_Name,Quantity)
			values(@GUID,@number,@Price,@Name,@Section_Name,@Quantity)


GO


