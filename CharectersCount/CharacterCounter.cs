namespace CountCharacters
{
    public class CharacterCounter
    {
        private readonly string symbolsInput;

        public CharacterCounter(string userInput)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(userInput);

            symbolsInput = userInput.ToLower();
        }

        public Dictionary<char, int> SorterLetters()
        {
            return CounterLetters()
                .OrderByDescending(x => x.Value)
                .ToDictionary(x => x.Key, x => x.Value);
        }

        private Dictionary<char, int> CounterLetters()
        {
            Dictionary<char, int> diction = new();

            foreach (char c in symbolsInput)
            {
                if (char.IsLetter(c))

                    if (diction.TryGetValue(c, out int value))
                        diction[c] = ++value;
                    else
                        diction[c] = 1;
            }
            return diction;
        }
    }
}