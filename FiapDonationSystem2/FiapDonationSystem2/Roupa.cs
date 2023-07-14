using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiapDonationSystem2.Enum;
using FiapDonationSystem2.Model;

namespace FiapDonationSystem2
{
    internal class Roupa : Produto, IAsyncResult
    {
        public string Material { get; set; }
        public ECategoria Categoria { get; set; }
        public ETamanhoRoupa Tamanho { get; set; }
        public EComprimentoRoupa ComprimentoRoupa { get; set; }

        public object? AsyncState => throw new NotImplementedException();

        public WaitHandle AsyncWaitHandle => throw new NotImplementedException();

        public bool CompletedSynchronously => throw new NotImplementedException();

        public bool IsCompleted => throw new NotImplementedException();
    }
}
