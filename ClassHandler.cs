using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;   

namespace MediaT_R
{
    class ClassExampleHandler : IRequestHandler<ClassABC, ClassDEF>
    {
        public async Task<ClassDEF> Handle(ClassABC request, CancellationToken cancellationToken)
        {
            ClassDEF response = new ClassDEF();
            response.OutPutMessage = $"Using mediatR {request.Text}";
            return response;
        }
    }
}
