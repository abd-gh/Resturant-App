if not exists (select * from sysobjects where name='RestEmpSal')

CREATE TABLE [dbo].[RestEmpSal](
	[GUID] [uniqueidentifier] NOT NULL,
	[GUID_Emp] [uniqueidentifier] NOT NULL,
	[Salary] [Float] NULL,
	[Salary_received][Float] NULL,
	[Salary_Remaining] [Float] NULL,	
	[Salary_Discount][Float] NULL,
	[Salary_Plus][Float] NULL,
	[Month] [nvarchar](250)NULL

	
	
 CONSTRAINT [PK_RestEmpSal] PRIMARY KEY CLUSTERED 
(
	[GUID] ASC
)
) ON [PRIMARY]

GO




