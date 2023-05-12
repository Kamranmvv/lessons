/*
1. Teachers adında bir table yaradın. 5 column olsun.
2. Insert əmriylə 5 fərqli məlumat əlavə edin.
3. Məlumatları əlavə etdikdən sonra, məlumatları update edin. Update sorğularınızı müxtəlif yazın. 
   Yəni bir sorğuda 1, digərində 2 column update olsun.
   Bütün update sorğularında where istifadə edin (and or da olsun).
4. Table'dan müəyyən etdiyiniz şərtləri təmin edən dataları silin. Məsələn adı 'Ceyhun' olan datanı, Id'si 2 olan və s.
*/
create database School
create table Teachers(
		Id int primary key,
		Name nvarchar(100),
		Surname nvarchar(100),
		Email nvarchar(100),
		Age int);

select* from Teachers
insert into Teachers(Id,Name,Surname,Email,Age) values (5,'Orkhan','Reis','patrickbob@gmail.com',21);

update Teachers set Email = 'kamranmv1@gmail.com' where Id = 1
update Teachers set Surname = 'Mammadov' where Name = 'Kamran' or Name = 'Semender'
update Teachers set Name ='Samandar' where Id = 3
update Teachers set Age = 20 , Surname = null where Id >= 3 And Age = 21

delete Teachers where Name = 'Kamran'
delete Teachers where Age>=22
delete Teachers where Id = 5


/*
Homework 2:
Kod yazaraq aşağıdakı table'ı yaradın. Sonra, UI tərəfdə də eynisini edin sadəcə table adının sonuna UI yazın ki, eyni adda iki table olmaz.
Həm kod, həm də UI tərəfdə bu iki table'ı yaratdıqdan sonra UI ilə yaratdığınızı silə bilərsiniz. Sadəcə məşğələ məqsədi daşıyır. Ancaq Personals
lazım olacaq. Yaradandan sonra aşağıdakı text'i oxuyun...

Personals:
		id rəqəm avtomatik artan deyer, boş buraxıla bilməz, təkrarlana bilməz (avtomatik artan dəyəri necə yazacağınızı araşdırın)
		name (50 simvollu mətn), boş buraxıla bilməz
		surname (50 simvollu mətn), boş buraxıla bilməz
		email (250 simvollu mətn), boş buraxıla bilməz, eynisi olmamalıdır
		gender (bunu araşdırın ki, 1 simvolu hansı tip datada saxlaya bilərsiniz? bit olmasın.)
		createdDate ,default olaraq indiki zamanı alsın, boş ola bilməz
		updatedDate boş ola bilər
		isDeleted boş olduğu halda false olsun

Aşağıda yazdığım select sorğusu sizə AdventureWorks database'indən müəyyən datalar qaytaracaq. Sizin etməli olduğunuz, aşağıdakı sorğuda sizə gələn
dataları, yuxarıda yaratdığınız Personals table'ınıza insert etməyinizdir. Ad, Soyad, Cinsiyyət select sorğusundan gəldiyi kimi daxil ediləcək. Email
ünvanı isə, ad.soyad@gmail.com formatında olacaq. Məsələn orxan.ferecov@gmail.com.
Aşağıdakı sorğuda sizə gələn ad və soyad ilə email generate edəcəksiniz. Ad və soyad böyük hərflə başlayır. Siz araşdırma edərək ad və soyad'dan email
generate edən zaman ad və soyad'ı kiçik hərflərə çevirməyi tapmalısınız. yəni Orxan Ferecov üçün orxan.ferecov@gmail.com generate olunacaq. Bu taskı
etmək üçün, internetdən araşdırma etməlisiniz. Bir select sorğusundan gələn nəticəni başqa table'a insert etməyi öyrənməlisiniz.

	select * from Person.Person as PP
	inner join HumanResources.Employee HRE on
	PP.BusinessEntityId = HRE.BusinessEntityId
*/

Create database Company
create table Personals (
		Id int identity(1,1) primary key,
		Name nvarchar(50) not null,
		Surname nvarchar(50) not null,
		Email nvarchar(250) not null unique,
		Gender char(1),
		CreatedDate datetime default getdate(),
		UpdatedDate datetime,
		IsDeleted bit default 0
		)

select * from Personals

insert into Personals (Name,Surname,Email,Gender) 
Select
	pp.FirstName as Name,
	pp.LastName as Surname,
	lower(concat(pp.FirstName, '.',pp.LastName,'@gmail.com')) as Email,
	HRE.Gender as Gender
	
	
from AdventureWorks2017.Person.Person as pp
INNER JOIN AdventureWorks2017.HumanResources.Employee HRE ON PP.BusinessEntityID = HRE.BusinessEntityID;


/*
Homework 2:
	Aşağıda yazdığım select sorğusunda hər iki table'dan column'lar gəlir. Siz elə etməlisiniz ki,
	BusinessEntityID column'u Id olaraq, 
	Firstname column'u Name olaraq,
	LastName column'u Surname olaraq,
	əlavə Email column'u Firstname və Lastname'dən 
	istifadə edərək kiçik hərflə orkhan.farajov@gmail.com olaraq, 
	Gender, 
	əlavə Date column'unda indiki tarixi almalısınız.

	select * from Person.Person as PP
	inner join HumanResources.Employee HRE on
	PP.BusinessEntityId = HRE.BusinessEntityId
*/
select 
PP.BusinessEntityID Id,
PP.FirstName Name,
PP.LastName Surname,
(lower(PP.FirstName) + '.' + lower(PP.LastName) + '@gmail.com') as Email,
HRE.Gender,
getdate() as Date from Person.Person as PP
inner join HumanResources.Employee HRE on
PP.BusinessEntityId = HRE.BusinessEntityId