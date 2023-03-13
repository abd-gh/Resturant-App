if  exists (select * from sysobjects where name='VwSearchRestBill')
	drop View VwSearchRestBill

Go
Create View  VwSearchRestBill
as
	select GUID, Date, Num, Total_Price  ,
		CASE 
    WHEN Type = 1 THEN 'Local'
    WHEN Type=0 THEN 'Delivery'
   
END as Bill_Type
	from [dbo].[RestBill] where Checks=1
																	
																
					