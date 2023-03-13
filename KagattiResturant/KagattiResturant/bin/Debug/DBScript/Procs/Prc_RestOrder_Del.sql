if  exists (select * from sysobjects where name='Prc_RestOrder_Del')
	drop PROCEDURE Prc_RestOrder_Del

Go
Create proc [dbo].[Prc_RestOrder_Del]
	@GUID uniqueidentifier
as

	delete RestOrder where GUID=@GUID
	
GO

