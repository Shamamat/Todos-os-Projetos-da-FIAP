using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiapDonationSystem2
{
    internal class Transacao
    {
        public int IdTransacao { get; set; }
        public DateTime DataCancelamento { get; set; }
        public DateTime DataReserva { get; set; }
        public DateTime DataTroca { get; set; }
    }
}
