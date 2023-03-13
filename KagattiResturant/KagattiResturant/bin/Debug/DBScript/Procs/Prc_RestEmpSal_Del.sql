if  exists (select * from sysobjects where name='Prc_RestEmpSal_Del')
	drop PROCEDURE Prc_RestEmpSal_Del

Go
Create proc [dbo].[Prc_RestEmpSal_Del]
	@GUID uniqueidentifier
as

	delete RestEmpSal where GUID=@GUID
	
GO

