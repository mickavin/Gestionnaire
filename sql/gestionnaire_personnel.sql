CREATE DATABASE  IF NOT EXISTS `gestionnaire` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;
USE `gestionnaire`;
-- MariaDB dump 10.19  Distrib 10.4.24-MariaDB, for Win64 (AMD64)
--
-- Host: localhost    Database: gestionnaire
-- ------------------------------------------------------
-- Server version	10.4.24-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `personnel`
--

DROP TABLE IF EXISTS `personnel`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `personnel` (
  `IDPERSONNEL` int(2) NOT NULL AUTO_INCREMENT,
  `IDSERVICE` int(2) NOT NULL,
  `NOM` varchar(50) DEFAULT NULL,
  `PRENOM` varchar(50) DEFAULT NULL,
  `TEL` varchar(15) DEFAULT NULL,
  `MAIL` varchar(128) DEFAULT NULL,
  PRIMARY KEY (`IDPERSONNEL`),
  KEY `FK_PERSONNEL_SERVICE` (`IDSERVICE`),
  CONSTRAINT `FK_PERSONNEL_SERVICE` FOREIGN KEY (`IDSERVICE`) REFERENCES `service` (`IDSERVICE`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `personnel`
--

LOCK TABLES `personnel` WRITE;
/*!40000 ALTER TABLE `personnel` DISABLE KEYS */;
INSERT INTO `personnel` VALUES (1,2,'Sawyer','Aaron','05 67 82 18 54','sapien.nunc@hotmail.org'),(4,3,'Blake','Galvin','04 22 91 75 88','donec@outlook.couk'),(5,3,'Quentin','Cain','04 79 23 35 91','mi.tempor@aol.net'),(6,2,'Kyle','Ciaran','08 19 65 04 87','volutpat@hotmail.edu'),(7,1,'Lyle','Mikayla','08 38 90 56 16','vel.lectus@yahoo.net'),(8,2,'Zachery','Davis','07 72 71 48 44','primis@icloud.org'),(9,2,'Alexander','Omar','02 37 13 84 31','aliquet.libero@protonmail.edu'),(10,1,'Ian','Igor','02 78 39 12 13','venenatis.a@google.couk'),(11,2,'Jerry','Baxter','07 42 17 22 22','pede.ultrices@aol.edu'),(12,2,'Donovan','Kevin','05 88 74 62 85','sed.hendrerit@icloud.couk'),(13,1,'Edward','Constance','08 21 84 27 60','ipsum.suspendisse@icloud.net'),(14,2,'Brenden','Marvin','07 72 87 34 63','elit.elit@outlook.org'),(15,2,'Norman','Rowan','09 21 35 19 61','penatibus.et@icloud.org'),(16,1,'dzd','dz','dz','dz'),(17,2,'fez','fzeze','fezfz','fezz@'),(20,2,'Kevin','Jean','','Jp@fe.fr'),(21,2,'kevin','jean','012345678','joe@de.fr');
/*!40000 ALTER TABLE `personnel` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-05-21 22:47:02
