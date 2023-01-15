namespace EncryptAndDecrypt;

public class Services : IServices
{
    KeysAndValues _kv = new();
    Dictionary<char, char> _encryptionKeys = new();
    Dictionary<char, char> _decryptionKeys = new();

    public string Decrypt(string sentence)
    {
        Init();
        string decryptedWord = sentence;
        foreach (string word in sentence.Split(' '))
        {

            for (int i = (int)NumberEnum.Number; i < word.Length; i++)
            {
                char currentChar = word.ElementAt(i);
                char replacementChar = _decryptionKeys.Keys.Contains(currentChar) != null ? _decryptionKeys.GetValueOrDefault(currentChar) : currentChar;

                decryptedWord = decryptedWord.Replace(currentChar, replacementChar);
            }
        }

        return string.Join(" ", decryptedWord);
    }

    public string Encrypt(string sentence)
    {
        Init();
        string encryptedWord = sentence;

        foreach (string word in sentence.Split(' '))
        {
            for (int i = (int)NumberEnum.Number; i < word.Length; i++)
            {
                char currentChar = word.ElementAt(i);
                char replacementChar = _encryptionKeys.Keys.Contains(currentChar) != null ? _encryptionKeys.GetValueOrDefault(currentChar) : currentChar;

                encryptedWord = encryptedWord.Replace(currentChar, replacementChar);
            }
        }
        return string.Join(" ", encryptedWord);
    }

    private void Init()
    {
        for (int i = (int)NumberEnum.Number; i < (int)NumberEnum.LengthOfAlphabet; i++)
        {
            _encryptionKeys.Add(_kv.Alphabets[i], _kv.DecryptionKeys[i]);
        }

        for (int i = 0; i < (int)NumberEnum.LengthOfAlphabet; i++)
        {
            _decryptionKeys.Add(_kv.DecryptionKeys[i], _kv.Alphabets[i]);
        }
    }
}
