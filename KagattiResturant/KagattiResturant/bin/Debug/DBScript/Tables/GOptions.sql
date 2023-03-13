if not exists (select * from sysobjects where name='GOptions')
CREATE TABLE [dbo].[GOptions](
	[GUID]	[uniqueidentifier] NOT NULL,
	[Name] [nvarchar](250) NULL,
	[Value] [nvarchar](250) NULL,
	[UserGUID] [uniqueidentifier] NULL,
	[ComputerName] [nvarchar](250) NULL,
 CONSTRAINT [PK_GOptions] PRIMARY KEY CLUSTERED 
(
	[GUID] ASC
)
) ON [PRIMARY]

GO




