if  exists (select * from sysobjects where name='AddGSecurity')
	drop PROCEDURE AddGSecurity

Go
Create proc [dbo].[AddGSecurity]
	@GUID				[uniqueidentifier],
	@UserGUID			[uniqueidentifier],
	@SecurityType		[nvarchar](50),
	@Name				[nvarchar](250),
	@Command			[nvarchar](250),
	@Permission			Bit

as
	insert into GSecurity(GUID,UserGUID,SecurityType,Name,Command,Permission)
						values(@GUID,@UserGUID,@SecurityType,@Name,@Command,@Permission)
   	



