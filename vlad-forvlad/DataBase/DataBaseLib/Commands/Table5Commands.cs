using DataBaseLib.Access;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseLib.Commands
{
    internal class Table5Commands : ITableEditorCommand
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
            string query = $"INSERT INTO [Managers] " +
                    $"([Код менеджера], [Имя], [Фамилия], [Отчество], [Номер телефона]) " +
                    $"VALUES ({args[0]}, '{args[1]}', '{args[2]}', '{args[3]}', '{args[4]}')";
            controller.ExecuteCommand(query);
        }

        public void Update(string[] args)
        {
            string query = @$"UPDATE [Managers]
                    SET [Имя] = '{args[1]}', [Фамилия] = '{args[2]}', [Отчество] = '{args[3]}', [Номер телефона] = '{args[4]}'
                    WHERE [Код менеджера] = {args[0]}";
            controller.ExecuteCommand(query);
        }

        public void Delete(string[] args)
        {
            string query = $"DELETE FROM [Managers] " +
                    $"WHERE [Код менеджера] = {args[0]}";
            controller.ExecuteCommand(query);
        }


    }
}
