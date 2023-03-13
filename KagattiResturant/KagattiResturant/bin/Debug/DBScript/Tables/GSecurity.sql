if not exists (select * from sysobjects where name='GSecurity')

CREATE TABLE [dbo].[GSecurity](
	[GUID] [uniqueidentifier] ,
	[UserGUID] [uniqueidentifier] NULL,
	[SecurityType] [nvarchar](50) NULL,
	[Name] [nvarchar](250) NULL,
	[Command] [nvarchar](250) NULL,
	[Permission] [bit] NULL,
 CONSTRAINT [PK_GSecurity] PRIMARY KEY CLUSTERED 
(
	[GUID] ASC
)
) ON [PRIMARY]

GO


