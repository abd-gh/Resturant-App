if  exists (select * from sysobjects where name='Prc_RestOrder_Update')
	drop PROCEDURE Prc_RestOrder_Update

Go
Create proc [dbo].[Prc_RestOrder_Update]
		@GUID	uniqueidentifier,		
		@Date smalldatetime,
		@Item_Name uniqueidentifier,
		@Single_Price float,
		@Total_Price float,
		@Count int ,
		@Tax float,
		@Guid_RestBill uniqueidentifier,
		@Users	uniqueidentifier
		

as
	update [dbo].[RestOrder]
	set 
		Guid_RestBill=@Guid_RestBill,
		Date=@Date,
		@Tax=Tax,
		Item_Name=@Item_Name,
		Single_Price=@Single_Price,
		Total_Price=@Total_Price,
		Count=@Count,
		Users=@Users
	
	where GUID=@GUID

