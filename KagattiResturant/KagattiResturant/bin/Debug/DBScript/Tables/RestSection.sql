if not exists (select * from sysobjects where name='RestSection')

CREATE TABLE [dbo].[RestSection](
	[GUID] [uniqueidentifier] NOT NULL,
	[Number] [int] NULL,	
	[Name] [nvarchar](250) NULL,
	[Printer][nvarchar](250) NULL,
	[IsProduct][bit]Null
	
 CONSTRAINT [PK_RestSection] PRIMARY KEY CLUSTERED 
(
	[GUID] ASC
)
) ON [PRIMARY]

GO




