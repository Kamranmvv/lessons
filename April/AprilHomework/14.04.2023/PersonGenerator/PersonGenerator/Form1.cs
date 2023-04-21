using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridViewPersons.DataSource = VirtualDatabase.Persons;
            CreateNewFolderIfNotExists("C:/Countries/");
        }

        private void btnGeneratePerson_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < 1000; i++)
            {
                string name = FakeData.NameData.GetFirstName();
                string surname = FakeData.NameData.GetSurname();
                string email = FakeData.NetworkData.GetEmail();
                string country = FakeData.PlaceData.GetCountry();
                Person person = new Person(
                   name,
                   surname,
                   email,
                   country);
                VirtualDatabase.Persons.Add(person);

                CreateNewFolderIfNotExists(Path.Combine("C:/Countries/",country));

                Random random = new Random();
                int randomNum = random.Next(100000, 999999);
                string fileName = name + "-" + surname + "-" + randomNum.ToString();
                CreateFile(Path.Combine("C:/Countries/", country, fileName));

                
            }

            
           
        }

        static void CreateNewFolderIfNotExists(string path)
        {
            bool checkPath = Directory.Exists(path);

            if (!checkPath)
            {
                DirectoryInfo dirInfo = Directory.CreateDirectory(path);
            }
        }
        static void CreateFile(string path)
        {
            FileStream fileStream = File.Create(path);
            fileStream.Close();
        }

        private void btnGetPersonStatistics_Click(object sender, EventArgs e)
        {
            string path = "C:/Countries/";
            string[] subDirectories = Directory.GetDirectories(path);
            foreach (string item in subDirectories)
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(item);
                int fileCount = directoryInfo.GetFiles().Length;
                string country = Path.GetFileName(item);
                Statistic statistic = new Statistic(
                    country,
                    fileCount);

                VirtualDatabase.Statistics.Add(statistic);
            }




            Statistics statistics = new Statistics();
            statistics.ShowDialog();
        }
    }
}
