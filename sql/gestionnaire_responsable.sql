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
-- Table structure for table `responsable`
--

DROP TABLE IF EXISTS `responsable`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `responsable` (
  `login` varchar(64) NOT NULL,
  `pwd` varchar(128) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `responsable`
--

LOCK TABLES `responsable` WRITE;
/*!40000 ALTER TABLE `responsable` DISABLE KEYS */;
INSERT INTO `responsable` VALUES ('System.Byte[]','0'),('–žïnÊÓÂš:b’€æ†Ï?]Z†¯óÊ’:Ül’','admin'),('admin','–žïnÊÓÂš:b’€æ†Ï?]Z†¯óÊ’:Ül’'),('Essai','‹°Ïn¹±}}\"´Vñ!%}Á%NfSpGcƒêwmô'),('responsable','–žïnÊÓÂš:b’€æ†Ï?]Z†¯óÊ’:Ül’'),('admin1','_a!¼áŽ ™ Õ}/±|È-ü*Þ7]iQ¹œeÑ¸'),('admin','‹°Ïn¹±}}\"´Vñ!%}Á%NfSpGcƒêwmô');
/*!40000 ALTER TABLE `responsable` ENABLE KEYS */;
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
