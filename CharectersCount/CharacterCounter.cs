namespace CountCharacters
{
    public class CharacterCounter
    {
        private readonly string _symbolsInput;

        public CharacterCounter(string userInput)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(userInput);

            _symbolsInput = userInput.ToLower();
        }

        public Dictionary<char, int> SorterLetters()
        {
            return CounterLetters()
                .OrderByDescending(x => x.Value)
                .ToDictionary(x => x.Key, x => x.Value);
        }

        private Dictionary<char, int> CounterLetters()
        {
            Dictionary<char, int> catalogue = new();

            foreach (char c in _symbolsInput)
            {
                if (char.IsLetter(c))
                {
                    if (catalogue.ContainsKey(c))
                        catalogue[c]++;
                    else
                        catalogue[c] = 1;
                }
            }

            return catalogue;
        }
    }
}