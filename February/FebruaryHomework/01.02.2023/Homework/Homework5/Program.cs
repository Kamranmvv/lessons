using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Homework Text
            /* Homework 5:
            İlk öncə aşağıdakı kimi bir menu çıxsın ekranda.

                Menu:
                1 - Element elave et
                2 - Elementleri goster
                3 - Element axtar
                4 - Element editle
                5 - Element sil
                6 - Exit
                Emeliyyat novunu secin:

                Əməliyyat növünü user seçdikdən sonra aşağıdakı kimi proses davam edəcək...
                1:
                Soruşacaq: "Zehmet olmasa elave etmek istediyiniz elementi daxil edin: "
                Daxil edəndən sonra: "Element elave olundu!"

                2:
                Bunu seçəndə bütün elementlər aşağıdakı kimi göstəriləcək.
                1. Element = 15
                2. Element = Salam
                3. Element = Hi
                Burdan çıxmaq üçündə "Davam etmek ucun Enter'e basin" yazısı görsənəcək.

                3:
                Bunu seçəndə aşağıdakı yazı çıxacaq.
                "Axtarmaq istediyiniz elementi daxil edin: "
                Daxil edəndən sonra əgər tapılıbsa, aşağıdakı yazı çıxsın
                "Element tapildi : Index :0 - Deyer: Salam"
                tapılmayıbsa bu yazı çıxsın
                "Axtardiginiz element tapilmadi".

                4:
                "Editlemek istediyiniz elementi daxil edin : " yazısı çıxsın və məsələn Salam sözünü editləmək istəyirsə,
                ilk öncə yoxlayın Salam elementi var mı? Yoxdursa bu yazı çıxsın:
                "Axtardiginiz element tapilmadi"
                Varsa:
                "Salam elementini ne ile evezlemek isteyirsiniz?"
                Editləyəndən sonra da "Element editlendi!" yazısı çıxsın.

                5:
                İlk öncə bunu soruşsun:
                "Butun elementleri silmek isteyirsiniz? (H/Y)"
                əgər cavab H olarsa o zaman bütün elementləri silib "Butun elementler silindi" yazısı çıxsın.
                əgər cavab Y olarsa o zaman "Silmek istediyiniz elementi daxil edin: " yazısı çıxsın və məsələn adam Salam daxil etdisə 
                ilk öncə yoxlayın Salam var mı? Varsa silib "Element silindi" yazın yoxdursa "Silmek istediyiniz element tapilmadi!" yazısı
                çıxsın.
*/
            #endregion 

            Console.WriteLine("Menu:");
            Console.WriteLine("1 - Element elave et");
            Console.WriteLine("2 - Elementleri goster");
            Console.WriteLine("3 - Element axtar");
            Console.WriteLine("4 - Element editle");
            Console.WriteLine("5 - Element sil");
            Console.WriteLine("6 - Exit");
            Console.WriteLine("Emeliyyat novunu secin:");

            int operationValue = 0;
            string operationValueStr = Console.ReadLine();
            bool isInt = int.TryParse(operationValueStr, out operationValue);

            while (isInt == false)
            {
                Console.WriteLine("Eded daxil edin!");
                operationValueStr = Console.ReadLine();
                isInt = int.TryParse(operationValueStr, out operationValue);
            }
            if (isInt == true)
            {
                ArrayList elements = new ArrayList();
                elements.Add("Arrays");
                elements.Add("Data Types");
                elements.Add("Comments");
                elements.Add("Variables");
                elements.Add("Methods");
                elements.Add("Strings");
                elements.Add("Boolens");
                elements.Add("Loops");


                Console.Clear();
                switch (operationValue)
                {
                    case 1:
                        Console.WriteLine("Zehmet olmasa elave etmek istediyiniz elementi daxil edin: ");
                        elements.Add(Console.ReadLine());
                        Console.WriteLine("Element elave olundu!");
                        goto case 7;
                    case 2:
                        foreach (var item in elements)
                        {
                            int i = elements.IndexOf(item);
                            Console.WriteLine((i + 1) + ". Element = " + item);

                        }
                        Console.WriteLine("Davam etmek ucun Enter'e basin");
                        Console.ReadLine();
                        goto case 7;
                    case 3:
                        Console.WriteLine("Axtarmaq istediyiniz elementi daxil edin: ");
                        var checkElement = Console.ReadLine();
                        bool isExist = elements.Contains(checkElement);
                        if (isExist == true)
                        {
                            int i = elements.IndexOf(checkElement);
                            Console.WriteLine("Element tapildi : Index :{0} - Deyer: {1}", i, elements[i]);
                        }
                        else
                            Console.WriteLine("Axtardiginiz element tapilmadi");
                        goto case 7;
                    case 4:
                        Console.WriteLine("Editlemek istediyiniz elementi daxil edin : ");
                        var checkEditElement = Console.ReadLine();
                        bool isExist1 = elements.Contains(checkEditElement);
                        if (isExist1 == true)
                        {
                            int i = elements.IndexOf(checkEditElement);
                            Console.WriteLine("Salam elementini ne ile evezlemek isteyirsiniz?");
                            var changeValueOfElement = Console.ReadLine();
                            elements[i] = changeValueOfElement;
                            Console.WriteLine("Element editlendi!");
                        }
                        else
                            Console.WriteLine("Axtardiginiz element tapilmadi");
                        goto case 7;
                    case 5:
                        Console.WriteLine("Butun elementleri silmek isteyirsiniz? (H/Y)");
                        char yesOrNo = Convert.ToChar(Console.ReadLine().ToUpper());
                        if (yesOrNo == 'H')
                        {
                            elements.Clear();
                            Console.WriteLine("Butun elementler silindi");
                        }
                        else if (yesOrNo == 'Y')
                        {

                            Console.WriteLine("Silmek istediyiniz elementi daxil edin: ");
                            var checkRemoveElement = Console.ReadLine();
                            bool isExist2 = elements.Contains(checkRemoveElement);
                            if (isExist2 == true)
                            {
                                elements.Remove(checkRemoveElement);
                                Console.WriteLine("Element silindi!");
                            }
                            else
                                Console.WriteLine("Silmek istediyiniz element tapilmadi!");
                        }
                        goto case 7;


                    case 6:
                        Environment.Exit(1);

                        break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine("Menu:");
                        Console.WriteLine("1 - Element elave et");
                        Console.WriteLine("2 - Elementleri goster");
                        Console.WriteLine("3 - Element axtar");
                        Console.WriteLine("4 - Element editle");
                        Console.WriteLine("5 - Element sil");
                        Console.WriteLine("6 - Exit");
                        Console.WriteLine("Emeliyyat novunu secin:");

                        int secondOperationValue = 0;
                        string secondOperationValueStr = Console.ReadLine();
                        bool isInt1 = int.TryParse(secondOperationValueStr, out secondOperationValue);

                        while (isInt1 == false)
                        {
                            Console.WriteLine("Eded daxil edin!");
                            secondOperationValueStr = Console.ReadLine();
                            isInt = int.TryParse(secondOperationValueStr, out secondOperationValue);
                        }
                        if (isInt1 == true) {
                            if (secondOperationValue == 1)
                                goto case 1;

                            else if (secondOperationValue == 2)
                                goto case 2;
                            else if (secondOperationValue == 3)
                                goto case 3;
                            else if (secondOperationValue == 4)
                                goto case 4;
                            else if (secondOperationValue == 5)
                                goto case 5;
                            else if (secondOperationValue == 6)
                                goto case 6;
                            else
                                Console.WriteLine("Yanlis secim!!!");
                            goto case 7;

                        }
                            break;
                    default:
                        break;

                   
                }



            }


            Console.ReadLine();



        }
    }
}
