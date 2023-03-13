if not exists (select * from sysobjects where name='RestEmpSalInv')

CREATE TABLE [dbo].[RestEmpSalInv](
	[GUID] [uniqueidentifier] NOT NULL,
	[GUID_EmpSal] [uniqueidentifier] NOT NULL,
	[GUID_Emp] [uniqueidentifier] NOT NULL,
	[Salary] [Float] NULL,
	[Salary_received][Float] NULL,
	[Salary_Remaining] [Float] NULL,	
	[Salary_Discount][Float] NULL,
	[Salary_Plus][Float] NULL,
	[Month] [nvarchar](250)NULL,
	[Date][smalldatetime]Null,
	[Users][uniqueidentifier] NOT NULL

	
	
 CONSTRAINT [PK_RestEmpSalInv] PRIMARY KEY CLUSTERED 
(
	[GUID] ASC
)
) ON [PRIMARY]

GO




