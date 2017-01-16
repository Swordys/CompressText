using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace Shrinko
{
    public partial class compressWrap : Form
    {
        public compressWrap()
        {
            InitializeComponent();
        }

        OpenFileDialog op = new OpenFileDialog();
        int c = 0;
        private void checkIt_Click(object sender, EventArgs e)
        {
            op.ShowDialog();
            inptBox.Text = op.FileName;

        }

        private void readStuff_Click(object sender, EventArgs e)
        {
            if (inptBox.Text.Length > 0)
            {
                var read = File.ReadAllText(inptBox.Text);
                var fileSize = new FileInfo(inptBox.Text).Length;

                resBox.Text = read;
                sizeOfFile.Text = fileSize.ToString();
            }
        }

        private void computeFile_Click(object sender, EventArgs e)
        {
            var res = inptBox.Text;
            var check = new Compute();
            if (res.Length > 1)
            {

                c++;
                var newres = check.compress(res);
                using (var fileWr = File.Create(inptBox.Text))
                {
                    fileWr.Write(newres, 0, newres.Length);
                }
            }


        }


        private void decompressFile_Click(object sender, EventArgs e)
        {
            var res = resBox.Text;
            var check = new Compute();

            if (res.Length > 1)
            {
                for (int i = 0; i < c; i++)
                {
                    var ch = File.ReadAllBytes(inptBox.Text);
                    var newres = check.decompress(ch);
                    File.WriteAllBytes(inptBox.Text, newres);
                }

                c = 0;

            }

        }


        private void analitcsFile_Click(object sender, EventArgs e)
        {
            if (resBox.Text.Length > 1)
            {
                var text = resBox.Text;
                var cleanText = new Regex(@"ა|ბ|გ|დ|ე|ვ|ზ|თ|ი|კ|ლ|მ|ნ|ო|პ|ჟ|რ|ს|ტ|უ|ფ|ქ|ღ|ყ|შ|ჩ|ც|ძ|წ|ჭ|ხ|ჯ|ჰ").Matches(text).Cast<Match>().Select(c => c.Value).ToList().ToLookup(c => c).Select(c => new { name = c.Key, value = c.Count() }).OrderByDescending(c => c.value).Take(10).ToList();

                resBox.Text = "";

                foreach (var item in cleanText)
                {
                    resBox.Text += $" {item.name}  სიხშირე - {((float)item.value * 100 / new Regex(@"ა|ბ|გ|დ|ე|ვ|ზ|თ|ი|კ|ლ|მ|ნ|ო|პ|ჟ|რ|ს|ტ|უ|ფ|ქ|ღ|ყ|შ|ჩ|ც|ძ|წ|ჭ|ხ|ჯ|ჰ").Matches(text).Count).ToString(".00")}%\n";
                }
            }
        }

        private void inptBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void resBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void sizeOfFile_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
