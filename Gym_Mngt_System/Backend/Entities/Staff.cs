using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Mngt_System.Backend.Entities
{
    public class Staff
    {
        public int StaffID { get; set; }
        public string fname { get; set; }
        public string middle { get; set; }
        public string lname { get; set; }
        public DateTime birthdate { get; set; }
        public string gender { get; set; }
        public string phoneNumber { get; set; }
        public string position { get; set; }
        public DateTime hiredDate { get; set; }
        public string scheduleDate { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get;set; }
        public string status { get; set; }
        public Image image { get; set; }
        public Account account { get; set; }
        public List<Member> memberWithTrainer { get; set; } = new List<Member>();
        public string availedMemberPlan { get; set; }
        public static StaffBuilder Builder() => new StaffBuilder();
        public string getFullname() => $"{fname} {middle} {lname}";
        public string FullName => $"{fname} {middle} {lname}".Replace("  ", " ");
        public string FormattedBirthdate() => birthdate.ToString("yyyy-MM-dd");
        public string FormattedHiredDate() => hiredDate.ToString("yyyy-MM-dd");
        public interface IStaffBuilder
        {
            StaffBuilder withStaffID(int staffID);
            StaffBuilder withFname(string fname);
            StaffBuilder withMiddleName(string middle);
            StaffBuilder withLname(string lname);
            StaffBuilder withBirthdate(DateTime birthdate);
            StaffBuilder withGender(string gender);
            StaffBuilder withPhoneNumber(string phoneNum);
            StaffBuilder withPosition(string position);
            StaffBuilder withHiredDate(DateTime hiredDate);
            StaffBuilder withScheduleDate(string scheduleDate);
            StaffBuilder withStartTime(DateTime startTime);
            StaffBuilder withEndTime(DateTime endTime);
            StaffBuilder withStatus(string status);
            StaffBuilder withImage(Image image);
            StaffBuilder withAccount(string username, string password);
            StaffBuilder withMemberTrainer(List<Member> member);
            Staff Build();
        }



        public class StaffBuilder : IStaffBuilder
        {
            private Staff _staff;

            public StaffBuilder()
            {
                _staff = new Staff();
            }
            public StaffBuilder withStaffID(int staffID)
            {
                _staff.StaffID = staffID;
                return this;
            }
            public StaffBuilder withFname(string fname)
            {
                _staff.fname = fname;
                return this;
            }
            public StaffBuilder withMiddleName(string middle)
            {
                _staff.middle = middle;
                return this;
            }
            public StaffBuilder withLname(string lname)
            {
                _staff.lname = lname;
                return this;
            }
            public StaffBuilder withBirthdate(DateTime birthdate)
            {
                _staff.birthdate = birthdate;
                return this;
            }
            public StaffBuilder withGender(string gender)
            {
                _staff.gender = gender;
                return this;
            }
            public StaffBuilder withPhoneNumber(string phoneNum)
            {
                _staff.phoneNumber = phoneNum;
                return this;
            }
            public StaffBuilder withPosition(string position)
            {
                _staff.position = position;
                return this;
            }
            public StaffBuilder withHiredDate(DateTime hiredDate)
            {
                _staff.hiredDate = hiredDate;
                return this;
            }
            public StaffBuilder withScheduleDate(string scheduleDate)
            {
                _staff.scheduleDate = scheduleDate;
                return this;
            }
            public StaffBuilder withStartTime(DateTime startTime)
            {
                _staff.startTime = startTime;
                return this;
            }
            public StaffBuilder withEndTime(DateTime endTime)
            {
                _staff.endTime = endTime;
                return this;
            }
            public StaffBuilder withStatus(string status)
            {
                _staff.status = status;
                return this;
            }
            public StaffBuilder withMemberTrainer(List<Member> member)
            {
                _staff.memberWithTrainer = member;
                return this;
            }
            public StaffBuilder withAccount(string username, string password)
            {
                _staff.account = new Account
                {
                    Username = username,
                    Password = password
                };
                return this;
            }
            public StaffBuilder withImage(Image image)
            {
                _staff.image = image;
                return this;
            }
            public Staff Build()
            {
                return _staff;
            }
        }
    }
}
