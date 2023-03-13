IF EXISTS( SELECT name FROM  sysobjects
	WHERE  name = 'Prc_SetOPtions' AND type = 'P')
    DROP PROCEDURE Prc_SetOPtions

Go

Create  proc [dbo].[Prc_SetOPtions]
	@Name nvarchar(250),
	@Value nvarchar(250),
	@UserGUID  uniqueidentifier,
	@CpmputerName nvarchar(250)
as

	IF  EXISTS(SELECT * FROM GOptions WHERE Name = @Name and UserGUID =@UserGUID  and ComputerName=@CpmputerName)
		update  GOptions
		set value=@Value
		where Name=@Name and UserGUID =@UserGUID  and ComputerName=@CpmputerName
	else
		insert into GOptions(GUID, Name, Value, UserGUID, ComputerName)
		values(NEWID(),@Name,@Value,@UserGUID,@CpmputerName)

GO
