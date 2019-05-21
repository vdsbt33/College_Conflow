-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: localhost    Database: conflow
-- ------------------------------------------------------
-- Server version	5.7.20-log

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
-- Table structure for table `apartamento`
--

DROP TABLE IF EXISTS `apartamento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `apartamento` (
  `COD_APARTAMENTO` int(11) NOT NULL AUTO_INCREMENT,
  `NUM_APARTAMENTO` varchar(4) DEFAULT NULL,
  `VAL_FRACAOIDEAL_APARTAMENTO` float DEFAULT '0',
  `COD_PREDIO` int(11) NOT NULL,
  PRIMARY KEY (`COD_APARTAMENTO`),
  UNIQUE KEY `COD_APARTAMENTO` (`COD_APARTAMENTO`),
  KEY `COD_PREDIO` (`COD_PREDIO`),
  CONSTRAINT `apartamento_ibfk_1` FOREIGN KEY (`COD_PREDIO`) REFERENCES `predio` (`COD_PREDIO`)
) ENGINE=InnoDB AUTO_INCREMENT=196 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `apartamento`
--

LOCK TABLES `apartamento` WRITE;
/*!40000 ALTER TABLE `apartamento` DISABLE KEYS */;
/*!40000 ALTER TABLE `apartamento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `bloco`
--

