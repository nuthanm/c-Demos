using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Demos
{
    [MemoryDiagnoser]
    public class StringOptimization
    {
        private const string maskThisValue = "PottI@2920";

        [Benchmark]
        public string MaskThisValue()
        {
            string maskedValue = maskThisValue.Substring(0, 3);
            int length = maskThisValue.Length - 3;
            for (var i = 0; i < length; i++)
            {
                maskedValue += '*';
            }
            return maskedValue;
            /*
             * Strings are immutable it means creates many number of memories.
            
            |        Method |     Mean |   Error |  StdDev |  Gen 0 | Allocated |
            |-------------- |---------:|--------:|--------:|-------:|----------:|
            | MaskThisValue | 110.4 ns | 2.18 ns | 3.98 ns | 0.0726 |     304 B |

            */
        }

        [Benchmark]
        public string MaskThisValueUsingStringBuilder()
        {
            string maskedValue = maskThisValue.Substring(0, 3);
            int length = maskThisValue.Length - 3;
            
            var sb = new StringBuilder(maskedValue);

            for (var i = 0; i < length; i++)
            {
                sb.Append('*');
            }
            return sb.ToString();
            /*
            |                          Method |      Mean |    Error |   StdDev |   Median |  Gen 0 | Allocated |
|-------------------------------- |----------:|---------:|---------:|---------:|-------:|----------:|
|                   MaskThisValue | 148.20 ns | 8.999 ns | 26.53 ns | 133.5 ns | 0.0725 |     304 B |
| MaskThisValueUsingStringBuilder |  90.54 ns | 8.938 ns | 26.35 ns | 104.5 ns | 0.0440 |     184 B |

            */
        }

        [Benchmark]
        public string MaskThisValueUsingStringObject()
        {
            string maskedValue = maskThisValue.Substring(0, 3);
            int length = maskThisValue.Length - 3;

            var asterics = new string('*', length);
            
            return maskedValue + asterics;

            /*
           
|                          Method |      Mean |    Error |   StdDev |  Gen 0 | Allocated |
|-------------------------------- |----------:|---------:|---------:|-------:|----------:|
|                   MaskThisValue | 210.15 ns | 4.245 ns | 4.889 ns | 0.0725 |     304 B |
| MaskThisValueUsingStringBuilder |  82.66 ns | 1.664 ns | 1.389 ns | 0.0440 |     184 B |
|  MaskThisValueUsingStringObject |  60.61 ns | 1.331 ns | 1.367 ns | 0.0286 |     120 B |

            */
        }

    }
}
