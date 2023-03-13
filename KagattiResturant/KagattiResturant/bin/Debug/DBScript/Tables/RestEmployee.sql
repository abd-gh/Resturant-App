if not exists (select * from sysobjects where name='RestEmployee')

CREATE TABLE [dbo].[RestEmployee](
	[GUID] [uniqueidentifier] NOT NULL,
	[Number] [int] NULL,	
	[Name] [nvarchar](250) NULL,
	[Phone] [nvarchar](250) NULL,
	[Salary] [Float] NULL,
	[Notes] [nvarchar](250) NULL,
	
 CONSTRAINT [PK_RestEmployee] PRIMARY KEY CLUSTERED 
(
	[GUID] ASC
)
) ON [PRIMARY]

GO




