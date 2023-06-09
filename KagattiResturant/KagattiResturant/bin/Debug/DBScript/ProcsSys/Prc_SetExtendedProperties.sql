if  exists (select * from sysobjects where name='Prc_SetExtendedProperties')
	drop PROCEDURE Prc_SetExtendedProperties

Go

create   proc [dbo].[Prc_SetExtendedProperties]
	@Name nvarchar(250),
	@Value nvarchar(250)
as
	select value from sys.extended_properties where name =@Name
	if @@ROWCOUNT = 0
		EXEC sys.sp_addextendedproperty @name =@Name , @value =@Value
	else	
		EXEC sys.sp_updateextendedproperty @name =@Name ,@value =@Value
GO