DROP TABLE IF EXISTS `bloco`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `bloco` (
  `COD_BLOCO` int(11) NOT NULL AUTO_INCREMENT,
  `ID_BLOCO` varchar(80) DEFAULT NULL,
  `COD_CONDOMINIO` int(11) NOT NULL,
  `IDF_ATIVO` varchar(1) DEFAULT 'S',
  PRIMARY KEY (`COD_BLOCO`),
  UNIQUE KEY `COD_BLOCO` (`COD_BLOCO`),
  KEY `COD_CONDOMINIO` (`COD_CONDOMINIO`),
  CONSTRAINT `bloco_ibfk_1` FOREIGN KEY (`COD_CONDOMINIO`) REFERENCES `condominio` (`COD_CONDOMINIO`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bloco`
--

LOCK TABLES `bloco` WRITE;
/*!40000 ALTER TABLE `bloco` DISABLE KEYS */;
/*!40000 ALTER TABLE `bloco` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `condominio`
--

DROP TABLE IF EXISTS `condominio`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `condominio` (
  `COD_CONDOMINIO` int(11) NOT NULL AUTO_INCREMENT,
  `ID_CONDOMINIO` varchar(80) DEFAULT NULL,
  `TEL_CONTATO_CONDOMINIO` varchar(10) DEFAULT NULL,
  `END_UF_CONDOMINIO` varchar(80) DEFAULT NULL,
  `END_CIDADE_CONDOMINIO` varchar(80) DEFAULT NULL,
  `END_BAIRRO_CONDOMINIO` varchar(80) DEFAULT NULL,
  `END_RUA_CONDOMINIO` varchar(80) DEFAULT NULL,
  `END_NUM_CONDOMINIO` int(11) DEFAULT NULL,
  `IDF_ATIVO` varchar(1) DEFAULT 'S',
  PRIMARY KEY (`COD_CONDOMINIO`),
  UNIQUE KEY `COD_CONDOMINIO` (`COD_CONDOMINIO`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `condominio`
--

LOCK TABLES `condominio` WRITE;
/*!40000 ALTER TABLE `condominio` DISABLE KEYS */;
/*!40000 ALTER TABLE `condominio` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `condominio_despesa`
--

DROP TABLE IF EXISTS `condominio_despesa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `condominio_despesa` (
  `COD_DESPESA` int(11) NOT NULL AUTO_INCREMENT,
  `DSC_DESPESA` varchar(255) DEFAULT '',
  `VAL_DESPESA` float DEFAULT '0',
  `DAT_PAGAMENTO` datetime DEFAULT NULL,
  `COD_CONDOMINIO` int(11) NOT NULL,
  PRIMARY KEY (`COD_DESPESA`),
  UNIQUE KEY `COD_DESPESA` (`COD_DESPESA`),
  KEY `COD_CONDOMINIO` (`COD_CONDOMINIO`),
  CONSTRAINT `condominio_despesa_ibfk_1` FOREIGN KEY (`COD_CONDOMINIO`) REFERENCES `condominio` (`COD_CONDOMINIO`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `condominio_despesa`
--

LOCK TABLES `condominio_despesa` WRITE;
/*!40000 ALTER TABLE `condominio_despesa` DISABLE KEYS */;
/*!40000 ALTER TABLE `condominio_despesa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `conta_sistema`
--

DROP TABLE IF EXISTS `conta_sistema`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `conta_sistema` (
  `COD_CONTA` int(11) NOT NULL AUTO_INCREMENT,
  `USERNAME_CONTA` varchar(80) NOT NULL,
  `PASSWORD_CONTA` varchar(80) NOT NULL,
  PRIMARY KEY (`COD_CONTA`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `conta_sistema`
--

LOCK TABLES `conta_sistema` WRITE;
/*!40000 ALTER TABLE `conta_sistema` DISABLE KEYS */;
/*!40000 ALTER TABLE `conta_sistema` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `estacionamento`
--

DROP TABLE IF EXISTS `estacionamento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `estacionamento` (
  `COD_ESTACIONAMENTO` int(11) NOT NULL AUTO_INCREMENT,
  `ID_ESTACIONAMENTO` varchar(8) DEFAULT NULL,
  `COD_PROPRIETARIO` int(11) DEFAULT NULL,
  PRIMARY KEY (`COD_ESTACIONAMENTO`),
  UNIQUE KEY `COD_ESTACIONAMENTO` (`COD_ESTACIONAMENTO`),
  KEY `COD_PROPRIETARIO` (`COD_PROPRIETARIO`),
  CONSTRAINT `estacionamento_ibfk_1` FOREIGN KEY (`COD_PROPRIETARIO`) REFERENCES `proprietario` (`COD_PROPRIETARIO`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `estacionamento`
--

LOCK TABLES `estacionamento` WRITE;
/*!40000 ALTER TABLE `estacionamento` DISABLE KEYS */;
/*!40000 ALTER TABLE `estacionamento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `morador`
--

DROP TABLE IF EXISTS `morador`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `morador` (
  `COD_MORADOR` int(11) NOT NULL AUTO_INCREMENT,
  `NOME_MORADOR` varchar(80) DEFAULT NULL,
  `DAT_NASCIMENTO_MORADOR` date DEFAULT NULL,
  `SEXO_MORADOR` varchar(1) DEFAULT NULL,
  `COD_APARTAMENTO_MORADOR` int(11) DEFAULT NULL,
  `ULTIMA_MODIFICACAO` datetime DEFAULT NULL,
  `IDF_ATIVO` varchar(1) DEFAULT 'S',
  PRIMARY KEY (`COD_MORADOR`),
  UNIQUE KEY `COD_MORADOR` (`COD_MORADOR`),
  KEY `COD_APARTAMENTO_MORADOR` (`COD_APARTAMENTO_MORADOR`),
  CONSTRAINT `morador_ibfk_1` FOREIGN KEY (`COD_APARTAMENTO_MORADOR`) REFERENCES `apartamento` (`COD_APARTAMENTO`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `morador`
--

LOCK TABLES `morador` WRITE;
/*!40000 ALTER TABLE `morador` DISABLE KEYS */;
/*!40000 ALTER TABLE `morador` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `predio`
--

DROP TABLE IF EXISTS `predio`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `predio` (
  `COD_PREDIO` int(11) NOT NULL AUTO_INCREMENT,
  `ID_PREDIO` varchar(80) DEFAULT NULL,
  `COD_BLOCO` int(11) NOT NULL,
  `ULTIMA_MODIFICACAO` datetime DEFAULT NULL,
  `IDF_ATIVO` varchar(1) DEFAULT 'S',
  PRIMARY KEY (`COD_PREDIO`),
  UNIQUE KEY `COD_PREDIO` (`COD_PREDIO`),
  KEY `COD_BLOCO` (`COD_BLOCO`),
  CONSTRAINT `predio_ibfk_1` FOREIGN KEY (`COD_BLOCO`) REFERENCES `bloco` (`COD_BLOCO`)
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `predio`
--

LOCK TABLES `predio` WRITE;
/*!40000 ALTER TABLE `predio` DISABLE KEYS */;
/*!40000 ALTER TABLE `predio` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `proprietario`
--

DROP TABLE IF EXISTS `proprietario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `proprietario` (
  `COD_PROPRIETARIO` int(11) NOT NULL AUTO_INCREMENT,
  `NOME_PROPRIETARIO` varchar(80) NOT NULL,
  `RG_PROPRIETARIO` varchar(10) DEFAULT NULL,
  `SEXO_PROPRIETARIO` varchar(1) DEFAULT NULL,
  `DAT_NASCIMENTO_PROPRIETARIO` date DEFAULT NULL,
  `END_UF_PROPRIETARIO` varchar(2) DEFAULT NULL,
  `END_CIDADE_PROPRIETARIO` varchar(80) DEFAULT NULL,
  `END_BAIRRO_PROPRIETARIO` varchar(80) DEFAULT NULL,
  `END_RUA_PROPRIETARIO` varchar(80) DEFAULT NULL,
  `END_NUM_PROPRIETARIO` int(11) DEFAULT NULL,
  `COD_APARTAMENTO_PROPRIETARIO` int(11) DEFAULT NULL,
  `ULTIMA_MODIFICACAO` datetime DEFAULT NULL,
  `IDF_ATIVO` varchar(1) DEFAULT 'S',
  PRIMARY KEY (`COD_PROPRIETARIO`),
  UNIQUE KEY `COD_PROPRIETARIO` (`COD_PROPRIETARIO`),
  KEY `COD_APARTAMENTO_PROPRIETARIO` (`COD_APARTAMENTO_PROPRIETARIO`),
  CONSTRAINT `proprietario_ibfk_1` FOREIGN KEY (`COD_APARTAMENTO_PROPRIETARIO`) REFERENCES `apartamento` (`COD_APARTAMENTO`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `proprietario`
--

LOCK TABLES `proprietario` WRITE;
/*!40000 ALTER TABLE `proprietario` DISABLE KEYS */;
/*!40000 ALTER TABLE `proprietario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `proprietario_boleto`
--

DROP TABLE IF EXISTS `proprietario_boleto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `proprietario_boleto` (
  `COD_BOLETO` int(11) NOT NULL,
  `VAL_BOLETO` float DEFAULT '0',
  `COD_PROPRIETARIO` int(11) NOT NULL,
  PRIMARY KEY (`COD_BOLETO`),
  KEY `COD_PROPRIETARIO` (`COD_PROPRIETARIO`),
  CONSTRAINT `proprietario_boleto_ibfk_1` FOREIGN KEY (`COD_PROPRIETARIO`) REFERENCES `proprietario` (`COD_PROPRIETARIO`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `proprietario_boleto`
--

LOCK TABLES `proprietario_boleto` WRITE;
/*!40000 ALTER TABLE `proprietario_boleto` DISABLE KEYS */;
/*!40000 ALTER TABLE `proprietario_boleto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `proprietario_cnpj`
--

DROP TABLE IF EXISTS `proprietario_cnpj`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `proprietario_cnpj` (
  `COD_PROPRIETARIO` int(11) NOT NULL,
  `CNPJ_PROPRIETARIO` varchar(14) DEFAULT NULL,
  KEY `COD_PROPRIETARIO` (`COD_PROPRIETARIO`),
  CONSTRAINT `proprietario_cnpj_ibfk_1` FOREIGN KEY (`COD_PROPRIETARIO`) REFERENCES `proprietario` (`COD_PROPRIETARIO`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `proprietario_cnpj`
--

LOCK TABLES `proprietario_cnpj` WRITE;
/*!40000 ALTER TABLE `proprietario_cnpj` DISABLE KEYS */;
/*!40000 ALTER TABLE `proprietario_cnpj` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `proprietario_contato`
--

DROP TABLE IF EXISTS `proprietario_contato`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `proprietario_contato` (
  `COD_PROPRIETARIO` int(11) NOT NULL,
  `DSC_CONTATO` varchar(100) NOT NULL,
  KEY `COD_PROPRIETARIO` (`COD_PROPRIETARIO`),
  CONSTRAINT `proprietario_contato_ibfk_1` FOREIGN KEY (`COD_PROPRIETARIO`) REFERENCES `proprietario` (`COD_PROPRIETARIO`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `proprietario_contato`
--

LOCK TABLES `proprietario_contato` WRITE;
/*!40000 ALTER TABLE `proprietario_contato` DISABLE KEYS */;
/*!40000 ALTER TABLE `proprietario_contato` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `proprietario_cpf`
--

DROP TABLE IF EXISTS `proprietario_cpf`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `proprietario_cpf` (
  `COD_PROPRIETARIO` int(11) NOT NULL,
  `CPF_PROPRIETARIO` varchar(11) DEFAULT NULL,
  KEY `COD_PROPRIETARIO` (`COD_PROPRIETARIO`),
  CONSTRAINT `proprietario_cpf_ibfk_1` FOREIGN KEY (`COD_PROPRIETARIO`) REFERENCES `proprietario` (`COD_PROPRIETARIO`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `proprietario_cpf`
--

LOCK TABLES `proprietario_cpf` WRITE;
/*!40000 ALTER TABLE `proprietario_cpf` DISABLE KEYS */;
/*!40000 ALTER TABLE `proprietario_cpf` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuario` (
  `COD_USUARIO` int(11) NOT NULL AUTO_INCREMENT,
  `NOME_USUARIO` varchar(60) NOT NULL,
  `SENHA_USUARIO` varchar(60) NOT NULL,
  `NIVEL_USUARIO` int(11) DEFAULT '0',
  PRIMARY KEY (`COD_USUARIO`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES (1,'root','admin',2);
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-11-27 12:40:48
