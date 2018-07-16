DROP DATABASE HENDERSON_DB
GO
CREATE DATABASE HENDERSON_DB
GO
USE HENDERSON_DB
GO
CREATE TABLE ARTICULOS
		(IDARTICULO INT NOT NULL PRIMARY KEY IDENTITY(1,1),
		 NOMBRE VARCHAR(20) NOT NULL,
		 PRECIO INT NOT NULL,
		 STOCK INT NOT NULL DEFAULT 0)
GO
INSERT INTO ARTICULOS VALUES ('LADRILLO',40,17),('ARENA X KG.',16,23),('CAL X KG.',23,44),
		('YESO X KG',19,54),('APLICADOR C',15,16),('APLICADOR M',25,40),('APLICADOR G',40,7)
GO
CREATE TABLE EQUIPOS
		(EQUIPO INT NOT NULL PRIMARY KEY IDENTITY(1,1),
		 NOMBRE VARCHAR(20) NOT NULL)
GO		
INSERT INTO EQUIPOS VALUES ('ADMINISTRACION'),('VENTAS'),('OBRAS'),('COMPRAS'),('DEPOSITO'),('TESORERIA'),('CONTADURIA')
GO
CREATE TABLE EMPLEADOS
		(DNI VARCHAR(8) NOT NULL PRIMARY KEY,
		 NOMBRE VARCHAR(15) NOT NULL,
		 APELLIDO VARCHAR(20) NOT NULL,
		 FECHANAC DATETIME NOT NULL,
		 FECHAINGRESO DATETIME NOT NULL,
		 SEXO VARCHAR(1) NOT NULL,
		 SUELDO INT NOT NULL,
		 EQUIPO INT NOT NULL)		 
GO		 
INSERT INTO EMPLEADOS VALUES ('37479881','GONZALO','HENDERSON','1993/7/4','2018/4/1','M',40000,1),
		('40152312','CARLA','PEREZ','1996/6/24','2018/3/5','F',35000,2), ('38912832','JORGE','MARTINEZ','1994/3/2','2017/11/2','M',20000,3),
		('29412126','AGUSTINA','ESTEVEZ','1983/5/19','2016/6/15','F',30000,4), ('33355544','MARTIN','FERNANDEZ','1990/8/14','2015/1/6','M',27000,5),
		('36512812','PATRICIA','GONZALEZ','1992/3/4','2017/3/2','F',38000,6), ('39512351','GUSTAVO','AVALOS','1995/6/6','2017/2/17','M',29500,7)
GO
CREATE TABLE ADMINISTRADORES
		(DNI VARCHAR(8) NOT NULL PRIMARY KEY,
		 CONSTRAINT FK_ADMINISTRADOR FOREIGN KEY (DNI) REFERENCES EMPLEADOS(DNI))
GO
INSERT INTO ADMINISTRADORES VALUES ('37479881'),('40152312'),('38912832'),('29412126'),('33355544'),('36512812'),('39512351')
GO 
CREATE TABLE CLIENTES
		(DNI VARCHAR(8) NOT NULL PRIMARY KEY,
		 NOMBRE VARCHAR(15) NOT NULL,
		 APELLIDO VARCHAR(20) NOT NULL,
		 SEXO VARCHAR(1) NOT NULL,
		 FECHANAC DATETIME NOT NULL)
GO
INSERT INTO CLIENTES VALUES ('40512386','JORGE','ESTEVEZ','M','1995/3/6'), ('30456654','MICAELA','PEREZ','F','2000/1/1'), 
		('35467586','SUSANA','FERNANDEZ','F','1999/9/9'), ('39444123','FERNANDO','MARINA','M','1985/5/7'), 
		('42928312','GRACIELA','HERNANDEZ','F','1979/2/14')
GO
CREATE TABLE TELEFONOSC
		(DNI VARCHAR(8) NOT NULL,
		 TELEFONO INT NOT NULL,
		 DESCRIPCION VARCHAR(10),
		 CONSTRAINT PK_TELEFONOSC PRIMARY KEY (DNI,TELEFONO),
		 CONSTRAINT FK_TELEFONOSC FOREIGN KEY (DNI) REFERENCES CLIENTES(DNI))		 
GO
INSERT INTO TELEFONOSC VALUES ('40512386',1541231733,'CELULAR'), ('30456654',49422492,'FIJO'), 
		('35467586',1553535353,'CELULAR'), ('39444123',1520201234,'CELULAR'), ('42928312',49495353,'FIJO')
