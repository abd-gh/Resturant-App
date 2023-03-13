if  exists (select * from sysobjects where name='VwSearchRestOrder')
	drop View VwSearchRestOrder

Go
Create View  VwSearchRestOrder
as
	select R.GUID, R.Number, R.Date, R.Single_Price, R.Total_Price,  R.Count, F.Name ItemsName,B.Num Num_Bill,R.Tax from [dbo].[RestOrder] R
																	inner join RestItem F on R.Item_Name=F.GUID 
																	inner join RestBill B on R.Guid_RestBill=B.GUID 
					