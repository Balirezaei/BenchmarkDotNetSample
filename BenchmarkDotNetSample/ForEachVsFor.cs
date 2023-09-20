using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Reports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenchmarkDotNetSample
{

    [MemoryDiagnoser]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class ForEachVsFor
    {
      
        [Benchmark(Baseline = true)]
        public void ForEachAsync()
        {
            var i = 0;
            foreach (var item in Enumerable.Range(0, 1000000))
            {
                i++;
            }

        }


        [Benchmark]
        public void ForAsync()
        {
            var i = 0;
            for (var j = 0; j <= 1000000; j++)
            {
                i++;
            }

        }

    }
}
