-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               10.1.23-MariaDB - mariadb.org binary distribution
-- Server OS:                    Win64
-- HeidiSQL Version:             9.4.0.5125
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Dumping database structure for conflow
CREATE DATABASE IF NOT EXISTS `conflow` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `conflow`;

-- Dumping structure for table conflow.apartamentos
CREATE TABLE IF NOT EXISTS `apartamentos` (
  `COD_APARTAMENTO` int(11) NOT NULL AUTO_INCREMENT,
  `DON_APARTAMENTO` int(11) DEFAULT NULL,
  PRIMARY KEY (`COD_APARTAMENTO`),
  KEY `DON_APARTAMENTO` (`DON_APARTAMENTO`),
  CONSTRAINT `apartamentos_ibfk_1` FOREIGN KEY (`DON_APARTAMENTO`) REFERENCES `moradores` (`COD_MORADOR`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Data exporting was unselected.
-- Dumping structure for table conflow.blocos
CREATE TABLE IF NOT EXISTS `blocos` (
  `COD_BLOCO` int(11) NOT NULL AUTO_INCREMENT,
  `ID_BLOCO` varchar(80) DEFAULT NULL,
  `QTD_PREDIOS_BLOCO` int(11) NOT NULL,
  `COD_CONDOMINIO` int(11) NOT NULL,
  PRIMARY KEY (`COD_BLOCO`),
  KEY `COD_CONDOMINIO` (`COD_CONDOMINIO`),
  CONSTRAINT `blocos_ibfk_1` FOREIGN KEY (`COD_CONDOMINIO`) REFERENCES `condominios` (`COD_CONDOMINIO`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

-- Data exporting was unselected.
-- Dumping structure for table conflow.boletos
CREATE TABLE IF NOT EXISTS `boletos` (
  `COD_BOLETO` int(11) NOT NULL AUTO_INCREMENT,
  `VAL_BOLETO` float NOT NULL,
  `VAL_MULTA_BOLETO` float DEFAULT '0',
  `DAT_EXPEDICAO_BOLETO` date NOT NULL,
  `DAT_VENCIMENTO_BOLETO` date NOT NULL,
  `COD_MORADOR` int(11) NOT NULL,
  PRIMARY KEY (`COD_BOLETO`),
  KEY `COD_MORADOR` (`COD_MORADOR`),
  CONSTRAINT `boletos_ibfk_1` FOREIGN KEY (`COD_MORADOR`) REFERENCES `moradores` (`COD_MORADOR`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Data exporting was unselected.
-- Dumping structure for table conflow.condominios
CREATE TABLE IF NOT EXISTS `condominios` (
  `COD_CONDOMINIO` int(11) NOT NULL AUTO_INCREMENT,
  `ID_CONDOMINIO` varchar(80) DEFAULT NULL,
  `QTD_BLOCOS_CONDOMINIO` int(11) NOT NULL DEFAULT '1',
  `VAL_TOTAL_MENSAL` float DEFAULT '0',
  `IDF_ATIVO` varchar(1) DEFAULT 'S',
  PRIMARY KEY (`COD_CONDOMINIO`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

-- Data exporting was unselected.
-- Dumping structure for table conflow.estacionamento
CREATE TABLE IF NOT EXISTS `estacionamento` (
  `COD_ESTACIONAMENTO` int(11) NOT NULL AUTO_INCREMENT,
  `ID_ESTACIONAMENTO` int(11) NOT NULL,
  `COD_DONO` int(11) NOT NULL,
  PRIMARY KEY (`COD_ESTACIONAMENTO`),
  KEY `COD_DONO` (`COD_DONO`),
  CONSTRAINT `estacionamento_ibfk_1` FOREIGN KEY (`COD_DONO`) REFERENCES `moradores` (`COD_MORADOR`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Data exporting was unselected.
-- Dumping structure for table conflow.moradores
CREATE TABLE IF NOT EXISTS `moradores` (
  `COD_MORADOR` int(11) NOT NULL AUTO_INCREMENT,
  `NOME_MORADOR` varchar(80) NOT NULL,
  `RG_MORADOR` varchar(10) DEFAULT NULL,
  `DAT_NASCIMENTO_MORADOR` date DEFAULT NULL,
  `IDF_ATIVO` varchar(1) DEFAULT 'S',
  PRIMARY KEY (`COD_MORADOR`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;

-- Data exporting was unselected.
-- Dumping structure for table conflow.morador_cnpj
CREATE TABLE IF NOT EXISTS `morador_cnpj` (
  `COD_MORADOR` int(11) NOT NULL,
  `CNPJ_MORADOR` varchar(14) DEFAULT NULL,
  PRIMARY KEY (`COD_MORADOR`),
  CONSTRAINT `morador_cnpj_ibfk_1` FOREIGN KEY (`COD_MORADOR`) REFERENCES `moradores` (`COD_MORADOR`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Data exporting was unselected.
-- Dumping structure for table conflow.morador_cpf
CREATE TABLE IF NOT EXISTS `morador_cpf` (
  `COD_MORADOR` int(11) NOT NULL,
  `CPF_MORADOR` varchar(11) DEFAULT NULL,
  PRIMARY KEY (`COD_MORADOR`),
  CONSTRAINT `morador_cpf_ibfk_1` FOREIGN KEY (`COD_MORADOR`) REFERENCES `moradores` (`COD_MORADOR`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Data exporting was unselected.
-- Dumping structure for table conflow.predios
CREATE TABLE IF NOT EXISTS `predios` (
  `COD_PREDIO` int(11) NOT NULL AUTO_INCREMENT,
  `ID_PREDIO` varchar(80) DEFAULT NULL,
  `QTD_APARTAMENTOS_PREDIO` int(11) NOT NULL,
  `VAL_MENSALIDADES_PREDIO` float NOT NULL,
  `VAL_FRACAO_IDEAL_PREDIO` float DEFAULT NULL,
  `COD_BLOCO` int(11) NOT NULL,
  PRIMARY KEY (`COD_PREDIO`),
  KEY `COD_BLOCO` (`COD_BLOCO`),
  CONSTRAINT `predios_ibfk_1` FOREIGN KEY (`COD_BLOCO`) REFERENCES `blocos` (`COD_BLOCO`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

-- Data exporting was unselected.
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
