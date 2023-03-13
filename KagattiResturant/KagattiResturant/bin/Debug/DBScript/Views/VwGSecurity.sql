if  exists (select * from sysobjects where name='VwGSecurity')
	drop View VwGSecurity

Go
Create View  VwGSecurity
as
select PS.*,GU.LoginName,Gu.password from GSecurity PS
						inner join GUsers GU on ps.UserGUID=GU.guid