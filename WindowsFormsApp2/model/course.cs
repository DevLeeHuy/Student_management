using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.model
{
    class course
    {
        private int id;
        private string label;
        private int period;
        private string description;

        public int Id { get => id; set => id = value; }
        public string Description { get => description; set => description = value; }
        public string Label { get => label; set => label = value; }
        public int Period { get => period; set => period = value; }

        public course() { }
        public course(int id, string label, int period, string description)
        {
            this.id = id;
            this.label = label;
            this.period = period;
            this.description = description;
        }
    }
}
