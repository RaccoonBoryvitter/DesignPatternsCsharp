using Proxy.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy.Models
{
    internal class Manager
    {

        public Guid Id { get; set; } = Guid.NewGuid();

        public string Login { get; set; }

        public string Password { get; set; }

        public ManagerPermissions Permissions { get; set; }

    }
}
