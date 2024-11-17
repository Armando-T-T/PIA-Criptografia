using System;
using System.Linq;

namespace PIA_Criptografia
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("=== Menú Principal ===");
                Console.WriteLine("1. Encriptación");
                Console.WriteLine("2. Mostrar datos del autor");
                Console.WriteLine("3. Imprimir código fuente");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        ShowEncryptionMenu();
                        break;
                    case "2":
                        ShowAuthorInfo();
                        break;
                    case "3":
                        PrintSourceCode();
                        break;
                    case "4":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Presione Enter para intentar nuevamente.");
                        Console.ReadLine();
                        break;
                }
            }
        }

        static void ShowEncryptionMenu()
        {
            Console.Clear();
            Console.WriteLine("=== Menú de Encriptación ===");
            Console.WriteLine("1. Transposición");
            Console.WriteLine("2. Vigenere");
            Console.WriteLine("3. Volver al Menú Principal");
            Console.Write("Seleccione una opción: ");

            switch (Console.ReadLine())
            {
                case "1":
                    ShowTranspositionMenu();
                    break;
                case "2":
                    ShowVigenereMenu();
                    break;
                case "3":
                    break;
                default:
                    Console.WriteLine("Opción no válida. Presione Enter para intentar nuevamente.");
                    Console.ReadLine();
                    break;
            }
        }

        static void ShowAuthorInfo()
        {
            Console.Clear();
            Console.WriteLine("=== Información del Autor ===");
            Console.WriteLine("Nombre: Armando Torres Treviño");
            Console.WriteLine("Matricula: 1993724");
            Console.WriteLine("\nDescripción del Proyecto:");
            Console.WriteLine("Este proyecto es un sistema de encriptación en C# que permite encriptar y desencriptar mensajes utilizando dos técnicas clásicas de cifrado: ");
            Console.WriteLine("\n1. **Cifrado de Vigenere**: Esta técnica utiliza una clave repetida para desplazar cada letra del mensaje según el valor de la letra correspondiente de la clave, formando un texto cifrado. Para desencriptar, el mismo proceso se invierte.");
            Console.WriteLine("\n2. **Transposición Tabular con Clave**: Este método organiza el mensaje en una tabla de columnas que depende de la clave, y las columnas se reordenan alfabéticamente según la clave. Esto cambia el orden de los caracteres en el mensaje. Para desencriptar, se sigue el proceso inverso.");
            Console.WriteLine("\nAmbos métodos son útiles para ver cómo funcionan diferentes enfoques de encriptación, uno sustituyendo letras (Vigenere) y otro reordenándolas (Transposición).");
            Console.WriteLine("\nPresione Enter para continuar.");
            Console.ReadLine();
        }

        static void PrintSourceCode()
        {

            Console.Clear();
            // Importaciones


            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("=== Información del Autor ===");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Nombre: Armando Torres Treviño");
            Console.WriteLine("Matricula: 1993724");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("=== Codigo Fuente ===");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("using System;");
            Console.WriteLine("using System.Linq;");
            Console.ResetColor();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("namespace PIA_Criptografia");
            Console.WriteLine("{");
            Console.WriteLine("    class Program");
            Console.WriteLine("    {");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("        static void Main(string[] args)");
            Console.WriteLine("        {");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("            bool exit = false;");
            Console.WriteLine();
            Console.WriteLine("            while (!exit)");
            Console.WriteLine("            {");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("                Console.Clear();");
            Console.WriteLine("                Console.WriteLine(\"=== Menú Principal ===\");");
            Console.WriteLine("                Console.WriteLine(\"1. Encriptación\");");
            Console.WriteLine("                Console.WriteLine(\"2. Mostrar datos del autor\");");
            Console.WriteLine("                Console.WriteLine(\"3. Imprimir código fuente\");");
            Console.WriteLine("                Console.WriteLine(\"4. Salir\");");
            Console.WriteLine("                Console.Write(\"Seleccione una opción: \");");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("                switch (Console.ReadLine())");
            Console.WriteLine("                {");
            Console.WriteLine("                    case '1':");
            Console.WriteLine("                        ShowEncryptionMenu();");
            Console.WriteLine("                        break;");
            Console.WriteLine("                    case '2':");
            Console.WriteLine("                        ShowAuthorInfo();");
            Console.WriteLine("                        break;");
            Console.WriteLine("                    case '3':");
            Console.WriteLine("                        PrintSourceCode();");
            Console.WriteLine("                        break;");
            Console.WriteLine("                    case '4':");
            Console.WriteLine("                        exit = true;");
            Console.WriteLine("                        break;");
            Console.WriteLine("                    default:");
            Console.WriteLine("                        Console.WriteLine(\"Opción no válida. Presione Enter para intentar nuevamente.\");");
            Console.WriteLine("                        Console.ReadLine();");
            Console.WriteLine("                        break;");
            Console.WriteLine("                }");
            Console.WriteLine("            }");
            Console.WriteLine("        }");

            // Método ShowEncryptionMenu
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("        static void ShowEncryptionMenu()");
            Console.WriteLine("        {");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("            Console.Clear();");
            Console.WriteLine("            Console.WriteLine(\"=== Menú de Encriptación ===\");");
            Console.WriteLine("            Console.WriteLine(\"1. Transposición\");");
            Console.WriteLine("            Console.WriteLine(\"2. Vigenere\");");
            Console.WriteLine("            Console.WriteLine(\"3. Volver al Menú Principal\");");
            Console.WriteLine("            Console.Write(\"Seleccione una opción: \");");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("            switch (Console.ReadLine())");
            Console.WriteLine("            {");
            Console.WriteLine("                case '1':");
            Console.WriteLine("                    ShowTranspositionMenu();");
            Console.WriteLine("                    break;");
            Console.WriteLine("                case '2':");
            Console.WriteLine("                    ShowVigenereMenu();");
            Console.WriteLine("                    break;");
            Console.WriteLine("                case '3':");
            Console.WriteLine("                    break;");
            Console.WriteLine("                default:");
            Console.WriteLine("                    Console.WriteLine(\"Opción no válida. Presione Enter para intentar nuevamente.\");");
            Console.WriteLine("                    Console.ReadLine();");
            Console.WriteLine("                    break;");
            Console.WriteLine("            }");
            Console.WriteLine("        }");

            // Método ShowAuthorInfo
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("        static void ShowAuthorInfo()");
            Console.WriteLine("        {");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("            Console.Clear();");
            Console.WriteLine("            Console.WriteLine(\"=== Información del Autor ===\");");
            Console.WriteLine("            Console.WriteLine(\"Nombre: Armando Torres Treviño\");");
            Console.WriteLine("            Console.WriteLine(\"Matricula: 1993724\");");
            Console.WriteLine("            Console.WriteLine(\"\\nDescripción del Proyecto:\");");
            Console.WriteLine("            Console.WriteLine(\"Este proyecto es un sistema de encriptación en C# que permite encriptar y desencriptar mensajes utilizando dos técnicas clásicas de cifrado:\");");
            Console.WriteLine("            Console.WriteLine(\"\\n1. **Cifrado de Vigenere**: Esta técnica utiliza una clave repetida para desplazar cada letra del mensaje...\");");
            Console.WriteLine("            Console.WriteLine(\"\\n2. **Transposición Tabular con Clave**: Este método organiza el mensaje en una tabla de columnas que depende de la clave...\");");
            Console.WriteLine("            Console.WriteLine(\"\\nAmbos métodos son útiles para ver cómo funcionan diferentes enfoques de encriptación, uno sustituyendo letras y otro reordenándolas.\");");
            Console.WriteLine("            Console.WriteLine(\"\\nPresione Enter para continuar.\");");
            Console.WriteLine("            Console.ReadLine();");
            Console.WriteLine("        }");

            // Método PrintSourceCode (vacío, esperando implementación)
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("        static void PrintSourceCode()");
            Console.WriteLine("        {");
            Console.WriteLine("            // Implementación pendiente");
            Console.WriteLine("        }");

            // Método ShowVigenereMenu
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("        static void ShowVigenereMenu()");
            Console.WriteLine("        {");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("            Console.Clear();");
            Console.WriteLine("            Console.WriteLine(\"=== Cifrado Vigenere ===\");");
            Console.WriteLine("            Console.WriteLine(\"1. Encriptar\");");
            Console.WriteLine("            Console.WriteLine(\"2. Desencriptar\");");
            Console.WriteLine("            Console.WriteLine(\"3. Volver al Menú de Encriptación\");");
            Console.WriteLine("            Console.Write(\"Seleccione una opción: \");");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("            switch (Console.ReadLine())");
            Console.WriteLine("            {");
            Console.WriteLine("                case '1':");
            Console.WriteLine("                    VigenereEncrypt();");
            Console.WriteLine("                    break;");
            Console.WriteLine("                case '2':");
            Console.WriteLine("                    VigenereDecrypt();");
            Console.WriteLine("                    break;");
            Console.WriteLine("                case '3':");
            Console.WriteLine("                    break;");
            Console.WriteLine("                default:");
            Console.WriteLine("                    Console.WriteLine(\"Opción no válida. Presione Enter para intentar nuevamente.\");");
            Console.WriteLine("                    Console.ReadLine();");
            Console.WriteLine("                    break;");
            Console.WriteLine("            }");
            Console.WriteLine("        }");

            // Método VigenereEncrypt
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("        static void VigenereEncrypt()");
            Console.WriteLine("        {");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("            Console.Clear();");
            Console.WriteLine("            Console.WriteLine(\"=== Vigenere - Encriptación ===\");");
            Console.WriteLine("            Console.Write(\"Ingrese el mensaje a encriptar: \");");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("            string message = Console.ReadLine().ToUpper();");
            Console.WriteLine("            Console.Write(\"Ingrese la clave: \");");
            Console.WriteLine("            string key = Console.ReadLine().ToUpper();");
            Console.WriteLine("            Console.Write(\"Ingrese el alfabeto a utilizar (por ejemplo, ABCDEFGHIJKLMNOPQRSTUVWXYZ): \");");
            Console.WriteLine("            string alphabet = Console.ReadLine().ToUpper();");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("            string encryptedMessage = VigenereCipherEncrypt(message, key, alphabet);");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("            Console.WriteLine($\"\\nMensaje encriptado: {encryptedMessage}\");");
            Console.WriteLine("            Console.WriteLine(\"Presione Enter para continuar.\");");
            Console.WriteLine("            Console.ReadLine();");
            Console.WriteLine("        }");

            // Método VigenereCipherEncrypt
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("        static string VigenereCipherEncrypt(string message, string key, string alphabet)");
            Console.WriteLine("        {");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("            string result = \"\";");
            Console.WriteLine("            int alphabetLength = alphabet.Length;");
            Console.WriteLine("            string extendedKey = ExtendKey(key, message.Length);");

            Console.WriteLine("            for (int i = 0; i < message.Length; i++)");
            Console.WriteLine("            {");
            Console.WriteLine("                char messageChar = message[i];");
            Console.WriteLine("                char keyChar = extendedKey[i];");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("                if (alphabet.Contains(messageChar))");
            Console.WriteLine("                {");
            Console.WriteLine("                    int messageIndex = alphabet.IndexOf(messageChar);");
            Console.WriteLine("                    int keyIndex = alphabet.IndexOf(keyChar);");
            Console.WriteLine("                    int encryptedIndex = (messageIndex + keyIndex) % alphabetLength;");
            Console.WriteLine("                    result += alphabet[encryptedIndex];");
            Console.WriteLine("                }");
            Console.WriteLine("                else");
            Console.WriteLine("                {");
            Console.WriteLine("                    result += messageChar;");
            Console.WriteLine("                }");
            Console.WriteLine("            }");
            Console.WriteLine("            return result;");
            Console.WriteLine("        }");

            Console.ResetColor();



            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("      static void VigenereDecrypt()");
            Console.WriteLine("     {");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("         Console.Clear();");
            Console.WriteLine("         Console.WriteLine(\"=== Vigenere - Desencriptación ===\");");
            Console.WriteLine("         Console.Write(\"Ingrese el mensaje a desencriptar: \");");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("         string encryptedMessage = Console.ReadLine().ToUpper();");
            Console.WriteLine("         Console.Write(\"Ingrese la clave: \");");
            Console.WriteLine("         string key = Console.ReadLine().ToUpper();");
            Console.WriteLine("         Console.Write(\"Ingrese el alfabeto a utilizar (por ejemplo, ABCDEFGHIJKLMNOPQRSTUVWXYZ): \");");
            Console.WriteLine("         string alphabet = Console.ReadLine().ToUpper();");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("         string decryptedMessage = VigenereCipherDecrypt(encryptedMessage, key, alphabet);");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("         Console.WriteLine($\"\\nMensaje desencriptado: {decryptedMessage}\");");
            Console.WriteLine("         Console.WriteLine(\"Presione Enter para continuar.\");");
            Console.WriteLine("         Console.ReadLine();");
            Console.WriteLine("     }");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("     static string VigenereCipherDecrypt(string encryptedMessage, string key, string alphabet)");
            Console.WriteLine("     {");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("         string result = \"\";");
            Console.WriteLine("         int alphabetLength = alphabet.Length;");
            Console.WriteLine();
            Console.WriteLine("         string extendedKey = ExtendKey(key, encryptedMessage.Length);");
            Console.WriteLine();
            Console.WriteLine("         for (int i = 0; i < encryptedMessage.Length; i++)");
            Console.WriteLine("         {");
            Console.WriteLine("             char encryptedChar = encryptedMessage[i];");
            Console.WriteLine("             char keyChar = extendedKey[i];");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("             if (alphabet.Contains(encryptedChar))");
            Console.WriteLine("             {");
            Console.WriteLine("                 int encryptedIndex = alphabet.IndexOf(encryptedChar);");
            Console.WriteLine("                 int keyIndex = alphabet.IndexOf(keyChar);");
            Console.WriteLine("                 int decryptedIndex = (encryptedIndex - keyIndex + alphabetLength) % alphabetLength;");
            Console.WriteLine("                 result += alphabet[decryptedIndex];");
            Console.WriteLine("             }");
            Console.WriteLine("             else");
            Console.WriteLine("             {");
            Console.WriteLine("                 result += encryptedChar;");
            Console.WriteLine("                }");
            Console.WriteLine("         }");
            Console.WriteLine();
            Console.WriteLine("         return result;");
            Console.WriteLine("     }");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("     static string ExtendKey(string key, int length)");
            Console.WriteLine("     {");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("         if (key.Length >= length)");
            Console.WriteLine("         {");
            Console.WriteLine("             return key.Substring(0, length);");
            Console.WriteLine("         }");
            Console.WriteLine("         else");
            Console.WriteLine("         {");
            Console.WriteLine("             string extendedKey = key;");
            Console.WriteLine("             while (extendedKey.Length < length)");
            Console.WriteLine("             {");
            Console.WriteLine("                 extendedKey += key;");
            Console.WriteLine("             }");
            Console.WriteLine("             return extendedKey.Substring(0, length);");
            Console.WriteLine("         }");
            Console.WriteLine("     }");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("     static void ShowTranspositionMenu()");
            Console.WriteLine("     {");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("         Console.Clear();");
            Console.WriteLine("         Console.WriteLine(\"=== Cifrado Transposición ===\");");
            Console.WriteLine("         Console.WriteLine(\"1. Encriptar\");");
            Console.WriteLine("         Console.WriteLine(\"2. Desencriptar\");");
            Console.WriteLine("         Console.WriteLine(\"3. Volver al Menú de Encriptación\");");
            Console.WriteLine("         Console.Write(\"Seleccione una opción: \");");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("         switch (Console.ReadLine())");
            Console.WriteLine("         {");
            Console.WriteLine("             case \"1\":");
            Console.WriteLine("                 TranspositionEncryptWithKey();");
            Console.WriteLine("                 break;");
            Console.WriteLine("             case \"2\":");
            Console.WriteLine("                 TranspositionDecryptWithKey();");
            Console.WriteLine("                 break;");
            Console.WriteLine("             case \"3\":");
            Console.WriteLine("                 break;");
            Console.WriteLine("             default:");
            Console.WriteLine("                 Console.WriteLine(\"Opción no válida. Presione Enter para intentar nuevamente.\");");
            Console.WriteLine("                 Console.ReadLine();");
            Console.WriteLine("                 break;");
            Console.WriteLine("         }");
            Console.WriteLine("     }");
            Console.ResetColor();





            // Método TranspositionEncryptWithKey
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("        static void TranspositionEncryptWithKey()");
            Console.WriteLine("        {");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("            Console.Clear();");
            Console.WriteLine("            Console.WriteLine(\"=== Transposición Tabular con Clave - Encriptación ===\");");
            Console.WriteLine("            Console.Write(\"Ingrese el mensaje a encriptar: \");");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("            string message = Console.ReadLine().Replace(\" \", \"\").ToUpper(); // Eliminamos espacios y convertimos a mayúsculas");
            Console.WriteLine("            Console.Write(\"Ingrese la clave: \");");
            Console.WriteLine("            string key = Console.ReadLine().ToUpper();");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("            string encryptedMessage = TranspositionCipherEncryptWithKey(message, key);");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("            Console.WriteLine($\"\\nMensaje encriptado: {encryptedMessage}\");");
            Console.WriteLine("            Console.WriteLine(\"Presione Enter para continuar.\");");
            Console.WriteLine("            Console.ReadLine();");
            Console.WriteLine("        }");

            // Método TranspositionCipherEncryptWithKey
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("        static string TranspositionCipherEncryptWithKey(string message, string key)");
            Console.WriteLine("        {");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("            int columns = key.Length;");
            Console.WriteLine("            int rows = (int)Math.Ceiling((double)message.Length / columns);");
            Console.WriteLine("            message = message.PadRight(rows * columns, 'A');");

            Console.WriteLine("            char[,] grid = new char[rows, columns];");
            Console.WriteLine("            int index = 0;");
            Console.WriteLine("            for (int row = 0; row < rows; row++)");
            Console.WriteLine("            {");
            Console.WriteLine("                for (int col = 0; col < columns; col++)");
            Console.WriteLine("                {");
            Console.WriteLine("                    grid[row, col] = message[index++];");
            Console.WriteLine("                }");
            Console.WriteLine("            }");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("            int[] columnOrder = key");
            Console.WriteLine("                .Select((ch, i) => new { Char = ch, Index = i })");
            Console.WriteLine("                .OrderBy(x => x.Char)");
            Console.WriteLine("                .Select(x => x.Index)");
            Console.WriteLine("                .ToArray();");

            Console.WriteLine("            string result = \"\";");
            Console.WriteLine("            foreach (int col in columnOrder)");
            Console.WriteLine("            {");
            Console.WriteLine("                for (int row = 0; row < rows; row++)");
            Console.WriteLine("                {");
            Console.WriteLine("                    result += grid[row, col];");
            Console.WriteLine("                }");
            Console.WriteLine("            }");

            Console.WriteLine("            return result;");
            Console.WriteLine("        }");

            // Método TranspositionDecryptWithKey
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("        static void TranspositionDecryptWithKey()");
            Console.WriteLine("        {");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("            Console.Clear();");
            Console.WriteLine("            Console.WriteLine(\"=== Transposición Tabular con Clave - Desencriptación ===\");");
            Console.WriteLine("            Console.Write(\"Ingrese el mensaje encriptado: \");");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("            string encryptedMessage = Console.ReadLine().Replace(\" \", \"\").ToUpper();");
            Console.WriteLine("            Console.Write(\"Ingrese la clave: \");");
            Console.WriteLine("            string key = Console.ReadLine().ToUpper();");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("            string decryptedMessage = TranspositionCipherDecryptWithKey(encryptedMessage, key);");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("            Console.WriteLine($\"\\nMensaje desencriptado: {decryptedMessage}\");");
            Console.WriteLine("            Console.WriteLine(\"Presione Enter para continuar.\");");
            Console.WriteLine("            Console.ReadLine();");
            Console.WriteLine("        }");

            // Método TranspositionCipherDecryptWithKey
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("        static string TranspositionCipherDecryptWithKey(string encryptedMessage, string key)");
            Console.WriteLine("        {");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("            int columns = key.Length;");
            Console.WriteLine("            int rows = (int)Math.Ceiling((double)encryptedMessage.Length / columns);");

            Console.WriteLine("            int[] columnOrder = key");
            Console.WriteLine("                .Select((ch, i) => new { Char = ch, Index = i })");
            Console.WriteLine("                .OrderBy(x => x.Char)");
            Console.WriteLine("                .Select(x => x.Index)");
            Console.WriteLine("                .ToArray();");

            Console.WriteLine("            char[,] grid = new char[rows, columns];");
            Console.WriteLine("            int index = 0;");
            Console.WriteLine("            foreach (int col in columnOrder)");
            Console.WriteLine("            {");
            Console.WriteLine("                for (int row = 0; row < rows; row++)");
            Console.WriteLine("                {");
            Console.WriteLine("                    if (index < encryptedMessage.Length)");
            Console.WriteLine("                    {");
            Console.WriteLine("                        grid[row, col] = encryptedMessage[index++];");
            Console.WriteLine("                    }");
            Console.WriteLine("                }");
            Console.WriteLine("            }");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("            string result = \"\";");
            Console.WriteLine("            for (int row = 0; row < rows; row++)");
            Console.WriteLine("            {");
            Console.WriteLine("                for (int col = 0; col < columns; col++)");
            Console.WriteLine("                {");
            Console.WriteLine("                    result += grid[row, col];");
            Console.WriteLine("                }");
            Console.WriteLine("            }");

            Console.WriteLine("            return result.TrimEnd('A'); // Elimina caracteres de relleno si los hay");
            Console.WriteLine("        }");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("\nPresione Enter para continuar.");
            Console.ReadLine();

        }

        static void ShowVigenereMenu()
        {
            Console.Clear();
            Console.WriteLine("=== Cifrado Vigenere ===");
            Console.WriteLine("1. Encriptar");
            Console.WriteLine("2. Desencriptar");
            Console.WriteLine("3. Volver al Menú de Encriptación");
            Console.Write("Seleccione una opción: ");

            switch (Console.ReadLine())
            {
                case "1":
                    VigenereEncrypt();
                    break;
                case "2":
                    VigenereDecrypt();
                    break;
                case "3":
                    break;
                default:
                    Console.WriteLine("Opción no válida. Presione Enter para intentar nuevamente.");
                    Console.ReadLine();
                    break;
            }
        }

        static void VigenereEncrypt()
        {
            Console.Clear();
            Console.WriteLine("=== Vigenere - Encriptación ===");
            Console.Write("Ingrese el mensaje a encriptar: ");
            string message = Console.ReadLine().ToUpper();
            Console.Write("Ingrese la clave: ");
            string key = Console.ReadLine().ToUpper();
            Console.Write("Ingrese el alfabeto a utilizar (por ejemplo, ABCDEFGHIJKLMNOPQRSTUVWXYZ): ");
            string alphabet = Console.ReadLine().ToUpper();

            string encryptedMessage = VigenereCipherEncrypt(message, key, alphabet);

            Console.WriteLine($"\nMensaje encriptado: {encryptedMessage}");
            Console.WriteLine("Presione Enter para continuar.");
            Console.ReadLine();
        }

        static string VigenereCipherEncrypt(string message, string key, string alphabet)
        {
            string result = "";
            int alphabetLength = alphabet.Length;

            // Ajuste de la clave para que tenga la misma longitud que el mensaje
            string extendedKey = ExtendKey(key, message.Length);

            for (int i = 0; i < message.Length; i++)
            {
                char messageChar = message[i];
                char keyChar = extendedKey[i];

                // Verificamos si el carácter del mensaje está en el alfabeto
                if (alphabet.Contains(messageChar))
                {
                    int messageIndex = alphabet.IndexOf(messageChar);
                    int keyIndex = alphabet.IndexOf(keyChar);

                    // Cálculo de la posición encriptada y envoltura
                    int encryptedIndex = (messageIndex + keyIndex) % alphabetLength;
                    result += alphabet[encryptedIndex];
                }
                else
                {
                    // Si el carácter no está en el alfabeto, lo añadimos tal cual
                    result += messageChar;
                }
            }

            return result;
        }

        static void VigenereDecrypt()
        {
            Console.Clear();
            Console.WriteLine("=== Vigenere - Desencriptación ===");
            Console.Write("Ingrese el mensaje a desencriptar: ");
            string encryptedMessage = Console.ReadLine().ToUpper();
            Console.Write("Ingrese la clave: ");
            string key = Console.ReadLine().ToUpper();
            Console.Write("Ingrese el alfabeto a utilizar (por ejemplo, ABCDEFGHIJKLMNOPQRSTUVWXYZ): ");
            string alphabet = Console.ReadLine().ToUpper();

            string decryptedMessage = VigenereCipherDecrypt(encryptedMessage, key, alphabet);

            Console.WriteLine($"\nMensaje desencriptado: {decryptedMessage}");
            Console.WriteLine("Presione Enter para continuar.");
            Console.ReadLine();
        }

        static string VigenereCipherDecrypt(string encryptedMessage, string key, string alphabet)
        {
            string result = "";
            int alphabetLength = alphabet.Length;

            // Extender la clave a la longitud del mensaje cifrado
            string extendedKey = ExtendKey(key, encryptedMessage.Length);

            for (int i = 0; i < encryptedMessage.Length; i++)
            {
                char encryptedChar = encryptedMessage[i];
                char keyChar = extendedKey[i];

                // Verificamos si el carácter encriptado está en el alfabeto
                if (alphabet.Contains(encryptedChar))
                {
                    int encryptedIndex = alphabet.IndexOf(encryptedChar);
                    int keyIndex = alphabet.IndexOf(keyChar);

                    // Cálculo de la posición desencriptada y envoltura
                    int decryptedIndex = (encryptedIndex - keyIndex + alphabetLength) % alphabetLength;
                    result += alphabet[decryptedIndex];
                }
                else
                {
                    // Si el carácter no está en el alfabeto, lo añadimos tal cual
                    result += encryptedChar;
                }
            }

            return result;
        }

        // Función para extender la clave a la longitud del mensaje
        static string ExtendKey(string key, int length)
        {
            // Repetir la clave hasta que iguale o exceda la longitud deseada, y luego truncarla
            if (key.Length >= length)
            {
                return key.Substring(0, length);
            }
            else
            {
                string extendedKey = key;
                while (extendedKey.Length < length)
                {
                    extendedKey += key;
                }
                return extendedKey.Substring(0, length);
            }
        }

        static void ShowTranspositionMenu()
        {
            Console.Clear();
            Console.WriteLine("=== Cifrado Trasnposicion ===");
            Console.WriteLine("1. Encriptar");
            Console.WriteLine("2. Desencriptar");
            Console.WriteLine("3. Volver al Menú de Encriptación");
            Console.Write("Seleccione una opción: ");

            switch (Console.ReadLine())
            {
                case "1":
                    TranspositionEncryptWithKey();
                    break;
                case "2":
                    TranspositionDecryptWithKey();
                    break;
                case "3":
                    break;
                default:
                    Console.WriteLine("Opción no válida. Presione Enter para intentar nuevamente.");
                    Console.ReadLine();
                    break;
            }
        }
        
        static void TranspositionEncryptWithKey()
        {
            Console.Clear();
            Console.WriteLine("=== Transposición Tabular con Clave - Encriptación ===");
            Console.Write("Ingrese el mensaje a encriptar: ");
            string message = Console.ReadLine().Replace(" ", "").ToUpper(); // Eliminamos espacios y convertimos a mayúsculas
            Console.Write("Ingrese la clave: ");
            string key = Console.ReadLine().ToUpper();

            string encryptedMessage = TranspositionCipherEncryptWithKey(message, key);
            Console.WriteLine($"\nMensaje encriptado: {encryptedMessage}");
            Console.WriteLine("Presione Enter para continuar.");
            Console.ReadLine();
        }

        static string TranspositionCipherEncryptWithKey(string message, string key)
        {
            int columns = key.Length;
            int rows = (int)Math.Ceiling((double)message.Length / columns);

            // Relleno de "A" en el mensaje si es necesario
            message = message.PadRight(rows * columns, 'A');

            // Crear la matriz
            char[,] grid = new char[rows, columns];
            int index = 0;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    grid[row, col] = message[index++];
                }
            }

            // Determinar el orden de columnas basado en el orden alfabético de la clave
            int[] columnOrder = key
                .Select((ch, i) => new { Char = ch, Index = i })
                .OrderBy(x => x.Char)
                .Select(x => x.Index)
                .ToArray();

            // Leer el mensaje en el orden de columnas
            string result = "";
            foreach (int col in columnOrder)
            {
                for (int row = 0; row < rows; row++)
                {
                    result += grid[row, col];
                }
            }

            return result;
        }

        static void TranspositionDecryptWithKey()
        {
            Console.Clear();
            Console.WriteLine("=== Transposición Tabular con Clave - Desencriptación ===");
            Console.Write("Ingrese el mensaje encriptado: ");
            string encryptedMessage = Console.ReadLine().Replace(" ", "").ToUpper();
            Console.Write("Ingrese la clave: ");
            string key = Console.ReadLine().ToUpper();

            string decryptedMessage = TranspositionCipherDecryptWithKey(encryptedMessage, key);
            Console.WriteLine($"\nMensaje desencriptado: {decryptedMessage}");
            Console.WriteLine("Presione Enter para continuar.");
            Console.ReadLine();
        }

        static string TranspositionCipherDecryptWithKey(string encryptedMessage, string key)
        {
            int columns = key.Length;
            int rows = (int)Math.Ceiling((double)encryptedMessage.Length / columns);

            // Obtener el orden de columnas según la clave
            int[] columnOrder = key
                .Select((ch, i) => new { Char = ch, Index = i })
                .OrderBy(x => x.Char)
                .Select(x => x.Index)
                .ToArray();

            // Crear una matriz para almacenar los caracteres en el orden correcto
            char[,] grid = new char[rows, columns];
            int index = 0;

            // Llenar la matriz en el orden de columnas
            foreach (int col in columnOrder)
            {
                for (int row = 0; row < rows; row++)
                {
                    if (index < encryptedMessage.Length)
                    {
                        grid[row, col] = encryptedMessage[index++];
                    }
                }
            }

            // Leer la matriz en orden de filas para formar el mensaje desencriptado
            string result = "";
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    result += grid[row, col];
                }
            }

            return result.TrimEnd('A'); // Elimina caracteres de relleno si los hay
        }

    }
}
