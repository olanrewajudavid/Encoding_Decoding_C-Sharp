// Task 2 : Binary Converter
// Encoding : Covert your name to Binary
// Decoding : from Binary to original string

namespace Class_Assignment_1_DataSecurity_Encoding_Encryption
{
    internal class BinaryConverter
    {
        public void DisplayHeader()
        {
            Console.WriteLine("\n===================This is our task 2: Binary Converter =======================\n");
        }

        // Encoding
        public string StringToBinary(string fullName)
        {
            string binaryData = ""; // declare an empty variable

            //iterate through each character of the string
            foreach (char c in fullName)
            {
                string binary = "";
                int AsciiValue = (int)c;   //stores ascii value
                while (AsciiValue > 1)
                {
                    int remainder = AsciiValue % 2;
                    binary = Convert.ToString(remainder) + binary;
                    AsciiValue /= 2;
                }
                binary = Convert.ToString(AsciiValue) + binary;
                binaryData = binaryData + binary.PadLeft(8, '0');
                Console.WriteLine($"ASCII for {c} = {(int)c} Binary = {binary.PadLeft(8, '0')}"); //8 bit data
            }
            Console.WriteLine($"Lengh of string is : {binaryData.Length} = {binaryData}");
            Console.WriteLine($"Binary data = {binaryData}"); //entire binary string

            return binaryData; // return output 
        }

        // Decoding
        public void BinaryToString(string binaryData) // Receives conerted binary Data 
        {
            string result = "";
            for (int i = 0; i < binaryData.Length; i += 8)  // loops through the binary data
            {
                var first8_bits = binaryData.Substring(i, 8); // Captures the first 8 bits
                var number = Convert.ToInt32(first8_bits, 2); // Covert the 8 bits to ascii value
                result += (char)number; // Converts to character value related to the ascii value
            }
            Console.WriteLine($"Binary {binaryData} to string = {result}");
        }
    }
}
