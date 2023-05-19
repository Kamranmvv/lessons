using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Create Folder and File
            string folderPath = @"C:\XML"; 
            string filePath = Path.Combine(folderPath, "Students.xml");
            //Directory.CreateDirectory(folderPath);
            //File.Create(filePath).Close();
            #endregion

            XDocument document = new XDocument(
                new XDeclaration("1.0", "uft-8", "true"),
                new XComment("Tələbə məlumatları"),
                new XElement("Students",
                    new XComment("Tələbə 1"),
                    new XElement("Student",
                        new XAttribute("Id", "1"),
                        new XElement("Name", "Hər hansısa ad"),
                        new XElement("Surname", "Hər hansısa soyad"),
                        new XElement("Gender", "Male/Female"),
                        new XElement("Birthdate", "Hər hansısa tarix"),
                        new XElement("Degree", "Hər hansısa dərəcə: Associate, Bachelor's, Master's, Doctoral"),
                        new XElement("Contact",
                            new XElement("Address", "Azerbaijan, Baku, Yasamal"),
                            new XElement("Phone", "000-000-00-00")
                    )
                 ),
                    new XComment("Tələbə 2"),
                    new XElement("Student",
                        new XAttribute("Id", "2"),
                        new XElement("Name", "Hər hansısa ad"),
                        new XElement("Surname", "Hər hansısa soyad"),
                        new XElement("Gender", "Male/Female"),
                        new XElement("Birthdate", "Hər hansısa tarix"),
                        new XElement("Degree", "Hər hansısa dərəcə: Associate, Bachelor's, Master's, Doctoral"),
                        new XElement("Contact",
                            new XElement("Address", "Azerbaijan, Baku, Yasamal"),
                            new XElement("Phone", "000-000-00-00")
                    )
                )
              )
             );

            document.Save(filePath);
        }
    }
}
