
public class PromptGenerator
{
    public List<string> _prompts;
    public PromptGenerator()
    {

        _prompts = new List<string>()
        {
        "What would you like to do tomorrow?",
        "What was the best part of your day today?",
        "What did you learn today in your job?",
        "Is there anything you don't like to do today?",
        "what book would you like to read tomorrow?"
        };
    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

}