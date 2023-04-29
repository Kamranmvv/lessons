/*Homework 3:
AdventureWorks2017 database'ində aşağıdakı məlumatları almaq üçün lazım olan select sorğularını yazın.
Store adlı table'dan bütün column'ları select edin.
Product adlı table'dan bütün column'ları select edin.
ProductCategory adlı table'dan sadəcə ProductCategoryID və Name column'larını select edin.
AddressType adlı table'dan sadəcə AddressTypeID və Name column'larını select edin.
Document adlı table'dan sadəcə Title, FileName, ChangeNumber və Status column'larını select edin.
*/

select * from AdventureWorks2017.Sales.Store;
select * from AdventureWorks2017.Production.Product;
select ProductCategoryID, Name from AdventureWorks2017.Production.ProductCategory;
select AddressTypeID , Name from AdventureWorks2017.Person.AddressType;
select Title, Filename, ChangeNumber, Status from AdventureWorks2017.Production.Document;

/*
Homework 4:
Araşdırıb və ya düşünüb yaza biləcəyiniz bonus sorğu (yaza bilməsəniz eybi yox):
Store table'ından bütün məlumatları * ilə çəkin. Sadəcə ilk column SalesPersonID olsun.
Bu sorğuda SalesPersonID iki dəfə çıxsa da olar eybi yox.

*/

select SalesPersonID, * from AdventureWorks2017.Sales.Store;
