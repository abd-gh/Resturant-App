if  exists (select * from sysobjects where name='Prc_RestEmployee_Del')
	drop PROCEDURE Prc_RestEmployee_Del

Go
Create proc [dbo].[Prc_RestEmployee_Del]
	@GUID uniqueidentifier
as

	delete RestEmployee where GUID=@GUID
	
GO

