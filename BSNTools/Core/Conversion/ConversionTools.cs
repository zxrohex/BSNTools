using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace BSNTools.Core.Conversion
{
    public class ConversionTools
    {
        public static Dictionary<BigInteger, int> GenerateBinaryTable(string binaryString)
        {
            var binaryTable = new Dictionary<BigInteger, int>();

            BigInteger currentPlaceValue = 1;

            for (int i = binaryString.Length - 1; i >= 0; i--)
            {
                char bitChar = binaryString[i];

                int bitValue;
                if (bitChar == '1')
                {
                    bitValue = 1;
                }
                else if (bitChar == '0')
                {
                    bitValue = 0;
                }
                else
                {
                    throw new ArgumentException($"Invalid character '{bitChar}' found. Input must be binary.");
                }

                binaryTable.Add(currentPlaceValue, bitValue);

                currentPlaceValue <<= 1;
            }

            return binaryTable;
        }
    }
}