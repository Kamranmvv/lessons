
	--VACİB QEYD: Taskların heç birini edərkən qətiyyən copy-paste etməyin. Bütün sorğuları bir-bir özünüz yazın.
	--Bütün taskları Adventure Works database'ində işləyəcəksiniz. Table seçimlərini sizə həvalə edirəm.
	
	--Homework 1:
	--Ən az 10 fərqli table'dan məlumat select edin.

use AdventureWorks2017;

select * from Person.Address;
select * from Person.Password;
select * from Production.Location;
select * from Production.Product;
select * from HumanResources.Department;

select AddressID,AddressLine1,AddressLine2 from Person.Address;
select PasswordHash, PasswordSalt from Person.Password;
select LocationID,ModifiedDate from Production.Location;
select ProductID,ProductNumber,ProductSubcategoryID from Production.Product;
select DepartmentID,Name,GroupName from HumanResources.Department;

---------------------------------------------------------------------------------------------------------------------------
	
	--Homework 2:
	--Ən az 5 fərqli table'dan məlumat select edin. Hər select sorğusunda where'da 1 column'a şərt qoyun.

select * from Person.Person where FirstName = 'Michael';
select * from Person.PersonPhone where PhoneNumber = '150-555-0189';
select * from Person.StateProvince where CountryRegionCode = 'US';
select * from Sales.SalesPerson where SalesQuota = '250000.0000';
select * from Sales.CreditCard where CardType = 'Vista';

---------------------------------------------------------------------------------------------------------------------------

	--Homework 3:
	--Ən az 5 fərqli table'dan məlumat select edin. Hər select sorğusunda where'da 2 column'a şərt qoyun (and ilə).

select * from HumanResources.Employee where MaritalStatus = 'M' and Gender = 'M';
select * from Person.Person where FirstName like 'T%' and EmailPromotion = '0';
select * from Person.Person where MiddleName = 'T' and EmailPromotion = '2';
select * from Production.Product where Name like 'Flat Washer%' and ProductNumber = 'FW-5800';
select * from Person.Person where LastName = 'Martinez' and FirstName like '%k';

---------------------------------------------------------------------------------------------------------------------------

	--Homework 4:
	--Ən az 5 fərqli table'dan məlumat select edin. Hər select sorğusunda where'da 2 column'a şərt qoyun (or ilə).
	
select * from Sales.Currency where CurrencyCode = 'AZM' or Name = 'Lek';
select * from Sales.Customer where TerritoryID = '1' or TerritoryID = '9'; --where TerritoryID IN ('1', '9');
select * from Sales.SalesPerson where SalesQuota = '300000.0000' or TerritoryID = '4';
select * from Sales.Store where SalesPersonID = '279' or Name like 'Se%';
select FirstName, LastName from Person.Person where MiddleName = 'T' or EmailPromotion = '1';

---------------------------------------------------------------------------------------------------------------------------

	--Homework 5:
	--Ən az 5 fərqli table'dan məlumat select edin. Hər select sorğusunda where'da 4 column'a şərt qoyun (and ilə).

select * from Production.Product where Color = 'Black' and StandardCost >90 and ReorderPoint<1000 and MakeFlag = 'True'; -- MakeFlag = 1
select * from HumanResources.Employee where OrganizationLevel = '1' and Gender = 'F' and SalariedFlag = 1 and BirthDate>'1952';
select * from Sales.SalesOrderHeader where BillToAddressID > 111 and Freight > 1000 and TaxAmt > 2000 and CreditCardID like '%1%';
select * from Purchasing.Vendor where BusinessEntityID like '%15%' and Name like '%a%' and ActiveFlag = 1 and CreditRating = '2';
select * from Person.Person where FirstName like 'J%' and Title is null and MiddleName = 'A' and LastName like '%s%';

---------------------------------------------------------------------------------------------------------------------------

	--Homework 6:
	--Ən az 5 fərqli table'dan məlumat select edin. Hər select sorğusunda where'da 4 column'a şərt qoyun (or ilə).

select * from Sales.Customer where TerritoryID = '1' or StoreID = '1326' or CustomerID like '10%' or rowguid = 'd1e756e0-a0d1-43d6-a7cb-ac5c5ef404e7';
select * from HumanResources.Employee where BirthDate > '1965' or MaritalStatus = 'S' or Gender = 'F' or VacationHours > 90;
select * from Sales.SalesOrderHeader where OnlineOrderFlag = 1 or RevisionNumber = 7 or TerritoryID = 1 or CustomerID like '%29%';
select * from Sales.SalesOrderDetail where ProductID like '77%' or UnitPrice< 50 or OrderQty >=3 or SalesOrderDetailID = 21;
select * from Production.Product where Name like '%ade' or MakeFlag = 0 or DaysToManufacture = 1 or ReorderPoint between 300 and 500;

