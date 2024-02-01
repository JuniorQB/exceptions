using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TratamentoExcecao.Entities.Exepetions
{
    class DomainExeption : ApplicationException
    {
            
        public DomainExeption(string message) : base(message) { }

    }
}
