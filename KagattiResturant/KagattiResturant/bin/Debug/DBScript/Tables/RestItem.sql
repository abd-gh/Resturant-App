if not exists (select * from sysobjects where name='RestItem')

CREATE TABLE [dbo].[RestItem](
	[GUID] [uniqueidentifier] NOT NULL,
	[Number] [int] NULL,	
	[Name] [nvarchar](250) NULL,
	[Price] [float] NULL,
	[Section_Name] [uniqueidentifier] NOT NULL,
	[Quantity] [int]NULL
	
 CONSTRAINT [PK_RestItem] PRIMARY KEY CLUSTERED 
(
	[GUID] ASC
)
) ON [PRIMARY]

GO




