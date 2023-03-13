if  exists (select * from sysobjects where name='Prc_RestEmployee_Update')
	drop PROCEDURE Prc_RestEmployee_Update

Go
Create proc [dbo].[Prc_RestEmployee_Update]
		@GUID	uniqueidentifier,	
		@Name	nvarchar(250),
		@Phone nvarchar(250),
		@Salary float,
		@Notes nvarchar(250)
		

as
	update [dbo].[RestEmployee]
	set 
		Phone=@Phone,
		Salary=@Salary,
		Notes=@Notes,
		Name=@Name
		
	where GUID=@GUID

