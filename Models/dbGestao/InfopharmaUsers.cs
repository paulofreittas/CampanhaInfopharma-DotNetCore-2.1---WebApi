using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class InfopharmaUsers
    {
        public string UserName { get; set; }
        public string UserCnpj { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
        public DateTime UserCreateDate { get; set; }
        public DateTime UserLastLogInDate { get; set; }
        public Guid UserId { get; set; }
        public string UserAtivo { get; set; }
    }
}
