DROP database IF EXISTS `DBGuian`;  
create database DBGuian; 
use DBGuian; 
create table Admin(		AdminID int auto_increment primary key,
						Email varchar(40) not null,
                        Password varchar(40) not null,
                        FirstName varchar(40) not null, 
                        LastName varchar(40) not null
                      );
                      
create table Enterprise(EnterpriseID int auto_increment primary key,
						Email varchar(40) not null,
                        Password varchar(40) not null,
						Name varchar(40)not null,
                        Category varchar(40)not null,
                        RUC int not null,
                        Status varchar(10)not null
                        );       
create table Tour(		TourID int auto_increment primary key,
						Name varchar(40)not null,
                        Description varchar(9999) not null,
                        Star int,
                        Logo varchar(9999)not null,/*link*/
                        Cost decimal(6,2)not null,
                        EnterpriseID int not null 
						);
create table Place_Tour(PlaceId int not null,
						TourID int not null
                        
						);
create table Place(		PlaceID int auto_increment primary key,
						Name varchar(50)not null,
                        Audio varchar(9999),/*link*/
                        Longitud varchar(40),
                        Latitud varchar(40),
                        Description varchar(9999) not null,
                        Visits int,
                        CityID int not null
                        );         
create table City(		CityID int auto_increment primary key,
						Name varchar(40)not null,
                        Country varchar(40)not null
						);   
create table User(		UserID int auto_increment primary key,
						FirstName varchar(40)not null,
                        LastName varchar(40)not null,
                        Email varchar(40)not null,
                        Password varchar(40)not null,
                        Age int
						);
create table Place_User(PlaceID int not null,
						UserID int not null,
                        Interest bool
                        );
create table User_Tour(	UserID int not null,
                        TourID int not null
                        );
create table TopPlaces(	TopID int auto_increment primary key,
						UserID int not null
                        );
create table Place_TopPlaces(	PlaceID int not null,
								TopID int not null
                                );
/*Primary keys*/			
alter table Place_Tour add constraint PK_Place_Tour primary key(PlaceID,TourID);
alter table Place_User add constraint PK_Place_User primary key(PlaceID,UserID);
alter table User_Tour add constraint PK_User_Tour primary key(UserID,TourID);	
alter table Place_TopPlaces add constraint PK_Place_TopPlaces primary key(PlaceID,TopID);

/*Foreign keys*/				
alter table Tour add constraint FK_Tour_Enterprise foreign key(EnterpriseID)references Enterprise(EnterpriseID);
alter table Place add constraint FK_Place_City foreign key(CityID)references City(CityID);
alter table Place_Tour add constraint FK_Place_Tour_Place foreign key(PlaceID)references Place(PlaceID);
alter table Place_Tour add constraint FK_Place_Tour_Tour foreign key(TourID)references Tour(TourID);
alter table Place_User add constraint FK_Place_User_Place foreign key(PlaceID)references Place(PlaceID);
alter table Place_User add constraint FK_Place_User_User foreign key(UserID)references User(UserID);
alter table User_Tour add constraint FK_User_Tour_User foreign key(UserID)references User(UserID);
alter table User_Tour add constraint FK_User_Tour_Tour foreign key(TourID)references Tour(TourID);
alter table TopPlaces add constraint FK_TopPlaces_User foreign key(UserID)references User(UserID);
alter table Place_TopPlaces add constraint FK_Place_TopPlaces_Place foreign key(PlaceID)references Place(PlaceID);
alter table Place_TopPlaces add constraint FK_Place_TopPlaces_Top foreign key(TopID)references TopPlaces(TopID);

/*Datos de prueba*/	
insert into Admin(Email,Password,FirstName,LastName)values('a','a','David','Silva');

insert into Enterprise(Email,Password,Name,Category,RUC,Status)values('b','b','Maricarmen','Peras',123465,'PEN');

insert into City(Name,Country)values('Cuzco','Peru');
insert into City(Name,Country)values('Teotihuacan','Mexico');
insert into City(Name,Country)values('Arequipa','Peru');
insert into City(Name,Country)values('Ciudad de Mexico','Mexico');

insert into Place(Name,Audio,Longitud,Latitud,Description,Visits,CityID)values('Machu Picchu','LINK','0','0','Descripcion',0,1);
insert into Place(Name,Audio,Longitud,Latitud,Description,Visits,CityID)values('Piramide del Sol','LINK','0','0','Descripcion',0,2);
insert into Place(Name,Audio,Longitud,Latitud,Description,Visits,CityID)values('Monasterio Santa Catalina','LINK','0','0','Descripcion',0,3);
insert into Place(Name,Audio,Longitud,Latitud,Description,Visits,CityID)values('Catedral de Cuzco','LINK','0','0','Descripcion',0,1);
insert into Place(Name,Audio,Longitud,Latitud,Description,Visits,CityID)values('Catedral Metropolitana de Mexico','LINK','0','0','Descripcion',0,4);
insert into Place(Name,Audio,Longitud,Latitud,Description,Visits,CityID)values('Basílica Menor de la Inmaculada Concepción','LINK','0','0','Descripcion',0,4);


insert into Tour(Name,Description,Star,Logo,Cost,EnterpriseID)values('DiverTour','Visitaremos la catedral de cuzco, se almorzara en Don Lusho Food y en la tarde visitaremos Machu Picchu',0,'LINK del logo',122.11,1);
insert into Tour(Name,Description,Star,Logo,Cost,EnterpriseID)values('MexTour','Visitaremos la Catedral de Metropolitana de Mexico para terminar en la basilica menor de la Inamucalada Concepciion',0,'LINK del logo',32.21,1);

<<<<<<< HEAD
insert into Place_Tour(PlaceId,TourID)values(1,1);
insert into Place_Tour(PlaceId,TourID)values(2,1);
insert into Place_Tour(PlaceId,TourID)values(5,2);
insert into Place_Tour(PlaceId,TourID)values(6,2);
=======
insert into Tour(Name,Description,Star,Logo,Cost,EnterpriseID)values('TurIAN','Pase Grati a IAN',0,'LINK del logo',122.11,1);
insert into Tour(Name,Description,Star,Logo,Cost,EnterpriseID)values('PEPILANDI','Oshezii',0,'LINK del logo',32.21,1);
insert into Tour(Name,Description,Star,Logo,Cost,EnterpriseID)values('Elpirata','grasoso',0,'LINK del logo',55.15,1);

insert into Place_Tour(PlaceId,TourID)values(1,1);
insert into Place_Tour(PlaceId,TourID)values(2,1);
insert into Place_Tour(PlaceId,TourID)values(3,1);
>>>>>>> b4981fa2d33e2e42d24e8692ca0f02183bfbe7fd
