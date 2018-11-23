/*
SQLyog Community Edition- MySQL GUI v8.01 
MySQL - 5.1.30-community : Database - de0707
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

CREATE DATABASE /*!32312 IF NOT EXISTS*/de0707 /*!40100 DEFAULT CHARACTER SET latin1 */;

USE de0707;

/*Table structure for table empleados */

DROP TABLE IF EXISTS empleados;

CREATE TABLE empleados (
  cedula char(13) DEFAULT NULL,
  nombre varchar(30) DEFAULT NULL,
  apellido1 varchar(15) DEFAULT NULL,
  apellido2 varchar(15) DEFAULT NULL,
  direccion varchar(100) DEFAULT NULL,
  telefono char(14) DEFAULT NULL,
  celular char(14) DEFAULT NULL,
  fecha_nacimiento date DEFAULT NULL,
  sexo char(1) DEFAULT NULL,
  estado tinyint(1) DEFAULT NULL,
  fecha_ingreso date DEFAULT NULL,
  fecha_reg date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table empleados */

insert  into empleados(cedula,nombre,apellido1,apellido2,direccion,telefono,celular,fecha_nacimiento,sexo,estado,fecha_ingreso,fecha_reg) values ('051-0000982-1','JULIANA','MARIA','ROSARIO','VILLA TAPIA','(809) 574-0920','(   )    -','1977-06-16','F',1,'2009-12-15','2010-06-16'),('051-0004132-5','MARIA AURORA','GONZALEZ','JORGE','URBANIZACION LOS MAESTROS, APTO. 1B','(809) 574-3097','(829) 379-5319','1976-04-01','F',1,'1998-02-01','2010-06-16'),('051-0002136-7','JULIO','POLANCO','SOSA','SAN JOSE, VILLA TAPIA','(809) 574-0921','(829) 213-2019','1977-06-16','M',1,'2009-08-11','2010-06-20'),('051-0008989-8','MARIA','MARTINEZ','SANTANA','EL COCO, VILLA TAPIA','(809) 574-1289','(829) 647-8182','1968-06-16','F',1,'2009-05-20','2010-06-20'),('051-0909384-0','HENRY ELOE','LOPEZ','SALCEDO','EL TABLON, VILLA TAPIA','(809) 434-3641','(829) 762-3271','1982-04-01','M',1,'2005-02-01','2010-06-20'),('051-0031928-7','AMABLE','JAQUEZ','SANTANA','MONTE PLATA, VILLA TAPIA','(809) 444-1070','(   )    -','1970-04-01','M',1,'2002-02-01','2010-06-20'),('051-0009897-9','LUZ MARIA','SOLANO','SANTOS','SABANA ANGOSTA, VILLA TAPIA','(829) 532-4029','(   )    -','1968-06-16','F',1,'2005-05-20','2010-06-20'),('051-0001293-8','BASILIA','MARIA','','EL HOSPITAL, VILLA TAPIA','(809) 574-0980','(   )    -','1976-06-16','F',1,'2005-05-20','2010-06-20'),('051-0008199-2','XIOMARA','MARTINEZ','','HOSTOS, SAN FRANCISCO DE MACORIS','(809) 588-0809','(   )    -','2002-02-01','M',1,'2002-02-01','2010-05-31'),('051-0019574-1','BIENVENIDA ANTOMIA','NUÑEZ','HENRIQUEZ','VILLA TAPIA','(809) 574-3305','(   )    -','1980-06-01','F',1,'2006-04-26','2010-06-10'),('051-0002496-6','MARIA RUMERIS ALTAGRACIA','VELEZ','','VILLA TAPIA','(809) 574-3305','(   )    -','1959-06-16','F',1,'2004-10-08','2010-09-09'),('051-0005585-3','ANA CRISTINA','GUZMAN','DE TORIBIO','VILLA TAPIA','(809) 574-3305','(   )    -','1955-06-01','F',0,'1973-11-01','2010-09-28'),('055-0014024-8','MARIA MARGARITA','CRUZ','MARIA','SAN JOSE DE CONUCO, VILLA TAPIA','(809) 574-3305','(   )    -','1965-06-01','F',1,'1975-07-01','2010-09-29'),('051-0000958-7','LUZ MARIA','ABREU','ROSARIO','SABANA ANGOSTA, VILLA TAPIA','(809) 574-3305','(   )    -','1950-06-16','F',1,'2000-01-01','2010-09-30'),('051-0018369-7','MARTINA','PERALTA','VASQUEZ','VILLA TAPIA','(809) 574-3305','(   )    -','1960-06-16','F',1,'2007-10-09','2010-10-05'),('001-0558360-3','FELIX MARIA ','VALERIO ','SANCHEZ','SANTA ANA, VILLA TAPIA','(809) 574-3305','(   )    -','1958-06-01','M',1,'1984-08-01','2010-10-26'),('051-0014785-8','WENDI JOSEFINA','FERNANDEZ','MONEGRO','VILLA TAPIA','(809) 574-3305','(   )    -','1964-06-01','F',1,'2005-04-25','2010-10-26');

/*Table structure for table tblareas_curso */

DROP TABLE IF EXISTS tblareas_curso;

CREATE TABLE tblareas_curso (
  IDcurso int(11) DEFAULT NULL,
  CodigoArea int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table tblareas_curso */

insert  into tblareas_curso(IDcurso,CodigoArea) values (1,1),(1,2),(1,3),(1,4),(1,7),(1,8),(1,11),(2,1),(2,2),(2,3),(2,4),(2,7),(2,8),(2,11),(3,1),(3,2),(3,3),(3,4),(3,7),(3,8),(3,11),(4,1),(4,2),(4,3),(4,4),(4,7),(4,8),(4,11),(5,1),(5,2),(5,3),(5,4),(5,7),(5,8),(5,11),(6,1),(6,2),(6,3),(6,4),(6,7),(6,8),(6,11),(7,2),(7,3),(7,4),(7,5),(7,6),(7,7),(7,8),(8,1),(8,2),(8,3),(8,4),(8,5),(8,6),(8,7),(8,8),(8,11),(9,1),(9,2),(9,3),(9,4),(9,5),(9,6),(9,7),(9,8),(9,11),(7,1),(7,11),(10,1),(10,2),(10,3),(10,4),(10,5),(10,6),(10,7),(10,8),(10,11),(11,1),(11,2),(11,3),(11,4),(11,5),(11,6),(11,7),(11,8),(11,11),(12,1),(12,2),(12,3),(12,4),(12,5),(12,6),(12,7),(12,8),(12,11),(12,12),(13,1),(13,2),(13,3),(13,4),(13,5),(13,6),(13,7),(13,8),(13,11),(14,1),(14,2),(14,3),(14,4),(14,5),(14,6),(14,7),(14,8),(14,11),(14,13),(15,1),(15,2),(15,3),(15,4),(15,5),(15,6),(15,7),(15,8),(15,11),(15,13);

/*Table structure for table tblareasdocentes */

DROP TABLE IF EXISTS tblareasdocentes;

CREATE TABLE tblareasdocentes (
  CodigoArea int(11) NOT NULL,
  NomArea varchar(50) DEFAULT NULL,
  PRIMARY KEY (CodigoArea)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table tblareasdocentes */

insert  into tblareasdocentes(CodigoArea,NomArea) values (1,'MATEMATICA'),(2,'LENGGUA ESPAÑOLA'),(3,'CIENCIAS SOCIALES'),(4,'CIENCIAS NATURALES'),(5,'INGLES'),(6,'FRANCES'),(7,'EDUCACION FISICA'),(8,'EDUCACION ARTISTICA'),(9,'ANIMACIÓN SOCIO- CULTURAL'),(10,'EDUCACIÓN EN GÉNERO'),(11,'F.I.H.R.'),(12,'EDUCACION CIVICA'),(13,'INFORMATICA');

/*Table structure for table tblcargos */

DROP TABLE IF EXISTS tblcargos;

CREATE TABLE tblcargos (
  IDcargo int(11) NOT NULL AUTO_INCREMENT,
  nombreCarg varchar(50) DEFAULT NULL,
  tipo tinyint(4) DEFAULT NULL,
  PRIMARY KEY (IDcargo)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=latin1;

/*Data for the table tblcargos */

insert  into tblcargos(IDcargo,nombreCarg,tipo) values (1,'PORTERO',2),(2,'MAYORDOMO',2),(3,'MENSAJERO',2),(4,'JARDINERO',2),(5,'CONSERJE',2),(6,'CHOFER',2),(7,'MAESTRO/A BASICA',1),(8,'DIRECTOR BASICA',0),(9,'SUB-DIRECTOR BASICA',0),(10,'DIGITADOR',0),(11,'DIRECTOR DISTRITAL',0),(12,'SUB-DIRECTOR DISTRITAL',0),(13,'TEC. DISTRITAL',0),(14,'TEC. ADMINISTRATIVO',0),(15,'MAESTRO EF',1),(16,'ORIENTADOR/A',0),(17,'TEC. AVE.',0),(18,'INSTRUCTOR',0),(19,'MAESTRO/A MEDIA GENERAL',1);

/*Table structure for table tblcentroed */

DROP TABLE IF EXISTS tblcentroed;

CREATE TABLE tblcentroed (
  codigoCent int(11) NOT NULL,
  Codistrito char(5) DEFAULT NULL,
  nombre varchar(50) DEFAULT NULL,
  direccion varchar(100) DEFAULT NULL,
  telefono char(14) DEFAULT NULL,
  tanda varchar(21) DEFAULT NULL,
  fecha_reg date DEFAULT NULL,
  estado char(1) DEFAULT NULL,
  cant_aulas int(11) DEFAULT NULL,
  cant_secc int(11) DEFAULT NULL,
  PRIMARY KEY (codigoCent)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table tblcentroed */

insert  into tblcentroed(codigoCent,Codistrito,nombre,direccion,telefono,tanda,fecha_reg,estado,cant_aulas,cant_secc) values (13018512,'7','LOS ORNES','LOS ORNES, VILLA TAPIA','(809) 574-0000','MATUTINA','2010-06-16','A',3,3),(13018520,'7','LOS ORNES','LOS ORNES, VILLA TAPIA','(809) 574-0000','VESPERTINA','2010-06-16','A',3,4),(19001113,'7','EUGENIO MARIA DE HOSTOS','SANTA ANA, VILLA TAPIA','(809) 574-0000','MATUTINA','2010-06-16','A',4,4),(19005217,'7','HERMANAS MIRABAL','SAN JOSE DE CONUCO, VILLA TAPIA','(809) 574-0000','VESPERTINA','2010-06-16','A',7,7),(19005222,'7','HERMANAS MIRABAL','SAN JOSE DE CONUCO, VILLA TAPIA','(809) 574-0000','MATUTINA','2010-06-16','A',7,7),(19014614,'7','JAIME MOLINA MOTA','VILLA TAPIA','(809) 574-3226','VESPERTINA','2010-06-16','A',11,22),(19014627,'7','ERCILIO DE JESUS MOYA','VILLA TAPIA','(809) 574-3022','NOCTURNA','2010-06-16','A',5,5),(19014637,'7','JAIME MOLINA MOTA','VILLA TAPIA','(809) 574-3226','MATUTINA','2010-06-16','A',11,13),(19014916,'7','FEDERICO AUGUSTO GONZÁLEZ','VILLA TAPIA, R. D.','(809) 574-0000','NOCTURNA','2010-06-16','A',4,4),(19014929,'7','FEDERICO AUGUSTO GONZÁLEZ ','VILLA TAPIA, R. D.','(809) 574-3329','MATUTINA','2010-06-16','A',18,32),(19014951,'7','FEDERICO AUGUSTO GONZÁLEZ','VILLA TAPIA, R. D.','(809) 574-3329','VESPERTINA','2010-06-16','A',18,32),(19015213,'7','EL HATO','EL HATO, VILLA TAPIA','(809) 574-0000','MATUTINA','2010-06-16','A',3,3),(19015220,'7','EL HATO','EL HATO, VILLA TAPIA','(809) 574-0000','VESPERTINA','2010-06-16','A',3,3),(19015317,'7','LA CEIBA AFUERA','LA CEIBA, VILLA TAPIA','(809) 574-0000','MATUTINA','2010-06-16','A',6,6),(19015338,'7','LA CEIBA AFUERA','LA CEIBA, VILLA TAPIA','(809) 574-0000','VESPERTINA','2010-06-16','A',4,4),(19015411,'7','JESÚS MARIA JORGE ','EL HOSPITAL, VILLA TAPIA','(809) 574-0000','MATUTINA','2010-06-16','A',3,3),(19015437,'7','JESÚS MARIA JORGE','EL HOSPITAL, VILLA TAPIA','(809) 574-0000','VESPERTINA','2010-06-16','A',5,6),(19015515,'7','LA CEIBA ADENTRO','LA CEIBA, VILLA TAPIA','(809) 574-0000','VESPERTINA','2010-06-16','A',5,5),(19015713,'7','SALOMÉ UREÑA DE HENRÍQUEZ','LAS GUAZUMAS, VILLA TAPIA','(809) 574-0000','MATUTINA','2010-06-16','A',5,5),(19015817,'7','LOS LIMONES NO. II','LOS LIMONES, VILLA TAPIA','(809) 574-0000','VESPERTINA','2010-06-16','A',5,6),(19015833,'7','LOS LIMONES NO. II','LOS LIMONES, VILLA TAPIA','(809) 574-0000','MATUTINA','2010-06-16','A',4,6),(19015911,'7','LOS LIMONES NO. I','LOS LIMONES, VILLA TAPIA','(809) 574-0000','MATUTINA','2010-06-16','A',5,5),(19015923,'7','LOS LIMONES NO. I','LOS LIMONES, VILLA TAPIA','(809) 574-0000','VESPERTINA','2010-06-16','A',4,5),(19016114,'7','SAN JOSÉ DE CONUCO','SAN JOSÉ DE CONUCO, VILLA TAPIA','(809) 574-0000','MATUTINA','2010-06-16','A',5,7),(19016120,'7','SAN JOSÉ DE CONUCO','SAN JOSÉ DE CONUCO, VILLA TAPIA','(809) 574-0000','VESPERTINA','2010-06-16','A',5,6),(19016139,'7','SAN JOSÉ DE CONUCO (ADULTOS)','SAN JOSÉ DE CONUCO, VILLA TAPIA','(809) 574-0000','NOCTURNA','2010-06-16','A',3,3),(19016312,'7','EL RANCHITO ','EL RANCHITO, VILLA TAPIA','(809) 574-0000','MATUTINA','2010-06-16','A',7,7),(19016337,'7','EL RANCHITO','EL RANCHITO, VILLA TAPIA','(809) 574-0000','VESPERTINA','2010-06-16','A',5,5),(19016614,'7','LAS AROMAS','LAS AROMAS, VILLA TAPIA','(809) 574-0000','MATUTINA','2010-06-16','A',4,4),(19016625,'7','LAS AROMAS','LAS AROMAS, VILLA TAPIA','(809) 574-0000','VESPERTINA','2010-06-16','A',5,5),(19016718,'7','EL COCO NO. 1','EL COCO, VILLA TAPIA','(809) 574-0000','MATUTINA','2010-06-16','A',4,6),(19016733,'7','EL COCO NO. 1','EL COCO, VILLA TAPIA','(809) 574-0000','VESPERTINA','2010-06-16','A',5,6),(19016916,'7','EL COCO NO. 2','EL COCO, VILLA TAPIA','(809) 574-0000','MATUTINA','2010-06-16','A',4,5),(19016931,'7','EL COCO NO. 2','EL COCO, VILLA TAPIA','(809) 574-0000','VESPERTINA','2010-06-16','A',3,3),(19017119,'7','LA GINA','LA GINA, VILLA TAPIA','(809) 574-0000','MATUTINA','2010-06-16','A',7,8),(19017129,'7','CASIMIRO DE JESUS MOYA','LA GINA, VILLA TAPIA','(809) 574-0000','NOCTURNA','2010-06-16','A',4,4),(19017138,'7','LA GINA','LA GINA, VILLA TAPIA','(809) 574-0000','VESPERTINA','2010-06-16','A',7,5),(19017317,'7','SABANA ANGOSTA','SABANA ANGOSTA, VILLA TAPIA','(809) 574-0000','MATUTINA','2010-06-16','A',4,4),(19017327,'7','SABANA ANGOSTA','SABANA ANGOSTA, VILLA TAPIA','(809) 574-0000','VESPERTINA','2010-06-16','A',4,3),(19017515,'7','SANTA ANA MADRID','SANTA ANA MADRID, VILLA TAPIA','(809) 574-3778','MATUTINA','2010-06-16','A',6,8),(19017534,'7','SANTA ANA MADRID','SANTA ANA MADRID, VILLA TAPIA','(809) 574-3778','VESPERTINA','2010-06-16','A',6,6),(19017713,'7','LA CUARENTA','LA CUARENTA, VILLA TAPIA','(809) 574-0000','MATUTINA','2010-06-16','A',7,8),(19017723,'7','LA CUARENTA','LA CUARENTA, VILLA TAPIA','(809) 574-0000','VESPERTINA','2010-06-16','A',3,6),(19017817,'7','EL TABLÓN','EL TABLÓN, VILLA TAPIA','(809) 574-0000','MATUTINA','2010-06-16','A',5,5),(19017822,'7','EL TABLÓN','EL TABLÓN, VILLA TAPIA','(809) 574-0000','VESPERTINA','2010-06-16','A',4,4),(19017911,'7','ERMITA SANTA ANA','SANTA ANA, VILLA TAPIA','(809) 574-0000','MATUTINA','2010-06-16','A',10,10),(19017921,'7','ERMITA SANTA ANA','SANTA ANA, VILLA TAPIA','(809) 574-0000','VESPERTINA','2010-06-16','A',10,15),(19018114,'7','TORO CENIZO','TORO CENIZO, VILLA TAPI','(809) 574-0000','MATUTINA','2010-06-16','A',6,6),(19018128,'7','TORO CENIZO','TORO CENIZO, VILLA TAPIA','(809) 574-0000','VESPERTINA','2010-06-16','A',5,6),(19018312,'7','SAN JOSÉ DE CENOVÍ ','SAN JOSÉ DE CENOVÍ, VILLA TAPIA','(809) 574-0000','MATUTINA','2010-06-16','A',6,6),(19018326,'7','SAN JOSÉ DE CENOVÍ ','SAN JOSÉ DE CENOVÍ, VILLA TAPIA','(809) 574-0000','VESPERTINA','2010-06-16','A',5,5),(19018416,'7','JUAN VENTURA','LAS GUAZUMAS VILLA TAPIA','(809) 574-0000','MATUTINA','2010-06-16','A',10,12),(19018434,'7','JUAN VENTURA','LAS GUAZUMAS, VILLA TAPIA','(809) 574-0000','VESPERTINA','2010-06-16','A',9,10),(19019217,'7','ESCUELA LABORAL SAN RAFAEL','CALLE SAN RAFAEL, VILLA TAPIA','(809) 574-0000','MATUTINA','2010-06-16','A',4,4),(19019712,'7','POLANCO','POLANCO, VILLA TAPIA','(809) 574-0000','MATUTINA','2010-06-16','A',5,6),(19019721,'7','POLANCO','POLANCO, VILLA TAPIA','(809) 574-0000','VESPERTINA','2010-06-16','A',4,5),(19020017,'7','CENTRO DE EDUCACION Y PROMOCION RURAL','SANTA ANA, VILLA TAPIA','(809) 574-0000','MATUTINA','2010-06-16','A',5,5),(19020026,'7','CENTRO DE EDUCACON Y PROMOCION RURAL','SANTA ANA, VILLA TAPIA','(809) 574-0000','NOCTURNA','2010-06-16','A',5,5),(19020035,'7','CENTRO DE EDUCACION Y PROMOCION RURAL','SANTA ANA VILLA TAPIA','(809) 574-0000','VESPERTINA','2010-06-16','A',5,5);

/*Table structure for table tblcursos */

DROP TABLE IF EXISTS tblcursos;

CREATE TABLE tblcursos (
  IDcurso int(11) NOT NULL AUTO_INCREMENT,
  nombre_curso varchar(50) DEFAULT NULL,
  fecha_reg date DEFAULT NULL,
  estado char(1) DEFAULT NULL,
  nivel varchar(50) DEFAULT NULL,
  PRIMARY KEY (IDcurso)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=latin1;

/*Data for the table tblcursos */

insert  into tblcursos(IDcurso,nombre_curso,fecha_reg,estado,nivel) values (1,'MATERNAL','2009-11-26','1','INICIAL'),(2,'QUINDER','2009-11-26','1','INICIAL'),(3,'PRE-PRIMARIA','2009-11-26','1','INICIAL'),(4,'1RO','2009-11-26','1','BASICO'),(5,'2DO','2009-11-26','1','BASICO'),(6,'3RO','2009-11-26','1','BASICO'),(7,'4TO','2009-11-26','1','BASICO'),(8,'5TO','2009-11-26','1','BASICO'),(9,'6TO','2009-11-26','1','BASICO'),(10,'7MO','2009-11-26','1','BASICO'),(11,'8VO','2009-11-26','1','BASICO'),(12,'1RO','2009-11-26','1','MEDIO'),(13,'2DO','2009-11-26','1','MEDIO'),(14,'3RO','2009-11-26','1','MEDIO'),(15,'4TO','2009-11-26','1','MEDIO');

/*Table structure for table tblcursos_centro */

DROP TABLE IF EXISTS tblcursos_centro;

CREATE TABLE tblcursos_centro (
  IDccentro int(11) DEFAULT NULL,
  IDcurso int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table tblcursos_centro */

insert  into tblcursos_centro(IDccentro,IDcurso) values (19014929,2),(19014929,3),(19014929,4),(19014929,5),(19014929,6),(19014929,7),(19014951,8),(19014951,9),(19014951,10),(19014951,11),(19014614,12),(19014614,13),(19014614,14),(19014614,15),(19014637,12),(19014637,13),(19014637,14),(19014637,15);

/*Table structure for table tbldepartamdist */

DROP TABLE IF EXISTS tbldepartamdist;

CREATE TABLE tbldepartamdist (
  ID_departamento int(11) NOT NULL AUTO_INCREMENT,
  nomb_depart varchar(50) DEFAULT NULL,
  fec_reg date DEFAULT NULL,
  estado char(1) DEFAULT NULL,
  PRIMARY KEY (ID_departamento)
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=latin1;

/*Data for the table tbldepartamdist */

insert  into tbldepartamdist(ID_departamento,nomb_depart,fec_reg,estado) values (1,'DIRECCION DISTRITAL','2009-11-26','1'),(2,'SUB-DIRECCION DISTRITAL','2009-11-26','1'),(3,'RRHH','2009-11-26','1'),(4,'NIVEL INICIAL','2009-11-26','1'),(5,'BASICA','2009-11-26','1'),(6,'MEDIA','2009-11-26','1'),(7,'ESTADISTICA','2009-11-26','1'),(8,'DESAYUNO ESCOLAR','2009-11-26','1'),(9,'CIENCIAS SOCIALES','2009-11-26','1'),(10,'LENGUA ESPAÑOLA','2009-11-26','1'),(11,'MATEMATICA','2009-11-26','1'),(12,'CIENCIAS NATURALES','2009-11-26','1'),(13,'EDUCACION ARTISTICA','2009-11-26','1'),(14,'F.I.H.R.','2009-11-26','1'),(15,'EDUCACION FISICA','2009-11-26','1'),(16,'IDIOMAS','2009-11-26','1'),(17,'ORIENTACION','2009-11-27','1'),(18,'SOPORTE TECNICO','2009-11-27','1'),(19,'PREPARA','2009-11-27','1'),(20,'1ER CICLO BASICA','2009-11-27','1'),(21,'2DO CICLO BASICA','2009-11-27','1'),(22,'COLEGIOS PRIVADOS','2009-11-27','1');

/*Table structure for table tbldist_depart */

DROP TABLE IF EXISTS tbldist_depart;

CREATE TABLE tbldist_depart (
  ID_departamento int(11) DEFAULT NULL,
  Codistrito char(5) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table tbldist_depart */

insert  into tbldist_depart(ID_departamento,Codistrito) values (1,'07-07'),(2,'07-07'),(3,'07-07'),(4,'07-07'),(5,'07-07'),(6,'07-07'),(7,'07-07'),(8,'07-07'),(9,'07-07'),(10,'07-07'),(11,'07-07'),(12,'07-07'),(13,'07-07'),(14,'07-07'),(15,'07-07'),(16,'07-07'),(17,'07-07'),(18,'07-07'),(19,'07-07'),(20,'07-07'),(21,'07-07'),(22,'07-07');

/*Table structure for table tbldistrito */

DROP TABLE IF EXISTS tbldistrito;

CREATE TABLE tbldistrito (
  Codistrito int(11) NOT NULL,
  cod_regional char(2) NOT NULL,
  d_nombre varchar(50) DEFAULT NULL,
  d_direccion varchar(100) DEFAULT NULL,
  d_telefono char(14) DEFAULT NULL,
  fecha_reg date DEFAULT NULL,
  estado char(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table tbldistrito */

insert  into tbldistrito(Codistrito,cod_regional,d_nombre,d_direccion,d_telefono,fecha_reg,estado) values (7,'07','VILLA TAPIA','VILLA TAPIA, R. D.','(809) 574-3305','2010-06-16','A');

/*Table structure for table tbldocent_area */

DROP TABLE IF EXISTS tbldocent_area;

CREATE TABLE tbldocent_area (
  IDdocente int(11) DEFAULT NULL,
  CodigoArea int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table tbldocent_area */

/*Table structure for table tbldocente */

DROP TABLE IF EXISTS tbldocente;

CREATE TABLE tbldocente (
  IDdocente int(11) NOT NULL AUTO_INCREMENT,
  cedula char(13) DEFAULT NULL,
  nivelacad varchar(50) DEFAULT NULL,
  titulo varchar(50) DEFAULT NULL,
  areaestudio varchar(50) DEFAULT NULL,
  tipo tinyint(4) DEFAULT NULL,
  PRIMARY KEY (IDdocente)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;

/*Data for the table tbldocente */

insert  into tbldocente(IDdocente,cedula,nivelacad,titulo,areaestudio,tipo) values (1,'051-0004132-5','UNIVERSITARIO','MAESTRIA','OTROS',0),(2,'051-0909384-0','UNIVERSITARIO','MAESTRIA','MATEMATICA',0),(3,'051-0031928-7','UNIVERSITARIO','LICENCIADO','IDIOMAS',0),(4,'051-0008199-2','UNIVERSITARIO','LICENCIADO','IDIOMAS',0),(5,'051-0019574-1','UNIVERSITARIO','LICENCIADO','LENGUA ESPAÑOLA',1),(6,'051-0005585-3','UNIVERSITARIO','LICENCIADO','LENGUA ESPAÑOLA',1),(7,'055-0014024-8','UNIVERSITARIO','LICENCIADO','LENGUA ESPAÑOLA',0),(8,'001-0558360-3','UNIVERSITARIO','LICENCIADO','CIENCIAS SOCIALES',0),(9,'051-0014785-8','UNIVERSITARIO','LICENCIADO','LETRAS',1);

/*Table structure for table tblhistorial */

DROP TABLE IF EXISTS tblhistorial;

CREATE TABLE tblhistorial (
  Id_historial int(7) unsigned NOT NULL,
  cedula_Empl int(7) DEFAULT NULL,
  Nomb_usuario varchar(100) DEFAULT NULL,
  Descripción varchar(100) DEFAULT NULL,
  fecha_Reg datetime DEFAULT NULL,
  PRIMARY KEY (Id_historial)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table tblhistorial */

/*Table structure for table tblpermisosusuarios */

DROP TABLE IF EXISTS tblpermisosusuarios;

CREATE TABLE tblpermisosusuarios (
  fPerID int(10) DEFAULT '0',
  fUsuID int(10) DEFAULT NULL,
  fAsignado tinyint(1) DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table tblpermisosusuarios */

insert  into tblpermisosusuarios(fPerID,fUsuID,fAsignado) values (300,1,1),(301,1,1),(308,1,1),(309,1,1),(310,1,1),(302,1,1),(303,1,1),(304,1,1),(305,1,1),(306,1,1),(307,1,1),(400,1,1),(401,1,1),(402,1,1),(403,1,1),(404,1,1),(500,1,1),(501,1,1),(502,1,1),(503,1,1);

/*Table structure for table tblregional */

DROP TABLE IF EXISTS tblregional;

CREATE TABLE tblregional (
  cod_regional char(2) NOT NULL,
  nombre varchar(50) DEFAULT NULL,
  direccion varchar(100) DEFAULT NULL,
  telefono char(14) DEFAULT NULL,
  fecha_reg date DEFAULT NULL,
  estado char(1) DEFAULT NULL,
  PRIMARY KEY (cod_regional)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table tblregional */

insert  into tblregional(cod_regional,nombre,direccion,telefono,fecha_reg,estado) values ('07','SAN FRANCISCO DE MACORIS','SAN FRANCISCO, R. D.','(809) 588-8098','2010-06-16','A');

/*Table structure for table tbltarj_empl */

DROP TABLE IF EXISTS tbltarj_empl;

CREATE TABLE tbltarj_empl (
  cedula_empl char(13) NOT NULL,
  tarjeta char(9) NOT NULL,
  estado char(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table tbltarj_empl */

insert  into tbltarj_empl(cedula_empl,tarjeta,estado) values ('051-0000982-1','12376-821','A'),('051-0000982-1','32409-832','A'),('051-0002136-7','00165-002','A'),('051-0008989-8','19091-238','A'),('051-0004132-5','00265-132','A'),('051-0009897-9','00165-001','A'),('051-0909384-0','00165-004','A'),('051-0019574-1','11091-102','A'),('051-0002496-6','00265-123','A'),('055-0014024-8','00265-049','A'),('051-0000958-7','00265-169','A'),('051-0018369-7','11141-008','A'),('001-0558360-3','00265-130','A'),('051-0014785-8','11107-066','A'),('051-0014785-8','11109-031','A');

/*Table structure for table tbltarjeta */

DROP TABLE IF EXISTS tbltarjeta;

CREATE TABLE tbltarjeta (
  tarjeta char(9) NOT NULL,
  CodigoCent int(11) DEFAULT NULL,
  cargo varchar(50) DEFAULT NULL,
  ingresos double DEFAULT NULL,
  fecha_reg date DEFAULT NULL,
  estado char(1) DEFAULT NULL,
  PRIMARY KEY (tarjeta)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table tbltarjeta */

insert  into tbltarjeta(tarjeta,CodigoCent,cargo,ingresos,fecha_reg,estado) values ('00165-001',7,'CONSERJE',5000,'2010-06-20','A'),('00165-002',7,'CHOFER',9000,'2010-06-20','A'),('00165-004',7,'TEC. DISTRITAL',25000,'2010-06-20','A'),('00265-049',7,'TEC. DISTRITAL',31209.14,'2010-09-29','A'),('00265-123',7,'CONSERJE',5117.5,'2010-09-09','A'),('00265-130',7,'TEC. DISTRITAL',30094.53,'2010-10-26','A'),('00265-132',7,'TEC. DISTRITAL',24521.46,'2010-06-16','A'),('00265-169',7,'CONSERJE',5117.5,'2010-09-30','A'),('06547-577',19014614,'MAESTRO/A BASICA',7000,'2010-06-19','A'),('11091-001',19016718,'DIRECTOR BASICA',22766.08,'2010-09-28','A'),('11091-102',19016718,'MAESTRO/A BASICA',11415.53,'2010-06-10','A'),('11107-066',19017119,'MAESTRO/A BASICA',11710.46,'2010-10-26','A'),('11109-031',19017138,'MAESTRO/A BASICA',11710.46,'2010-10-26','A'),('11141-008',13018520,'CONSERJE',5117.5,'2010-10-05','A'),('12376-821',19005217,'CONSERJE',5000,'2010-06-16','A'),('19091-238',19001113,'CONSERJE',5000,'2010-06-20','A'),('32409-832',13018512,'CONSERJE',5000,'2010-06-16','A');

/*Table structure for table tblusuarios */

DROP TABLE IF EXISTS tblusuarios;

CREATE TABLE tblusuarios (
  UsuarioID int(11) NOT NULL AUTO_INCREMENT,
  NomUsu varchar(50) DEFAULT NULL,
  contrac varchar(50) DEFAULT NULL,
  cedulaEmpl char(13) DEFAULT NULL,
  fecha_reg date DEFAULT NULL,
  estado char(1) DEFAULT NULL,
  PRIMARY KEY (UsuarioID)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

/*Data for the table tblusuarios */

insert  into tblusuarios(UsuarioID,NomUsu,contrac,cedulaEmpl,fecha_reg,estado) values (1,'SA','SA','051-0002132-1','2010-05-31','A');

/* Procedure structure for procedure guardacentro */

/*!50003 DROP PROCEDURE IF EXISTS  guardacentro */;

DELIMITER $$

/*!50003 CREATE DEFINER=root@localhost PROCEDURE guardacentro(control tinyint(1),ccodigoCent int,cCodistrito char(5),cnombre varchar(50),cdireccion varchar(100),ctelefono char(14),ctanda varchar(21),cestado char(1),cantaulas int,cantsecc int)
BEGIN
        IF(control=0) THEN /*HACE UN UPDATE*/	
	    if exists (select codigoCent from tblcentroed  where codigoCent=ccodigoCent) then 
                UPDATE tblcentroed SET codigoCent=ccodigoCent,Codistrito=cCodistrito,nombre=cnombre,direccion=cdireccion,telefono=ctelefono,tanda=ctanda,estado=cestado,cant_aulas=cantaulas,cant_secc=cantsecc WHERE codigoCent=ccodigoCent;
	    end if;
	elseif (control=1) THEN /*HACE UN INSERT*/
	   if NOT exists (select codigoCent from tblcentroed  where codigoCent=ccodigoCent) then 
		INSERT INTO tblcentroed (codigoCent,Codistrito,nombre,direccion,telefono,tanda,estado,fecha_reg,cant_aulas,cant_secc)
                VALUES(ccodigoCent,cCodistrito,cnombre,cdireccion,ctelefono,ctanda,cestado,curdate(),cantaulas,cantsecc);
           END IF;
	END IF;
END */$$
DELIMITER ;

/* Procedure structure for procedure guardadist */

/*!50003 DROP PROCEDURE IF EXISTS  guardadist */;

DELIMITER $$

/*!50003 CREATE DEFINER=root@localhost PROCEDURE guardadist(control tinyint,dCodistrito int,dcod_regional char(2),dd_nombre varchar(50),dd_direccion varchar(100),dd_telefono char(14),destado char(1))
begin 
   if (control=0)then 
       if exists(select Codistrito from tbldistrito where Codistrito=dCodistrito and cod_regional=dcod_regional)then
	   update tbldistrito set cod_regional=dcod_regional,d_nombre=dd_nombre,d_direccion=dd_direccion,d_telefono=dd_telefono,estado=destado;
       end if;
   elseif(control=1)then 
      if((select count(Codistrito) from tbldistrito)=0)then 
       if not exists(select Codistrito from tbldistrito where Codistrito=dCodistrito and cod_regional=dcod_regional)then
	  insert into tbldistrito (Codistrito,cod_regional,d_nombre,d_direccion,d_telefono,fecha_reg,estado)
          values(dCodistrito,dcod_regional,dd_nombre,dd_direccion,dd_telefono,curdate(),destado);
       end if;
      end if;
   end if;
end */$$
DELIMITER ;

/* Procedure structure for procedure guardadocente */

/*!50003 DROP PROCEDURE IF EXISTS  guardadocente */;

DELIMITER $$

/*!50003 CREATE DEFINER=root@localhost PROCEDURE guardadocente(control tinyint(1),ecedula char(13),dnivelacad varchar(50), dtitulo varchar(50),dareaestudio varchar(50),dtipo tinyint,
enombre varchar(30),eapellido1 varchar(15),eapellido2 varchar(15),edireccion varchar(50),etelefono char(14),ecelular char(14),efecha_nacimiento date,esexo char(1),eestado tinyint,efecha_ingreso date)
begin
  declare existe tinyint default 0;
  if exists (select empleados.cedula from empleados,tbldocente  where empleados.cedula=ecedula and tbldocente.cedula=ecedula) then 
    set existe = 1;
  else
    set existe = 0;
  end if;
  IF(control=0) THEN /*HACE UN UPDATE*/
	if (existe=1) then
		UPDATE empleados SET nombre=enombre,apellido1=eapellido1,apellido2=eapellido2,direccion=edireccion,telefono=etelefono,celular=ecelular,fecha_nacimiento=efecha_ingreso,sexo=esexo,estado=eestado,fecha_ingreso=efecha_ingreso WHERE cedula=ecedula;
	    /*CALL guardaEmpleado(0,ecedula ,enombre ,eapellido1,eapellido2 ,edireccion ,etelefono,ecelular ,efecha_nacimiento ,esexo ,eestado ,efecha_ingreso);*/
	end if;
	if (existe=1) then
		UPDATE tbldocente SET cedula=ecedula,nivelacad=dnivelacad,titulo=dtitulo,areaestudio=dareaestudio,tipo=dtipo WHERE cedula=ecedula;
	end if;
   elseif (control=1) THEN /*HACE UN INSERT*/
	   if (existe=0) then 
		INSERT INTO empleados (cedula,nombre,apellido1,apellido2,direccion,telefono,celular,fecha_nacimiento,sexo,estado,fecha_ingreso,fecha_reg)
                                VALUES(ecedula,enombre,eapellido1,eapellido2,edireccion,etelefono,ecelular,efecha_nacimiento,esexo,eestado,efecha_ingreso,curdate());
           /*CALL guardaEmpleado(1,ecedula ,enombre ,eapellido1,eapellido2 ,edireccion ,etelefono,ecelular ,efecha_nacimiento ,esexo ,eestado ,efecha_ingreso);*/
	   END IF;
	   if (existe=0) then 
		INSERT INTO tbldocente (cedula,nivelacad,titulo,areaestudio,tipo)
                                VALUES(ecedula,dnivelacad,dtitulo,dareaestudio,dtipo);
           END IF;
	END IF;
end */$$
DELIMITER ;

/* Procedure structure for procedure guardaEmpleado */

/*!50003 DROP PROCEDURE IF EXISTS  guardaEmpleado */;

DELIMITER $$

/*!50003 CREATE DEFINER=root@localhost PROCEDURE guardaEmpleado(control tinyint(1),ecedula char(13),enombre varchar(30),eapellido1 varchar(15),eapellido2 varchar(15),edireccion varchar(100),etelefono char(14),ecelular char(14),efecha_nacimiento date,esexo char(1),eestado tinyint,efecha_ingreso date)
BEGIN
        IF(control=0) THEN /*HACE UN UPDATE*/	
	    if exists (select cedula from empleados  where cedula=ecedula) then 
                UPDATE empleados SET nombre=enombre,apellido1=eapellido1,apellido2=eapellido2,direccion=edireccion,telefono=etelefono,celular=ecelular,fecha_nacimiento=efecha_ingreso,sexo=esexo,estado=eestado,fecha_ingreso=efecha_ingreso WHERE cedula=ecedula;
	    end if;
	elseif (control=1) THEN /*HACE UN INSERT*/
	   if NOT exists (select cedula from empleados  where cedula=ecedula) then 
		INSERT INTO empleados (cedula,nombre,apellido1,apellido2,direccion,telefono,celular,fecha_nacimiento,sexo,estado,fecha_ingreso,fecha_reg)
                                VALUES(ecedula,enombre,eapellido1,eapellido2,edireccion,etelefono,ecelular,efecha_nacimiento,esexo,eestado,efecha_ingreso,curdate());
           END IF;
	END IF;
END */$$
DELIMITER ;

/* Procedure structure for procedure guardaHist */

/*!50003 DROP PROCEDURE IF EXISTS  guardaHist */;

DELIMITER $$

/*!50003 CREATE DEFINER=root@localhost PROCEDURE guardaHist(hcedula_Empl int(7),hNomb_usuario varchar(100),hDescripción varchar(100))
begin  
	insert into tblhistorial (cedula_Empl,Nomb_usuario,Descripción,fecha_Reg)
                           values(hcedula_Empl,hNomb_usuario ,hDescripción,curdate());
end */$$
DELIMITER ;

/* Procedure structure for procedure guardapermisos */

/*!50003 DROP PROCEDURE IF EXISTS  guardapermisos */;

DELIMITER $$

/*!50003 CREATE DEFINER=root@localhost PROCEDURE guardapermisos(control tinyint,PerID int,UsuID int,Asignado tinyint(1))
begin
  if (control=0) then 
	if not exists(select fPerID,fUsuID from tblpermisosusuarios where fUsuID=UsuID and fPerID=PerID) then 
		insert into tblpermisosusuarios values(PerID,UsuID,Asignado);
	end if;
   else
	if exists(select fPerID,fUsuID from tblpermisosusuarios where fUsuID=UsuID and fPerID=PerID) then 
		update tblpermisosusuarios set fAsignado=Asignado;
	end if;
   end if;
end */$$
DELIMITER ;

/* Procedure structure for procedure guardaReg */

/*!50003 DROP PROCEDURE IF EXISTS  guardaReg */;

DELIMITER $$

/*!50003 CREATE DEFINER=root@localhost PROCEDURE guardaReg(control tinyint,rcod_regional char(2),rnombre varchar(50),rdireccion varchar(100),rtelefono char(14),restado char(1))
begin 
   if (control=0)then 
       if exists(select cod_regional from tblregional where cod_regional=rcod_regional)then
	   update tblregional set nombre=rnombre,direccion=rdireccion,telefono=rtelefono,estado=restado where cod_regional=rcod_regional;
       end if;
   elseif(control=1)then 
       if not exists(select cod_regional from tblregional where cod_regional=rcod_regional)then
	  insert into tblregional (cod_regional,nombre,direccion,telefono,fecha_reg,estado)
          values(rcod_regional,rnombre,rdireccion,rtelefono,curdate(),restado);
       end if;
   end if;
end */$$
DELIMITER ;

/* Procedure structure for procedure guardaTarj */

/*!50003 DROP PROCEDURE IF EXISTS  guardaTarj */;

DELIMITER $$

/*!50003 CREATE DEFINER=root@localhost PROCEDURE guardaTarj(control tinyint ,ttarjeta char(9),tcodigoCent int, tcargo varchar(50),tingresos double,testado char(1))
begin 
  if (control=0) then 
     if exists(select tarjeta from tbltarjeta where tarjeta=ttarjeta)then 
        update tbltarjeta set CodigoCent=tCodigoCent,cargo=tcargo,ingresos=tingresos,estado=testado where tarjeta=ttarjeta;
     end if;
  elseif (control=1)then 
     if not exists(select tarjeta from tbltarjeta where tarjeta=ttarjeta)then 
        insert into tbltarjeta (tarjeta,CodigoCent,cargo,ingresos,estado,fecha_reg)
        values(ttarjeta,tCodigoCent,tcargo,tingresos,testado,curdate());
     end if;
  end if;
  
end */$$
DELIMITER ;

/* Procedure structure for procedure guardaTarjEmpl */

/*!50003 DROP PROCEDURE IF EXISTS  guardaTarjEmpl */;

DELIMITER $$

/*!50003 CREATE DEFINER=root@localhost PROCEDURE guardaTarjEmpl(ttarjeta char(9),tcedula char(13))
begin 
  
     if exists(select cedula_empl,tarjeta from tbltarj_empl where cedula_empl=tcedula and tarjeta=ttarjeta)then 
        update tbltarj_empl set estado="A" where cedula_empl=tcedula and tarjeta=ttarjeta;
     else
        insert into tbltarj_empl (cedula_empl,tarjeta,estado) values(tcedula,ttarjeta,"A");
     end if;
  
end */$$
DELIMITER ;

/* Procedure structure for procedure guardaUsuario */

/*!50003 DROP PROCEDURE IF EXISTS  guardaUsuario */;

DELIMITER $$

/*!50003 CREATE DEFINER=root@localhost PROCEDURE guardaUsuario(uNomUsu varchar(50),ucontrac varchar(50),ucedulaEmpl char(13)/*,uestado CHAR(1)*/)
begin 
   IF NOT EXISTS(SELECT NomUsu from tblusuarios where NomUsu=uNomUsu)then 
       insert into tblusuarios (NomUsu,contrac,cedulaEmpl,fecha_reg,estado)
	values(uNomUsu,ucontrac,ucedulaEmpl,curdate(),"A");
   end if;
end */$$
DELIMITER ;

/* Procedure structure for procedure UpUsuario */

/*!50003 DROP PROCEDURE IF EXISTS  UpUsuario */;

DELIMITER $$

/*!50003 CREATE DEFINER=root@localhost PROCEDURE UpUsuario(usuario varchar(50),contrasena varchar(50))
begin
  if exists(select NomUsu from tblusuarios where NomUsu=usuario)then
     update tblusuarios set contrac=contrasena where NomUsu=usuario;
  end if;
end */$$
DELIMITER ;

/*Table structure for table v_apoyotarjeta */

DROP TABLE IF EXISTS v_apoyotarjeta;

/*!50001 DROP VIEW IF EXISTS v_apoyotarjeta */;
/*!50001 DROP TABLE IF EXISTS v_apoyotarjeta */;

/*!50001 CREATE TABLE v_apoyotarjeta (
  cedula char(13) DEFAULT NULL,
  nombre varchar(30) DEFAULT NULL,
  apellido1 varchar(15) DEFAULT NULL,
  apellido2 varchar(15) DEFAULT NULL,
  direccion varchar(100) DEFAULT NULL,
  telefono char(14) DEFAULT NULL,
  celular char(14) DEFAULT NULL,
  fecha_nacimiento date DEFAULT NULL,
  sexo char(1) DEFAULT NULL,
  fecha_ingreso date DEFAULT NULL,
  estado tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 */;

/*Table structure for table v_docentes */

DROP TABLE IF EXISTS v_docentes;

/*!50001 DROP VIEW IF EXISTS v_docentes */;
/*!50001 DROP TABLE IF EXISTS v_docentes */;

/*!50001 CREATE TABLE v_docentes (
  cedula char(13) DEFAULT NULL,
  nombre varchar(62) DEFAULT NULL,
  direccion varchar(100) DEFAULT NULL,
  telefono char(14) DEFAULT NULL,
  celular char(14) DEFAULT NULL,
  fecha_nacimiento date DEFAULT NULL,
  sexo char(1) DEFAULT NULL,
  estado tinyint(1) DEFAULT NULL,
  fecha_ingreso date DEFAULT NULL,
  IDdocente int(11) NOT NULL DEFAULT '0',
  nivelacad varchar(50) DEFAULT NULL,
  titulo varchar(50) DEFAULT NULL,
  areaestudio varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 */;

/*Table structure for table v_docentestarje */

DROP TABLE IF EXISTS v_docentestarje;

/*!50001 DROP VIEW IF EXISTS v_docentestarje */;
/*!50001 DROP TABLE IF EXISTS v_docentestarje */;

/*!50001 CREATE TABLE v_docentestarje (
  cedula char(13) DEFAULT NULL,
  nombre varchar(30) DEFAULT NULL,
  apellido1 varchar(15) DEFAULT NULL,
  apellido2 varchar(15) DEFAULT NULL,
  direccion varchar(100) DEFAULT NULL,
  telefono char(14) DEFAULT NULL,
  celular char(14) DEFAULT NULL,
  fecha_nacimiento date DEFAULT NULL,
  sexo char(1) DEFAULT NULL,
  fecha_ingreso date DEFAULT NULL,
  estado tinyint(1) DEFAULT NULL,
  tipo tinyint(4) DEFAULT NULL,
  IDdocente int(11) NOT NULL DEFAULT '0',
  nivelacad varchar(50) DEFAULT NULL,
  titulo varchar(50) DEFAULT NULL,
  areaestudio varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 */;

/*Table structure for table v_perapoyo */

DROP TABLE IF EXISTS v_perapoyo;

/*!50001 DROP VIEW IF EXISTS v_perapoyo */;
/*!50001 DROP TABLE IF EXISTS v_perapoyo */;

/*!50001 CREATE TABLE v_perapoyo (
  cedula char(13) DEFAULT NULL,
  nombre varchar(62) DEFAULT NULL,
  direccion varchar(100) DEFAULT NULL,
  telefono char(14) DEFAULT NULL,
  celular char(14) DEFAULT NULL,
  fecha_nacimiento date DEFAULT NULL,
  sexo char(1) DEFAULT NULL,
  estado tinyint(1) DEFAULT NULL,
  fecha_ingreso date DEFAULT NULL,
  IDdocente binary(0) DEFAULT NULL,
  nivelacad binary(0) DEFAULT NULL,
  titulo binary(0) DEFAULT NULL,
  areaestudio binary(0) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 */;

/*Table structure for table v_tarjataperapoyo1 */

DROP TABLE IF EXISTS v_tarjataperapoyo1;

/*!50001 DROP VIEW IF EXISTS v_tarjataperapoyo1 */;
/*!50001 DROP TABLE IF EXISTS v_tarjataperapoyo1 */;

/*!50001 CREATE TABLE v_tarjataperapoyo1 (
  tarjeta char(9) NOT NULL,
  CodigoCent int(11) DEFAULT NULL,
  nombre varchar(50) DEFAULT NULL,
  cargo varchar(50) DEFAULT NULL,
  ingresos double DEFAULT NULL,
  fecha_reg date DEFAULT NULL,
  estado char(1) DEFAULT NULL,
  tipo tinyint(4) DEFAULT NULL,
  tanda varchar(21) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 */;

/*Table structure for table v_tarjetadocente0 */

DROP TABLE IF EXISTS v_tarjetadocente0;

/*!50001 DROP VIEW IF EXISTS v_tarjetadocente0 */;
/*!50001 DROP TABLE IF EXISTS v_tarjetadocente0 */;

/*!50001 CREATE TABLE v_tarjetadocente0 (
  tarjeta char(9) NOT NULL,
  CodigoCent int(11) DEFAULT NULL,
  nombre varchar(50) DEFAULT NULL,
  cargo varchar(50) DEFAULT NULL,
  ingresos double DEFAULT NULL,
  fecha_reg date DEFAULT NULL,
  estado char(1) DEFAULT NULL,
  tipo tinyint(4) DEFAULT NULL,
  tanda varchar(21) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 */;

/*Table structure for table v_tarjetadocente1 */

DROP TABLE IF EXISTS v_tarjetadocente1;

/*!50001 DROP VIEW IF EXISTS v_tarjetadocente1 */;
/*!50001 DROP TABLE IF EXISTS v_tarjetadocente1 */;

/*!50001 CREATE TABLE v_tarjetadocente1 (
  tarjeta char(9) NOT NULL,
  CodigoCent int(11) DEFAULT NULL,
  nombre varchar(50) DEFAULT NULL,
  cargo varchar(50) DEFAULT NULL,
  ingresos double DEFAULT NULL,
  fecha_reg date DEFAULT NULL,
  estado char(1) DEFAULT NULL,
  tipo tinyint(4) DEFAULT NULL,
  tanda varchar(21) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 */;

/*Table structure for table v_tarjetadocentedistrito */

DROP TABLE IF EXISTS v_tarjetadocentedistrito;

/*!50001 DROP VIEW IF EXISTS v_tarjetadocentedistrito */;
/*!50001 DROP TABLE IF EXISTS v_tarjetadocentedistrito */;

/*!50001 CREATE TABLE v_tarjetadocentedistrito (
  tarjeta char(9) NOT NULL,
  CodigoCent int(11) DEFAULT NULL,
  nombre varchar(50) DEFAULT NULL,
  cargo varchar(50) DEFAULT NULL,
  ingresos double DEFAULT NULL,
  fecha_reg date DEFAULT NULL,
  estado char(1) DEFAULT NULL,
  tipo tinyint(4) DEFAULT NULL,
  tanda varchar(8) CHARACTER SET utf8 NOT NULL DEFAULT ''
) ENGINE=InnoDB DEFAULT CHARSET=latin1 */;

/*Table structure for table v_tarjetadocentedistrito1 */

DROP TABLE IF EXISTS v_tarjetadocentedistrito1;

/*!50001 DROP VIEW IF EXISTS v_tarjetadocentedistrito1 */;
/*!50001 DROP TABLE IF EXISTS v_tarjetadocentedistrito1 */;

/*!50001 CREATE TABLE v_tarjetadocentedistrito1 (
  tarjeta char(9) NOT NULL,
  CodigoCent int(11) DEFAULT NULL,
  nombre varchar(50) DEFAULT NULL,
  cargo varchar(50) DEFAULT NULL,
  ingresos double DEFAULT NULL,
  fecha_reg date DEFAULT NULL,
  estado char(1) DEFAULT NULL,
  tipo tinyint(4) DEFAULT NULL,
  tanda varchar(8) CHARACTER SET utf8 NOT NULL DEFAULT ''
) ENGINE=InnoDB DEFAULT CHARSET=latin1 */;

/*Table structure for table v_tarjetapoyo0 */

DROP TABLE IF EXISTS v_tarjetapoyo0;

/*!50001 DROP VIEW IF EXISTS v_tarjetapoyo0 */;
/*!50001 DROP TABLE IF EXISTS v_tarjetapoyo0 */;

/*!50001 CREATE TABLE v_tarjetapoyo0 (
  tarjeta char(9) NOT NULL,
  CodigoCent int(11) DEFAULT NULL,
  nombre varchar(50) DEFAULT NULL,
  cargo varchar(50) DEFAULT NULL,
  ingresos double DEFAULT NULL,
  fecha_reg date DEFAULT NULL,
  estado char(1) DEFAULT NULL,
  tipo tinyint(4) DEFAULT NULL,
  tanda varchar(21) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 */;

/*Table structure for table v_tarjetapoyo1 */

DROP TABLE IF EXISTS v_tarjetapoyo1;

/*!50001 DROP VIEW IF EXISTS v_tarjetapoyo1 */;
/*!50001 DROP TABLE IF EXISTS v_tarjetapoyo1 */;

/*!50001 CREATE TABLE v_tarjetapoyo1 (
  tarjeta char(9) NOT NULL,
  CodigoCent int(11) DEFAULT NULL,
  nombre varchar(50) DEFAULT NULL,
  cargo varchar(50) DEFAULT NULL,
  ingresos double DEFAULT NULL,
  fecha_reg date DEFAULT NULL,
  estado char(1) DEFAULT NULL,
  tipo tinyint(4) DEFAULT NULL,
  tanda varchar(21) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 */;

/*Table structure for table v_tarjetapoyodistrito */

DROP TABLE IF EXISTS v_tarjetapoyodistrito;

/*!50001 DROP VIEW IF EXISTS v_tarjetapoyodistrito */;
/*!50001 DROP TABLE IF EXISTS v_tarjetapoyodistrito */;

/*!50001 CREATE TABLE v_tarjetapoyodistrito (
  tarjeta char(9) NOT NULL,
  CodigoCent int(11) DEFAULT NULL,
  nombre varchar(50) DEFAULT NULL,
  cargo varchar(50) DEFAULT NULL,
  ingresos double DEFAULT NULL,
  fecha_reg date DEFAULT NULL,
  estado char(1) DEFAULT NULL,
  tipo tinyint(4) DEFAULT NULL,
  tanda varchar(8) CHARACTER SET utf8 NOT NULL DEFAULT ''
) ENGINE=InnoDB DEFAULT CHARSET=latin1 */;

/*Table structure for table v_tarjetapoyodistrito1 */

DROP TABLE IF EXISTS v_tarjetapoyodistrito1;

/*!50001 DROP VIEW IF EXISTS v_tarjetapoyodistrito1 */;
/*!50001 DROP TABLE IF EXISTS v_tarjetapoyodistrito1 */;

/*!50001 CREATE TABLE v_tarjetapoyodistrito1 (
  tarjeta char(9) NOT NULL,
  CodigoCent int(11) DEFAULT NULL,
  nombre varchar(50) DEFAULT NULL,
  cargo varchar(50) DEFAULT NULL,
  ingresos double DEFAULT NULL,
  fecha_reg date DEFAULT NULL,
  estado char(1) DEFAULT NULL,
  tipo tinyint(4) DEFAULT NULL,
  tanda varchar(8) CHARACTER SET utf8 NOT NULL DEFAULT ''
) ENGINE=InnoDB DEFAULT CHARSET=latin1 */;

/*Table structure for table v_tarjetastecdoc */

DROP TABLE IF EXISTS v_tarjetastecdoc;

/*!50001 DROP VIEW IF EXISTS v_tarjetastecdoc */;
/*!50001 DROP TABLE IF EXISTS v_tarjetastecdoc */;

/*!50001 CREATE TABLE v_tarjetastecdoc (
  tarjeta char(9) NOT NULL,
  CodigoCent int(11) DEFAULT NULL,
  nombre varchar(50) DEFAULT NULL,
  cargo varchar(50) DEFAULT NULL,
  ingresos double DEFAULT NULL,
  fecha_reg date DEFAULT NULL,
  estado char(1) DEFAULT NULL,
  tipo tinyint(4) DEFAULT NULL,
  tanda varchar(21) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 */;

/*View structure for view v_apoyotarjeta */

/*!50001 DROP TABLE IF EXISTS v_apoyotarjeta */;
/*!50001 DROP VIEW IF EXISTS v_apoyotarjeta */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=root@localhost SQL SECURITY DEFINER VIEW v_apoyotarjeta AS (select empleados.cedula AS cedula,empleados.nombre AS nombre,empleados.apellido1 AS apellido1,empleados.apellido2 AS apellido2,empleados.direccion AS direccion,empleados.telefono AS telefono,empleados.celular AS celular,empleados.fecha_nacimiento AS fecha_nacimiento,empleados.sexo AS sexo,empleados.fecha_ingreso AS fecha_ingreso,empleados.estado AS estado from empleados where ((not(empleados.cedula in (select tbldocente.cedula AS cedula from tbldocente))) and (empleados.estado = 1))) */;

/*View structure for view v_docentes */

/*!50001 DROP TABLE IF EXISTS v_docentes */;
/*!50001 DROP VIEW IF EXISTS v_docentes */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=root@localhost SQL SECURITY DEFINER VIEW v_docentes AS (select empleados.cedula AS cedula,concat(empleados.nombre,_latin1' ',empleados.apellido1,_latin1' ',empleados.apellido2) AS nombre,empleados.direccion AS direccion,empleados.telefono AS telefono,empleados.celular AS celular,empleados.fecha_nacimiento AS fecha_nacimiento,empleados.sexo AS sexo,empleados.estado AS estado,empleados.fecha_ingreso AS fecha_ingreso,tbldocente.IDdocente AS IDdocente,tbldocente.nivelacad AS nivelacad,tbldocente.titulo AS titulo,tbldocente.areaestudio AS areaestudio from (empleados join tbldocente) where (empleados.cedula = tbldocente.cedula)) */;

/*View structure for view v_docentestarje */

/*!50001 DROP TABLE IF EXISTS v_docentestarje */;
/*!50001 DROP VIEW IF EXISTS v_docentestarje */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=root@localhost SQL SECURITY DEFINER VIEW v_docentestarje AS (select empleados.cedula AS cedula,empleados.nombre AS nombre,empleados.apellido1 AS apellido1,empleados.apellido2 AS apellido2,empleados.direccion AS direccion,empleados.telefono AS telefono,empleados.celular AS celular,empleados.fecha_nacimiento AS fecha_nacimiento,empleados.sexo AS sexo,empleados.fecha_ingreso AS fecha_ingreso,empleados.estado AS estado,tbldocente.tipo AS tipo,tbldocente.IDdocente AS IDdocente,tbldocente.nivelacad AS nivelacad,tbldocente.titulo AS titulo,tbldocente.areaestudio AS areaestudio from (empleados join tbldocente) where ((empleados.cedula = tbldocente.cedula) and (empleados.estado = 1))) */;

/*View structure for view v_perapoyo */

/*!50001 DROP TABLE IF EXISTS v_perapoyo */;
/*!50001 DROP VIEW IF EXISTS v_perapoyo */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=root@localhost SQL SECURITY DEFINER VIEW v_perapoyo AS (select empleados.cedula AS cedula,concat(empleados.nombre,_latin1' ',empleados.apellido1,_latin1' ',empleados.apellido2) AS nombre,empleados.direccion AS direccion,empleados.telefono AS telefono,empleados.celular AS celular,empleados.fecha_nacimiento AS fecha_nacimiento,empleados.sexo AS sexo,empleados.estado AS estado,empleados.fecha_ingreso AS fecha_ingreso,NULL AS IDdocente,NULL AS nivelacad,NULL AS titulo,NULL AS areaestudio from empleados where (not(empleados.cedula in (select tbldocente.cedula AS cedula from tbldocente)))) */;

/*View structure for view v_tarjataperapoyo1 */

/*!50001 DROP TABLE IF EXISTS v_tarjataperapoyo1 */;
/*!50001 DROP VIEW IF EXISTS v_tarjataperapoyo1 */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=root@localhost SQL SECURITY DEFINER VIEW v_tarjataperapoyo1 AS (select tbltarjeta.tarjeta AS tarjeta,tbltarjeta.CodigoCent AS CodigoCent,tblcentroed.nombre AS nombre,tbltarjeta.cargo AS cargo,tbltarjeta.ingresos AS ingresos,tbltarjeta.fecha_reg AS fecha_reg,tbltarjeta.estado AS estado,tblcargos.tipo AS tipo,tblcentroed.tanda AS tanda from ((tbltarjeta join tblcargos) join tblcentroed) where ((tbltarjeta.cargo = tblcargos.nombreCarg) and (tblcargos.tipo = 2) and (tbltarjeta.CodigoCent = tblcentroed.codigoCent) and (tbltarjeta.estado = 'A'))) */;

/*View structure for view v_tarjetadocente0 */

/*!50001 DROP TABLE IF EXISTS v_tarjetadocente0 */;
/*!50001 DROP VIEW IF EXISTS v_tarjetadocente0 */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=root@localhost SQL SECURITY DEFINER VIEW v_tarjetadocente0 AS (select tbltarjeta.tarjeta AS tarjeta,tbltarjeta.CodigoCent AS CodigoCent,tblcentroed.nombre AS nombre,tbltarjeta.cargo AS cargo,tbltarjeta.ingresos AS ingresos,tbltarjeta.fecha_reg AS fecha_reg,tbltarjeta.estado AS estado,tblcargos.tipo AS tipo,tblcentroed.tanda AS tanda from (((tbltarjeta join tblcargos) join tblcentroed) join tbltarj_empl) where ((tbltarjeta.cargo = tblcargos.nombreCarg) and (tblcargos.tipo <> 2) and (tbltarjeta.CodigoCent = tblcentroed.codigoCent) and (tbltarj_empl.tarjeta = tbltarjeta.tarjeta) and (tbltarjeta.estado = _latin1'A') and (tbltarj_empl.estado <> 'A'))) */;

/*View structure for view v_tarjetadocente1 */

/*!50001 DROP TABLE IF EXISTS v_tarjetadocente1 */;
/*!50001 DROP VIEW IF EXISTS v_tarjetadocente1 */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=root@localhost SQL SECURITY DEFINER VIEW v_tarjetadocente1 AS (select tbltarjeta.tarjeta AS tarjeta,tbltarjeta.CodigoCent AS CodigoCent,tblcentroed.nombre AS nombre,tbltarjeta.cargo AS cargo,tbltarjeta.ingresos AS ingresos,tbltarjeta.fecha_reg AS fecha_reg,tbltarjeta.estado AS estado,tblcargos.tipo AS tipo,tblcentroed.tanda AS tanda from (((tbltarjeta join tblcargos) join tblcentroed) join tbltarj_empl) where ((tbltarjeta.cargo = tblcargos.nombreCarg) and (tblcargos.tipo <> 2) and (tbltarjeta.CodigoCent = tblcentroed.codigoCent) and (tbltarjeta.estado = _latin1'A') and (not(tbltarjeta.tarjeta in (select tbltarj_empl.tarjeta AS tarjeta from tbltarj_empl))))) */;

/*View structure for view v_tarjetadocentedistrito */

/*!50001 DROP TABLE IF EXISTS v_tarjetadocentedistrito */;
/*!50001 DROP VIEW IF EXISTS v_tarjetadocentedistrito */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=root@localhost SQL SECURITY DEFINER VIEW v_tarjetadocentedistrito AS (select tbltarjeta.tarjeta AS tarjeta,tbltarjeta.CodigoCent AS CodigoCent,tbldistrito.d_nombre AS nombre,tbltarjeta.cargo AS cargo,tbltarjeta.ingresos AS ingresos,tbltarjeta.fecha_reg AS fecha_reg,tbltarjeta.estado AS estado,tblcargos.tipo AS tipo,'COMPLETA' AS tanda from (((tbltarjeta join tblcargos) join tbldistrito) join tbltarj_empl) where ((tbltarjeta.cargo = tblcargos.nombreCarg) and (tblcargos.tipo <> 2) and (tbltarjeta.CodigoCent = tbldistrito.Codistrito) and (tbltarj_empl.tarjeta = tbltarjeta.tarjeta) and (tbltarjeta.estado = _latin1'A') and (tbltarj_empl.estado <> 'A')) group by tbltarjeta.tarjeta) */;

/*View structure for view v_tarjetadocentedistrito1 */

/*!50001 DROP TABLE IF EXISTS v_tarjetadocentedistrito1 */;
/*!50001 DROP VIEW IF EXISTS v_tarjetadocentedistrito1 */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=root@localhost SQL SECURITY DEFINER VIEW v_tarjetadocentedistrito1 AS (select tbltarjeta.tarjeta AS tarjeta,tbltarjeta.CodigoCent AS CodigoCent,tbldistrito.d_nombre AS nombre,tbltarjeta.cargo AS cargo,tbltarjeta.ingresos AS ingresos,tbltarjeta.fecha_reg AS fecha_reg,tbltarjeta.estado AS estado,tblcargos.tipo AS tipo,'COMPLETA' AS tanda from (((tbltarjeta join tblcargos) join tbldistrito) join tbltarj_empl) where ((tbltarjeta.cargo = tblcargos.nombreCarg) and (tblcargos.tipo <> 2) and (tbltarjeta.CodigoCent = tbldistrito.Codistrito) and (tbltarjeta.estado = _latin1'A') and (not(tbltarjeta.tarjeta in (select tbltarj_empl.tarjeta AS tarjeta from tbltarj_empl)))) group by tbltarjeta.tarjeta) */;

/*View structure for view v_tarjetapoyo0 */

/*!50001 DROP TABLE IF EXISTS v_tarjetapoyo0 */;
/*!50001 DROP VIEW IF EXISTS v_tarjetapoyo0 */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=root@localhost SQL SECURITY DEFINER VIEW v_tarjetapoyo0 AS (select tbltarjeta.tarjeta AS tarjeta,tbltarjeta.CodigoCent AS CodigoCent,tblcentroed.nombre AS nombre,tbltarjeta.cargo AS cargo,tbltarjeta.ingresos AS ingresos,tbltarjeta.fecha_reg AS fecha_reg,tbltarjeta.estado AS estado,tblcargos.tipo AS tipo,tblcentroed.tanda AS tanda from (((tbltarjeta join tblcargos) join tblcentroed) join tbltarj_empl) where ((tbltarjeta.cargo = tblcargos.nombreCarg) and (tblcargos.tipo = 2) and (tbltarjeta.CodigoCent = tblcentroed.codigoCent) and (tbltarj_empl.tarjeta = tbltarjeta.tarjeta) and (tbltarjeta.estado = _latin1'A') and (tbltarj_empl.estado <> 'A'))) */;

/*View structure for view v_tarjetapoyo1 */

/*!50001 DROP TABLE IF EXISTS v_tarjetapoyo1 */;
/*!50001 DROP VIEW IF EXISTS v_tarjetapoyo1 */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=root@localhost SQL SECURITY DEFINER VIEW v_tarjetapoyo1 AS (select tbltarjeta.tarjeta AS tarjeta,tbltarjeta.CodigoCent AS CodigoCent,tblcentroed.nombre AS nombre,tbltarjeta.cargo AS cargo,tbltarjeta.ingresos AS ingresos,tbltarjeta.fecha_reg AS fecha_reg,tbltarjeta.estado AS estado,tblcargos.tipo AS tipo,tblcentroed.tanda AS tanda from (((tbltarjeta join tblcargos) join tblcentroed) join tbltarj_empl) where ((tbltarjeta.cargo = tblcargos.nombreCarg) and (tblcargos.tipo = 2) and (tbltarjeta.CodigoCent = tblcentroed.codigoCent) and (tbltarjeta.estado = _latin1'A') and (not(tbltarjeta.tarjeta in (select tbltarj_empl.tarjeta AS tarjeta from tbltarj_empl))))) */;

/*View structure for view v_tarjetapoyodistrito */

/*!50001 DROP TABLE IF EXISTS v_tarjetapoyodistrito */;
/*!50001 DROP VIEW IF EXISTS v_tarjetapoyodistrito */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=root@localhost SQL SECURITY DEFINER VIEW v_tarjetapoyodistrito AS (select tbltarjeta.tarjeta AS tarjeta,tbltarjeta.CodigoCent AS CodigoCent,tbldistrito.d_nombre AS nombre,tbltarjeta.cargo AS cargo,tbltarjeta.ingresos AS ingresos,tbltarjeta.fecha_reg AS fecha_reg,tbltarjeta.estado AS estado,tblcargos.tipo AS tipo,'COMPLETA' AS tanda from (((tbltarjeta join tblcargos) join tbldistrito) join tbltarj_empl) where ((tbltarjeta.cargo = tblcargos.nombreCarg) and (tblcargos.tipo = 2) and (tbltarjeta.CodigoCent = tbldistrito.Codistrito) and (tbltarj_empl.tarjeta = tbltarjeta.tarjeta) and (tbltarjeta.estado = _latin1'A') and (tbltarj_empl.estado <> 'A')) group by tbltarjeta.tarjeta) */;

/*View structure for view v_tarjetapoyodistrito1 */

/*!50001 DROP TABLE IF EXISTS v_tarjetapoyodistrito1 */;
/*!50001 DROP VIEW IF EXISTS v_tarjetapoyodistrito1 */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=root@localhost SQL SECURITY DEFINER VIEW v_tarjetapoyodistrito1 AS (select tbltarjeta.tarjeta AS tarjeta,tbltarjeta.CodigoCent AS CodigoCent,tbldistrito.d_nombre AS nombre,tbltarjeta.cargo AS cargo,tbltarjeta.ingresos AS ingresos,tbltarjeta.fecha_reg AS fecha_reg,tbltarjeta.estado AS estado,tblcargos.tipo AS tipo,'COMPLETA' AS tanda from (((tbltarjeta join tblcargos) join tbldistrito) join tbltarj_empl) where ((tbltarjeta.cargo = tblcargos.nombreCarg) and (tblcargos.tipo = 2) and (tbltarjeta.CodigoCent = tbldistrito.Codistrito) and (tbltarjeta.estado = _latin1'A') and (not(tbltarjeta.tarjeta in (select tbltarj_empl.tarjeta AS tarjeta from tbltarj_empl)))) group by tbltarjeta.tarjeta) */;

/*View structure for view v_tarjetastecdoc */

/*!50001 DROP TABLE IF EXISTS v_tarjetastecdoc */;
/*!50001 DROP VIEW IF EXISTS v_tarjetastecdoc */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=root@localhost SQL SECURITY DEFINER VIEW v_tarjetastecdoc AS (select tbltarjeta.tarjeta AS tarjeta,tbltarjeta.CodigoCent AS CodigoCent,tblcentroed.nombre AS nombre,tbltarjeta.cargo AS cargo,tbltarjeta.ingresos AS ingresos,tbltarjeta.fecha_reg AS fecha_reg,tbltarjeta.estado AS estado,tblcargos.tipo AS tipo,tblcentroed.tanda AS tanda from ((tbltarjeta join tblcargos) join tblcentroed) where ((tbltarjeta.cargo = tblcargos.nombreCarg) and (tblcargos.tipo <> 2) and (tbltarjeta.CodigoCent = tblcentroed.codigoCent) and (tbltarjeta.estado = _latin1'A'))) */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
