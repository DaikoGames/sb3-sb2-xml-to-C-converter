using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Xml;
using Newtonsoft.Json;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;

namespace sb3_to_C__converter__extra_features_
{
    public partial class Converter : Form
    {

        string FileName;
        string Name;
        string Extension;
        string OutputF;
        string Extension1 = ".sb3";
        string Extension2 = ".sb2";
        string Extension3 = ".xml";
        string NewFileInNewFolder;
        string zipfile;
        string JSONFileName;
        string JSONFile;


        public Converter()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FilePath.Show();
            FileSearcherF.Show();
            Filename.Show();
            FolderSearcher.Show();
            OutputFolder.Show();
            Progress.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog FileDialogFile = new OpenFileDialog();
            FileDialogFile.Filter = "sb3 Files(*.sb3)|*.sb3*| sb2 Files (*.sb2*)|*.sb2*| xml Files (*.xml*)|*.xml*";
            FileDialogFile.ShowDialog();
            FileName = FileDialogFile.FileName;
            FilePath.Text = FileName;
            Name = Path.GetFileName(FileName);
            Extension = Path.GetExtension(FileName);
            Filename.Text = Name;
        }

        private void FolderSearcher_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FolderDialogFolder = new FolderBrowserDialog();
            FolderDialogFolder.ShowDialog();
            OutputF = FolderDialogFolder.SelectedPath;
            OutputFolder.Text = OutputF;
        }

        private void convert_Click(object sender, EventArgs e)
        {
            ProgressBar Progress = new ProgressBar();
            Progress.Minimum = 0;
            Progress.Maximum = 100;

            if (Extension == Extension1)
            {
                sb3();
            }

            if (Extension == Extension2)
            {
                sb2();
            }

            if (Extension == Extension3)
            {
                xml();
            }

            else
            {
                //Error, can´t convert it
            }
        }

        void sb3()
        {
            JSONFileName = "project.json";
            NewFileInNewFolder = Path.Combine(OutputF, Name);
            File.Copy(FileName, NewFileInNewFolder, true);
            Progress.Value = 1;
            zipfile = Path.ChangeExtension(NewFileInNewFolder, ".zip");
            File.Copy(NewFileInNewFolder, zipfile, true);
            Progress.Value = 10;
            ZipFile.ExtractToDirectory(zipfile, OutputF);
            
            Progress.Value = 20;
            
            
            //do the sb3(json to C# class converter) script
        }

        void sb2()
        {
            JSONFileName = "project.json";
            NewFileInNewFolder = Path.Combine(OutputF, Name);
            File.Copy(FileName, NewFileInNewFolder, true);
            Progress.Value = 1;
            zipfile = Path.ChangeExtension(NewFileInNewFolder, ".zip");
            File.Copy(NewFileInNewFolder, zipfile, true);
            Progress.Value = 10;
            
            //do the sb2(json to C# class converter) script
        }

        void xml()
        {
            NewFileInNewFolder = Path.Combine(OutputF, Name);
            File.Copy(FileName, NewFileInNewFolder, true);
            Progress.Value = 1;
            XmlDocument XML = new XmlDocument();
            XML.Load(NewFileInNewFolder);
            var JSON = JsonConvert.SerializeXmlNode(XML, Newtonsoft.Json.Formatting.Indented, true);
            File.WriteAllText(NewFileInNewFolder, JSON);
            JSONFile = Path.ChangeExtension(NewFileInNewFolder, ".json");
            File.Copy(NewFileInNewFolder, JSONFile, true);
            Progress.Value = 50;
            
            //Read The JSON
            File.ReadAllText(JSONFile);
            //Find Image base64 string
            string[] Lines = File.ReadAllLines(JSONFile);
            
            foreach( string line in Lines)
            {
                if (!string.IsNullOrWhiteSpace(line))
                {
                    
                }
                else
                {
                    string FileName;
                    double NumberN = +1;
                    FileName = NumberN + "png.png";
                    //var lineconverted = JsonConvert.DeserializeObject<>(JSONFile);
                    //byte[] PNGBytes = Convert.FromBase64String(lineconverted);
                    
                    //File.WriteAllBytes(FileName, PNGBytes);
                }
            }
            //deserialize it
            //use it as a byte
            //write all bytes into a file
            //convert File into png
            //do the xml(json to C# class converter) script
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Filename_TextChanged(object sender, EventArgs e)
        {

        }

        private void OutputFolder_TextChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
