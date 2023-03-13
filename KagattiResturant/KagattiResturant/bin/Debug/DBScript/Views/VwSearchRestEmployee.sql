if  exists (select * from sysobjects where name='VwSearchRestEmployee')
	drop View VwSearchRestEmployee

Go
Create View  VwSearchRestEmployee
as
	select GUID , Number ,  Name,Phone,Salary,Notes from [dbo].[RestEmployee] 
																	
					