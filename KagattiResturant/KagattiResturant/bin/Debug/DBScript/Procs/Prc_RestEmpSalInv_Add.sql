if  exists (select * from sysobjects where name='Prc_RestEmpSalInv_Add')
	drop PROCEDURE Prc_RestEmpSalInv_Add

Go
Create proc [dbo].[Prc_RestEmpSalInv_Add]
		@GUID	uniqueidentifier,	
		@GUID_EmpSal	uniqueidentifier,
		@GUID_Emp	uniqueidentifier,
		@Salary float,
		@Salary_received float,
		@Salary_Remaining float,
		@Salary_Discount float,
		@Salary_Plus float,
		@Month nvarchar(250),
		@Date smalldatetime,
		@Users uniqueidentifier
		

as

	insert into [dbo].[RestEmpSalInv](GUID,Salary,GUID_Emp,GUID_EmpSal,Salary_received,Salary_Remaining,Salary_Discount,Salary_Plus,Month,Users,Date)
			values(@GUID,@Salary,@GUID_Emp,@GUID_EmpSal,@Salary_received,@Salary_Remaining,@Salary_Discount,@Salary_Plus,@Month,@Users,@Date)


GO


