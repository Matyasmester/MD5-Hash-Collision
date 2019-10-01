using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MD5_Hash_Collision
{
    class Main
    {
        public string Encrypt(string pathToFile)
        {
            StringBuilder sb = new StringBuilder();

            const long a = 0x758396b3;
            const long b = 0x5814a7b1;
            const long c = 0xd863462c;
            const long d = 0xdeadbeef;

            List<long> constants = new List<long>()
            {
                a, b, c, d
            };

            string fileContent = File.ReadAllText(@pathToFile); 

            byte[] inputBytes = Encoding.ASCII.GetBytes(fileContent);
            long[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            long f = (b & c) | (negate(b) & d);
            long g = (b & d) | (c & negate(d));
            long h = b ^ c ^ d;
            long i = c ^ (b | negate(d));

            List<long> functionResults = new List<long>
            {
                f,
                g,
                h,
                i
            };

            long[] parts = new long[4];

            for (int j = 0; j < functionResults.Count; j++)
            {

                int bitshift = j + 1;
                parts[j] = moduloWithMaxValue(BitConverter.ToInt64(inputBytes, j * 4) + functionResults[j]);
                parts[j] = parts[j] << bitshift;

                if (numbers.Contains(parts[j]) == true)
                {
                    parts[j] = parts[j] << 2;
                }
                else
                {
                    parts[j] = parts[j] >> 1;
                }

            }
            for (int k = 0; k < parts.Length; k++)
            {
                sb.Append(parts[k].ToString("X2"));
            }
            string computedHash = BitConverter.ToString(inputBytes);
            return sb + "";
        }

        static long negate(long input)
        {
            return 0xffffffff - input;
        }

        static long moduloWithMaxValue(long input)
        {
            long maxvalue = Int32.MaxValue;
            if (input > maxvalue)
            {
                input %= maxvalue;
            }
            return input;
        }
    }
    
}
