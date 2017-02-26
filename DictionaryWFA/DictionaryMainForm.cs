using System;
using System.Windows.Forms;
using BL;

namespace DictionaryWFA
{
    public partial class DictionaryMainForm : Form
    {
        MyDictionary<Key, string> _dictionary;

        public DictionaryMainForm()
        {
            _dictionary = new MyDictionary<Key, string>();
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (AddTxtBox.Text != string.Empty) _dictionary.Add(new Key(AddTxtBox.Text), 1.ToString());
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            if (RemoveTxtBox.Text != string.Empty) _dictionary.Remove(new Key(RemoveTxtBox.Text));
        }

        private void DisplayBtn_Click(object sender, EventArgs e)
        {
            //DisplayKvpLbl.Text = string.Empty;
            //foreach (var variable in _dictionary.Keys)
            //{
            //    DisplayKvpLbl.Text += $@"{variable} : {_dictionary[variable]}" + Environment.NewLine;
            //}э

            Key testKey = new Key("123");
            _dictionary[testKey] = "456";
            _dictionary[testKey] += "678";
        }
    }
}
