if  exists (select * from sysobjects where name='VwSearchRestInvoices')
	drop View VwSearchRestInvoices

Go
Create View  VwSearchRestInvoices
as
	select i.GUID , i.Number ,  i.Title,i.Price,i.Notes,i.Date,u.LoginName from [dbo].[RestInvoices] i
	inner join GUsers u on u.GUID=i.users
																	
					