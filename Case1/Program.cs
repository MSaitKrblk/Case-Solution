using System;
using System.Security.Cryptography;
using System.Text;

public class CampaignCodeGenerator
{
    private const string Characters = "ACDEFGHKLMNPRTXYZ234579";
    private const string SecretKey = "my_secret_key";

    public static void Main()
    {
        string campaignId = "campaign123";
        string generatedCode = GenerateCampaignCode(campaignId);
        Console.WriteLine("Generated Code: " + generatedCode);

        bool isValid = ValidateCampaignCode(generatedCode, campaignId);
        Console.WriteLine(isValid ? "Code is valid." : "Code is not valid.");
        isValid = ValidateCampaignCode("CAP34G73", campaignId);
        Console.WriteLine(isValid ? "Code is valid." : "Code is not valid.");
    }

    public static string GenerateCampaignCode(string campaignId)
    {
        byte[] bytes = Encoding.UTF8.GetBytes(campaignId + SecretKey);
        using (SHA256 sha256Hash = SHA256.Create())
        {
            byte[] hashedBytes = sha256Hash.ComputeHash(bytes);
            StringBuilder builder = new StringBuilder();
            foreach (byte b in hashedBytes)
            {
                builder.Append(Characters[b % Characters.Length]);
            }
            return builder.ToString().Substring(0, 8);
        }
    }

    public static bool ValidateCampaignCode(string code, string campaignId)
    {
        string generatedCode = GenerateCampaignCode(campaignId);
        return code == generatedCode;
    }
}