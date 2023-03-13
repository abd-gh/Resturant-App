if  exists (select * from sysobjects where name='Prc_RestItem_Update')
	drop PROCEDURE Prc_RestItem_Update

Go
Create proc [dbo].[Prc_RestItem_Update]
		@GUID	uniqueidentifier,		
		@Name	nvarchar(250),
		@Price float,
		@Section_Name	uniqueidentifier,
		@Quantity int

as
	update [dbo].[RestItem]
	set 
		Price=@Price,
		Name=@Name,	
		Section_Name=@Section_Name,
		Quantity=@Quantity
		
	where GUID=@GUID

