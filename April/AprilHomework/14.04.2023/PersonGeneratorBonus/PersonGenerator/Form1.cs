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
                Random randomAge = new Random();
                string name = FakeData.NameData.GetFirstName();
                string surname = FakeData.NameData.GetSurname();
                string email = FakeData.NetworkData.GetEmail();
                string country = FakeData.PlaceData.GetCountry();
                int age = randomAge.Next(1, 99);
                Person person = new Person(
                   name,
                   surname,
                   email,
                   country,
                   age);
                
                VirtualDatabase.Persons.Add(person);

                CreateNewFolderIfNotExists(Path.Combine("C:/Countries/",country));
                string path = Path.Combine("C:/Countries/",country);
                if (age>0 &&age<=18)
                {
                    string ageS = "0-18";
                    CreateNewFolderIfNotExists(Path.Combine(path, ageS));
                    Random random = new Random();
                    int randomNum = random.Next(100000, 999999);
                    string fileName = name + "-" + surname + "-" + randomNum.ToString();
                    CreateFile(Path.Combine(path, ageS, fileName));

                    System.Threading.Thread.Sleep(1);
                }
                else if (age>18 && age<=35)
                {
                    string ageS = "19-35";
                    CreateNewFolderIfNotExists(Path.Combine(path, ageS));

                    Random random = new Random();
                    int randomNum = random.Next(100000, 999999);
                    string fileName = name + "-" + surname + "-" + randomNum.ToString();
                    CreateFile(Path.Combine(path, ageS, fileName));

                    System.Threading.Thread.Sleep(1);
                }
                else if (age>35 && age<=60)
                {
                    string ageS = "36-60";
                    CreateNewFolderIfNotExists(Path.Combine(path, ageS));

                    Random random = new Random();
                    int randomNum = random.Next(100000, 999999);
                    string fileName = name + "-" + surname + "-" + randomNum.ToString();
                    CreateFile(Path.Combine(path, ageS, fileName));

                    System.Threading.Thread.Sleep(1);
                }
                else if(age>60)
                {
                    string ageS = "60 ve uzeri";
                    CreateNewFolderIfNotExists(Path.Combine(path, ageS));

                    Random random = new Random();
                    int randomNum = random.Next(100000, 999999);
                    string fileName = name + "-" + surname + "-" + randomNum.ToString();
                    CreateFile(Path.Combine(path, ageS, fileName));

                    System.Threading.Thread.Sleep(1);
                }
              

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
            foreach (var item in subDirectories)
            {
                string[] subSubDirectories = Directory.GetDirectories(item);
                DirectoryInfo directoryInfo = new DirectoryInfo(item);
                string country = Path.GetFileName(item);
                foreach (var x in subSubDirectories)
                {
                    
                    DirectoryInfo directoryInfos = new DirectoryInfo(x);
                    int countAges = directoryInfos.GetFiles().Length;
                    string ages = Path.GetFileName(x);
                    Statistic statistic = new Statistic(
                        country,
                        ages,
                        countAges);

                    VirtualDatabase.Statistics.Add(statistic);
                }
            }
            
            Statistics statistics = new Statistics();
            statistics.ShowDialog();
        }
    }
}
