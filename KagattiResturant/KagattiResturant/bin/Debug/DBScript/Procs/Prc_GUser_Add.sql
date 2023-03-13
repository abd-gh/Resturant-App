if  exists (select * from sysobjects where name='Prc_GUser_Add')
	drop PROCEDURE Prc_GUser_Add

Go
Create proc [dbo].[Prc_GUser_Add]
	@GUID       [uniqueidentifier] ,
	@LoginName	[nvarchar](250),
	@Password	[nvarchar](250),
	@isAdmin	[bit],
	@ParentUser [uniqueidentifier]

as
	Declare @number     int
	
	Set @number=(select isNull(MAX(isnull(number,0))+1,1) from GUsers )

	insert into [dbo].[GUsers](Number,guid,LoginName,Password,Isadmin,ParentUser)
			values(@number,@GUID,@LoginName,@Password,@isadmin,@ParentUser)


