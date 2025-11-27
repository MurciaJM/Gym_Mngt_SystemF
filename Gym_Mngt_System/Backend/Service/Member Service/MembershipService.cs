using Gym_Mngt_System.Backend.Entities;
using Gym_Mngt_System.Backend.Repositories.MemberRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Mngt_System.Backend.Service.Member_Service
{
    class MembershipService
    {
        private MembershipRepository _membershipRepository = new MembershipRepository();

        public IEnumerable<Membership> GetAll()
        {
            return _membershipRepository.GetAll();
        }

        public IEnumerable<MembershipType> GetMembershipType()
        {
            return _membershipRepository.GetMembershipType();
        }

        public IEnumerable<MemberLog> MemberLogs()
        {
            return _membershipRepository.MemberLogs();
        }

        public void MemberCheckIn(Membership membership)
        {
            _membershipRepository.MemberCheckIn(membership);
        }

        public int addMembership(Member member)
        {
            return _membershipRepository.addMembership(member);
        }

        public int addMemberWithTrainer(Member member, Staff trainer)
        {
            return _membershipRepository.addMemberWithTrainer(member, trainer);
        }

        public void updateMembership(Member member)
        {
            _membershipRepository.updateMember(member);
        }

        public void insertQrCode(int membershipId, byte[] qrCode)
        {
            _membershipRepository.insertQrCode(membershipId, qrCode);
        }

        public bool qrCodeScanned(long membershipId)
        {
            return _membershipRepository.qrCodeScanned(membershipId);
        }
        // ===== NEW QR CODE METHODS =====

        /// <summary>
        /// Get QR code for a membership
        /// </summary>
        public byte[] GetQrCode(int membershipId)
        {
            return _membershipRepository.GetQrCode(membershipId);
        }

        /// <summary>
        /// Get membership details by ID
        /// </summary>
        public Membership GetMembershipById(int membershipId)
        {
            return _membershipRepository.GetMembershipById(membershipId);
        }

        /// <summary>
        /// Check if QR code exists for membership
        /// </summary>
        public bool QrCodeExists(int membershipId)
        {
            return _membershipRepository.QrCodeExists(membershipId);
        }

        /// <summary>
        /// Update existing QR code
        /// </summary>
        public void UpdateQrCode(int membershipId, byte[] qrCode)
        {
            _membershipRepository.UpdateQrCode(membershipId, qrCode);
        }

        /// <summary>
        /// Validate membership before check-in
        /// </summary>
        public (bool isValid, string message, Membership membership) ValidateMembershipForCheckIn(int membershipId)
        {
            return _membershipRepository.ValidateMembershipForCheckIn(membershipId);
        }
    }
}
