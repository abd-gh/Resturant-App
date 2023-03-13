if  exists (select * from sysobjects where name='Prc_GUser_Update')
	drop PROCEDURE Prc_GUser_Update

Go
Create proc [dbo].[Prc_GUser_Update]
	@GUID       [uniqueidentifier] ,
	@LoginName		[nvarchar](250),
	@Isadmin		[bit],
	@ParentUser		[uniqueidentifier],
	@password		[nvarchar](250)
as
	update [dbo].[GUsers]
	set LoginName=@LoginName,
		Isadmin=@Isadmin,
		password=@password,
		ParentUser=@ParentUser
	where GUID=@GUID

