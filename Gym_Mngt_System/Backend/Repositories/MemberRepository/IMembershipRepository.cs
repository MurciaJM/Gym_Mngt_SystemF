using Gym_Mngt_System.Backend.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Mngt_System.Backend.Repositories.MemberRepository
{
    interface IMembershipRepository
    {
        IEnumerable<Membership> GetAll();
        IEnumerable<MembershipType> GetMembershipType();
        IEnumerable<MemberLog> MemberLogs();
        void MemberCheckIn(Membership membershipId);
        int addMembership(Member member);
        int addMemberWithTrainer(Member member, Staff trainer);
        void insertQrCode(int membershipId, byte[] qrCode);
        void updateMember(Member member);
        bool qrCodeScanned(long membershipId);
        byte[] GetQrCode(int membershipId);
        Membership GetMembershipById(int membershipId);
        bool QrCodeExists(int membershipId);
        void UpdateQrCode(int membershipId, byte[] qrCode);
        (bool isValid, string message, Membership membership) ValidateMembershipForCheckIn(int membershipId);
    }
}
