# **EncryptAndDecryptSentences**
This is a simple library with built-in encryption characters matching every letter in the English alphabet.

### **Built With**
- Major languages: C#
- Frameworks: .NET 6.0
- Technologies: Github and Visual Studio

### **To get started?** 
Just like every other NuGet package installation, the EncryptAndDecryptSentences package can be installed in either of these two ways:

**Install using .NET CLI:** 
- run: dotnet add package EncryptAndDecryptSentences --version 1.0.2

**Install using Visual Studio:**
- Right-click on project dependencies
- Select manage Nuget packages
- Search for EncryptAndDecryptSentences
- Click install

### **Prerequisites**
An understanding of C# and NuGet Packages

### **Usage**
As the name implies, this package allows you to encrypt and decrypt wwords/sentences of your choice, using our built-in characters that match every letter in the English dictionary.
This package allows you access to two methods, namely:

**The Encrypt(string message) method:** this method takes in a word/sentence and returns a string 
**The Decrypt(string message) method:** this method takes in a word/sentence and returns a string

To call these methods, you have to first create an instance of the Services class, then call the method(s) that you are interested in.

### **Code Samples**

```
using EncryptAndDecryptSentences;
namespace Run;

    internal class Program
    {
        static void Main(string[] args)
        {
          //Create an Instance of the Services class
          Services service = new Services();
         //Call the Encrypt(string sentence) method if you want to encrypt anything
          string encrypt = service.Encrypt("my name is amaka");
          Console.WriteLine(encrypt);

          //To Decrypt a word/sentence
          string decrypt = service.Decrypt("~/ [£~>");
          Console.WriteLine(decrypt);
        }
    }
```

### **Limitations**
1. It supports only the English alphabets
2. It may give you inaccurate results if you intend to decrypt a word/sentence that was not encrypted with our methods
3. You can customize the encryption characters
4. It only converts lowercase characters

### **Authors**
Uzoamaka Nweze

GitHub: @Chelseaquiin
Twitter: @Chelseaqueen

### **License**
This project is MIT licensed.
