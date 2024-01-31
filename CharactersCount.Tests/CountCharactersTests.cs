using CountCharacters;

namespace CountCharactersTests;

public class CountCharactersTests
{
    [Theory(DisplayName = "Should correctly count letters")]
    [MemberData(nameof(CountLettersCaseGenerator.GetCases),
        MemberType = typeof(CountLettersCaseGenerator))]
    public void ShouldCorrectlyCountLetters(CountLettersCase testCase)
    {
        //Arrange
        CounterCharacter characterCounter = new CounterCharacter(testCase.Input);

        //Act
        Dictionary<char, int> result = characterCounter.SorterLetters();

        //Assert
        Assert.Equal(testCase.ExpectedDictionary, result);
    }

    [Theory(DisplayName = "Should throw an exception, if input is invalid")]
    [InlineData(null)]
    [InlineData("")]
    public void ShouldThrowExceptionIfInputIsInvalid(string input)
    {
        Assert.ThrowsAny<ArgumentException>(() => new CounterCharacter(input));
    }
}
