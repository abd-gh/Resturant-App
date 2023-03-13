if  exists (select * from sysobjects where name='VwSearchRestEmpSalInv')
	drop View VwSearchRestEmpSalInv

Go
Create View  VwSearchRestEmpSalInv
as
	select GUID ,  GUID_EmpSal,Salary,Salary_received,Salary_Remaining,Salary_Discount,Salary_Plus,Month ,Date  from [dbo].[RestEmpSalInv] 
																	
					