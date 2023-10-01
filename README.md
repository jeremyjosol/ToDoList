## Application Setup

1. Clone this repo.
2. Open your shell (e.g., Terminal or GitBash) and navigate to this project's production directory called `ToDoList`. 
3. Within the production directory `ToDoList`, create a new file entitled `appsettings.json`.
4. Within `appsettings.json`, enter the following code:
```javascript
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=to_do_list_with_mysqlconnector;uid={USERNAME};pwd={PASSWORD};",
      "TestConnection": "Server=localhost;Port=3306;database=to_do_list_with_mysqlconnector_test;uid=root;pwd=epicodus;"
  }
}
```
  > Be sure to replace the `{USERNAME}` and `{PASSWORD}` fields with your own relevant information. Do not include the curly brackets.
5. In the production directory, you can enter the following command `dotnet watch run`.
  > This command will start the project in development mode with a watcher.

## Available Routes

* localhost:5000/
* localhost:5000/items/new
* localhost:5000/items