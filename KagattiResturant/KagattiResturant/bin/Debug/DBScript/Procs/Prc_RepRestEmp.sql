if  exists (select * from sysobjects where name='RepRestEmp')
	drop PROCEDURE RepRestEmp
GO
CREATE PROCEDURE [dbo].[RepRestEmp]
	@StartDate	date,
	@EndDate	date,
	@EmpId	uniqueidentifier
as
BEGIN
 select  
		RE.Name, ESI.Salary_received,ESI.Salary_Discount,ESI.Salary_Plus,ESI.Salary_Remaining,Ru.LoginName , cast(ESI.Date as smalldatetime) Date                                  
	 	into #TempResut
   from RestEmpSalInv as ESI
	 	inner join GUsers Ru on Ru.GUID=ESI.Users
	 	inner join RestEmployee RE on RE.GUID=ESI.GUID_Emp	 	
    where( @EmpId=RE.GUID or @EmpId = 0x0)AND
	
	-- cast(convert(datetime,hp.DateIn ) as date) between Cast(convert(datetime,@StartDate )as date) and cast(convert(datetime,@EndDate)as date)
	 	
 -- CONVERT(NVARCHAR(255), CONVERT(SMALLDATETIME, Rp.Date, 101)) >= cast(convert(datetime,@StartDate )as date)and 
  --CONVERT(NVARCHAR(255), CONVERT(SMALLDATETIME, Rp.Date, 101)) <= cast(convert(datetime,@EndDate ) as date) 

   cast(convert(datetime,ESI.Date )as date) >= cast(convert(datetime,@StartDate )as date)and 
   cast(convert(datetime,ESI.Date ) as date) <= cast(convert(datetime,@EndDate ) as date)

  
  select * from #TempResut order by Date
  
  select sum(Salary_received) as Recevied,sum(Salary_Discount) as Discount,sum(Salary_Plus) as Plus from #TempResut
End

--exec RepHotelAgent '08-26-2017','08-26-2019','E5F9B576-84CB-4B2E-8C96-03E780EC2C44'
--exec RepRestAgent '08-26-2017','08-26-2019','00000000-0000-0000-0000-000000000000'

--exec RepRestEmp '08/26/2017','08/26/2019','00000000-0000-0000-0000-000000000000'
go