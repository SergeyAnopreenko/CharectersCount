namespace CountCharacters.Tests;

public record CountLettersCase
{
    public required string Input { get; set; }
    public required Dictionary<char, int> ExpectedDictionary { get; set; }
}