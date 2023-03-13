if  exists (select * from sysobjects where name='Prc_RestItem_Del')
	drop PROCEDURE Prc_RestItem_Del

Go
Create proc [dbo].[Prc_RestItem_Del]
	@GUID uniqueidentifier
as

	delete RestItem where GUID=@GUID
	
GO

