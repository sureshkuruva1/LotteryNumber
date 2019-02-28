using NumberGeneratorApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGeneratorApi.Models
{
    public interface INumberGeneratorRepository
    {
        NumberGeneratorResponse Generate(NumberGeneratorRequest request);
    }
}
