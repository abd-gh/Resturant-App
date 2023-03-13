if  exists (select * from sysobjects where name='VwSearchRestSection')
	drop View VwSearchRestSection

Go
Create View  VwSearchRestSection
as
	select GUID , Number ,  Name,Printer,IsProduct from [dbo].[RestSection] 
																	
					