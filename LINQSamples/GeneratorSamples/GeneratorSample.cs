using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQSampels.GeneratorSamples
{
    public class GeneratorSample
    {
        public void Generators()
        {
            var numbers = Enumerable.Range(0, 100).ToList();

            var emptynumber = Enumerable.Empty<int>().ToList();

            var repeatnumber = Enumerable.Repeat(0, 100).ToList();
        }
    }
}
