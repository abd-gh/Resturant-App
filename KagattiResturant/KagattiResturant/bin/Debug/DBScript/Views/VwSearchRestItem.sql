if  exists (select * from sysobjects where name='VwSearchRestItem')
	drop View VwSearchRestItem

Go
Create View  VwSearchRestItem
as
	select R.GUID, R.Number,  R.Name,   R.Price, F.Name Section_Name,R.Quantity from [dbo].[RestItem] R
																	inner join RestSection F on R.Section_Name=F.GUID 
					