namespace PackardJMiniChallengeFiveToSeven_Endpoints.Services.ReverseString;

public class ReverseStringService : IReverseStringService
{
    public string ReverseString(string word)
    {
        string reversed = "";

        for(int i = word.Length - 1; i >= 0; i--)
        {
            reversed += word[i];
        }

        return $"You entered {word}. Your word reversed is {reversed}.";
    }
}
