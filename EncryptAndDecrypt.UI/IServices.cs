namespace EncryptAndDecrypt;

public interface IServices
{
    protected string Encrypt(string sentence);
    protected string Decrypt(string sentence);
}
