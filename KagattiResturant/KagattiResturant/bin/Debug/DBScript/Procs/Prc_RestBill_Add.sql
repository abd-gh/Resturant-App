if  exists (select * from sysobjects where name='Prc_RestBill_Add')
	drop PROCEDURE Prc_RestBill_Add

Go
Create proc [dbo].[Prc_RestBill_Add]
		@GUID	uniqueidentifier,		
		@Date smalldatetime,
		@Num int,	
		@Total_Price float,			
		@Users	uniqueidentifier,
		@Type bit,
		@Checks	bit,
		@Notes nvarchar(100)
		
as
	Declare @number     int
	
	Set @number=(select isNull(MAX(isnull(number,0))+1,1) from RestBill )

	insert into [dbo].[RestBill](GUID, Number,Date ,Total_Price,Users,Num,Type,Checks,Notes)
			values(@GUID,@number ,@Date ,@Total_Price,@Users,@Num,@Type,@Checks,@Notes)


GO


