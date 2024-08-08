using System.Data;
using System.Data.SqlClient;

namespace Coffe_Shop.Classes
{
    public class CRUDOperationsInterpretor
    {
        /// <summary>
        /// This function execute the command from db with loading screen
        /// </summary>
        /// <param name="func"></param>
        /// <param name="Querry"></param>
        /// <param name="parameters"></param>
        /// <param name="title"></param>
        /// <param name="control"></param>
        /// <returns></returns>
        public static async Task MethodAsync(Func<string, SqlParameter[], Task> func, string Querry, SqlParameter[] parameters, string title, System.Windows.Forms.Control control)
        {
            // Thirr metodën async duke përdorur delegate
            Task requestTask = Task.Run(() => func(Querry, parameters));
            await LoadingScreenDialog.ShowLoadingScreen(requestTask, title, control);
        }

        /// <summary>
        /// This function execute the command from db with out loading screen
        /// </summary>
        /// <param name="func"></param>
        /// <param name="Querry"></param>
        /// <param name="parameters"></param>
        /// <param name="control"></param>
        /// <returns></returns>
        public static async Task MethodAsync(Func<string, SqlParameter[], Task> func, string Querry, SqlParameter[] parameters, System.Windows.Forms.Control control)
        {
            // Thirr metodën async duke përdorur delegate
            Task requestTask = Task.Run(() => func(Querry, parameters));
        }


        public static async Task MethodAsync(Func<string, Task> func, string Querry)
        {
            // Thirr metodën async duke përdorur delegate
            Task requestTask = Task.Run(() => func(Querry));
        }

        /// <summary>
        /// Get data in datatable  through querry with loading screen
        /// </summary>
        /// <param name="func"></param>
        /// <param name="Querry"></param>
        /// <param name="title"></param>
        /// <param name="control"></param>
        /// <returns></returns>
        public static async Task<DataTable> MethodAsyncTable(Func<string, Task<DataTable>> func, string Querry, string title, System.Windows.Forms.Control control)
        {
            DataTable result = await func(Querry);
            Task requestTask = Task.Run(async () => await func(Querry)); // Përdorimi i await këtu për të pritur task-in e funksionit

            await Task.WhenAll(requestTask);
            await LoadingScreenDialog.ShowLoadingScreen(requestTask, title, control);
            // Kthe rezultatin
            return result;
        }

        /// <summary>
        /// Get data in datatable  through procedure with loading screen
        /// </summary>
        /// <param name="func"></param>
        /// <param name="Querry"></param>
        /// <param name="param"></param>
        /// <param name="title"></param>
        /// <param name="control"></param>
        /// <returns></returns>
        public static async Task<DataTable> MethodAsyncTable(Func<string, SqlParameter[], Task<DataTable>> func, string Querry, SqlParameter[] param, string title, System.Windows.Forms.Control control)
        {
            DataTable result = await func(Querry, param);
            Task requestTask = Task.Run(async () => await func(Querry, param)); // Përdorimi i await këtu për të pritur task-in e funksionit

            await Task.WhenAll(requestTask);
            await LoadingScreenDialog.ShowLoadingScreen(requestTask, title, control);
            // Kthe rezultatin
            return result;
        }

        /// <summary>
        ///  Get data in datatable  through procedure without loading screen
        /// </summary>
        /// <param name="func"></param>
        /// <param name="Querry"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public static async Task<DataTable> MethodAsyncTable(Func<string, SqlParameter[], Task<DataTable>> func, string Querry, string v, SqlParameter[] param)
        {
            DataTable result = await func(Querry, param);
            Task requestTask = Task.Run(async () => await func(Querry, param)); // Përdorimi i await këtu për të pritur task-in e funksionit

            await Task.WhenAll(requestTask);
            // Kthe rezultatin
            return result;
        }

        /// <summary>
        /// Get data in datatable  through querry without loading screen
        /// </summary>
        /// <param name="func"></param>
        /// <param name="Querry"></param>
        /// <param name="control"></param>
        /// <returns></returns>
        public static async Task<DataTable> MethodAsyncTable(Func<string, Task<DataTable>> func, string Querry, System.Windows.Forms.Control control)
        {
            DataTable result = await func(Querry);
            Task requestTask = Task.Run(async () => await func(Querry)); // Përdorimi i await këtu për të pritur task-in e funksionit
            return result;
        }

        /// <summary>
        /// This method insert the data and after that get last id inserted
        /// </summary>
        /// <param name="func"></param>
        /// <param name="Querry"></param>
        /// <param name="parameters"></param>
        /// <param name="control"></param>
        /// <returns></returns>
        public static async Task<int> MethodAsyncGetLastIdAfterInsert(Func<string, SqlParameter[], Task<int>> func, string Querry, SqlParameter[] parameters, System.Windows.Forms.Control control)
        {
            // Thirr metodën async duke përdorur delegate
            int LastId = await func(Querry, parameters);
            Task requestTask = Task.Run(() => func(Querry, parameters));

            return LastId;
        }
        /// <summary>
        /// This method is to get bool if specific value excist in specific Table with loading Screen
        /// </summary>
        /// <param name="func"></param>
        /// <param name="Querry"></param>
        /// <param name="title"></param>
        /// <param name="control"></param>
        /// <returns></returns>
        public static async Task<bool> MethodAsyncCheckBeforeInsert(Func<string, Task<bool>> func, string Querry, string title, System.Windows.Forms.Control control)
        {
            // Thirr metodën async duke përdorur delegate
            bool LastId = await func(Querry);
            Task requestTask = Task.Run(() => func(Querry));
            await LoadingScreenDialog.ShowLoadingScreen(requestTask, title, control);
            return LastId;
        }
        /// <summary>
        /// This method is to get bool if specific value excist in specific Table without loading Screen
        /// </summary>
        /// <param name="func"></param>
        /// <param name="Querry"></param>
        /// <param name="control"></param>
        /// <returns></returns>
        public static async Task<bool> MethodAsyncCheckBeforeInsert(Func<string, Task<bool>> func, string Querry, System.Windows.Forms.Control control)
        {
            // Thirr metodën async duke përdorur delegate
            bool LastId = await func(Querry);
            Task requestTask = Task.Run(() => func(Querry));
            return LastId;
        }


    }
}
