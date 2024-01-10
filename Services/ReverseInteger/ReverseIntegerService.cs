namespace PackardJMiniChallengeFiveToSeven_Endpoints.Services.ReverseInteger;

public class ReverseIntegerService : IReverseIntegerService
{
    public string ReverseInteger(string integer)
    {
        double inputNumber = 0;

        bool success = double.TryParse(integer, out inputNumber);

        if (success)
        {
            string reversed = "";

            for (int i = integer.Length - 1; i >= 0; i--)
            {
                reversed += integer[i];
            }

            return $"You entered {integer}. Your number reversed is {reversed}.";
        }
        else
        {
            return "Please make sure you are entering a number.";
        }

    }
}
