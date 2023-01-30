using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace MediaT_R
{
    class ClassABC : IRequest<ClassDEF>
    {
        public string Text { get; set; }
        public void SendCommand()
        {

        }
    }
}
