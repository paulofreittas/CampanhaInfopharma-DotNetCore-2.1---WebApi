using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class AspnetUsers
    {
        public AspnetUsers()
        {
            Propostausuario = new HashSet<Propostausuario>();
        }

        public Guid ApplicationId { get; set; }
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string LoweredUserName { get; set; }
        public string MobileAlias { get; set; }
        public bool IsAnonymous { get; set; }
        public DateTime LastActivityDate { get; set; }

        public AspnetApplications Application { get; set; }
        public ICollection<Propostausuario> Propostausuario { get; set; }
    }
}
