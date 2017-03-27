using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace WordControl
{
    public class WordIO
    {

        public static void setWordInfo(WordStore wordInfo, string path)
        {
            String date = DateTime.Now.ToString("yyyyMMddHHmmss");
            File.Copy(path, path + ".bak" + date);
            File.Delete(path);
            FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate);
            XmlSerializer XmlSerializer = new XmlSerializer(typeof(WordStore));

            XmlSerializer.Serialize(fileStream, wordInfo);

            fileStream.Close();
            fileStream.Dispose();
        }

        public static WordStore getWordInfo(string path)
        {
            FileStream fileStream = new FileStream(path, FileMode.Open);
            XmlSerializer XmlSerializer = new XmlSerializer(typeof(WordStore));

            WordStore wordInfo = (WordStore)XmlSerializer.Deserialize(fileStream);

            fileStream.Close();
            fileStream.Dispose();
            return wordInfo;
        }
    }

    public class WordStore
    {
        private List<Word> wordList = null;
        public List<Word> WordList
        {
            get
            {
                return wordList;
            }
            set
            {
                this.wordList = value;
            }
        }

        private int wordIndex = -1;

        public int getWordCount()
        {
            if (wordList == null)
                return 0;

            return wordList.Count;
        }

        public Word getWord(int index)
        {
            Word word = wordList[index];

            if (word != null)
            {
                wordIndex = index;
            }

            return word;
        }

        public Word getWord(string jpName)
        {
            Word result = null;
            int index = 0;

            foreach(Word word in wordList)
            {
                if (word.JpWord.Equals(jpName))
                {
                    result = word;
                    wordIndex = index;
                    break;
                }
                index++;
            }

            return result;
        }

        public Word getFirstWord()
        {
            if (wordList == null || wordList.Count == 0)
                return null;

            Word word = wordList[0];
            return word;
        }

        public Word getLastWord()
        {
            Word word = wordList[wordList.Count - 1];
            return word;
        }

        public Word getCurrentWord()
        {
            if (wordIndex < 0 || wordIndex >= wordList.Count)
                return null;

            Word word = wordList[wordIndex];
            return word;
        }

        public int deleteCurrentWord()
        {
            if (wordIndex < 0 || wordIndex >= wordList.Count)
                return 0;

            wordList.RemoveAt(wordIndex);
            return 1;
        }

        public Word getPreWord()
        {
            wordIndex = wordIndex - 1;
            if (wordIndex < 0)
                wordIndex = wordList.Count - 1;

            if (wordIndex >= wordList.Count)
                wordIndex = 0;

            Word word = wordList[wordIndex];
            return word;
        }

        public Word getRandomWord()
        {
            Random random = new Random();
            int index = random.Next(1, wordList.Count + 1);

            Word word = wordList[index - 1];
            return word;
        }

        public Word getNextWord()
        {
            wordIndex = wordIndex + 1;
            if (wordIndex < 0)
                wordIndex = wordList.Count - 1;

            if (wordIndex >= wordList.Count)
                wordIndex = 0;

            Word word = wordList[wordIndex];
            return word;
        }

        public void addWord(Word word)
        {
            wordList.Add(word);
        }
    }

    public class Word
    {
        //private int index = -1;
        //public int Index
        //{
        //    get
        //    {
        //        return index;
        //    }
        //    set
        //    {
        //        this.index = value;
        //    }
        //}

        private string jpWord = null;
        public string JpWord
        {
            get
            {
                return jpWord;
            }
            set
            {
                this.jpWord = value;
            }
        }

        private string jp2Word = null;
        public string Jp2Word
        {
            get
            {
                return jp2Word;
            }
            set
            {
                this.jp2Word = value;
            }
        }

        private string cnWord = null;
        public string CnWord
        {
            get
            {
                return cnWord;
            }
            set
            {
                this.cnWord = value;
            }
        }

        private List<string> example = null;
        public List<string> Example
        {
            get
            {
                return example;
            }
            set
            {
                this.example = value;
            }
        }
    }
}
