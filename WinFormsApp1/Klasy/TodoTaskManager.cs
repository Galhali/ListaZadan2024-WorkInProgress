using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaZadan.Klasy
{
    public class TodoTaskManager
    {
        private readonly List<TodoTask> tasks;

        public TodoTaskManager()
        {
            tasks = new List<TodoTask>();
        }

        public TodoTask ZnajdzZadanie(int id)
        {
            foreach(var task in tasks)
            {
                if (task.Id == id)
                {
                    return task;
                }
            }

            return null;
        }

        public void DodaZadanie(TodoTask zadanie)
        {
            tasks.Add(zadanie);
            FileHelper.ZapiszZadania(tasks, zadanie.UserId);
        }

        public void UsunZadanie(int id)
        {
            TodoTask zadanie = ZnajdzZadanie(id);
            tasks.Remove(zadanie);
            FileHelper.ZapiszZadania(tasks, zadanie.UserId);
        }

        public List<TodoTask> PobierzZadania(string userId)
        {
            List<TodoTask> userTasks = new List<TodoTask>();
            foreach (var task in tasks)
            {
                if(task.UserId == userId)
                {
                    userTasks.Add(task);
                }
            }

            return userTasks;
        }

        public long ObliczNastepneId()
        {
            long max = tasks.Count > 0 ? tasks.Max(x => x.Id) : 0;
            return max + 1;
        }

        public void ZaladujZadaniaUzytkownika(string userId)
        {
            tasks.Clear();
            tasks.AddRange(FileHelper.ZaladujZadania(userId));
        }

        public void AktualizujZadaniaUzytkownika(string userId)
        {
            FileHelper.ZapiszZadania(tasks, userId);
        }
    }
}
