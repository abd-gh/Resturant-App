if  exists (select * from sysobjects where name='Prc_RestEmpSal_Add')
	drop PROCEDURE Prc_RestEmpSal_Add

Go
Create proc [dbo].[Prc_RestEmpSal_Add]
		@GUID	uniqueidentifier,	
		@GUID_Emp	uniqueidentifier,
		@Salary float,
		@Salary_received float,
		@Salary_Remaining float,
		@Salary_Discount float,
		@Salary_Plus float,
		@Month nvarchar(250)
		

as

	insert into [dbo].[RestEmpSal](GUID,Salary,GUID_Emp,Salary_received,Salary_Remaining,Salary_Discount,Salary_Plus,Month)
			values(@GUID,@Salary,@GUID_Emp,@Salary_received,@Salary_Remaining,@Salary_Discount,@Salary_Plus,@Month)


GO


