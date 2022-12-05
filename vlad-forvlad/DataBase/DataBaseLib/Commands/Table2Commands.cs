using DataBaseLib.Access;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseLib.Commands
{
    internal class Table2Commands : ITableEditorCommand
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
                    $"VALUES ({args[0]}, '{args[1]}','{args[2]}','{args[3]}')";
            controller.ExecuteCommand(query);
        }

        public void Update(string[] args)
        {
            string query = @$"UPDATE [Tovar]
                    SET [Название инструмента] = '{args[1]}',[Цена] = '{args[2]}',[Модель] = '{args[3]}'
                    WHERE [Код инструмента] = {args[0]}";
            controller.ExecuteCommand(query);
        }

        public void Delete(string[] args)
        {
            string query = $"DELETE FROM [Tovar] " +
                    $"WHERE [Код инструмента] = {args[0]}";
            controller.ExecuteCommand(query);
        }


    }
}
