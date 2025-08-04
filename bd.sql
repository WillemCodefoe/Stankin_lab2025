-- MySQL dump 10.13  Distrib 8.0.38, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: dashboard
-- ------------------------------------------------------
-- Server version	8.0.39

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
-- Table structure for table `machine_spindel_warmup`
--

DROP TABLE IF EXISTS `machine_spindel_warmup`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `machine_spindel_warmup` (
  `id` int NOT NULL AUTO_INCREMENT,
  `rpm` int DEFAULT NULL,
  `temperature` double DEFAULT NULL,
  `warmtime` int DEFAULT NULL,
  `idmn` int DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=91 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `machine_spindel_warmup`
--

LOCK TABLES `machine_spindel_warmup` WRITE;
/*!40000 ALTER TABLE `machine_spindel_warmup` DISABLE KEYS */;
INSERT INTO `machine_spindel_warmup` VALUES (1,0,15,0,12),(2,2500,28,20,12),(3,2500,27,80,12),(4,2500,31,120,12),(5,5000,34,140,12),(6,5000,35,180,12),(7,5000,37,240,12),(8,7500,41,260,12),(9,7500,44,300,12),(10,7500,48,350,12),(11,7500,46,360,12),(12,0,44,380,12),(13,0,42,420,12),(14,0,40,480,12),(16,0,11,0,13),(17,2500,25,15,13),(18,5000,48,60,13),(19,5800,55,90,13),(20,5800,59,120,13),(21,5800,53,150,13),(22,5800,50,180,13),(23,4000,45,210,13),(24,3200,41,240,13),(25,3200,38,270,13),(26,3200,36,300,13),(27,2400,35,330,13),(28,0,34,360,13),(29,0,31,420,13),(30,0,30,480,13),(31,0,13,0,14),(32,1200,22,30,14),(33,2400,31,60,14),(34,2400,32,90,14),(35,2500,33,120,14),(36,2800,42,150,14),(37,3400,48,180,14),(38,4000,50,210,14),(39,4200,51,240,14),(40,4200,50,300,14),(41,4200,49,360,14),(42,3000,42,390,14),(43,0,39,420,14),(44,0,35,450,14),(45,0,33,480,14),(46,0,10,0,15),(47,1000,20,30,15),(48,2000,35,60,15),(49,3000,48,90,15),(50,4000,60,120,15),(51,5000,68,150,15),(52,6000,72,180,15),(53,6700,75,210,15),(54,7200,77,240,15),(55,7400,74,300,15),(56,7400,68,360,15),(57,0,52,420,15),(58,0,43,450,15),(59,0,38,480,15),(60,0,35,510,15),(61,0,11,0,16),(62,2500,21,30,16),(63,2500,25,60,16),(64,2500,27,90,16),(65,5000,33,120,16),(66,5000,40,150,16),(67,5000,44,180,16),(68,5000,50,210,16),(69,5000,53,240,16),(70,5000,52,300,16),(71,5000,47,360,16),(72,200,42,390,16),(73,0,40,420,16),(74,0,39,450,16),(75,0,38,480,16),(76,0,12,0,17),(77,2000,25,30,17),(78,3000,28,60,17),(79,3000,31,120,17),(80,4000,35,180,17),(81,5000,38,240,17),(82,5800,40,300,17),(83,6000,39,360,17),(84,100,37,390,17),(85,0,34,420,17),(86,0,32,450,17),(87,0,30,480,17),(88,0,29,510,17),(89,0,28,540,17),(90,0,27,570,17);
/*!40000 ALTER TABLE `machine_spindel_warmup` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `machine_tool_load`
--

DROP TABLE IF EXISTS `machine_tool_load`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `machine_tool_load` (
  `id_mtl` int NOT NULL AUTO_INCREMENT,
  `status` varchar(45) DEFAULT NULL,
  `time_mtl` varchar(45) DEFAULT NULL,
  `id_mtn` int DEFAULT NULL,
  PRIMARY KEY (`id_mtl`),
  KEY `id_mtn_load_idx` (`id_mtn`),
  CONSTRAINT `id_mtn_load` FOREIGN KEY (`id_mtn`) REFERENCES `machine_tool_name` (`id_mtn`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=223 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `machine_tool_load`
--

LOCK TABLES `machine_tool_load` WRITE;
/*!40000 ALTER TABLE `machine_tool_load` DISABLE KEYS */;
INSERT INTO `machine_tool_load` VALUES (1,'off','15',1),(2,'off','15',1),(3,'off','60',1),(4,'off','60',1),(5,'off','60',1),(6,'off','60',1),(7,'off','180',1),(8,'on','15',1),(9,'on','15',1),(10,'load','30',1),(11,'load','15',1),(12,'load','20',1),(13,'load','15',1),(14,'load','30',1),(15,'load','15',1),(16,'on','30',1),(17,'on','30',1),(18,'on','5',1),(19,'load','30',1),(20,'load','30',1),(21,'load','60',1),(22,'load','15',1),(23,'load','15',1),(24,'load','15',1),(25,'load','20',1),(26,'load','20',1),(27,'load','15',1),(28,'load','30',1),(29,'load','15',1),(30,'load','30',1),(31,'on','20',1),(32,'on','10',1),(33,'on','5',1),(34,'on','2',1),(35,'on','2',1),(36,'on','2',1),(37,'load','15',1),(38,'load','10',1),(39,'on','2',1),(40,'on','2',1),(41,'load','12',1),(42,'on','5',1),(43,'load','15',1),(44,'on','2',1),(45,'on','10',1),(46,'off','30',1),(47,'off','30',1),(48,'off','30',1),(49,'off','30',1),(50,'on','20',1),(51,'on','30',1),(52,'on','30',1),(53,'on','15',1),(54,'on','20',1),(55,'load','30',1),(56,'load','15',1),(57,'on','20',1),(58,'on','15',1),(59,'on','21',1),(60,'off','15',1),(61,'load','5',1),(62,'off','5',1),(63,'off','15',2),(64,'off','15',2),(65,'off','60',2),(66,'off','60',2),(67,'off','60',2),(68,'off','60',2),(69,'off','180',2),(70,'on','15',2),(71,'on','15',2),(72,'load','30',2),(73,'load','15',2),(74,'load','20',2),(75,'load','15',2),(76,'load','30',2),(77,'load','15',2),(78,'on','30',2),(79,'on','30',2),(80,'on','5',2),(81,'load','30',2),(82,'load','30',2),(83,'load','60',2),(84,'load','15',2),(85,'load','15',2),(86,'load','15',2),(87,'load','20',2),(88,'load','20',2),(89,'load','15',2),(90,'load','30',2),(91,'load','15',2),(92,'load','30',2),(93,'on','12',2),(94,'on','10',2),(95,'on','15',2),(96,'on','2',2),(97,'on','2',2),(98,'on','2',2),(99,'load','15',2),(100,'load','10',2),(101,'on','2',2),(102,'on','2',2),(103,'load','30',2),(104,'on','5',2),(105,'load','15',2),(106,'on','2',2),(107,'on','10',2),(108,'off','30',2),(109,'off','15',2),(110,'off','30',2),(111,'off','30',2),(112,'on','20',2),(113,'on','30',2),(114,'on','30',2),(115,'on','30',2),(116,'on','20',2),(117,'load','30',2),(118,'load','15',2),(119,'on','10',2),(120,'on','15',2),(121,'on','21',2),(122,'off','25',2),(123,'load','5',2),(124,'off','5',2),(125,'off','15',3),(126,'off','15',3),(127,'off','60',3),(128,'off','60',3),(129,'off','60',3),(130,'off','60',3),(131,'off','180',3),(132,'on','15',3),(133,'on','15',3),(134,'load','30',3),(135,'load','15',3),(136,'load','20',3),(137,'load','15',3),(138,'load','30',3),(139,'load','15',3),(140,'on','30',3),(141,'on','30',3),(142,'on','5',3),(143,'load','30',3),(144,'load','30',3),(145,'load','60',3),(146,'load','15',3),(147,'load','15',3),(148,'load','15',3),(149,'load','20',3),(150,'load','20',3),(151,'load','15',3),(152,'load','30',3),(153,'load','15',3),(154,'load','30',3),(155,'on','12',3),(156,'on','10',3),(157,'on','15',3),(158,'on','2',3),(159,'on','2',3),(160,'on','2',3),(161,'load','15',3),(162,'load','10',3),(163,'on','2',3),(164,'on','2',3),(165,'load','30',3),(166,'on','5',3),(167,'load','15',3),(168,'on','2',3),(169,'on','10',3),(170,'off','30',3),(171,'off','15',3),(172,'off','30',3),(173,'off','30',3),(174,'on','20',3),(175,'on','30',3),(176,'on','30',3),(177,'on','30',3),(178,'on','20',3),(179,'load','10',3),(180,'load','15',3),(181,'on','30',3),(182,'on','15',3),(183,'on','21',3),(184,'off','35',3),(185,'load','15',3),(186,'off','5',3),(187,'on','5',12),(188,'load','5',12),(189,'on','5',12),(190,'on','5',12),(191,'on','5',12),(192,'on','5',12),(193,'on','5',13),(194,'load','5',13),(195,'off','5',13),(196,'off','5',13),(197,'on','5',13),(198,'on','5',13),(199,'on','5',14),(200,'load','5',14),(201,'off','5',14),(202,'off','5',14),(203,'off','5',14),(204,'load','5',14),(205,'on','5',15),(206,'on','5',15),(207,'on','5',15),(208,'on','5',15),(209,'on','5',15),(210,'on','5',15),(211,'on','5',16),(212,'load','5',16),(213,'load','5',16),(214,'load','5',16),(215,'load','5',16),(216,'off','5',16),(217,'off','5',17),(218,'load','5',17),(219,'load','5',17),(220,'on','5',17),(221,'on','5',17),(222,'off','5',17);
/*!40000 ALTER TABLE `machine_tool_load` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `machine_tool_name`
--

DROP TABLE IF EXISTS `machine_tool_name`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `machine_tool_name` (
  `id_mtn` int NOT NULL,
  `machine_tool_name` tinytext,
  `id_mt` int DEFAULT NULL,
  PRIMARY KEY (`id_mtn`),
  KEY `id_mt_idx` (`id_mt`),
  CONSTRAINT `id_mt` FOREIGN KEY (`id_mt`) REFERENCES `machine_tool_type` (`id_mt`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `machine_tool_name`
--

LOCK TABLES `machine_tool_name` WRITE;
/*!40000 ALTER TABLE `machine_tool_name` DISABLE KEYS */;
INSERT INTO `machine_tool_name` VALUES (1,'KSU1538',1),(2,'SVG124F',2),(3,'FLK1547JK7',1),(4,'DCG14HG7',2),(5,'DCH1458',3),(6,'RTCG1547',4),(7,'LOKD458',1),(8,'SKN457',1),(9,'ASD125',1),(10,'QWSC895',2),(11,'TRE1547G',3),(12,'IMU-5XP 2518',9),(13,'Haas UMC-750',9),(14,'IRONMAC IT-560',10),(15,'SPECTR TH-2500',10),(16,'Haas ST-10',11),(17,'DMG MORI CL2000',11);
/*!40000 ALTER TABLE `machine_tool_name` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `machine_tool_position`
--

DROP TABLE IF EXISTS `machine_tool_position`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `machine_tool_position` (
  `id` int NOT NULL AUTO_INCREMENT,
  `Axe` char(20) DEFAULT NULL,
  `position` double DEFAULT NULL,
  `id_mtn` int DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=37 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `machine_tool_position`
--

LOCK TABLES `machine_tool_position` WRITE;
/*!40000 ALTER TABLE `machine_tool_position` DISABLE KEYS */;
INSERT INTO `machine_tool_position` VALUES (1,'X',100,12),(2,'Y',50,12),(3,'Z',-10,12),(4,'A',45,12),(5,'B',30,12),(6,'C',15,12),(7,'X',90,13),(8,'Y',-70,13),(9,'Z',-55,13),(10,'A',20,13),(11,'B',30,13),(12,'C',24,13),(13,'X',10,14),(14,'Y',-90,14),(15,'Z',-55,14),(16,'A',-20,14),(17,'B',68,14),(18,'C',50,14),(19,'X',-21.22,15),(20,'Y',-12,15),(21,'Z',-30,15),(22,'A',-45,15),(23,'B',50.41,15),(24,'C',32,15),(25,'X',0,16),(26,'Y',0,16),(27,'Z',0,16),(28,'A',100,16),(29,'B',100,16),(30,'C',100,16),(31,'X',27.43,17),(32,'Y',44.22,17),(33,'Z',76.38,17),(34,'A',-45,17),(35,'B',-50,17),(36,'C',-2.19,17);
/*!40000 ALTER TABLE `machine_tool_position` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `machine_tool_state`
--

DROP TABLE IF EXISTS `machine_tool_state`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `machine_tool_state` (
  `id` int NOT NULL,
  `name` tinytext,
  `status` tinytext,
  `value` tinytext,
  `description` longtext,
  `id_mtn` int DEFAULT NULL,
  `worktime` time DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `id_mtn_idx` (`id_mtn`),
  CONSTRAINT `id_mtn` FOREIGN KEY (`id_mtn`) REFERENCES `machine_tool_name` (`id_mtn`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `machine_tool_state`
--

LOCK TABLES `machine_tool_state` WRITE;
/*!40000 ALTER TABLE `machine_tool_state` DISABLE KEYS */;
INSERT INTO `machine_tool_state` VALUES (1,'Аварийный останов','high','2000','Останов приводов',1,NULL),(2,'Ошибка интерполятора','high','2001','Строка G02 X12 Y15 R20 - траектория не может быть построена',2,NULL),(3,'Актуальный режим работы JOG','common','1004','Переключение режима работы',1,NULL),(4,'Ошибка ПЛК','high','3001','Сконфигурировать входы/выходы ПЛК',2,NULL),(5,'Ошибка интерполятора','high','2001','Строка G02 X12 Y15 R20 - траектория не может быть построена',1,NULL),(6,'Актуальный режим работы MDI','common','1003','Переключение режима работы',1,NULL),(7,'Ошибка интерпретатора','high','2003','команда G01 x10 Y10 R15 не может иметь такие параметры. Сконфигурирровать команду',1,NULL),(8,'Актуальный режим работы Auto','common','1001','Переключение режима работы',2,NULL),(9,'Ошибка приводов','high','2005','Сконфигурировать приводы',1,NULL),(10,'Нет связи с приводами','high','2006','Приводы не подключены. проверить подключение, сконфигурировать приводы',3,NULL),(11,'Готовность к работе','common','0000','Приводы готовы к работе',3,NULL),(12,'Аварийный останов','high','2000','Останов приводов',12,'12:30:00'),(13,'Актуальный режим работы JOG','common','1004','Переключение режима работы',12,'12:55:36'),(14,'Ошибка интерполятора','high','2001','Строка G02 X12 Y15 R20 - траектория не может быть построена',12,'13:20:48'),(15,'Актуальный режим работы MDI','common','1003','Переключение режима работы',12,'14:00:20'),(16,'Ошибка интерпретатора','high','2003','команда G01 x10 Y10 R15 не может иметь такие параметры. Сконфигурирровать команду',12,'14:07:41'),(17,'Ошибка приводов','high','2005','Сконфигурировать приводы',12,'22:11:36'),(18,'Ошибка интерполятора','high','2001','Строка G02 X12 Y15 R20 - траектория не может быть построена',13,'06:14:22'),(19,'Актуальный режим работы Auto','common','1001','Переключение режима работы',13,'08:30:21'),(20,'Ошибка ПЛК','high','3001','Сконфигурировать входы/выходы ПЛК',13,'08:57:02'),(21,'Нет связи с приводами','high','2006','Приводы не подключены. проверить подключение, сконфигурировать приводы',14,'08:30:23'),(22,'Готовность к работе','common','0','Приводы готовы к работе',14,'08:33:00'),(23,'2094 ЛИШНИЙ ПАРАМЕТР В ФАЙЛЕ XML','high','2094','Число параметров в загруженном файле\nконфигурации данных XML превышает\nколичество, поддерживаемое управляющим\nпрограммным обеспечением.',15,'07:22:31'),(24,'2094 ЛИШНИЙ ПАРАМЕТР В ФАЙЛЕ XML','high','2094','Число параметров в загруженном файле\nконфигурации данных XML превышает\nколичество, поддерживаемое управляющим\nпрограммным обеспечением.',15,'07:25:31'),(25,'ПЕРЕЗАГРУЗКА СТАНКА','high','2093','Перезагрузите станок. Нажмите кнопку\nВЫКЛЮЧИТЬ ПИТАНИЕ и затем\nВКЛЮЧИТЬ ПИТАНИЕ..',15,'07:30:54'),(26,'Актуальный режим работы JOG','common','\n1004','Переключение режима работы',15,'08:22:41'),(27,'Актуальный режим работы Auto','common','1001','Переключение режима работы',15,'09:30:30'),(28,'ОШИБКА ОТКРЫТИЯ ДВЕРЦЫ\nУСИ',' high','\n1004','ДВЕРЦА УСИ ЗАКРЫТА',16,'08:02:34'),(29,'ДВЕРЦА УСИ ЗАКРЫТА','high','1001','Дверца УСИ не открылась в результате\nнизкого давления воздуха. Проверьте\nдавление поступающего воздуха. ',16,'08:04:34'),(31,'Готовность к работе','common','0','Приводы готовы к работе',16,'08:25:13'),(32,'ПРЕВЫШЕНИЕ ПОГРЕШНОСТИ','medium','995','Превышение погрешности усилителя.\nСлишком большая разница между\nфактическим током и током по команде в\nусилителе. Убедитесь, что\nконтроллер двигателя работает.',16,'12:47:11'),(33,'Готовность к работе','common','0','Приводы готовы к работе',17,'06:45:23'),(34,'Актуальный режим работы Auto','common','1001','Переключение режима работы',17,'06:50:58'),(35,'Низкий ур. смазки шпинделя.','medium','805','Низкий уровень масла в масляном\nрезервуаре смазки шпинделя. Техническое\nобслуживание резервуара смазки шпинделя\nсостоит в доливке масла. Если уровень масла\nв резервуаре находится в норме, убедитесь в\nнормальной работе или отсутствии\nповреждений датчика уровня резервуара.\nПроверьте провода выключателя и\nубедитесь, что они не повреждены или\nотключены.',17,'14:10:18'),(36,'Конфликт конфигурации','medium','9845','Настройка перемычки не соответствует таблице конфигурации.',17,'18:45:52');
/*!40000 ALTER TABLE `machine_tool_state` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `machine_tool_type`
--

DROP TABLE IF EXISTS `machine_tool_type`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `machine_tool_type` (
  `id_mt` int NOT NULL,
  `type` tinytext,
  PRIMARY KEY (`id_mt`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `machine_tool_type`
--

LOCK TABLES `machine_tool_type` WRITE;
/*!40000 ALTER TABLE `machine_tool_type` DISABLE KEYS */;
INSERT INTO `machine_tool_type` VALUES (1,'3-координатный вертикально-фрезерный'),(2,'токарный расточной'),(3,'токарный с фрезерной головкой'),(4,'вертикально-фрезерный с поворотным столом и поворотной головой'),(5,'токарный обрабатывающий центр'),(6,'токарный с противошпинделем'),(7,'токарный с противошпинделем и фрезерной головкой'),(8,'вертикально-фрезерный с поворотным столом'),(9,'5-координатный фрезерный с поворотным столом и поворотной головой'),(10,'токарно-револьверный'),(11,'Токарный');
/*!40000 ALTER TABLE `machine_tool_type` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-08-04 23:49:53
