if  exists (select * from sysobjects where name='DeleteGSecurityByUser')
	drop PROCEDURE DeleteGSecurityByUser

Go
Create proc [dbo].[DeleteGSecurityByUser]
	@UserGUID uniqueidentifier
as

	delete GSecurity where UserGUID=@UserGUID
	
GO

