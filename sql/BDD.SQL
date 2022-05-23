# -----------------------------------------------------------------------------
#       TABLE : ABSENCE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS ABSENCE
 (
   IDPERSONNEL INTEGER(2) NOT NULL  ,
   DATEDEBUT DATETIME NOT NULL  ,
   IDMOTIF INTEGER(2) NOT NULL  ,
   DATEFIN DATETIME NULL  
   , PRIMARY KEY (IDPERSONNEL,DATEDEBUT) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : MOTIF
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS MOTIF
 (
   IDMOTIF INTEGER(2) NOT NULL AUTO_INCREMENT ,
   LIBELLE VARCHAR(128) NULL  
   , PRIMARY KEY (IDMOTIF) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : SERVICE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS SERVICE
 (
   IDSERVICE INTEGER(2) NOT NULL AUTO_INCREMENT ,
   NOM VARCHAR(50) NULL  
   , PRIMARY KEY (IDSERVICE) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : PERSONNEL
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS PERSONNEL
 (
   IDPERSONNEL INTEGER(2) NOT NULL AUTO_INCREMENT ,
   IDSERVICE INTEGER(2) NOT NULL  ,
   NOM VARCHAR(50) NULL  ,
   PRENOM VARCHAR(50) NULL  ,
   TEL VARCHAR(15) NULL  ,
   MAIL VARCHAR(128) NULL  
   , PRIMARY KEY (IDPERSONNEL) 
 ) 
 comment = "";


CREATE TABLE IF NOT EXISTS `responsable` (
  `login` varchar(64) NOT NULL,
  `pwd` varchar(128) NOT NULL
)

# -----------------------------------------------------------------------------
#       CREATION DES REFERENCES DE TABLE
# -----------------------------------------------------------------------------


ALTER TABLE ABSENCE 
  ADD FOREIGN KEY FK_ABSENCE_MOTIF (IDMOTIF)
      REFERENCES MOTIF (IDMOTIF) 
	ON DELETE CASCADE;


ALTER TABLE ABSENCE 
  ADD FOREIGN KEY FK_ABSENCE_PERSONNEL (IDPERSONNEL)
      REFERENCES PERSONNEL (IDPERSONNEL) 
	ON DELETE CASCADE;


ALTER TABLE PERSONNEL 
  ADD FOREIGN KEY FK_PERSONNEL_SERVICE (IDSERVICE)
      REFERENCES SERVICE (IDSERVICE) 
	ON DELETE CASCADE;

INSERT INTO `motif` VALUES (1,'vacances'),(2,'maladie'),(3,'motif familial'),(4,'congé parental');
INSERT INTO `service` VALUES (1,'administratif'),(2,'médiation culturelle'),(3,'prêt');
INSERT INTO `personnel` VALUES (1,2,'Sawyer','Aaron','05 67 82 18 54','sapien.nunc@hotmail.org'),(4,3,'Blake','Galvin','04 22 91 75 88','donec@outlook.couk'),(5,3,'Quentin','Cain','04 79 23 35 91','mi.tempor@aol.net'),(6,2,'Kyle','Ciaran','08 19 65 04 87','volutpat@hotmail.edu'),(7,1,'Lyle','Mikayla','08 38 90 56 16','vel.lectus@yahoo.net'),(8,2,'Zachery','Davis','07 72 71 48 44','primis@icloud.org'),(9,2,'Alexander','Omar','02 37 13 84 31','aliquet.libero@protonmail.edu'),(10,1,'Ian','Igor','02 78 39 12 13','venenatis.a@google.couk'),(11,2,'Jerry','Baxter','07 42 17 22 22','pede.ultrices@aol.edu'),(12,2,'Donovan','Kevin','05 88 74 62 85','sed.hendrerit@icloud.couk'),(13,1,'Edward','Constance','08 21 84 27 60','ipsum.suspendisse@icloud.net'),(14,2,'Brenden','Marvin','07 72 87 34 63','elit.elit@outlook.org'),(15,2,'Norman','Rowan','09 21 35 19 61','penatibus.et@icloud.org'),(16,1,'dzd','dz','dz','dz'),(17,2,'fez','fzeze','fezfz','fezz@'),(20,2,'Kevin','Jean','','Jp@fe.fr'),(21,2,'kevin','jean','012345678','joe@de.fr');
INSERT INTO `absence` VALUES (1,'2022-01-03 09:38:43',4,'2024-10-31 00:31:27'),(4,'2022-05-21 13:20:27',2,'2022-05-28 13:20:27'),(4,'2022-05-28 13:41:17',3,'2022-05-29 13:41:17'),(4,'2023-01-14 05:20:37',3,'2023-04-15 04:54:17'),(4,'2023-03-29 04:54:17',4,'2025-03-15 04:54:17'),(4,'2023-04-08 01:26:29',3,'2023-04-29 04:54:17'),(5,'2022-08-10 02:30:40',3,'2025-03-31 13:40:01'),(6,'2021-08-30 09:55:08',4,'2025-09-05 10:00:19'),(6,'2021-10-15 02:01:25',3,'2024-10-10 14:34:00'),(6,'2021-10-19 12:57:16',2,'2026-02-28 23:30:21'),(6,'2022-01-28 12:08:36',3,'2026-01-03 20:10:39'),(6,'2022-01-30 17:19:05',1,'2025-02-18 02:06:55'),(6,'2022-06-26 05:23:48',2,'2026-04-04 07:05:56'),(6,'2022-12-29 23:31:41',2,'2024-05-30 11:32:03'),(7,'2022-04-03 08:12:07',4,'2024-11-13 08:35:30'),(7,'2022-05-28 07:06:19',2,'2026-04-07 22:47:06'),(7,'2022-12-22 22:26:08',2,'2026-04-12 19:28:40'),(7,'2023-02-02 04:37:44',2,'2024-05-19 05:03:49'),(7,'2023-03-03 23:44:54',4,'2026-01-05 17:28:24'),(7,'2023-04-29 21:11:54',1,'2025-10-18 02:54:21'),(8,'2021-12-29 04:35:16',3,'2025-10-27 09:11:12'),(8,'2022-04-23 01:02:23',1,'2024-06-03 21:30:24'),(8,'2022-08-21 12:34:24',4,'2026-05-17 09:02:51'),(8,'2023-03-28 22:12:43',2,'2026-04-14 14:27:19'),(9,'2021-07-10 17:02:44',3,'2024-09-12 23:23:41'),(9,'2021-12-03 22:30:56',3,'2025-09-20 06:42:56'),(9,'2022-09-13 10:37:01',3,'2025-06-28 07:39:04'),(9,'2023-04-26 04:38:37',1,'2024-12-07 01:41:39'),(10,'2021-07-12 16:21:02',3,'2024-10-12 05:25:35'),(10,'2022-04-25 16:14:51',3,'2025-12-06 13:28:54'),(10,'2023-02-17 21:18:12',2,'2026-03-30 10:52:31'),(10,'2023-03-13 23:53:22',3,'2025-12-05 01:03:01'),(11,'2021-12-06 21:59:25',4,'2025-05-16 15:52:06'),(11,'2022-06-20 07:54:33',1,'2024-10-20 22:37:10'),(11,'2023-01-08 02:11:28',2,'2024-09-09 15:19:08'),(12,'2022-10-02 21:45:58',3,'2026-03-10 16:11:21'),(12,'2023-01-25 11:49:44',2,'2025-09-15 13:10:06'),(14,'2021-09-07 13:23:52',4,'2025-05-12 19:48:21'),(14,'2021-11-03 18:02:46',2,'2024-12-17 20:30:53'),(14,'2021-12-28 13:51:03',3,'2026-03-05 03:36:19'),(14,'2022-07-28 10:01:31',3,'2025-04-04 19:55:10'),(14,'2022-08-29 00:17:21',3,'2024-08-21 01:21:40'),(14,'2022-10-18 03:25:10',3,'2025-07-12 23:18:49'),(15,'2022-09-18 14:40:27',3,'2026-03-20 18:50:37');
INSERT INTO `responsable` VALUES ('admin','‹°Ïn¹±}}\"´Vñ!%}Á%NfSpGcƒêwmô');

