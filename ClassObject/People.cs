using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObject
{
    class People
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        public People(string name,int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public People() { }

        /*protected string name;
        protected int age;
        public void setName(string name)
        {
            this.name = name;
        }
        public void setAge(int age)
        {
            this.age = age;
        }
        public void Display()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
        }*/
        public override string ToString()
        {
            return "\t" + this.Name + "\t" + this.Age;

        }
    }
}
