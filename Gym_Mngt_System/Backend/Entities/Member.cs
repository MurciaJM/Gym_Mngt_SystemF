using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Mngt_System.Backend.Entities
{
    public class Member
    {
        public int memberID { get; set; }
        public string fname { get; set; } //Change to fname, lname, middle name later.
        public string middle { get; set; }
        public string lname { get; set; }
        public string gender { get; set; }
        public string phonenum { get; set; }
        public byte[] qrCode { get; set; }
        public MembershipType membershipType { get; set; }
        public TrainerPlan planName { get; set; }

        public static MemberBuilder Builder() => new MemberBuilder();
        public string getFullname() => $"{fname} {middle} {lname}";

        public interface IMemberBuilder
        {
            MemberBuilder withMemberID(int memberID);
            MemberBuilder withFname(string fname);
            MemberBuilder withMiddleName(string middle);
            MemberBuilder withLname(string lname);
            MemberBuilder withGender(string gender);
            MemberBuilder withPhonenum(string phonenum);
            MemberBuilder withQrCode(byte[] qrCode);
            MemberBuilder withMembershipType(int membershipType);
            MemberBuilder withTrainerPlan(TrainerPlan planName);
            Member Build();
        }

        public class MemberBuilder : IMemberBuilder
        {
            private Member _member;

            public MemberBuilder()
            {
                _member = new Member();
            }
            public MemberBuilder withMemberID(int memberID)
            {
                _member.memberID = memberID;
                return this;
            }
            public MemberBuilder withFname(string fname)
            {
                _member.fname = fname;
                return this;
            }
            public MemberBuilder withMiddleName(string middle)
            {
                _member.middle = middle;
                return this;
            }
            public MemberBuilder withLname(string lname)
            {
                _member.lname = lname;
                return this;
            }
            public MemberBuilder withGender(string gender)
            {
                _member.gender = gender;
                return this;
            }
            public MemberBuilder withPhonenum(string phonenum)
            {
                _member.phonenum = phonenum;
                return this;
            }
            public MemberBuilder withQrCode(byte[] qrCode)
            {
                _member.qrCode = qrCode;
                return this;
            }
            public MemberBuilder withMembershipType(int membershipType)
            {
                _member.membershipType = new MembershipType
                {
                    membershipTypeID = membershipType
                };
                return this;
            }
            public MemberBuilder withTrainerPlan(TrainerPlan trainerPlan)
            {
                _member.planName = trainerPlan;
                return this;
            }
            public Member Build()
            {
                return _member;
            }
        }
    }
}
