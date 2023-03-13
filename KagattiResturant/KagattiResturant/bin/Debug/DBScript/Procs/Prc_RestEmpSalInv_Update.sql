if  exists (select * from sysobjects where name='Prc_RestEmpSalInv_Update')
	drop PROCEDURE Prc_RestEmpSalInv_Update

Go
Create proc [dbo].[Prc_RestEmpSalInv_Update]
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
	update [dbo].[RestEmpSalInv]
	set 
		GUID_Emp=@GUID_Emp,
		GUID_EmpSal=@GUID_EmpSal,
		Salary=@Salary,
		Salary_received=@Salary_received,
		Salary_Remaining=@Salary_Remaining,
		Salary_Discount=@Salary_Discount,
		Salary_Plus=@Salary_Plus,
		Month=@Month,
		Date=@Date,
		Users=@Users
		
	where GUID=@GUID

