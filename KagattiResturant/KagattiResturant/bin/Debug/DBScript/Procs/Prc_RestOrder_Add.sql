if  exists (select * from sysobjects where name='Prc_RestOrder_Add')
	drop PROCEDURE Prc_RestOrder_Add

Go
Create proc [dbo].[Prc_RestOrder_Add]
		@GUID	uniqueidentifier,		
		@Date smalldatetime,
		@Item_Name uniqueidentifier,
		@Single_Price float,
		@Total_Price float,
		@Tax float,
		@Count int ,
		@Guid_RestBill uniqueidentifier,
		@Users	uniqueidentifier
		
as
	Declare @number     int
	
	Set @number=(select isNull(MAX(isnull(number,0))+1,1) from RestOrder )

	insert into [dbo].[RestOrder](GUID, Number,Date ,Item_Name,Single_Price,Total_Price,Count,Users,Guid_RestBill,Tax)
			values(@GUID,@number ,@Date , @Item_Name, @Single_Price,@Total_Price,@Count,@Users,@Guid_RestBill,@Tax)


GO


