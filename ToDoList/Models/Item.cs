using System.Collections.Generic;
using MySqlConnector;

namespace ToDoList.Models
{
  public class Item
  {
    public string Description { get; set; }
    public int Id { get; }

    public Item(string description)
    {
      Description = description;
    }
    public static List<Item> GetAll()
    {
      List<Item> allItems = new List<Item> { };
      
      MySqlConnection conn = new MySqlConnection(DBConfiguration.ConnectionString);
      conn.Open();
    }
    public static void ClearAll()
    {
    }
    public static Item Find(int searchId)
    {
      Item placeholderItem = new Item("placeholder item");
      return placeholderItem;
    }
  }
}