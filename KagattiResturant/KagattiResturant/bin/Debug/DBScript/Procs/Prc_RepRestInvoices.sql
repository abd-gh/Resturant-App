if  exists (select * from sysobjects where name='RepRestInvoices')
	drop PROCEDURE RepRestInvoices
GO
CREATE PROCEDURE [dbo].[RepRestInvoices]
	@StartDate	date,
	@EndDate	date,
	@UserId	uniqueidentifier
as
BEGIN
 select  
		 Rp.title Title  ,Rp.Price Price, cast(Rp.Date as date) Date, Ru.LoginName Name                                   
	 	into #TempResut
   from RestInvoices as Rp
	 	inner join GUsers Ru on Ru.GUID=Rp.Users
	 		 	
    where( @UserId=Rp.Users or @UserId = 0x0)AND
	-- cast(convert(datetime,hp.DateIn ) as date) between Cast(convert(datetime,@StartDate )as date) and cast(convert(datetime,@EndDate)as date)
	 	
 -- CONVERT(NVARCHAR(255), CONVERT(SMALLDATETIME, Rp.Date, 101)) >= cast(convert(datetime,@StartDate )as date)and 
  --CONVERT(NVARCHAR(255), CONVERT(SMALLDATETIME, Rp.Date, 101)) <= cast(convert(datetime,@EndDate ) as date) 

   cast(CONVERT(SMALLDATETIME, Rp.Date, 103)as date) >= cast(convert(date,@StartDate,111 )as date)and 
   cast(CONVERT(SMALLDATETIME, Rp.Date, 103)as date) <= cast(convert(date,@EndDate,111 ) as date)
   --(Rp.Date >=@StartDate )and Rp.Date<=@EndDate
  
  select * from #TempResut order by Date
  
  select sum(Price) as TotalCredit from #TempResut
End

--exec RepHotelAgent '08-26-2017','08-26-2019','E5F9B576-84CB-4B2E-8C96-03E780EC2C44'
--exec RepRestInvoices '08-01-2019','08-03-2019','00000000-0000-0000-0000-000000000000'

--exec RepRestInvoices '2019/01/01','2019/03/03','00000000-0000-0000-0000-000000000000'
go