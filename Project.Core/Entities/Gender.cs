using System;

namespace Project.Core.Entities
{
    public class Genders
    {
        private int _id;
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name { get; set; }
        public override string ToString()
        {
            //Gender Name
            return Name;
        }
    }
}
