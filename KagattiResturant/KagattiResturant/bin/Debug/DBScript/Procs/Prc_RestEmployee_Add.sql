if  exists (select * from sysobjects where name='Prc_RestEmployee_Add')
	drop PROCEDURE Prc_RestEmployee_Add

Go
Create proc [dbo].[Prc_RestEmployee_Add]
		@GUID	uniqueidentifier,	
		@Name	nvarchar(250),
		@Phone nvarchar(250),
		@Salary float,
		@Notes nvarchar(250)
		

as
	Declare @number     int
	
	Set @number=(select isNull(MAX(isnull(number,0))+1,1) from RestEmployee )

	insert into [dbo].[RestEmployee](GUID, Number, Name,Phone,Salary,Notes)
			values(@GUID,@number,@Name,@Phone,@Salary,@Notes)


GO


