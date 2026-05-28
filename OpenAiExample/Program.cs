using OpenAI.Chat;

string apiKey = "keu_001";

ChatClient client = new ChatClient(
    model: "gpt:5",
    apiKey: apiKey
    );

ChatCompletion Completion = await client.CompleteChatAsync("Hello, chatGPT!");

Console.WriteLine(Completion.Content[0].Text);
