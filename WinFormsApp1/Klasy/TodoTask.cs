using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaZadan.Klasy
{
    internal class TodoTask
    {
        public long Id;
        public string UserId;
        public string Title;
        public string Description;
        public bool IsFinished;

        public TodoTask(
            long id,
            string userId,
            string title,
            string description,
            bool isFinished)
        {
            Id = id;
            UserId = userId;
            Title = title;
            Description = description;
            IsFinished = isFinished;
        }
    }
}
