## Resturant Application

---

## Description

This program provides a service for managing restaurants, including foods catigories, foods item, employees, and invoices. It also includes all the necessary reports, a point of sale, and enables direct sales or delivery services.


---

## Used Technologies
Project is created with:
- C#
- .Net framework 4.8 or later
- ADO.Net to handle database and queries
- SQL Server Management Studio (SSMS) 

---

## Prerequisites
- .Net framework 4.8 or later
- SQL Server Management Studio (SSMS)

----

## How-To run
- Install SQL Server Management Studio (SSMS) and create Database
- Run "KagattiRestaurant" Application in "Debug" folder

- Click "New" to connect to your database <img src="./Screenshots/click_on_new.png" width="900" height="400">

- You have to enter "server name" and select "authentication" after that click "test" then you can select your database you want to use <img src="./Screenshots/Sql information.png" width="900" height="400">

- Here you have to select the correct database and click OK to create all tables in the selected database <img src="./Screenshots/open DB.png" width="900" height="400"><img src="./Screenshots/Create_Tables.png" width="900" height="400">

- For first time you will create User Admin to mange the application <img src="./Screenshots/create_Username.png" width="900" height="400">
 
 - The main interface of the application includes Cards, Reports, and Tools. At the bottom information about the database and the current user</br><img src="./Screenshots/mainform.png" width="900" height="400">

- For every card ther are CRUD operations "create, read, update and delete". 
### Users
To manage all application users and their permissions

----

### Change Password
To Change the current user's password

 ----
### Section
To manage all food categories in the restaurant and choose the kitchen printer, "Is Product" means whether this category have quantity and you must manage

----
### Item
Managing the food item and determining the category to which it belongs, the price and the quantity, if any

----
### Invoices
To manage all purchase invoices to include in the reports

----
### Employee
To manage all employees working in the restaurant

----
### Salary Invoices
Managing the employees' salaries process, where the employee can receive his salary in installments and can be given salary increases or deductions
