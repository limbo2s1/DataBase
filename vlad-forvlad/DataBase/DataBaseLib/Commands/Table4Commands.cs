using DataBaseLib.Access;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseLib.Commands
{
    internal class Table4Commands : ITableEditorCommand
    {
        // ЕСЛИ нужна другая БД, просто меняем AccessDataBaseController
        // на нужную, например SQLiteDataBaseController
        // в следующей строке
        private AccessDataBaseController controller = new AccessDataBaseController();

        public void Select(string[] args)
        {

        }

        public void Insert(string[] args)
        {            
            string query = $"INSERT INTO [Shops] " +
                    $"([Код магазина], [Название], [Адрес]) " +
                    $"VALUES ({args[0]}, '{args[1]}', '{args[2]}')";
            controller.ExecuteCommand(query);
        }

        public void Update(string[] args)
        {
            string query = @$"UPDATE [Shops]
                    SET [Название] = '{args[1]}',[Адрес] = '{args[2]}'
                    WHERE [Код магазина] = {args[0]}";
            controller.ExecuteCommand(query);
        }

        public void Delete(string[] args)
        {
            string query = $"DELETE FROM [Shops] " +
                    $"WHERE [Код магазина] = {args[0]}";
            controller.ExecuteCommand(query);
        }


    }
}
