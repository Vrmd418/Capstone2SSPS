using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone2
{
    public class Application
    {

        private bool isStarted; //application is not empty. will not be saved to DB if this is true.

        public bool IsStarted
        {
            get { return isStarted; }
            set { isStarted = value; }
        }
        private bool completed; //application is completed.  can be submitted for review.

        public bool Completed
        {
            get { return completed; }
            set { completed = value; }
        }
        private string applicationID;

        public string ApplicationID
        {
            get { return applicationID; }
            set { applicationID = value; }
        }
        private int totalRanking; //sum of all rankings.

        public int TotalRanking
        {
            get { return totalRanking; }
            set { totalRanking = value; }
        }
        private int avgRanking; //mean of all rankings.

        public int AvgRanking
        {
            get { return avgRanking; }
            set { avgRanking = value; }
        }
        private List<Ranking> rankings; //list of all rankings.

        public List<Ranking> Rankings
        {
            get { return rankings; }
            set { rankings = value; }
        }
        private string lastUpdateDate; //date/time of last edit to application

        public string LastUpdateDate
        {
            get { return lastUpdateDate; }
            set { lastUpdateDate = value; }
        }
        private string lastUpdatedBy; //ID of user who last updated.

        public string LastUpdatedBy
        {
            get { return lastUpdatedBy; }
            set { lastUpdatedBy = value; }
        }
        private string studentID;

        public string StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }
        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        private string year; //freshman or sophomore

        public string Year
        {
            get { return year; }
            set { year = value; }
        }
        private string dateSubmitted;

        public string DateSubmitted
        {
            get { return dateSubmitted; }
            set { dateSubmitted = value; }
        }

    }
}
