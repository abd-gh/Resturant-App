if  exists (select * from sysobjects where name='RepHotelRes')
	drop PROCEDURE RepHotelRes
GO
CREATE PROCEDURE [dbo].[RepHotelRes]
	@StartDate	date,
	@EndDate	date
	--@NumberId	uniqueidentifier
as
BEGIN
 select  
		hr.Status, hr.Name as Room ,hh.CustomerName as Customer ,hh.DayNumber as DayNumber,cast(hh.CheckIn as Date)DateIn ,cast(hh.CheckOut as DATe)DateOut ,cast(hh.Date as DATe)Date                                
	 	into #TempResut
   from HotelReservation  as hh
	--	inner join HotelCustomer as hc on hc.GUID = hp.CustomerName
	 	inner join HotelRooms hr on hr.GUID = 	hh.RoomNumber
	 		 	
   -- where @NumberId=hh.RoomNumber AND
	-- cast(convert(datetime,hp.DateIn ) as date) between Cast(convert(datetime,@StartDate )as date) and cast(convert(datetime,@EndDate)as date)
	 	where
  CONVERT(NVARCHAR(255), CONVERT(SMALLDATETIME, hh.Date, 101)) >= cast(convert(datetime,@StartDate )as date)and 
  CONVERT(NVARCHAR(255), CONVERT(SMALLDATETIME, hh.Date, 101)) <= cast(convert(datetime,@EndDate ) as date) 
  
  select * from #TempResut order by DateIn
  
  --select sum(Debit) as TotalCredit,sum(Creditor) as TotalDepit ,(sum (Creditor)-sum(Debit)) as Balance from #TempResut
End

--exec RepHotelHost '08/26/2017','08/26/2019'
--,'E5F9B576-84CB-4B2E-8C96-03E780EC2C44'
go