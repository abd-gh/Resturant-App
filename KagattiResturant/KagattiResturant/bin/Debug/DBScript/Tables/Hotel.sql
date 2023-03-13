if not exists (select * from sysobjects where name='HotelFloors')

CREATE TABLE [dbo].[HotelFloors](
	[GUID] [uniqueidentifier] NOT NULL,
	[Number] [int] NULL,
	[Code] [nvarchar](50) NULL,
	[Name] [nvarchar](250) NULL,
	[Notes] [nvarchar](250) NULL,
 CONSTRAINT [PK_HotelFloors] PRIMARY KEY CLUSTERED 
(
	[GUID] ASC
)
) ON [PRIMARY]

GO


