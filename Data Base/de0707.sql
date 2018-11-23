/*
SQLyog Community Edition- MySQL GUI v8.01 
MySQL - 5.1.30-community : Database - de0707
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

CREATE DATABASE /*!32312 IF NOT EXISTS*/`de0707` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `de0707`;

/*Table structure for table `empleados` */

DROP TABLE IF EXISTS `empleados`;

CREATE TABLE `empleados` (
  `cedula` char(13) DEFAULT NULL,
  `nombre` varchar(30) DEFAULT NULL,
  `apellido1` varchar(15) DEFAULT NULL,
  `apellido2` varchar(15) DEFAULT NULL,
  `direccion` varchar(50) DEFAULT NULL,
  `telefono` char(14) DEFAULT NULL,
  `celular` char(14) DEFAULT NULL,
  `fecha_nacimiento` date DEFAULT NULL,
  `sexo` char(1) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  `area_trabajo` varchar(20) DEFAULT NULL,
  `titulo` varchar(15) DEFAULT NULL,
  `carrera_estudiada` varchar(20) DEFAULT NULL,
  `fecha_ingreso` date DEFAULT NULL,
  `fecha_reg` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `empleados` */

insert  into `empleados`(`cedula`,`nombre`,`apellido1`,`apellido2`,`direccion`,`telefono`,`celular`,`fecha_nacimiento`,`sexo`,`estado`,`area_trabajo`,`titulo`,`carrera_estudiada`,`fecha_ingreso`,`fecha_reg`) values ('051-0000065-4','JUNA','PEREZ','COLLADO','VILLA TAPIA','(809) 654-6413','(829) 654-6546','1981-11-13','M',1,'ENC. BASICA','LICENCIATURA','EDUCACION BASICA','2009-11-13','2009-11-13'),('051-0065497-9','MARIA','CARRASCO','PEÑA','VILLA TAPIA','(809) 574-6987','(829) 698-8784','2009-11-13','M',1,'ENC. BASICA','LICENCIATURA','EDUCACION BASICA','2009-11-13','2009-11-13');

/*Table structure for table `tblare_curso` */

DROP TABLE IF EXISTS `tblare_curso`;

CREATE TABLE `tblare_curso` (
  `ID_area` int(11) DEFAULT NULL,
  `ID_Curso` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tblare_curso` */

/*Table structure for table `tblareas` */

DROP TABLE IF EXISTS `tblareas`;

CREATE TABLE `tblareas` (
  `CodigoArea` int(11) NOT NULL,
  `NomArea` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`CodigoArea`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tblareas` */

insert  into `tblareas`(`CodigoArea`,`NomArea`) values (1,'DIRECCION DEL CENTRO'),(2,'SUB-DIRECCION DEL CENTRO'),(3,'SECRETARIA'),(4,'MATEMATICA'),(5,'LENGGUA ESPAÑOLA'),(6,'SOCIALES'),(7,'NATURALES'),(8,'INGLES'),(9,'FRANCES'),(10,'EDUCACION FISICA'),(11,'EDUCACION ARTISTICA'),(12,NULL),(13,''),(14,'SUB-DIRECCION DE DISTRITO'),(15,'ENC. RRHH');

/*Table structure for table `tblaretrabajo` */

DROP TABLE IF EXISTS `tblaretrabajo`;

CREATE TABLE `tblaretrabajo` (
  `ID_area` int(11) NOT NULL,
  `nombre_area` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID_area`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tblaretrabajo` */

/*Table structure for table `tblcentroed` */

DROP TABLE IF EXISTS `tblcentroed`;

CREATE TABLE `tblcentroed` (
  `codigoCent` int(11) NOT NULL,
  `Codistrito` char(5) DEFAULT NULL,
  `nombre` varchar(50) DEFAULT NULL,
  `direccion` varchar(100) DEFAULT NULL,
  `telefono` char(14) DEFAULT NULL,
  `tanda` varchar(21) DEFAULT NULL,
  `fecha_reg` date DEFAULT NULL,
  `estado` char(1) DEFAULT NULL,
  PRIMARY KEY (`codigoCent`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tblcentroed` */

insert  into `tblcentroed`(`codigoCent`,`Codistrito`,`nombre`,`direccion`,`telefono`,`tanda`,`fecha_reg`,`estado`) values (19006545,'07-07','LA TANTA','LAS VANTA','(809) 654-6546','NOCTURNA','2009-11-20','A'),(19014654,'07','LA GINA','LA GINA','(809) 654-6546','NOCTURNA','2009-11-19','A'),(19014923,'07-07','LA GINA','Villa Tapia','(809)-574-3932','VESPERTINO','2009-11-10','1'),(19014929,'07-07','Federico a. Gonzalez','Villa Tapia','(809)-574-3932','MATUTINO','2009-11-06','1'),(19014931,'07','FEDERICO A ','VILLA TAPIA ','(809) 574-3354','VESPERTINO','2009-11-19','A'),(19014951,'07-07','Federico a. Gonzalez','Villa Tapia','(809)-574-3932','VESPERTINO','2009-11-06','1');

/*Table structure for table `tblcursos` */

DROP TABLE IF EXISTS `tblcursos`;

CREATE TABLE `tblcursos` (
  `IDcurso` int(11) NOT NULL,
  `nombre_curso` varchar(50) DEFAULT NULL,
  `fecha_reg` date DEFAULT NULL,
  `estado` char(1) DEFAULT NULL,
  PRIMARY KEY (`IDcurso`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tblcursos` */

/*Table structure for table `tblcursos_centro` */

DROP TABLE IF EXISTS `tblcursos_centro`;

CREATE TABLE `tblcursos_centro` (
  `IDccentro` int(11) DEFAULT NULL,
  `IDcurso` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tblcursos_centro` */

/*Table structure for table `tbldistrito` */

DROP TABLE IF EXISTS `tbldistrito`;

CREATE TABLE `tbldistrito` (
  `Codistrito` char(5) NOT NULL,
  `cod_regional` char(2) NOT NULL,
  `d_nombre` varchar(50) DEFAULT NULL,
  `d_direccion` varchar(100) DEFAULT NULL,
  `d_telefono` char(14) DEFAULT NULL,
  `fecha_reg` date DEFAULT NULL,
  `estado` char(1) DEFAULT NULL,
  PRIMARY KEY (`Codistrito`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tbldistrito` */

insert  into `tbldistrito`(`Codistrito`,`cod_regional`,`d_nombre`,`d_direccion`,`d_telefono`,`fecha_reg`,`estado`) values ('07-04','07','DISTRITO EDUCATIVO','TENARES','(809) 574-3305','2009-11-18','A'),('07-06','07','DISTRITO EDUCATIVO','VILLA TAPIA','(809) 546-5454','2009-11-16','A'),('07-07','07','Distrito Educativo 07-07 de Villa Tapia','calle duarte #3','(809)-574-3029','2009-11-10','A');

/*Table structure for table `tbldocente` */

DROP TABLE IF EXISTS `tbldocente`;

CREATE TABLE `tbldocente` (
  `IDdocente` int(11) NOT NULL,
  `cedula` char(13) DEFAULT NULL,
  `nivelacad` varchar(50) DEFAULT NULL,
  `titulo` varchar(50) DEFAULT NULL,
  `areaestudio` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`IDdocente`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tbldocente` */

/*Table structure for table `tblhistorial` */

DROP TABLE IF EXISTS `tblhistorial`;

CREATE TABLE `tblhistorial` (
  `Id_historial` int(7) unsigned NOT NULL,
  `cedula_Empl` int(7) DEFAULT NULL,
  `Nomb_usuario` varchar(100) DEFAULT NULL,
  `Descripción` varchar(100) DEFAULT NULL,
  `fecha_Reg` datetime DEFAULT NULL,
  PRIMARY KEY (`Id_historial`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tblhistorial` */

/*Table structure for table `tblpermisosusuarios` */

DROP TABLE IF EXISTS `tblpermisosusuarios`;

CREATE TABLE `tblpermisosusuarios` (
  `fPerID` int(10) DEFAULT '0',
  `fUsuID` int(10) DEFAULT NULL,
  `fAsignado` tinyint(1) DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tblpermisosusuarios` */

insert  into `tblpermisosusuarios`(`fPerID`,`fUsuID`,`fAsignado`) values (100,1,1),(110,1,1),(111,1,1),(112,1,1),(113,1,1),(120,1,1),(121,1,1),(122,1,1),(123,1,1),(124,1,0),(125,1,1),(200,1,1);

/*Table structure for table `tblregional` */

DROP TABLE IF EXISTS `tblregional`;

CREATE TABLE `tblregional` (
  `cod_regional` char(2) NOT NULL,
  `nombre` varchar(50) DEFAULT NULL,
  `direccion` varchar(100) DEFAULT NULL,
  `telefono` char(14) DEFAULT NULL,
  `fecha_reg` date DEFAULT NULL,
  `estado` char(1) DEFAULT NULL,
  PRIMARY KEY (`cod_regional`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tblregional` */

insert  into `tblregional`(`cod_regional`,`nombre`,`direccion`,`telefono`,`fecha_reg`,`estado`) values ('01','SANTO DOMINGO','SANTO DOMINGO #50','(809) 564-4645','2009-11-13','A'),('02','SANTIAGO','SANTIAGO','(809) 464-6546','2009-11-13','A'),('04','SAMANA','SAMANA','(809) 654-6546','2009-11-13','A'),('07','Regional de Educativo 07 ','c/ 27 de Febrero #10','(809)-588-3254','2009-11-10','A');

/*Table structure for table `tbltarj_empl` */

DROP TABLE IF EXISTS `tbltarj_empl`;

CREATE TABLE `tbltarj_empl` (
  `cedula_empl` char(13) NOT NULL,
  `tarjeta` char(9) NOT NULL,
  `estado` char(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tbltarj_empl` */

insert  into `tbltarj_empl`(`cedula_empl`,`tarjeta`,`estado`) values ('051-0046823-9','11012-032','A');

/*Table structure for table `tbltarjeta` */

DROP TABLE IF EXISTS `tbltarjeta`;

CREATE TABLE `tbltarjeta` (
  `tarjeta` char(9) NOT NULL,
  `CodigoCent` int(11) DEFAULT NULL,
  `cargo` varchar(50) DEFAULT NULL,
  `ingresos` double DEFAULT NULL,
  `fecha_reg` date DEFAULT NULL,
  `estado` char(1) DEFAULT NULL,
  PRIMARY KEY (`tarjeta`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tbltarjeta` */

insert  into `tbltarjeta`(`tarjeta`,`CodigoCent`,`cargo`,`ingresos`,`fecha_reg`,`estado`) values ('11105-002',19014929,'CONSERJE',5000.75,'2009-11-10','A'),('11105-005',19014929,'CONSERJE',5000.75,'2009-11-10','A'),('15345-645',19014929,'CONSERJE',5000,'2009-11-23','A'),('19014-929',19014929,'MAESTRO/A',5000.5,'2009-11-20','A'),('19021-313',19014929,'MAESTRO/A',5000,'2009-11-23','A');

/*Table structure for table `tblusuarios` */

DROP TABLE IF EXISTS `tblusuarios`;

CREATE TABLE `tblusuarios` (
  `UsuarioID` int(11) NOT NULL AUTO_INCREMENT,
  `NomUsu` varchar(50) DEFAULT NULL,
  `contrac` varchar(50) DEFAULT NULL,
  `cedulaEmpl` char(13) DEFAULT NULL,
  `fecha_reg` date DEFAULT NULL,
  `estado` char(1) DEFAULT NULL,
  PRIMARY KEY (`UsuarioID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

/*Data for the table `tblusuarios` */

insert  into `tblusuarios`(`UsuarioID`,`NomUsu`,`contrac`,`cedulaEmpl`,`fecha_reg`,`estado`) values (1,'sa','sa','051-0032468-5','2009-11-11','A');

/* Procedure structure for procedure `guardacentro` */

/*!50003 DROP PROCEDURE IF EXISTS  `guardacentro` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `guardacentro`(control tinyint(1),ccodigoCent int,cCodistrito char(5),cnombre varchar(50),cdireccion varchar(100),ctelefono char(14),ctanda varchar(21),cestado char(1))
BEGIN
        IF(control=0) THEN /*HACE UN UPDATE*/	
	    if exists (select codigoCent from tblcentroed  where codigoCent=ccodigoCent) then 
                UPDATE tblcentroed SET codigoCent=ccodigoCent,Codistrito=cCodistrito,nombre=cnombre,direccion=cdireccion,telefono=ctelefono,tanda=ctanda,estado=cestado WHERE codigoCent=ccodigoCent;
	    end if;
	elseif (control=1) THEN /*HACE UN INSERT*/
	   if NOT exists (select codigoCent from tblcentroed  where codigoCent=ccodigoCent) then 
		INSERT INTO tblcentroed (codigoCent,Codistrito,nombre,direccion,telefono,tanda,estado,fecha_reg)
                VALUES(ccodigoCent,cCodistrito,cnombre,cdireccion,ctelefono,ctanda,cestado,curdate());
           END IF;
	END IF;
END */$$
DELIMITER ;

/* Procedure structure for procedure `guardadist` */

/*!50003 DROP PROCEDURE IF EXISTS  `guardadist` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `guardadist`(control tinyint,dCodistrito char(5),dcod_regional char(2),dd_nombre varchar(50),dd_direccion varchar(100),dd_telefono char(14),destado char(1))
begin 
   if (control=0)then 
       if exists(select Codistrito from tbldistrito where Codistrito=dCodistrito)then
	   update tbldistrito set cod_regional=dcod_regional,d_nombre=dd_nombre,d_direccion=dd_direccion,d_telefono=dd_telefono,estado=destado;
       end if;
   elseif(control=1)then 
       if not exists(select Codistrito from tbldistrito where Codistrito=dCodistrito)then
	  insert into tbldistrito (Codistrito,cod_regional,d_nombre,d_direccion,d_telefono,fecha_reg,estado)
          values(dCodistrito,dcod_regional,dd_nombre,dd_direccion,dd_telefono,curdate(),destado);
       end if;
   end if;
end */$$
DELIMITER ;

/* Procedure structure for procedure `guardaEmpleado` */

/*!50003 DROP PROCEDURE IF EXISTS  `guardaEmpleado` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `guardaEmpleado`(control tinyint(1),ecedula char(13),enombre varchar(30),eapellido1 varchar(15),eapellido2 varchar(15),edireccion varchar(50),etelefono char(14),ecelular char(14),efecha_nacimiento date,esexo char(1),eestado tinyint,earea_trabajo varchar(20),etitulo varchar(15),ecarrera_estudiada varchar(20),efecha_ingreso date)
BEGIN
        IF(control=0) THEN /*HACE UN UPDATE*/	
	    if exists (select cedula from empleados  where cedula=ecedula) then 
                UPDATE empleados SET nombre=enombre,apellido1=eapellido1,apellido2=eapellido2,direccion=edireccion,telefono=etelefono,celular=ecelular,fecha_nacimiento=efecha_ingreso,sexo=esexo,estado=eestado,area_trabajo=earea_trabajo,titulo=etitulo,carrera_estudiada=ecarrera_estudiada,fecha_ingreso=efecha_ingreso WHERE cedula=ecedula;
	    end if;
	elseif (control=1) THEN /*HACE UN INSERT*/
	   if NOT exists (select cedula from empleados  where cedula=ecedula) then 
		INSERT INTO empleados (cedula,nombre,apellido1,apellido2,direccion,telefono,celular,fecha_nacimiento,sexo,estado,area_trabajo,titulo,carrera_estudiada,fecha_ingreso,fecha_reg)
                                VALUES(ecedula,enombre,eapellido1,eapellido2,edireccion,etelefono,ecelular,efecha_nacimiento,esexo,eestado,earea_trabajo,etitulo,ecarrera_estudiada,efecha_ingreso,curdate());
           END IF;
	END IF;
END */$$
DELIMITER ;

/* Procedure structure for procedure `guardaHist` */

/*!50003 DROP PROCEDURE IF EXISTS  `guardaHist` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `guardaHist`(hcedula_Empl int(7),hNomb_usuario varchar(100),hDescripción varchar(100))
begin  
	insert into tblhistorial (cedula_Empl,Nomb_usuario,Descripción,fecha_Reg)
                           values(hcedula_Empl,hNomb_usuario ,hDescripción,curdate());
end */$$
DELIMITER ;

/* Procedure structure for procedure `guardaPermisos` */

/*!50003 DROP PROCEDURE IF EXISTS  `guardaPermisos` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `guardaPermisos`(pfPerID int(10),pfUsuID int(10),pfAsignado tinyint(1))
begin 
       insert into tblpermisosusuarios (fPerID,fUsuID,fAsignado)
	values(pfPerID,pfUsuID,pfAsignado);
end */$$
DELIMITER ;

/* Procedure structure for procedure `guardaReg` */

/*!50003 DROP PROCEDURE IF EXISTS  `guardaReg` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `guardaReg`(control tinyint,rcod_regional char(2),rnombre varchar(50),rdireccion varchar(100),rtelefono char(14),restado char(1))
begin 
   if (control=0)then 
       if exists(select cod_regional from tblregional where cod_regional=rcod_regional)then
	   update tblregional set nombre=rnombre,direccion=rdireccion,telefono=rtelefono,estado=restado;
       end if;
   elseif(control=1)then 
       if not exists(select cod_regional from tblregional where cod_regional=rcod_regional)then
	  insert into tblregional (cod_regional,nombre,direccion,telefono,fecha_reg,estado)
          values(rcod_regional,rnombre,rdireccion,rtelefono,curdate(),restado);
       end if;
   end if;
end */$$
DELIMITER ;

/* Procedure structure for procedure `guardaTarj` */

/*!50003 DROP PROCEDURE IF EXISTS  `guardaTarj` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `guardaTarj`(control tinyint ,ttarjeta char(9),tcodigoCent int, tcargo varchar(50),tingresos double,testado char(1))
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

/* Procedure structure for procedure `guardaTarjEmpl` */

/*!50003 DROP PROCEDURE IF EXISTS  `guardaTarjEmpl` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `guardaTarjEmpl`(ttarjeta char(9),tcedula char(13))
begin 
  
     if exists(select cedula_empl,tarjeta from tbltarj_empl where cedula_empl=tcedula and tarjeta=ttarjeta)then 
        update tbltarj_empl set estado="A" where cedula_empl=tcedula and tarjeta=ttarjeta;
     else
        insert into tbltarj_empl (cedula_empl,tarjeta,estado) values(tcedula,ttarjeta,"A");
     end if;
  
end */$$
DELIMITER ;

/* Procedure structure for procedure `guardaUsuario` */

/*!50003 DROP PROCEDURE IF EXISTS  `guardaUsuario` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `guardaUsuario`(uNomUsu varchar(50),ucontrac varchar(50),ucedulaEmpl char(13)/*,uestado CHAR(1)*/)
begin 
   IF NOT EXISTS(SELECT NomUsu from tblusuarios where NomUsu=uNomUsu)then 
       insert into tblusuarios (NomUsu,contrac,cedulaEmpl,fecha_reg,estado)
	values(uNomUsu,ucontrac,ucedulaEmpl,curdate(),"A");
   end if;
end */$$
DELIMITER ;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
