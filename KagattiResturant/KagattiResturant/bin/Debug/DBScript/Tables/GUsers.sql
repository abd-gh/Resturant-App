if not exists (select * from sysobjects where name='GUsers')
CREATE TABLE [dbo].[GUsers](
	[Number]	[int] NULL,
	[GUID]	[uniqueidentifier] NOT NULL,
	[LoginName] [nvarchar](250) NULL,
	[Password] [nvarchar](250) NULL,
	[Isadmin]	[Bit] NULL,
	[ParentUser] [uniqueidentifier] NULL,
 CONSTRAINT [PK_GUsers] PRIMARY KEY CLUSTERED 
(
	[GUID] ASC
)
) ON [PRIMARY]
	
		
GO




