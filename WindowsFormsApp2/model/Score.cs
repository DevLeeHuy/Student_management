using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.model
{
    class Score
    {
        private int sid;
        private int cid;
        private float? stdScore;
        private string description;

        public int Sid { get => sid; set => sid = value; }
        public int Cid { get => cid; set => cid = value; }
        public float? StdScore { get => stdScore; set => stdScore = value; }
        public string Description { get => description; set => description = value; }
        public Score(int sid, int cid, float? score, string des)
        {
            this.sid = sid;
            this.cid = cid;
            this.stdScore = score;
            this.description = des;
        }
    }
}
