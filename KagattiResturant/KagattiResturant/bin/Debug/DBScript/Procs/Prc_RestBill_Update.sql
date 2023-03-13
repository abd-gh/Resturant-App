if  exists (select * from sysobjects where name='Prc_RestBill_Update')
	drop PROCEDURE Prc_RestBill_Update

Go
Create proc [dbo].[Prc_RestBill_Update]
		@GUID	uniqueidentifier,		
		@Date smalldatetime,
		@Num int,
		@Total_Price float,		
		@Users	uniqueidentifier,
		@Type bit,
		@Checks	bit,
		@Notes nvarchar(100)
		

as
	update [dbo].[RestBill]
	set 
		
		Date=@Date,
		Num=@Num,
		Total_Price=@Total_Price,
		Users=@Users,
		Type=@Type,
		Checks=@Checks,
		Notes=@Notes
	
	where GUID=@GUID

