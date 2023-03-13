if not exists (select * from sysobjects where name='RestBill')

CREATE TABLE [dbo].[RestBill](
	[GUID] [uniqueidentifier] NOT NULL,
	[Number] [int] NULL,
	[Num][int]null,
	[Date] [smalldatetime] NULL,	
	[Total_Price][float]NULL,
	[Users][uniqueidentifier],
	[Type][bit]null,
	[Checks][bit]null,
	[Notes][nvarchar]
	    
 CONSTRAINT [PK_RestBill] PRIMARY KEY CLUSTERED 
(
	[GUID] ASC
)
) ON [PRIMARY]

GO




