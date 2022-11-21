using DataBaseLib.Access;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseLib.Commands
{
    internal class Table1Commands : ITableEditorCommand
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
            string query = $"INSERT INTO [Tovar] " +
                    $"([Код инструмента], [Название инструмента], [Цена], [Модель]) " +
                    $"VALUES ('{args[0]}', '{args[1]}', {args[2]})";
            controller.ExecuteCommand(query);
        }

        public void Update(string[] args)
        {
            //// дома


            //string query = $"UPDATE [Tovar] SET [Название инструмента] = '{type}', " +
            //       $"WHERE [Код инструмента] = {id}";

        }

        public void Delete(string[] args)
        {
            // дома


            string query = $"DELETE FROM [Tovar] " +
                    $"WHERE [Код инструмента] = {args[0]}";
            controller.ExecuteCommand(query);

        }


    }
}
