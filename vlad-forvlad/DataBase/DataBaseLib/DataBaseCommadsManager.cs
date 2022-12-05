using DataBaseLib.Access;
using DataBaseLib.Commands;
using System.Data;

namespace DataBaseLib;

/// <summary>
/// Выполнение команд пользователя
/// </summary>
public class DataBaseCommadsManager
{
    public DataTable GetDataTable(string tableName)
    {
        BaseCommands command = new BaseCommands();
        return command.GetDataTable(tableName);
    }

    public void Insert(string[] args, string tableName)
    {
        ITableEditorCommand command;
        switch (tableName)
        {
            case "Sells":
                command = new Table1Commands();
                break;
            case "Tovar":
                command = new Table2Commands();
                break;
            case "Clients":
                command = new Table3Commands();
                break;
            case "Shops":
                command = new Table4Commands();
                break;
            case "Managers":
                command = new Table5Commands();
                break;
            default: throw new Exception("Ошибка!");
        }
        command.Insert(args);
    }

    public void Delete(string[] args, string tableName)
    {
        ITableEditorCommand command;
        switch (tableName)
        {
            case "Sells":
                command = new Table1Commands();
                break;
            case "Tovar":
                command = new Table2Commands();
                break;
            case "Clients":
                command = new Table3Commands();
                break;
            case "Shops":
                command = new Table4Commands();
                break;
            case "Managers":
                command = new Table5Commands();
                break;
            default: throw new Exception("Ошибка!");
        }
        command.Delete(args);
    }

    public void Update(string[] args, string tableName)
    {
        ITableEditorCommand command;
        switch (tableName)
        {
            case "Sells":
                command = new Table1Commands();
                break;
            case "Tovar":
                command = new Table2Commands();
                break;
            case "Clients":
                command = new Table3Commands();
                break;
            case "Shops":
                command = new Table4Commands();
                break;
            case "Managers":
                command = new Table5Commands();
                break;
            default: throw new Exception("Ошибка!");
        }
        command.Update(args);
    }
}