if  exists (select * from sysobjects where name='RepRestItem')
	drop PROCEDURE RepRestItem
GO
CREATE PROCEDURE [dbo].[RepRestItem]
	@StartDate	date,
	@EndDate	date,
	@ItemId	uniqueidentifier
as
BEGIN
 select  
		O.Count Counts,O.Single_Price single_price,o.Total_Price Total,I.Name Name, cast(B.Date as smalldatetime) Date                                   
	 	into #TempResut
   from RestOrder as O
	 	inner join RestItem I on I.GUID=O.Item_Name
		inner join RestBill B on B.GUID=O.Guid_RestBill
	 		 	
    where( @ItemId=I.GUID or @ItemId = 0x0)AND
	-- cast(convert(datetime,hp.DateIn ) as date) between Cast(convert(datetime,@StartDate )as date) and cast(convert(datetime,@EndDate)as date)
	 	
 -- CONVERT(NVARCHAR(255), CONVERT(SMALLDATETIME, Rp.Date, 101)) >= cast(convert(datetime,@StartDate )as date)and 
  --CONVERT(NVARCHAR(255), CONVERT(SMALLDATETIME, Rp.Date, 101)) <= cast(convert(datetime,@EndDate ) as date) 

   cast(convert(datetime,B.Date )as date) >= cast(convert(datetime,@StartDate )as date)and 
   cast(convert(datetime,B.Date ) as date) <= cast(convert(datetime,@EndDate ) as date)and (B.Checks=1)

  
  select * from #TempResut order by Date
  
  select sum(Total) as Totals , sum(Counts) as Counts from #TempResut
End

--exec RepHotelAgent '08-26-2017','08-26-2019','E5F9B576-84CB-4B2E-8C96-03E780EC2C44' and (b.Checks=1)
--exec RepHotelAgent '08-26-2017','08-26-2019','00000000-0000-0000-0000-000000000000'

--exec RepRestItem '08/26/2017','08/26/2019','00000000-0000-0000-0000-000000000000'
go