CREATE TABLE TELEFONOSE
		(DNI VARCHAR(8) NOT NULL,
		 TELEFONO INT NOT NULL,
		 DESCRIPCION VARCHAR(10),
		 CONSTRAINT PK_TELEFONOSE PRIMARY KEY (DNI,TELEFONO),
		 CONSTRAINT FK_TELEFONOSE FOREIGN KEY (DNI) REFERENCES EMPLEADOS(DNI))	
GO		 
INSERT INTO TELEFONOSE VALUES ('37479881',1564326432,'CELULAR'), ('40152312',1598798798,'CELULAR'), ('38912832',1553534141,'CELULAR'), ('29412126',45328843,'FIJO'), 
		('33355544',44126718,'FIJO'), ('36512812',47743322,'FIJO'), ('39512351',49948549,'FIJO')
GO
CREATE TABLE DOMICILIOSC
		(DNI VARCHAR(8) NOT NULL,
		 CALLE VARCHAR(20) NOT NULL,
		 ALTURA INT NOT NULL,
		 PISO INT,
		 DEPARTAMENTO CHAR,
		 CONSTRAINT PK_DOMICILIOSC PRIMARY KEY (DNI,CALLE,ALTURA),
		 CONSTRAINT FK_DOMICILIOSC FOREIGN KEY (DNI) REFERENCES CLIENTES(DNI))
GO
INSERT INTO DOMICILIOSC VALUES ('40512386','AV. RIVADAVIA',412,6,'B'), ('30456654','AV NAZCA',3356,3,'D'), 
		('35467586','ROQUE PEREZ',4156, NULL, NULL), ('39444123','VIDAL',34,3,NULL), 
		('42928312','MOLDES',4856, NULL, NULL)
GO
CREATE TABLE DOMICILIOSE
		(DNI VARCHAR(8) NOT NULL,
		 CALLE VARCHAR(20) NOT NULL,
		 ALTURA INT NOT NULL,
		 PISO INT,
		 DEPARTAMENTO CHAR,
		 CONSTRAINT PK_DOMICILIOSE PRIMARY KEY (DNI,CALLE,ALTURA),
		 CONSTRAINT FK_DOMICILIOSE FOREIGN KEY (DNI) REFERENCES EMPLEADOS(DNI))
GO
INSERT INTO DOMICILIOSE VALUES ('37479881','AV. CABILDO',523,6,'A'), ('40152312','AV. RIVADIAVIA',965,17,'D'), 
		('38912832','ARCOS',1954,2, NULL), ('29412126','CUBA',695,NULL,NULL), ('33355544','CERRITO',412,8,'C'), 
		('36512812','AV CABILDO',4231,3,NULL), ('39512351','AV JUAN B. JUSTO',378,4,'G')
GO
CREATE TABLE EMAILSC
		(DNI VARCHAR(8) NOT NULL,
		 MAIL VARCHAR(50) NOT NULL,
		 CONSTRAINT PK_EMAILSC PRIMARY KEY (DNI, MAIL),
		 CONSTRAINT FK_EMAILSC FOREIGN KEY (DNI) REFERENCES CLIENTES(DNI))		 
GO
INSERT INTO EMAILSC VALUES ('40512386','JORGE@ESTEVEZ.COM'), ('30456654','MICAELA@PEREZ.COM.AR'), 
		('35467586','SUSANA@FERNANDEZ.COM.AR'), ('39444123','FERNANDO@MARINA.COM.AR'), 
		('42928312','GRACIELA@HERNANDEZ.COM')
GO
CREATE TABLE EMAILSE
		(DNI VARCHAR(8) NOT NULL,
		 MAIL VARCHAR(50) NOT NULL,
		 CONSTRAINT PK_EMAILSE PRIMARY KEY (DNI, MAIL),
		 CONSTRAINT FK_EMAILSE FOREIGN KEY (DNI) REFERENCES EMPLEADOS(DNI))		 
GO
INSERT INTO EMAILSE VALUES ('37479881','GONZALO@HENDERSON.COM.AR'), ('40152312','CARLA@PEREZ.COM'), 
		('38912832','JORGE@MARTINEZ.COM.AR'), ('29412126','AGUSTINA@ESTEVEZ.COM'), 
		('33355544','MARTIN@FERNANDEZ.COM.AR'), ('36512812','PATRICIA@GONZALEZ.COM'), 
		('39512351','GUSTAVO@AVALOS.COM')
