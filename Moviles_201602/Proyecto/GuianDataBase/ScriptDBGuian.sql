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
						Name varchar(40)not null,
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

insert into City(Name,Country)values('Lima','Peru');
insert into City(Name,Country)values('Medellin','Colombia');
insert into City(Name,Country)values('Arequipa','Peru');

insert into Place(Name,Audio,Longitud,Latitud,Description,Visits,CityID)values('Machu','AKA EL LINK','0','0','Descripzhiioon',0,1);
insert into Place(Name,Audio,Longitud,Latitud,Description,Visits,CityID)values('Pikachu','AKA EL LINK','0','0','Descripzhiioon2',0,2);
insert into Place(Name,Audio,Longitud,Latitud,Description,Visits,CityID)values('VAMOACALMARNO','AKA EL LINK','0','0','Descripzhiioon3',0,1);


				