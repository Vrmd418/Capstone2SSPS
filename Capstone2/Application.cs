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

        private string citizenship;

        public string Citizenship
        {
            get { return citizenship; }
            set { citizenship = value; }
        }

        private string contents;

        public string Contents
        {
            get { return contents; }
            set { contents = value; }
        }


        private string mobileNumber;

        public string MobileNumber
        {
            get { return mobileNumber; }
            set { mobileNumber = value; }
        }

        private string year; //TERM

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

        private string isMedicalStudent;

        public string IsMedicalStudent
        {
            get { return isMedicalStudent; }
            set { isMedicalStudent = value; }
        }

        private string question1;

        public string Question1
        {
            get { return question1; }
            set { question1 = value; }
        }

        private string question2;

        public string Question2
        {
            get { return question2; }
            set { question2 = value; }
        }

        private string question3;

        public string Question3
        {
            get { return question3; }
            set { question3 = value; }
        }

        private string question4;

        public string Question4
        {
            get { return question4; }
            set { question4 = value; }
        }

        private string essay1;

        public string Essay1
        {
            get { return essay1; }
            set { essay1 = value; }
        }

        private string essay2;

        public string Essay2
        {
            get { return essay2; }
            set { essay2 = value; }
        }

        private string essay3;

        public string Essay3
        {
            get { return essay3; }
            set { essay3 = value; }
        }



    }
}
