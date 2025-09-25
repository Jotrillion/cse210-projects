using System;
using System.Collections.Generic;
public class Scripture
{
    private Reference _reference;
    private List<string> _words;


    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<string>(text.Split(' '));
    }

    public void Display()
    {
        Console.WriteLine(_reference.GetDisplayText());
        foreach (string word in _words)
        {
            Console.Write(word + " ");
        }
        Console.WriteLine();
    }
    public void HideRandomWords(int numberToHide)
    {
        for (int i = 0; i < numberToHide; i++)
        {

            Random random = new Random();
            int index = random.Next(_words.Count);
            if (_words[index].All(c => c == '_'))
            {
                i++;
            }
            else
            {
                _words[index] = new string('_', _words[index].Length);
            }

        }
    }
    public bool AllWordsHidden()
    {
        foreach (string word in _words)
        {
            if (!word.All(c => c == '_'))
            {
                return false;
            }
        }
        return true;
    }

}