---------------------------------------------------------------------------------------------------------------------------

	--Homework 7:
	--Ən az 6 fərqli table'dan məlumat select edin. Hər select sorğusunda where'da 3-4 column'a şərt qoyun (and və or ilə).

select * from Person.Person where (FirstName like 'J%' and LastName like 'G%') or MiddleName is null;
select * from Production.Product where (Name like '%Flat%' or MakeFlag = 1) and (DaysToManufacture = 0 or Class = 'L');
select * from Sales.SalesOrderHeader where (CustomerID like '%298%' and TerritoryID = '5') or RevisionNumber = '10';
select * from HumanResources.Employee where Gender = 'M' and (OrganizationLevel >3 or VacationHours <78);
select * from Sales.Customer where (StoreID >1000 and TerritoryID = '4') or StoreID not between 900 and 1000;
select * from Sales.SalesTerritory where (CountryRegionCode = 'US' or Name != 'France') and SalesYTD>1;

---------------------------------------------------------------------------------------------------------------------------

	--Homework 8:
	--5 fərqli table'dan ilk 5, 10, 15, 20, 25 məlumatı çəkməyə çalışın. Birindən ilk 5, digərindən ilk 10 və s.

select top 5 * from Person.Person;
select top 10 * from Production.Product;
select top 15 * from Sales.Customer;
select top 20 * from Sales.Store;
select top 25 * from Purchasing.Vendor;

---------------------------------------------------------------------------------------------------------------------------

	--Homework 9:
	--Sales.SalesOrderDetail table'dan CarrierTrackingNumber'ində 480 rəqəmi keçən, OrderQty'i 15 olmayanları gətirin.
	
select * from Sales.SalesOrderDetail where CarrierTrackingNumber like '%480%' and OrderQty != '15';

---------------------------------------------------------------------------------------------------------------------------

	--Homework 10:
	--Sales.SalesOrderDetail table'dan UnitPrice'ı 250-dən böyük və ya bərabər olan amma 125 olmayan,
	--ProductID'si 1-dən böyük və 1000-dən kiçik və ya bərabər olanları gətirin

select * from Sales.SalesOrderDetail where UnitPrice>=250 and UnitPrice!=125;

---------------------------------------------------------------------------------------------------------------------------

	--Homework 11:
	--1. Person.PersonPhone table'ından PhoneNumber column'unda 15 rəqəmi olan məlumatların bütün column'larını gətir.
		select * from Person.PersonPhone where PhoneNumber like '%15%';

	--2. Person.PersonPhone table'ından PhoneNumber'i 1 rəqəmilə başlayan məlumatların bütün column'larını gətir.
		select * from Person.PersonPhone where PhoneNumber like '1%';

	--3. Person.PersonPhone table'ından PhoneNumber'i 15 rəqəmilə bitən məlumatların bütün column'larını gətir.
		select * from Person.PersonPhone where PhoneNumber like '%15';

	--4. Person.PersonPhone table'ından PhoneNumber column'unda 82 rəqəmi olan məlumatların bütün column'larını gətir.
		select * from Person.PersonPhone where PhoneNumber like '%82%';

	--5. Person.ContactType table'ından Name column'unda a hərfi olan məlumatların bütün column'larını gətir.
		select * from Person.ContactType where Name like '%a%';

	--6. Person.ContactType table'ından Name'i r hərfilə başlayan məlumatların bütün column'larını gətir.
		select * from Person.ContactType where Name like 'r%';

	--7. Person.ContactType table'ından Name'i s hərfilə bitən məlumatların bütün column'larını gətir.
		select * from Person.ContactType where Name like '%s';

	--8. Person.Person table'ından FirstName'i a hərfilə bitən və o hərfilə başlayan məlumatların bütün column'larını gətir.
		select * from Person.Person where FirstName like '%a' and FirstName like 'o%';

	--9. Person.Person table'ından FirstName'i a hərfilə bitən və o hərfilə başlayan və LastName'ında 'ver' sözü olan məlumatların bütün column'larını gətir.
		select * from Person.Person where (FirstName like '%a%' and FirstName like 'o%') and LastName like '%ver%';

	--10. Person.Person table'ından FirstName'i a hərfilə bitən və PersonType'ı ZT olmayan ilk 40 məlumatın bütün column'larını gətir.
		select top 40 * from Person.Person where FirstName like '%a' and PersonType !='ZT' ;


					






