/*
(IN və NOT IN keçəndən sonrakı hissələrin praktiki və ev tapşırıqları)
Part 3:
1. In istifadə edərək Person.Person table'ından FirstName column'u Scott, Frank, Eric olan məlumatların bütün column'larını gətir.
2. In istifadə edərək Person.Person table'ından FirstName column'u Scott, Frank, Eric olan məlumatların FirstName, MiddleName, LastName column'larını FullName adı olaraq gətir.
3. Not In istifadə edərək Person.Person table'ından FirstName column'u Eugene, Barry, Jack olmayan məlumatların bütün column'larını gətir.
4. Not In istifadə edərək Person.Person table'ından FirstName column'u Eugene, Barry, Jack olmayan məlumatların BusinessEntityID column'unun toplamını Total adı olaraq gətir.
5. Person.Address table'ından bütün dataları gətir. Ancaq PostalCode column'una görə A-dan Z'yə (artan) sırala.
6. Person.Address table'ından bütün dataları gətir. Ancaq City column'una görə Z-dən A'ya (azalan) sırala.
7. Person.Address table'ından City column'una görə qruplaşdıraraq neçə adres olduğunu çıxardın. Yəni hər şəhər üçün neçə adres məlumatı var? Eyni zamanda da şəhər sayına görə azalan sıralama edin.
*/
--1
select * from Person.Person where FirstName IN ('Scott', 'Frank', 'Eric');
--2
select FirstName + ' ' + MiddleName + ' ' + LastName as FullName,* from Person.Person where FirstName IN ('Scott', 'Frank', 'Eric');
--3
select * from Person.Person where FirstName NOT IN ('Eugene', 'Barry','Jack');
--4
select sum(BusinessEntityID) as Total  from Person.Person where FirstName NOT IN ('Eugene', 'Barry','Jack');
--5
select * from Person.Address order by PostalCode;
--6
select * from Person.Address order by City desc;
--7
select City, count(AddressLine1) as CityCount from Person.Address group by City;