using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Capstone2
{
    public class SSPSStudent
    {
        private string studentID;
        private string firstName;
        private string lastName;
        private string major;
        private string gender;
        private string ethnicity;
        private string totalRankings;
        private string birthDate;
        private string scholarshipType;
        private string admitTerm;
        private string degreeType;
        private string nameOfHighSchool;
        private string termID;
        private string studentYearStatus;

        public string StudentYearStatus
        {
            get { return studentYearStatus; }
            set { studentYearStatus = value; }
        }

        public string StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string Major
        {
            get { return major; }
            set { major = value; }
        }
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public string Ethnicity
        {
            get { return ethnicity; }
            set { ethnicity = value; }
        }
        public string TotalRankings
        {
            get { return totalRankings; }
            set { totalRankings = value; }
        }
        public string BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }
        public string ScholarshipType
        {
            get { return scholarshipType; }
            set { scholarshipType = value; }
        }
        public string AdmitTerm
        {
            get { return admitTerm; }
            set { admitTerm = value; }
        }
        public string DegreeType
        {
            get { return degreeType; }
            set { degreeType = value; }
        }
        public string NameOfHighSchool
        {
            get { return nameOfHighSchool; }
            set { nameOfHighSchool = value; }
        }
        public string TermID
        {
            get { return termID; }
            set { termID = value; }
        }
    }
}