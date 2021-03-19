# ToDoLIst
Aplicação 
  API
  * .net core 5
  * postgresql
  * entity code first migration.
  
  FRONT END
  
  * reactjs

API
1) Rodar comando migration
Add-Migration Init -Project ToDoList.Repository -StartupProject ToDoList.API -Context ApplicationDbContext

2) Visualizar scripts gerados
Script-Migration -Context ApplicationDbContext -Project ToDoList.Repository -StartupProject ToDoList.API

3) Atualizar a base de dados 
Update-Database -Context ApplicationDbContext -Project ToDoList.Repository -StartupProject ToDoList.API

Front-End
1) npm install
2) yarn start
