namespace Lab8
{
    public partial class Form1 : Form
    {
        string fileName;
        public Form1()
        {
            InitializeComponent();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                fileName = ofd.FileName;
                searchBox.Text = fileName.Split("\\").LastOrDefault();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private async Task ReadBook(string fileName)
        {
            var lines = await Task.FromResult(File.ReadAllLinesAsync(fileName));
            var linesWithoutPunctuation = lines.Result.Where(x => x != string.Empty)
                .AsParallel()
                .Select(x => x.ToLower().Trim().Replace(",", "").Replace("*", "")
                .Replace(".", ""));
            var arrayOfWords = linesWithoutPunctuation.SelectMany(x => x.Split(" "));
            Dictionary<string, int> dictionaryOfWords = new Dictionary<string, int>();
            foreach (var word in arrayOfWords)
            {
                // add test here
                if (dictionaryOfWords.ContainsKey(word))
                {
                    dictionaryOfWords[word]++;
                }
                else
                {
                    dictionaryOfWords.Add(word, 1);
                }
            }
            var top10 = dictionaryOfWords.Where(x => !string.IsNullOrWhiteSpace(x.Key)).OrderByDescending(x => x.Value).Take(10);
            foreach (var word in top10)
            {
                listBox.Items.Add(word.Key + " - " + word.Value);
            }
        }

        private async Task submitButton_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            List<Task> tasks = new List<Task>();
            var wordTask = ReadBook(fileName);
            tasks.Add(wordTask);
            await Task.WhenAll(tasks);
        }
    }
}