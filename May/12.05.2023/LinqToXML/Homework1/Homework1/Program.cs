using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             Homework 1:
             FakeData'dan istifadə edib 3 XML faylı üzərində iş görəcəksiniz. Students, Teachers və Stuffs adında 3 XML faylına dinamik
             olaraq məlumat əlavə edəcəksiniz. Proqramı run edəndə, hər faylın içinə 1000 nəfər insan məlumatı əlavə edilməlidir. Student,
             Teacher və Stuff property'lərini özünüz seçə bilərsiniz. Ancaq hər birində ən az 5 property olsun.
*/
            #region Create Folder and Files
            string folderPath = @"C:\XML";
            string filePath1 = Path.Combine(folderPath, "Students.xml");
            string filePath2 = Path.Combine(folderPath, "Stuffs.xml");
            string filePath3 = Path.Combine(folderPath, "Teachers.xml");

            Directory.CreateDirectory(folderPath);
            File.Create(filePath1).Close();
            File.Create(filePath2).Close();
            File.Create(filePath3).Close();

            #endregion

            #region Student

            List<Student> students = new List<Student>();

            for (int i = 0; i < 1000; i++)
            {
                Student student = new Student();
                student.Id = Guid.NewGuid();
                student.Name = FakeData.NameData.GetFirstName();
                student.Surname = FakeData.NameData.GetSurname();
                student.PhoneNumber = FakeData.PhoneNumberData.GetPhoneNumber();
                student.EmailAddress = FakeData.NetworkData.GetEmail();

                students.Add(student);
            }

            XDocument docStudents = new XDocument(
                new XDeclaration("1.0", "UTF-8", "yes"),
                    new XElement("Students",
                        students.Select(m =>
                            new XElement("Student",
                                new XElement("Id", m.Id),
                                new XElement("Name", m.Name),
                                new XElement("Surname", m.Surname),
                                new XElement("PhoneNumber", m.PhoneNumber),
                                new XElement("EmailAddress", m.EmailAddress)
                                )
                             )
                          )
                       );
            docStudents.Save(filePath1);
            #endregion

            #region Teacher 

            List<Teacher> teachers = new List<Teacher>();

            for (int i = 0; i < 1000; i++)
            {
                Teacher teacher = new Teacher();
                teacher.Id = Guid.NewGuid();
                teacher.Name = FakeData.NameData.GetFirstName();
                teacher.Surname = FakeData.NameData.GetSurname();
                teacher.PhoneNumber = FakeData.PhoneNumberData.GetPhoneNumber();
                teacher.EmailAddress = FakeData.NetworkData.GetEmail();
                teacher.DateRegistration = FakeData.DateTimeData.GetDatetime();

                teachers.Add(teacher);
            }

            XDocument docTeachers = new XDocument(
                new XDeclaration("1.0", "UTF-8", "yes"),
                    new XElement("Teachers",
                        teachers.Select(m =>
                            new XElement("Teacher",
                                new XElement("Id", m.Id),
                                new XElement("Name", m.Name),
                                new XElement("Surname", m.Surname),
                                new XElement("PhoneNumber", m.PhoneNumber),
                                new XElement("EmailAddress", m.EmailAddress),
                                new XElement("DateRegistration", m.DateRegistration)
                                )
                             )
                          )
                       );
            docTeachers.Save(filePath3);
            #endregion

            #region Stuff

            List<Stuff> stuffs = new List<Stuff>();

            for (int i = 0; i < 1000; i++)
            {
                Stuff stuff = new Stuff();
                stuff.Id = Guid.NewGuid();
                stuff.Name = FakeData.NameData.GetFirstName();
                stuff.Surname = FakeData.NameData.GetSurname();
                stuff.PhoneNumber = FakeData.PhoneNumberData.GetPhoneNumber();
                stuff.EmailAddress = FakeData.NetworkData.GetEmail();
                stuff.Country = FakeData.PlaceData.GetCountry();

                stuffs.Add(stuff);
            }

            XDocument docStuffs = new XDocument(
                new XDeclaration("1.0", "UTF-8", "yes"),
                    new XElement("Stuffs",
                        stuffs.Select(m =>
                            new XElement("Stuff",
                                new XElement("Id", m.Id),
                                new XElement("Name", m.Name),
                                new XElement("Surname", m.Surname),
                                new XElement("PhoneNumber", m.PhoneNumber),
                                new XElement("EmailAddress", m.EmailAddress),
                                new XElement("Country", m.Country)
                                )
                             )
                          )
                       );
            docStuffs.Save(filePath2);
            #endregion


            /*Homework 2:
             1-ci ev tapşırığını edəndən sonra Students.xml, Teachers.xml və Stuffs.xml içindəki məlumatları List<Student>, List<Teacher>
             və List<Stuff> içərisinə çəkməlisiniz.
*/

            XDocument readStudentsXML = XDocument.Load(filePath1);
            List<XElement> studentElements = readStudentsXML.Descendants("Student").ToList();

            List<Student> readStudents = new List<Student>();

            foreach (XElement item in studentElements)
            {
                Student student = new Student();
                student.Id = Guid.Parse(item.Element("Id").Value);
                student.Name = item.Element("Name").Value;
                student.Surname = item.Element("Surname").Value;
                student.PhoneNumber = item.Element("PhoneNumber").Value;
                student.EmailAddress = item.Element("EmailAddress").Value;

                readStudents.Add(student);
            }

            XDocument readTeachersXML = XDocument.Load(filePath3);
            List<XElement> teacherElements = readTeachersXML.Descendants("Teacher").ToList();

            List<Teacher> readTeachers = new List<Teacher>();

            foreach (XElement item in studentElements)
            {
                Teacher teacher = new Teacher();
                teacher.Id = Guid.Parse(item.Element("Id").Value);
                teacher.Name = item.Element("Name").Value;
                teacher.Surname = item.Element("Surname").Value;
                teacher.PhoneNumber = item.Element("PhoneNumber").Value;
                teacher.EmailAddress = item.Element("EmailAddress").Value;
                XElement dateRegistrationElement = item.Element("DateRegistration");
                if (dateRegistrationElement != null && !string.IsNullOrEmpty(dateRegistrationElement.Value))
                {
                    teacher.DateRegistration = DateTime.Parse(dateRegistrationElement.Value);
                }
                else
                {
                    teacher.DateRegistration = DateTime.MinValue;
                }
                readTeachers.Add(teacher);
            }


            XDocument readStuffsXML = XDocument.Load(filePath2);
            List<XElement> stuffElements = readStuffsXML.Descendants("Stuff").ToList();

            List<Stuff> readStuffs = new List<Stuff>();

            foreach (XElement item in studentElements)
            {
                Stuff stuff = new Stuff();
                stuff.Id = Guid.Parse(item.Element("Id").Value);
                stuff.Name = item.Element("Name").Value;
                stuff.Surname = item.Element("Surname").Value;
                stuff.PhoneNumber = item.Element("PhoneNumber").Value;
                stuff.EmailAddress = item.Element("EmailAddress").Value;
                //stuff.Country = item.Element("Country").Value;
                readStuffs.Add(stuff);
            }
        }
    }

}

