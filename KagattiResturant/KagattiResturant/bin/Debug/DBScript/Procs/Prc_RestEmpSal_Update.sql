if  exists (select * from sysobjects where name='Prc_RestEmpSal_Update')
	drop PROCEDURE Prc_RestEmpSal_Update

Go
Create proc [dbo].[Prc_RestEmpSal_Update]
		@GUID	uniqueidentifier,	
		@GUID_Emp	uniqueidentifier,
		@Salary float,
		@Salary_received float,
		@Salary_Remaining float,
		@Salary_Discount float,
		@Salary_Plus float,
		@Month nvarchar(250)
		

as
	update [dbo].[RestEmpSal]
	set 

		GUID_Emp=@GUID_Emp,
		Salary=@Salary,
		Salary_received=@Salary_received,
		Salary_Remaining=@Salary_Remaining,
		Salary_Discount=@Salary_Discount,
		Salary_Plus=@Salary_Plus,
		Month=@Month
		
	where GUID=@GUID

