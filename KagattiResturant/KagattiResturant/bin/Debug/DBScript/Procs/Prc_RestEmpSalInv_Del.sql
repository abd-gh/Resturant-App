if  exists (select * from sysobjects where name='Prc_RestEmpSalInv_Del')
	drop PROCEDURE Prc_RestEmpSalInv_Del

Go
Create proc [dbo].[Prc_RestEmpSalInv_Del]
	@GUID uniqueidentifier
as

	delete RestEmpSalInv where GUID=@GUID
	
GO

