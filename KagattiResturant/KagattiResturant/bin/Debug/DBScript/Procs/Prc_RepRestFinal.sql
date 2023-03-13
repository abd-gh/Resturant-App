if  exists (select * from sysobjects where name='RepRestFinal')
	drop PROCEDURE RepRestFinal
GO
CREATE PROCEDURE [dbo].[RepRestFinal]
	@StartDate	date,
	@EndDate	date,
	@UserId	uniqueidentifier
as
BEGIN
 select  
		Sum( Rp.Total_Price) Total_Receipts                                 
	 	into #TempResut
   from RestBill as Rp
	 	inner join GUsers Ru on Ru.GUID=Rp.Users
	 	--inner join RestInvoices ri on ri.Users=Ru.GUID	 	
    where( @UserId=Rp.Users or @UserId = 0x0)AND
   cast(convert(datetime,Rp.Date )as date) >= cast(convert(datetime,@StartDate )as date)and 
   cast(convert(datetime,Rp.Date ) as date) <= cast(convert(datetime,@EndDate ) as date)and (Rp.Checks=1)

   select  
		Sum( ri.Price) Total_Invoices                                 
	 	into #TempResut2
   from RestInvoices as ri
	 	inner join GUsers Ru on Ru.GUID=ri.Users
	 	--inner join RestInvoices ri on ri.Users=Ru.GUID	 	
    where( @UserId=ri.Users or @UserId = 0x0)AND
   cast(convert(datetime,ri.Date )as date) >= cast(convert(datetime,@StartDate )as date)and 
   cast(convert(datetime,ri.Date ) as date) <= cast(convert(datetime,@EndDate ) as date)

   
   select  
	--COALESCE(Sum( res.Salary_received),0) as Total_Salary	
	--Sum( res.Salary_received) Total_Salary     
	sum( ISNULL(res.Salary_received,0)   )   Total_Salary                      
	 	into #TempResut3
   from RestEmpSalInv as res
	 	inner join GUsers Ru on Ru.GUID=res.Users
	 	--inner join RestInvoices ri on ri.Users=Ru.GUID	 	
    where( @UserId=res.Users or @UserId = 0x0)AND
   cast(convert(datetime,res.Date )as date) >= cast(convert(datetime,@StartDate )as date)and 
   cast(convert(datetime,res.Date ) as date) <= cast(convert(datetime,@EndDate ) as date)


  --group by cast(convert(datetime,Rp.Date )as date) 
  --select * from #TempResut --order by Date
  select * from #TempResut,#TempResut2 ,#TempResut3
  select sum( ISNULL(Total_Receipts,0)) -sum( ISNULL(Total_Invoices,0))-sum( ISNULL(Total_Salary,0)) as Balanc from #TempResut2,#TempResut,#TempResut3 
End

--exec RepHotelAgent '08-26-2017','08-26-2019','E5F9B576-84CB-4B2E-8C96-03E780EC2C44'
--exec RepHotelAgent '08-26-2017','08-26-2019','00000000-0000-0000-0000-000000000000'

--exec RepRestFinal '2019-3-1','2019-3-19','00000000-0000-0000-0000-000000000000'
go