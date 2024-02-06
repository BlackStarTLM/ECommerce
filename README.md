# E-Commerce Inventory system
The project is made in .NET Core Environment.
The assignment was as follows:
+ Create an Inventory database with tables mentioned in Sheet 1 using Entity Framework in the .Net Core 8 class library.
+ Create a Business Logic Layer to create different methods for Crud operations on these tables.
+ Create an API layer to get commands and data from users to interact with inventory db.
+ Place orders by having validations of quantity in inventory for the below cases:
  - return NotFound, if the quantity in order is more than the quantity in inventory.
  - return BadRequest, if quantity is in negatives or zero.
  - return Success, if order is placed by passing these validations."
+ Place 5 orders each belonging to 2 different customers and then create a reporting endpoint, in which you may pass CustomerId
  and it returns all details of orders and products in that order. (Use stored procedure/view to return this data)

 
  The error handling was done using Filters as well as Middlewares
  Middleware was used to throw custome httpcontext.Response when an error is caught. 
