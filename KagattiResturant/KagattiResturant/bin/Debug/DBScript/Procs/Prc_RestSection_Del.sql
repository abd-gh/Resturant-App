if  exists (select * from sysobjects where name='Prc_RestSection_Del')
	drop PROCEDURE Prc_RestSection_Del

Go
Create proc [dbo].[Prc_RestSection_Del]
	@GUID uniqueidentifier
as

	delete RestSection where GUID=@GUID
	
GO

