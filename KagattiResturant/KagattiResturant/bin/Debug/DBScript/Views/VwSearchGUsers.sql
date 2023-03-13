if  exists (select * from sysobjects where name='VwSearchGUsers')
	drop View VwSearchGUsers

Go
Create View  VwSearchGUsers
as
	select G.Number, G.GUID, G.LoginName, G.Isadmin   from [dbo].[GUsers] G
												
					