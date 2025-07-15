using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference ?? throw new ArgumentNullException(nameof(reference));
        _words = new List<Word>();

        // Split the text by spaces into words
        string[] splitWords = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        foreach (string word in splitWords)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int hiddenCount = 0;

        // Create a list of indices of words that are not yet hidden
        List<int> availableIndices = new List<int>();
        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
            {
                availableIndices.Add(i);
            }
        }

        // Shuffle and hide from the available list
        while (hiddenCount < numberToHide && availableIndices.Count > 0)
        {
            int randomIndex = random.Next(availableIndices.Count);
            int wordIndex = availableIndices[randomIndex];

            _words[wordIndex].Hide();
            availableIndices.RemoveAt(randomIndex);
            hiddenCount++;
        }
    }

    public string GetDisplayText()
    {
        List<string> displayWords = new List<string>();
        foreach (Word word in _words)
        {
            displayWords.Add(word.GetDisplayText());
        }

        return $"{_reference.GetDisplayText()}\n{string.Join(" ", displayWords)}";
    }

   public bool AllWordsHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}
