using Gym_Mngt_System.Backend.Entities;
using Gym_Mngt_System.Backend.Repositories.SessionRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Mngt_System.Backend.Service.Session_Service
{
    class SessionService
    {
        private SessionRepository _sessionRepo = new SessionRepository();
        public IEnumerable<Sessions> GetAllSessions()
        {
            return _sessionRepo.GetAll();
        }
        public void AddSession(Sessions session)
        {
            _sessionRepo.addSession(session);
        }
    }
}
