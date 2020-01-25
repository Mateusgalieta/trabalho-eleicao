CREATE DATABASE  IF NOT EXISTS `trabalho_mailson` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `trabalho_mailson`;
-- MySQL dump 10.13  Distrib 8.0.17, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: trabalho_mailson
-- ------------------------------------------------------
-- Server version	5.6.45-log

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
-- Table structure for table `eleicoes`
--

DROP TABLE IF EXISTS `eleicoes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `eleicoes` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `codigo` varchar(45) NOT NULL,
  `titulo` varchar(45) NOT NULL,
  `data_cadastro` date NOT NULL,
  `data_eleicao` date NOT NULL,
  `pais` int(11) NOT NULL,
  `situacao` int(11) NOT NULL DEFAULT '1',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `eleicoes`
--

LOCK TABLES `eleicoes` WRITE;
/*!40000 ALTER TABLE `eleicoes` DISABLE KEYS */;
/*!40000 ALTER TABLE `eleicoes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pessoas`
--

DROP TABLE IF EXISTS `pessoas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pessoas` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nome_completo` varchar(45) NOT NULL,
  `nome_abreviado` varchar(45) DEFAULT NULL,
  `data_nascimento` date NOT NULL,
   `numero_partido` varchar(45) NOT NULL,
  `nome_partido` varchar(45) NOT NULL,
  `foto` longblob,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pessoas`
--

LOCK TABLES `pessoas` WRITE;
/*!40000 ALTER TABLE `pessoas` DISABLE KEYS */;
/*!40000 ALTER TABLE `pessoas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `candidaturas`
--

DROP TABLE IF EXISTS `candidaturas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `candidaturas` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `id_pessoa` int(11) DEFAULT NULL,
  `id_eleicao` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `eleicoes_idx` (`id_eleicao`),
  KEY `pessoas_idx` (`id_pessoa`),
  CONSTRAINT `eleicoes_c` FOREIGN KEY (`id_eleicao`) REFERENCES `eleicoes` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `pessoas_c` FOREIGN KEY (`id_pessoa`) REFERENCES `pessoas` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `candidaturas`
--
LOCK TABLES `candidaturas` WRITE;

UNLOCK TABLES;

--
-- Table structure for table `votos`
--

DROP TABLE IF EXISTS `votos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `votos` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `valor_digitado` varchar(45) DEFAULT NULL,
  `turno` int(11) NOT NULL DEFAULT '1',
  `id_pessoa` int(11) DEFAULT NULL,
  `id_eleicao` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `pessoas_idx` (`id_pessoa`),
  KEY `eleicoes_idx` (`id_eleicao`),
  CONSTRAINT `pessoas` FOREIGN KEY (`id_pessoa`) REFERENCES `pessoas` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `eleicao` FOREIGN KEY (`id_eleicao`) REFERENCES `eleicoes` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `votos`
--

LOCK TABLES `votos` WRITE;
/*!40000 ALTER TABLE `votos` DISABLE KEYS */;
/*!40000 ALTER TABLE `votos` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-11-08 16:12:14















