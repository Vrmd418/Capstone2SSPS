using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApplications
{
    class Application
    {

        private bool isStarted; //application is not empty. will not be saved to DB if this is true.
        private bool completed; //application is completed.  can be submitted for review.
        private string applicationID;
        private int totalRanking; //sum of all rankings.
        private int avgRanking; //mean of all rankings.
        private List<Ranking> rankings; //list of all rankings.
        private string lastUpdateDate; //date/time of last edit to application
        private string lastUpdatedBy; //ID of user who last updated.
        private string studentID;
        private string firstName;
        private string lastName;
        private string year; //freshman or sophomore
        private string dateSubmitted;

    }
}
