if  exists (select * from sysobjects where name='Prc_RestBill_Del')
	drop PROCEDURE Prc_RestBill_Del

Go
Create proc [dbo].[Prc_RestBill_Del]
	@GUID uniqueidentifier
as

	delete RestBill where GUID=@GUID
	
GO

