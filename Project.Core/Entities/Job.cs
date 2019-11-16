using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Entities
{
    public class Job
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
            //Job Name
            return Name;
        }

    }
}
