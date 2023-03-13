if  exists (select * from sysobjects where name='VwSearchRestUsers')
	drop View VwSearchRestUsers

Go
Create View  VwSearchRestUsers
as
	select GUID,Number,Loginname,isadmin from GUsers
					