-- MySQL dump 10.13  Distrib 8.0.45, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: tienda
-- ------------------------------------------------------
-- Server version	8.0.45

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `categorias`
--

DROP TABLE IF EXISTS `categorias`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `categorias` (
  `id_categoria` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`id_categoria`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categorias`
--

LOCK TABLES `categorias` WRITE;
/*!40000 ALTER TABLE `categorias` DISABLE KEYS */;
INSERT INTO `categorias` VALUES (1,'carniceria'),(2,'lacteos'),(3,'verduras'),(4,'panaderia'),(5,'abarrotes');
/*!40000 ALTER TABLE `categorias` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `clientes`
--

DROP TABLE IF EXISTS `clientes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `clientes` (
  `id_cliente` varchar(8) NOT NULL,
  `nombre` varchar(30) NOT NULL,
  `apellido_paterno` varchar(20) DEFAULT NULL,
  `apellido_materno` varchar(20) DEFAULT NULL,
  `correo` varchar(100) DEFAULT NULL,
  `celular` varchar(10) DEFAULT NULL,
  `prueba` varchar(10) DEFAULT NULL,
  `fecha_nacimiento` date DEFAULT NULL,
  PRIMARY KEY (`id_cliente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clientes`
--

LOCK TABLES `clientes` WRITE;
/*!40000 ALTER TABLE `clientes` DISABLE KEYS */;
INSERT INTO `clientes` VALUES ('ABC123','Luis','Lopez','Castro','asdas@hotmail.com','6241234567','probando','1955-05-07'),('ABC456','Jose','lopez','ruiz','llc@correo.com','6241234567','probando','1995-07-02'),('ABC789','Jose','hernandez','ruiz','llc@correo.com','Hernandez','probando','2005-02-01'),('CLI00001','Juan','García','López','juan.garcia@email.com','5512345678','Aprobado','1990-05-15'),('CLI00002','María','Rodríguez','Hernández','maria.rodriguez@email.com','5523456789','Pendiente','1985-08-22'),('CLI00003','Carlos','Martínez','Sánchez','carlos.martinez@email.com','5534567890','Rechazado','1992-11-10'),('CLI00004','Ana','González','Pérez','ana.gonzalez@email.com','5545678901','Aprobado','1955-05-07'),('CLI00005','Luis','Fernández','Díaz','luis.fernandez@email.com','5556789012','Pendiente','1995-07-18'),('CLI00006','Patricia','López','Romero','patricia.lopez@email.com','5567890123','Aprobado','1983-12-27'),('CLI00007','Miguel','Sánchez','Morales','miguel.sanchez@email.com','5578901234','Rechazado','1991-09-14'),('CLI00008','Isabel','Ramírez','Torres','isabel.ramirez@email.com','5589012345','Aprobado','1987-06-30'),('CLI00009','Javier','Torres','Flores','javier.torres@email.com','5590123456','Pendiente','1993-04-05'),('CLI00010','Carmen','Flores','Rivera','carmen.flores@email.com','5501234567','Aprobado','1989-10-19'),('CLI00011','Ricardo','Mendoza','Cruz','ricardo.mendoza@email.com','5512345670','Pendiente','1994-02-28'),('CLI00012','Laura','Cruz','Ortiz','laura.cruz@email.com','5523456780','Aprobado','1986-08-12'),('CLI00013','Fernando','Ortiz','Gómez','fernando.ortiz@email.com','5534567890','Rechazado','1996-01-07'),('CLI00014','Martha','Gómez','Muñoz','martha.gomez@email.com','5545678901','Aprobado','1990-11-24'),('CLI00015','Roberto','Muñoz','Reyes','roberto.munoz@email.com','5556789012','Pendiente','1984-09-16'),('CLI00016','Verónica','Reyes','Vargas','veronica.reyes@email.com','5567890123','Aprobado','1992-05-09'),('CLI00017','Sergio','Vargas','Silva','sergio.vargas@email.com','5578901234','Pendiente','1988-07-25'),('CLI00018','Gloria','Silva','Castro','gloria.silva@email.com','5589012345','Aprobado','1995-12-03'),('CLI00019','Adrián','Castro','Méndez','adrian.castro@email.com','5590123456','Rechazado','1987-03-29'),('CLI00020','Teresa','Méndez','Aguilar','teresa.mendez@email.com','5501234567','Aprobado','1991-10-11'),('CLI00021','Francisco','Aguilar','Herrera','francisco.aguilar@email.com','5512345678','Pendiente','1985-01-18'),('CLI00022','Rosa','Herrera','León','rosa.herrera@email.com','5523456789','Aprobado','1993-06-21'),('CLI00023','Manuel','León','Jiménez','manuel.leon@email.com','5534567890','Pendiente','1989-11-30'),('CLI00024','Julia','Jiménez','Ramos','julia.jimenez@email.com','5545678901','Aprobado','1996-04-14'),('CLI00025','Eduardo','Ramos','Delgado','eduardo.ramos@email.com','5556789012','Rechazado','1994-08-26'),('CLI00026','Sandra','Delgado','Peña','sandra.delgado@email.com','5567890123','Aprobado','1986-02-09'),('CLI00027','Alejandro','Peña','Navarro','alejandro.pena@email.com','5578901234','Pendiente','1990-12-17'),('CLI00028','Elena','Navarro','Montero','elena.navarro@email.com','5589012345','Aprobado','1988-05-23'),('CLI00029','Antonio','Montero','Rojas','antonio.montero@email.com','5590123456','Pendiente','1992-09-08'),('CLI00030','Olga','Rojas','Soto','olga.rojas@email.com','5501234567','Aprobado','1984-07-19');
/*!40000 ALTER TABLE `clientes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `demo`
--

DROP TABLE IF EXISTS `demo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `demo` (
  `id` int DEFAULT NULL,
  `nombre` varchar(10) DEFAULT NULL,
  `id_categoria` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `demo`
--

LOCK TABLES `demo` WRITE;
/*!40000 ALTER TABLE `demo` DISABLE KEYS */;
INSERT INTO `demo` VALUES (1,'prueba',1);
/*!40000 ALTER TABLE `demo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalles_ventas`
--

DROP TABLE IF EXISTS `detalles_ventas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `detalles_ventas` (
  `id` int NOT NULL AUTO_INCREMENT,
  `id_venta` varchar(12) DEFAULT NULL,
  `id_producto` int DEFAULT NULL,
  `precio_unitario` decimal(7,2) DEFAULT NULL,
  `cantidad` int DEFAULT NULL,
  `total` decimal(7,2) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_ventas_detalles` (`id_venta`),
  KEY `fk_productos_detalles` (`id_producto`),
  CONSTRAINT `fk_productos_detalles` FOREIGN KEY (`id_producto`) REFERENCES `productos` (`id_producto`),
  CONSTRAINT `fk_ventas_detalles` FOREIGN KEY (`id_venta`) REFERENCES `ventas` (`id_venta`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalles_ventas`
--

LOCK TABLES `detalles_ventas` WRITE;
/*!40000 ALTER TABLE `detalles_ventas` DISABLE KEYS */;
INSERT INTO `detalles_ventas` VALUES (2,'042026000001',1,100.00,3,300.00),(3,'042026000001',4,50.00,2,100.00),(4,'042026000002',4,50.00,1,50.00),(5,'042026000002',5,100.00,1,100.00);
/*!40000 ALTER TABLE `detalles_ventas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `lista_gastos`
--

DROP TABLE IF EXISTS `lista_gastos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `lista_gastos` (
  `id_gasto` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`id_gasto`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lista_gastos`
--

LOCK TABLES `lista_gastos` WRITE;
/*!40000 ALTER TABLE `lista_gastos` DISABLE KEYS */;
INSERT INTO `lista_gastos` VALUES (1,'CFE'),(2,'Telmex'),(3,'Agua'),(4,'Otros');
/*!40000 ALTER TABLE `lista_gastos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `productos`
--

DROP TABLE IF EXISTS `productos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `productos` (
  `id_producto` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) DEFAULT NULL,
  `precio` decimal(7,2) DEFAULT NULL,
  `id_categoria` int DEFAULT NULL,
  `descripcion` varchar(500) DEFAULT NULL,
  PRIMARY KEY (`id_producto`),
  KEY `id_categoria` (`id_categoria`),
  CONSTRAINT `productos_ibfk_1` FOREIGN KEY (`id_categoria`) REFERENCES `categorias` (`id_categoria`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `productos`
--

LOCK TABLES `productos` WRITE;
/*!40000 ALTER TABLE `productos` DISABLE KEYS */;
INSERT INTO `productos` VALUES (1,'carne',100.00,1,'este es un producto de prueba'),(3,'queso oaxaca',150.00,2,'ques para quesadillas'),(4,'tomate',50.00,3,'tomate rojo bien fresco'),(5,'jamon de pavo',100.00,2,'jamon swan');
/*!40000 ALTER TABLE `productos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pruebas`
--

DROP TABLE IF EXISTS `pruebas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pruebas` (
  `nombre` varchar(10) DEFAULT NULL,
  `cantidad` int DEFAULT NULL,
  `precio` decimal(5,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pruebas`
--

LOCK TABLES `pruebas` WRITE;
/*!40000 ALTER TABLE `pruebas` DISABLE KEYS */;
INSERT INTO `pruebas` VALUES ('carne',5,5.50),('manzanas',10,55.30),('peras',45,12.00),('kjk',15,12.00),('we',1,21.00),('yuui',213,123.00);
/*!40000 ALTER TABLE `pruebas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ventas`
--

DROP TABLE IF EXISTS `ventas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ventas` (
  `id_venta` varchar(12) NOT NULL,
  `fecha` datetime DEFAULT NULL,
  `id_cliente` varchar(8) DEFAULT NULL,
  `total` decimal(7,2) DEFAULT NULL,
  PRIMARY KEY (`id_venta`),
  KEY `id_cliente` (`id_cliente`),
  CONSTRAINT `ventas_ibfk_1` FOREIGN KEY (`id_cliente`) REFERENCES `clientes` (`id_cliente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ventas`
--

LOCK TABLES `ventas` WRITE;
/*!40000 ALTER TABLE `ventas` DISABLE KEYS */;
INSERT INTO `ventas` VALUES ('042026000001','2026-04-20 00:00:00','ABC123',500.00),('042026000002','2026-04-20 00:00:00','ABC456',150.00);
/*!40000 ALTER TABLE `ventas` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2026-10-08 12:47:42
