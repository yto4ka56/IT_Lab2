using System.Collections;
using System.Text;


namespace TI_Lab2;

public partial class Form1 : Form
{
    private readonly Cipher cipher = new();
    public Form1()
    {
        InitializeComponent();
    }


    private void RegTextBoxChanged(object sender, EventArgs e)
    {
        BitCountLabel.Text = $@"Длина введенного регистра: {RegTextBox.Text.Count(x => x is '0' or '1')}";
    }


    private void ResultButtonClick(object sender, EventArgs e)
    {
        RegTextBox.Text = string.Join("", RegTextBox.Text.Where(x => x is '0' or '1'));
        if (RegTextBox.Text.Length != 36)
        {
            MessageBox.Show("Длина вашего регистра должна равняться 36!", "Ошибка");
            return;
        }

        if (PlainTextBox.Text.Length is 0)
        {
            MessageBox.Show("Выберите файл с исходным текстом!", "Ошибка");
            return;
        }
        
        cipher.GetRegBit(RegTextBox.Text);
        cipher.GetBitKey(cipher.PlainText.Length);

        KeyTextBox.Text = BitToStr(cipher.BitKey);
        
        cipher.GetCipher();

        CipherTextBox.Text = BitToStr(cipher.CipherText);
    }

    string BitToStr(BitArray array)
    {
        StringBuilder temp = new();
        if (array.Length <= 148)
        {
            foreach (bool bit in array)
            {
                temp.Append(bit ? 1 : 0);
            }       
        }
        else
        {
            temp.Append("Первые 72 бита: \n");
            for (int i = 0; i < 72; i++)
                temp.Append(array[i] ? 1 : 0);
            temp.Append($"{Environment.NewLine}Последние 72 бита: \n");
            for (int i = 72; i > 0; i--)
            {
                temp.Append(array[array.Length - i] ? 1 : 0);
            }
        }

        return temp.ToString();
    }

    private void OpenFileClick(object sender, EventArgs e)
    {
        if (OpenFileDialog.ShowDialog() != DialogResult.Cancel)
        {
            StringBuilder stringBuilder = new StringBuilder();

            var bytes = File.ReadAllBytes(OpenFileDialog.FileName);
            for (int i = 0; i < bytes.Length; i++)
            {
                BitArray help = new BitArray(new[] { bytes[i] });
                foreach (bool bit in help)
                {
                    stringBuilder.Append(bit ? 1 : 0);
                }
            }

            cipher.PlainText = new BitArray(stringBuilder.Length);
            for (int i = 0; i < cipher.PlainText.Length; i++)
            {
                cipher.PlainText[i] = stringBuilder[i] == '1';
            }

            PlainTextBox.Text = BitToStr(cipher.PlainText);
        }
    }

    private void SaveButtonClick(object sender, EventArgs e)
    {
        if (SaveFileDialog.ShowDialog() != DialogResult.Cancel)
        {
            using FileStream fileStream = new FileStream(SaveFileDialog.FileName, FileMode.Create);
            byte[] result = new byte[cipher.CipherText.Count / 8];
            cipher.CipherText.CopyTo(result, 0);
            fileStream.Write(result, 0, result.Length);
        }
    }

    private void ClearButtonClick(object sender, EventArgs e)
    {
        KeyTextBox.Clear();
        CipherTextBox.Clear();
        PlainTextBox.Clear();
    }
}