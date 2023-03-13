if  exists (select * from sysobjects where name='Prc_GUser_Del')
	drop PROCEDURE Prc_GUser_Del

Go
Create proc [dbo].[Prc_GUser_Del]
	@GUID uniqueidentifier
as

	delete GUsers where GUID=@GUID
	
GO

