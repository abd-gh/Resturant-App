if not exists (select * from sysobjects where name='RestOrder')

CREATE TABLE [dbo].[RestOrder](
	[GUID] [uniqueidentifier] NOT NULL,
	[Number] [int] NULL,
	[Date] [smalldatetime] NULL,
	[Item_Name] [uniqueidentifier] NULL,
	[Count] [int]NULL,
	[Single_Price] [float] NULL,
	[Total_Price][float]NULL,
	[Tax][float]Null,
	[Guid_RestBill][uniqueidentifier],
	[Users][uniqueidentifier]
	    
 CONSTRAINT [PK_RestOrder] PRIMARY KEY CLUSTERED 
(
	[GUID] ASC
)
) ON [PRIMARY]

GO




