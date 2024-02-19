using System;
using System.Security.Cryptography;
using System.Text;

public class CampaignCodeGenerator
{
    private const string Characters = "ACDEFGHKLMNPRTXYZ234579";
    private const string SecretKey = "my_secret_key";

    public static void Main()
    {
        int i;
        string campaignId = "";

        foreach (var character1 in Characters)
        {
            foreach (var character2 in Characters)
            {
                foreach (var character3 in Characters)
                {
                    campaignId+=character1;
                    campaignId+=character2;
                    campaignId+=character3;
                    string generatedCode = GenerateCampaignCode(campaignId);
                    Console.WriteLine("Generated Code: " + generatedCode);
                    
                    bool isValid = ValidateCampaignCode(generatedCode);
                    Console.WriteLine(isValid ? "Code is valid." : "Code is not valid.");
                    campaignId = null;
                }
            }
        }

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
            return builder.ToString().Substring(0, 5)+campaignId;
        }
    }

    public static bool ValidateCampaignCode(string code)
    {
        string generatedCode = GenerateCampaignCode(code.Substring(5));
        return code == generatedCode;
    }
}