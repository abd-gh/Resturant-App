if not exists (select * from sysobjects where name='RestInvoices')

CREATE TABLE [dbo].[RestInvoices](
	[GUID] [uniqueidentifier] NOT NULL,
	[Number] [int] NULL,	
	[Title] [nvarchar](250) NULL,
	[Price][float]NULL,
	[Notes] [nvarchar](250) NULL,
	[Date] [smalldatetime],
	[Users][uniqueidentifier] NOT NULL

	
 CONSTRAINT [PK_RestInvoices] PRIMARY KEY CLUSTERED 
(
	[GUID] ASC
)
) ON [PRIMARY]

GO




