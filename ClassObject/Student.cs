using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObject
{
    class Student:People
    {
        private float _score;

        public float Score
        {
            get { return _score; }
            set { _score = value; }
        }
        public Student(string name,int age,float score) : base(name, age)
        {
            this.Score = score;
        }
        public Student() { }
        public override string ToString()
        {
            return "\t" + this.Name + "\t" + this.Age + "\t" + this.Score;

        }
    }
}
