using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone2
{
    public class Ranking
    {

        private string applicationID;

        public string ApplicationID
        {
            get { return applicationID; }
            set { applicationID = value; }
        }
        private int rank;

        public int Rank
        {
            get { return rank; }
            set { rank = value; }
        }
        private int adminID = 0;

        public int AdminID
        {
            get { return adminID; }
            set { adminID = value; }
        }
        private int committeeID = 0;

        public int CommitteeID
        {
            get { return committeeID; }
            set { committeeID = value; }
        }

    }
}
