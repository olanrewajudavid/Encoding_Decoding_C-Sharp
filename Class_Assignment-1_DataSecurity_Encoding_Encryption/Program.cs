//Assignment-1_DataSecurity_Encoding_Encryption

// Task 1 : Add code that would receive a string from the user through the console
using Class_Assignment_1_DataSecurity_Encoding_Encryption;

Console.WriteLine("\n========================= Task 1 : User Input =========================");
Console.Write("Enter your full name here :=> ");
string fullName = Console.ReadLine();

// Task 2 : BinaryConverter
BinaryConverter base2 = new BinaryConverter();
base2.DisplayHeader();
string binaryData = base2.StringToBinary(fullName);
base2.BinaryToString(binaryData);

// Task 3 : BinaryConverter
HexadecimalConverter base16 = new HexadecimalConverter();
base16.DisplayHeader();
string hexadecimalData = base16.StringToHexadecimal(fullName);
base16.StringToHexadecimal(hexadecimalData);

// Task 4 : BinaryConverter
Base64Converter base64 = new Base64Converter();
base64.DisplayHeader();
string base64Data = base64.StringToBase64(fullName);
base64.StringToBase64(base64Data);

// Task 5 : EncryptDecrypt
EncryptDecrypt encrypted = new EncryptDecrypt();
encrypted.DisplayHeader();
string encryptedData = encrypted.Encrypt(fullName);
encrypted.Decrypt(encryptedData);





