using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiapDonationSystem2.Model
{
    internal interface IAtutenticavel
    {
        public bool Autenticar(string username, string password);
    }
}
