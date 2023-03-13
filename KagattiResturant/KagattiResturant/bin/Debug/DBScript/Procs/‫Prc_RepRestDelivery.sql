if  exists (select * from sysobjects where name='RepRestDelivery')
	drop PROCEDURE RepRestDelivery
GO
CREATE PROCEDURE [dbo].[RepRestDelivery]
	@StartDate	date,
	@EndDate	date,
	@UserId	uniqueidentifier
as
BEGIN
 select  
		 Rp.Num Number  ,Rp.Total_Price Price, cast(Rp.Date as smalldatetime) Date, Ru.LoginName Name                                   
	 	into #TempResut
   from RestBill as Rp
	 	inner join GUsers Ru on Ru.GUID=Rp.Users
	 		 	
    where( @UserId=Rp.Users or @UserId = 0x0)AND
	( Rp.Checks=1)and(Rp.Type=0)and
	-- cast(convert(datetime,hp.DateIn ) as date) between Cast(convert(datetime,@StartDate )as date) and cast(convert(datetime,@EndDate)as date)
	 	
 -- CONVERT(NVARCHAR(255), CONVERT(SMALLDATETIME, Rp.Date, 101)) >= cast(convert(datetime,@StartDate )as date)and 
  --CONVERT(NVARCHAR(255), CONVERT(SMALLDATETIME, Rp.Date, 101)) <= cast(convert(datetime,@EndDate ) as date) 

   cast(convert(datetime,Rp.Date )as date) >= cast(convert(datetime,@StartDate )as date)and 
   cast(convert(datetime,Rp.Date ) as date) <= cast(convert(datetime,@EndDate ) as date)

  
  select * from #TempResut order by Date
  
  select sum(Price) as TotalCredit from #TempResut
End

--exec RepHotelAgent '08-26-2017','08-26-2019','E5F9B576-84CB-4B2E-8C96-03E780EC2C44'
--exec RepRestDelivery '08-26-2017','08-26-2019','00000000-0000-0000-0000-000000000000'

--exec RepRestAgent '08/26/2017','08/26/2019','7B8DD704-B46A-489A-98D2-862B386B262B'
go