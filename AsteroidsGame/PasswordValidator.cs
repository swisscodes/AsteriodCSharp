
namespace AsteroidsProject;

internal class PasswordValidator
{
    public static bool Validate(string password)
    {
        bool containsUpper = false;
        bool containsLower = false;
        bool NotTandAmpersand = !password.Contains('T') && !password.Contains('&');
        bool shortPassword = password.Length < 6 ? false:true;
        bool longEnoughPassword = password.Length > 13;
        bool containsDigit = false;


        foreach (char letter in password)
        {
            if (char.IsUpper(letter) && !containsUpper)
            {
                containsUpper = true;
            }
            if (char.IsLower(letter) && !containsLower)
            {
                containsLower = true;
            }
            if (char.IsDigit(letter) && !containsDigit)
            {
                containsDigit = true;
            }


        }
        return containsUpper && containsLower && NotTandAmpersand && shortPassword && longEnoughPassword && containsDigit;
    }
}
