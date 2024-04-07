using Hangman.Properties;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Hangman : Form
    {
        private string[] words = { "sword", "jupiter", "valorant", "cellphone", "philipines" };
        private string selectedWord;
        private int guessesLeft;
        private string[] wordToGuess;
        private bool[] guessedLetters;
        private Image[] hangmanImages;

        public Hangman()
        {
            InitializeComponent();
            LoadHangmanImages();
            NewGame();
        }

        // Method to update image
        private void LoadHangmanImages()
        {
            hangmanImages = new Image[6];
            for (int i = 0; i < 6; i++)
            {
                hangmanImages[i] = Image.FromFile($"hangman{i + 1}.gif");
            }
        }

        // Method to new game 
        private void NewGame()
        {
            guessesLeft = 6;
            Random random = new Random();
            selectedWord = words[random.Next(words.Length)];
            wordToGuess = new string[selectedWord.Length];
            guessedLetters = new bool[26];
            for (int i = 0; i < selectedWord.Length; i++)
            {
                wordToGuess[i] = "*";
            }
            UpdateDisplay();
            pictureBox1.Image = hangmanImages[0];
            buttonGuess.Text = "Guess";

            string[] clues = { "Common weapon in ancient age", "Planet", "Online 5v5 gun Game", "Electronic device", "Country" };
            int clueIndex = Array.IndexOf(words, selectedWord);
            if (clueIndex >= 0 && clueIndex < clues.Length)
            {
                labelClue.Text = $"Clue: {clues[clueIndex]}";
            }
        }

        // Method to update guesses and word
        private void UpdateDisplay()
        {
            string displayWord = string.Join(" ", wordToGuess);
            labelWord.Text = displayWord;
            labelGuessesLeft.Text = $"Guesses left: {guessesLeft}";
        }   

        // Method to check the inputted letter
        private void CheckLetter(char letter)
        {
            bool letterFound = false;
            for (int i = 0; i < selectedWord.Length; i++)
            {
                if (selectedWord[i] == letter)
                {
                    wordToGuess[i] = letter.ToString();
                    letterFound = true;
                }
            }
            if (!letterFound)
            {
                guessesLeft--;
                UpdateHangmanImage();
            }
            UpdateDisplay();
            CheckGameEnd();
        }

        // Method to update the image after a mistake 
        private void UpdateHangmanImage()
        {
            int hangmanIndex = 6 - guessesLeft;
            if (hangmanIndex >= 1 && hangmanIndex <= 5)
            {
                pictureBox1.Image = hangmanImages[hangmanIndex];
            }
        }

        // Checks the game status 
        private void CheckGameEnd()
        {
            if (guessesLeft == 0)
            {
                Form1 ftr = new Form1();
                ftr.Show();
                MessageBox.Show($"You lost! The correct word was: {selectedWord}");
                NewGame();
            }
            else if (!wordToGuess.Contains("*"))
            {
                Wins win = new Wins();
                win.Show();
                MessageBox.Show($" You guessed the correct word. ({selectedWord})");
                NewGame();
            }
        }
        private void buttonGuess_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxGuess.Text) && textBoxGuess.Text.Length == 1)
            {
                char guessedLetter = textBoxGuess.Text.ToLower()[0];
                if (guessedLetters[guessedLetter - 'a'])
                {
                    MessageBox.Show("You already guessed this letter.");
                }
                else
                {
                    guessedLetters[guessedLetter - 'a'] = true;
                    CheckLetter(guessedLetter);
                }
                textBoxGuess.Clear();
            }
        }

        private void buttonNewGame_Click_1(object sender, EventArgs e)
        {
            NewGame();
        }
    }
}
