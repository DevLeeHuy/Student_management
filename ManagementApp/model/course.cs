﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementApp.model
{
    class course
    {
        private int id;
        private string label;
        private int period;
        private string description;
        private int semester;

        public int Id { get => id; set => id = value; }
        public string Description { get => description; set => description = value; }
        public string Label { get => label; set => label = value; }
        public int Period { get => period; set => period = value; }
        public int Semester { get => semester; set => semester = value; }

        public course() { }
        public course(int id, string label, int period, string description,int semester)
        {
            this.id = id;
            this.label = label;
            this.period = period;
            this.description = description;
            this.semester = semester;
        }
    }
}
