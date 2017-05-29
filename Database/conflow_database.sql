-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               10.2.6-MariaDB - mariadb.org binary distribution
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

-- Dumping structure for table conflow.apartamento
CREATE TABLE IF NOT EXISTS `apartamento` (
  `COD_APARTAMENTO` int(11) NOT NULL AUTO_INCREMENT,
  `VAL_FRACAOIDEAL_APARTAMENTO` float DEFAULT 0,
  `COD_DONO_APARTAMENTO` int(11) DEFAULT NULL,
  `COD_PREDIO` int(11) NOT NULL,
  PRIMARY KEY (`COD_APARTAMENTO`),
  KEY `COD_DONO_APARTAMENTO` (`COD_DONO_APARTAMENTO`),
  KEY `COD_PREDIO` (`COD_PREDIO`),
  CONSTRAINT `apartamento_ibfk_1` FOREIGN KEY (`COD_DONO_APARTAMENTO`) REFERENCES `morador` (`COD_MORADOR`),
  CONSTRAINT `apartamento_ibfk_2` FOREIGN KEY (`COD_PREDIO`) REFERENCES `predio` (`COD_PREDIO`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=latin1;

-- Data exporting was unselected.
-- Dumping structure for table conflow.bloco
CREATE TABLE IF NOT EXISTS `bloco` (
  `COD_BLOCO` int(11) NOT NULL AUTO_INCREMENT,
  `ID_BLOCO` varchar(80) DEFAULT NULL,
  `COD_CONDOMINIO` int(11) NOT NULL,
  PRIMARY KEY (`COD_BLOCO`),
  KEY `COD_CONDOMINIO` (`COD_CONDOMINIO`),
  CONSTRAINT `blocos_ibfk_1` FOREIGN KEY (`COD_CONDOMINIO`) REFERENCES `condominio` (`COD_CONDOMINIO`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;

-- Data exporting was unselected.
-- Dumping structure for table conflow.boleto
CREATE TABLE IF NOT EXISTS `boleto` (
  `COD_BOLETO` int(11) NOT NULL AUTO_INCREMENT,
  `VAL_BOLETO` float NOT NULL,
  `DAT_EXPEDICAO_BOLETO` date NOT NULL,
  `DAT_VENCIMENTO_BOLETO` date NOT NULL,
  `COD_MORADOR` int(11) NOT NULL,
  PRIMARY KEY (`COD_BOLETO`),
  KEY `COD_MORADOR` (`COD_MORADOR`),
  CONSTRAINT `boletos_ibfk_1` FOREIGN KEY (`COD_MORADOR`) REFERENCES `morador` (`COD_MORADOR`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Data exporting was unselected.
-- Dumping structure for table conflow.condominio
CREATE TABLE IF NOT EXISTS `condominio` (
  `COD_CONDOMINIO` int(11) NOT NULL AUTO_INCREMENT,
  `ID_CONDOMINIO` varchar(80) DEFAULT NULL,
  `TEL_CONTATO_CONDOMINIO` varchar(10) DEFAULT '',
  `DESPESA_MENSAL_CONDOMINIO` float DEFAULT NULL,
  `VAL_QUOTACONDOMINIAL_CONDOMINIO` float DEFAULT 0,
  `END_UF_CONDOMINIO` varchar(2) DEFAULT NULL,
  `END_BAIRRO_CONDOMINIO` varchar(80) DEFAULT NULL,
  `END_RUA_CONDOMINIO` varchar(80) DEFAULT NULL,
  `END_NUMERO_CONDOMINIO` int(11) DEFAULT NULL,
  `IDF_ATIVO` varchar(1) DEFAULT 'S',
  PRIMARY KEY (`COD_CONDOMINIO`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=latin1;

-- Data exporting was unselected.
-- Dumping structure for table conflow.estacionamento
CREATE TABLE IF NOT EXISTS `estacionamento` (
  `COD_ESTACIONAMENTO` int(11) NOT NULL AUTO_INCREMENT,
  `ID_ESTACIONAMENTO` int(11) NOT NULL,
  `COD_DONO` int(11) NOT NULL,
  PRIMARY KEY (`COD_ESTACIONAMENTO`),
  KEY `COD_DONO` (`COD_DONO`),
  CONSTRAINT `estacionamento_ibfk_1` FOREIGN KEY (`COD_DONO`) REFERENCES `morador` (`COD_MORADOR`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Data exporting was unselected.
-- Dumping structure for table conflow.morador
CREATE TABLE IF NOT EXISTS `morador` (
  `COD_MORADOR` int(11) NOT NULL AUTO_INCREMENT,
  `NOME_MORADOR` varchar(80) NOT NULL,
  `RG_MORADOR` varchar(10) DEFAULT NULL,
  `DAT_NASCIMENTO_MORADOR` date DEFAULT NULL,
  `IDF_ATIVO` varchar(1) DEFAULT 'S',
  `ULTIMA_MODIFICACAO` datetime DEFAULT NULL,
  PRIMARY KEY (`COD_MORADOR`)
) ENGINE=InnoDB AUTO_INCREMENT=36 DEFAULT CHARSET=latin1;

-- Data exporting was unselected.
-- Dumping structure for table conflow.morador_cnpj
CREATE TABLE IF NOT EXISTS `morador_cnpj` (
  `COD_MORADOR` int(11) NOT NULL,
  `CNPJ_MORADOR` varchar(14) DEFAULT NULL,
  PRIMARY KEY (`COD_MORADOR`),
  CONSTRAINT `morador_cnpj_ibfk_1` FOREIGN KEY (`COD_MORADOR`) REFERENCES `morador` (`COD_MORADOR`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Data exporting was unselected.
-- Dumping structure for table conflow.morador_contato
CREATE TABLE IF NOT EXISTS `morador_contato` (
  `COD_MORADOR` int(11) NOT NULL,
  `VAL_CONTATO` varchar(80) NOT NULL,
  PRIMARY KEY (`COD_MORADOR`),
  CONSTRAINT `morador_contato_ibfk_1` FOREIGN KEY (`COD_MORADOR`) REFERENCES `morador` (`COD_MORADOR`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Data exporting was unselected.
-- Dumping structure for table conflow.morador_cpf
CREATE TABLE IF NOT EXISTS `morador_cpf` (
  `COD_MORADOR` int(11) NOT NULL,
  `CPF_MORADOR` varchar(11) DEFAULT NULL,
  PRIMARY KEY (`COD_MORADOR`),
  CONSTRAINT `morador_cpf_ibfk_1` FOREIGN KEY (`COD_MORADOR`) REFERENCES `morador` (`COD_MORADOR`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Data exporting was unselected.
-- Dumping structure for table conflow.predio
CREATE TABLE IF NOT EXISTS `predio` (
  `COD_PREDIO` int(11) NOT NULL AUTO_INCREMENT,
  `ID_PREDIO` varchar(80) DEFAULT NULL,
  `VAL_MENSALIDADES_PREDIO` float NOT NULL,
  `COD_BLOCO` int(11) NOT NULL,
  `ULTIMA_MODIFICACAO` datetime NOT NULL,
  PRIMARY KEY (`COD_PREDIO`),
  KEY `COD_BLOCO` (`COD_BLOCO`),
  CONSTRAINT `predios_ibfk_1` FOREIGN KEY (`COD_BLOCO`) REFERENCES `bloco` (`COD_BLOCO`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;

-- Data exporting was unselected.
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
