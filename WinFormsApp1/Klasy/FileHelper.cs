using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaZadan.Klasy
{
    internal class FileHelper
    {
        private static string basePath = $@"{AppDomain.CurrentDomain.BaseDirectory}/data/";

        public static List<TodoTask> ZaladujZadania(string userId)
        {
            List<TodoTask> todoTasks = new List<TodoTask>();
            string filePath = $@"{basePath}{userId}.txt";
            
            if(File.Exists(filePath))
            {
                StreamReader reader = new StreamReader(filePath);
                string linia;
                while((linia = reader.ReadLine()) != null)
                {
                    string[] columns = linia.Split('|');
                    int id = int.Parse(columns[0]);
                    string title = columns[1];
                    bool isFinished = bool.Parse(columns[2]);
                    string description = columns[3];
                    TodoTask task = new TodoTask(
                        id,
                        userId,
                        title,
                        description,
                        isFinished);

                    todoTasks.Add(task);
                }

                reader.Close();
            }

            return todoTasks;
        }

        public static void ZapiszZadania(List<TodoTask> tasks, string userId)
        {
            string filePath = $@"{basePath}{userId}.txt";
            StringBuilder builder = new StringBuilder();

            foreach(TodoTask task in tasks)
            {
                builder.AppendLine($"{task.Id}|{task.UserId}|{task.Title}|{task.Description}|{task.IsFinished}");
            }
        }
    }
}
