using BenchmarkDotNet.Attributes;
using System.Text;

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

        [Benchmark]
        public string MaskThisValueUsingStringCreate()
        {
            return String.Create(maskThisValue.Length, maskThisValue, (span, value) =>
            {
                // span has number of array locations and this based on maskThisValue Length
                value.AsSpan().CopyTo(span);
                // After the above statement span has actual values copied from value.
                // AsSpan is casting one
                span[3..].Fill('*'); // from 3rd location we are filling '*' to the span value.
            });
            /*
           
|                          Method |      Mean |    Error |    StdDev |    Median |  Gen 0 | Allocated |
|-------------------------------- |----------:|---------:|----------:|----------:|-------:|----------:|
|                   MaskThisValue | 214.24 ns | 8.867 ns | 25.153 ns | 206.06 ns | 0.0725 |     304 B |
| MaskThisValueUsingStringBuilder |  61.70 ns | 2.256 ns |  6.099 ns |  59.58 ns | 0.0440 |     184 B |
|  MaskThisValueUsingStringObject |  42.84 ns | 0.931 ns |  1.394 ns |  43.03 ns | 0.0287 |     120 B |
|  MaskThisValueUsingStringCreate |  16.49 ns | 0.425 ns |  0.637 ns |  16.50 ns | 0.0115 |      48 B |

            */
        }

    }
}
