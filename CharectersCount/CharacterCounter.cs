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
            Dictionary<char, int> diction = symbolsInput
                                    .Where(c => char.IsLetter(c))
                                    .GroupBy(c => c)
                                    .Select(gr => (Letter: gr.Key, Count: gr.Count()))
                                    .OrderByDescending(c => c.Count)
                                    .ToDictionary(p => p.Letter, p => p.Count);        
            return diction;
        }
    }
}