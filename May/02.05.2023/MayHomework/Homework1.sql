/*
	1. Production.Product table'ından ProductID'si 20-dən böyük olan məlumatların bütün column'larını gətir.
	2. Production.Product table'ından ProductID'si 20-dən kiçik olan məlumatların bütün column'larını gətir.
	3. Production.Product table'ından ListPrice'ı 200-dən böyük, 500-dən kiçik olan məlumatların ProductID, Name və ListPrice
	column'larını gətir.
	4. Production.Product table'ından SafetyStockLevel'i 900-dən böyük, 1500-dən kiçik olan və ProductID'si 10 olmayan məlumatların
	bütün column'larını gətir.
	5. Production.Product table'ından ProductNumber'ı 'BA-8327' olmayan, Color'u 'Black' olan ilk 50 dənə məlumatın bütün column'larını gətir.
	6. Production.Product table'ından ListPrice'ı 500-dən kiçik və ya bərabər olan məlumatların 50%'ni gətir.
	7. Production.Product table'ından ListPrice'ı 1001-dən böyük və ya bərabər olan məlumatların 25%'ni gətir.
	8. Production.Product table'ından Color'u 'Black' və ya 'Red' olan, Color'u 'Yellow' olmayan məlumatların bütün column'larını gətir.
	9. Production.Product table'ından ProductID'si 100-dən böyük, 500-dən kiçik olan və 300, 500 olmayan məlumatların ProductID
	column'unu gətir.
	10. Production.Product table'ından SafetyStockLevel'i 800 və ya 1000 olan amma Color'u 'Black' və ya 'Blue' olmayan məlumatların
	bütün column'larını gətir.
	11. Person.Address table'ından City, PostalCode və AddressLine1 column'larının dəyərlərini aralarında vergül olmaqla FullAddress
	column adı ilə çəkin.
*/
--1
select * from Production.Product where ProductID > 20;
--2
select * from Production.Product where ProductID < 20;
--3
select ProductID, Name, ListPrice from Production.Product where ListPrice > 200 and ListPrice < 500;
--4
select * from Production.Product where (SafetyStockLevel > 900 and SafetyStockLevel < 1500) and ProductID != 10;
--5
select top 50 * from Production.Product where ProductNumber != 'BA-8327' and Color = 'Black';
--6
select top 50 percent * from Production.Product where ListPrice <= 500;
--7
select top 25 percent * from Production.Product where ListPrice >= 1001;
--8
select * from Production.Product where (Color = 'Black' or Color = 'Red') and Color != 'Yellow';
--9
select * from Production.Product where ProductID > 100 and ProductID < 500  and ProductID != 300 and ProductID != 500;
--10
select * from Production.Product where (SafetyStockLevel = 800 or SafetyStockLevel = 1000) and (Color != 'Black' or Color != 'Blue');
--11
select City + ',' + PostalCode + ',' + AddressLine1 as FullAddress from Person.Address;
