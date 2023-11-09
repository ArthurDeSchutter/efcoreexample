go to ssms and excecute the CreateMyWebshop.sql file that will create the db and tables


the scaffold command, excecute this in the nuget package manager console

Scaffold-DbContext "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MyWebShop;Integrated Security=True" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models

