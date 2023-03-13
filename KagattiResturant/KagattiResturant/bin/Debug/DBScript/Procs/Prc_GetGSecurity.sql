IF EXISTS( SELECT name FROM  sysobjects
	WHERE  name = 'Prc_GetGSecurity' AND type = 'P')
    DROP PROCEDURE Prc_GetGSecurity

Go

Create  proc [dbo].[Prc_GetGSecurity]
	@SecurityType nvarchar(250),
	@UserGUID	uniqueidentifier,
	@Def		bit
as

select Top 0 UserGUID, SecurityType, Name, Command, Permission into #TempGSecurity from GSecurity
insert into #TempGSecurity(UserGUID,SecurityType, Name, Command)
select distinct  @UserGUID,SecurityType,Name,Command  from GSecurity where SecurityType=@SecurityType

update B
set B.Permission=S.Permission,
	B.UserGUID=@UserGUID
from #TempGSecurity B inner join GSecurity s on (b.Name=s.Name and b.Command=s.Command and b.SecurityType=s.SecurityType)
and s.UserGUID=@UserGUID

update #TempGSecurity
set Permission=@Def
where Permission is null



DECLARE @cols AS NVARCHAR(MAX),
    @query  AS NVARCHAR(MAX)

select @cols = STUFF((SELECT ',' + QUOTENAME(Command) 
                    from GSecurity	where SecurityType=@SecurityType
                    group by Command
            FOR XML PATH(''), TYPE
            ).value('.', 'NVARCHAR(MAX)') 
        ,1,1,'')
print @cols 


set @query = 'SELECT * from 
             (
			  select Name, Command,cast(Permission as TINYINT) Permission
			  from #TempGSecurity 
			  where SecurityType=''' + @SecurityType +''' 
				and UserGUID=''' +cast(@UserGUID as nvarchar(250)) +'''
			) src
            pivot
			(
			  max(Permission)
			  for Command in (' + @cols + ')
			) piv'

print @query
execute(@query);