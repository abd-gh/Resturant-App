if  exists (select * from sysobjects where name='Prc_RestInvoices_Del')
	drop PROCEDURE Prc_RestInvoices_Del

Go
Create proc [dbo].[Prc_RestInvoices_Del]
	@GUID uniqueidentifier
as

	delete RestInvoices where GUID=@GUID
	
GO

