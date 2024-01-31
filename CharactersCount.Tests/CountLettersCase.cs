namespace CountCharactersTests;

public record CountLettersCase
{
    public required string Input { get; init; }
    public required Dictionary<char, int> ExpectedDictionary { get; init; }
}