using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.EventSample
{
    public class TeacherNameChangeArgs : EventArgs
    {
        public string OldName { get; set; }
        public string NewName { get; set; }
        public TeacherNameChangeArgs(string newName, string oldName)
        {
            this.OldName = oldName;
            this.NewName = newName;
        }
    }
    public class Teacher
    {
        public event EventHandler<TeacherNameChangeArgs> TeacherChanged;
        private string Name;
        private string Description;
        public Teacher(string name, string description)
        {
            this.Name = name;
            this.Description = description;
        }

        public void SetName(string newName)
        {
            var args = new TeacherNameChangeArgs(newName, Name);
            this.Name=newName;
            TeacherChanged.Invoke(this, args);
        }
    }

    public class TeacherChangeNameLogger
    {
        public void Log(object sender, TeacherNameChangeArgs args)
        {
            Console.WriteLine($"Old name is {args.OldName} and new name is {args.NewName}");
        }
    }
     
    public class TeacherChangeNameLogger2
    {
        public void Log(object sender, TeacherNameChangeArgs args)
        {
            Console.WriteLine("Logger2");
            Console.WriteLine($"Old name is {args.OldName} and new name is {args.NewName}");
        }
    }
}