GO
CREATE TABLE INTERESES
		(IDINTERES INT NOT NULL PRIMARY KEY IDENTITY(1,1),
		 PORCENTAJE INT NOT NULL,
		 DESCRIPCION VARCHAR(20) NOT NULL)
GO 
INSERT INTO INTERESES VALUES (2,'ATRAZO MENSUAL'), (5,'ALTO RIESGO'), 
		(1,'CREDITO'), (17,'REPETIDOS IMPAGOS'),(0,'SIN INTERES')
GO		 
CREATE TABLE VENTAS
		(IDVENTA INT NOT NULL PRIMARY KEY IDENTITY(1,1),
		 DNIE VARCHAR(8) NOT NULL FOREIGN KEY REFERENCES EMPLEADOS(DNI),
		 DNIC VARCHAR(8) NOT NULL FOREIGN KEY REFERENCES CLIENTES(DNI),
		 IDINTERES INT FOREIGN KEY REFERENCES INTERESES(IDINTERES),
		 FECHA DATETIME NOT NULL)
GO
CREATE TABLE ARTICULOSXVENTA
		(IDVENTA INT NOT NULL,
		 IDARTICULO INT NOT NULL,
		 QART INT NOT NULL)		 
GO 
CREATE TABLE TIPOINCIDENTE
		(IDTIPO INT NOT NULL PRIMARY KEY IDENTITY (1,1),
		 DESCRIPCION VARCHAR(50) NOT NULL) 		
GO
INSERT INTO TIPOINCIDENTE VALUES ('Productos'), ('Envios'), ('Atencion al cliente'), ('Pagos')
GO
CREATE TABLE GRUPOINCIDENTE
		(IDGRUPO INT NOT NULL PRIMARY KEY IDENTITY(1,1),
		 DESCRIPCION VARCHAR(40),
		 IDTIPO INT FOREIGN KEY REFERENCES TIPOINCIDENTE(IDTIPO))
GO
INSERT INTO GRUPOINCIDENTE VALUES ('Mal estado',1), ('Envio tardio',2), ('Mala atencion',3), ('Falta de Pago',4)
GO
CREATE TABLE SUBTIPOINCIDENTE
		(IDSUBTIPO INT NOT NULL PRIMARY KEY IDENTITY(1,1),
		 DESCRIPCION VARCHAR(40),
		 IDGRUPO INT NOT NULL FOREIGN KEY REFERENCES GRUPOINCIDENTE(IDGRUPO))
GO
INSERT INTO SUBTIPOINCIDENTE VALUES ('Prod. Vencido',1), ('Prod. Estropeado',1), ('Envio pendiente',2), 
		('Fuera de tiempo',2), ('Representante desatento',3), 
		('Falta de contacto',3), ('Factura Impaga',4)
GO
CREATE TABLE INCIDENTES
		(IDINCID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
		 ESTADO INT NOT NULL,
		 DNICLIENTE VARCHAR(8) NOT NULL FOREIGN KEY REFERENCES CLIENTES(DNI),
		 DNIEMPLEADO VARCHAR(8) NOT NULL FOREIGN KEY REFERENCES EMPLEADOS(DNI),
		 PALTA BIT NOT NULL,
		 IDTIPO INT NOT NULL FOREIGN KEY REFERENCES TIPOINCIDENTE(IDTIPO),
		 IDGRUPO INT NOT NULL FOREIGN KEY REFERENCES GRUPOINCIDENTE(IDGRUPO),
		 IDSUB INT NOT NULL FOREIGN KEY REFERENCES SUBTIPOINCIDENTE(IDSUBTIPO),
		 IDVENTA INT NULL FOREIGN KEY REFERENCES VENTAS(IDVENTA),
		 FECHA DATETIME NOT NULL,
		 DESCRIPCION VARCHAR(50) NOT NULL) 
GO
CREATE TABLE USERS
		(DNI VARCHAR(8) NOT NULL PRIMARY KEY FOREIGN KEY REFERENCES EMPLEADOS(DNI),
		 NOMBRE VARCHAR(10) NOT NULL UNIQUE,
		 PASS VARCHAR(10) NOT NULL,
		 TIPO INT NOT NULL DEFAULT 1)
GO
INSERT INTO USERS VALUES ('37479881','ADMIN','admin',3)

		 	 
