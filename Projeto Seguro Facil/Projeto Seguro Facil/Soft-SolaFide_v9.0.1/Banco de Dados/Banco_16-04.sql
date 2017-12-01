-- MySQL dump 10.13  Distrib 5.6.17, for Win32 (x86)
--
-- Host: localhost    Database: solafide_v6
-- ------------------------------------------------------
-- Server version	5.6.22-log

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
-- Table structure for table `tb_antifurto_alarme_rastreador`
--

DROP TABLE IF EXISTS `tb_antifurto_alarme_rastreador`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_antifurto_alarme_rastreador` (
  `id_antifurto_alarme_rastreador` int(11) NOT NULL AUTO_INCREMENT,
  `descricao` varchar(3) NOT NULL,
  `tb_Questionario_id_questionario` int(11) NOT NULL,
  PRIMARY KEY (`id_antifurto_alarme_rastreador`),
  KEY `fk_tb_Antifurto_Alarme_Rastreador_tb_Questionario1_idx` (`tb_Questionario_id_questionario`),
  CONSTRAINT `fk_tb_Antifurto_Alarme_Rastreador_tb_Questionario1` FOREIGN KEY (`tb_Questionario_id_questionario`) REFERENCES `tb_questionario` (`id_questionario`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 PACK_KEYS=0;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_antifurto_alarme_rastreador`
--

LOCK TABLES `tb_antifurto_alarme_rastreador` WRITE;
/*!40000 ALTER TABLE `tb_antifurto_alarme_rastreador` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_antifurto_alarme_rastreador` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_clausolas`
--

DROP TABLE IF EXISTS `tb_clausolas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_clausolas` (
  `id_Clausolas` int(11) NOT NULL AUTO_INCREMENT,
  `Ass_24_horas` tinyint(1) DEFAULT NULL,
  `Vidro` tinyint(1) DEFAULT NULL,
  `Carro_Reserva` tinyint(1) DEFAULT NULL,
  `tb_Orcamento_id_Orcamento` int(11) NOT NULL,
  PRIMARY KEY (`id_Clausolas`),
  KEY `fk_tb_Clausolas_tb_Orcamento1_idx` (`tb_Orcamento_id_Orcamento`),
  CONSTRAINT `fk_tb_Clausolas_tb_Orcamento1` FOREIGN KEY (`tb_Orcamento_id_Orcamento`) REFERENCES `tb_orcamento` (`id_Orcamento`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_clausolas`
--

LOCK TABLES `tb_clausolas` WRITE;
/*!40000 ALTER TABLE `tb_clausolas` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_clausolas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_cobertura`
--

DROP TABLE IF EXISTS `tb_cobertura`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_cobertura` (
  `id_cobertura` int(11) NOT NULL AUTO_INCREMENT,
  `dn_material` varchar(12) DEFAULT NULL,
  `dn_corporal` varchar(12) DEFAULT NULL,
  `dn_moral` varchar(10) DEFAULT NULL,
  `app_morte` varchar(10) DEFAULT NULL,
  `app_invalidez` varchar(10) DEFAULT NULL,
  `tb_Orcamento_id_Orcamento` int(11) NOT NULL,
  PRIMARY KEY (`id_cobertura`,`tb_Orcamento_id_Orcamento`),
  KEY `fk_tb_Cobertura_tb_Orcamento1_idx` (`tb_Orcamento_id_Orcamento`),
  CONSTRAINT `fk_tb_Cobertura_tb_Orcamento1` FOREIGN KEY (`tb_Orcamento_id_Orcamento`) REFERENCES `tb_orcamento` (`id_Orcamento`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 PACK_KEYS=0 COMMENT='APP: Acidentes Pessoais a Passageiros\nNesta tabela serão preenchidos valores em dinheiro seguindo as regras de negócio abaixo:\n\ndano material: Neste campo deve haver valores de 50.000,00 a 1.000.000,00 variando de 10.000,00 em 10.000,00 - ou seja: 50.000,00 / 60.000,00 / 70.000,00 / 80.000,00 / 90.000,00 até 1.000.000,00. Entendeu?\ndano corporal:  a mesma coisa do item danos materiais.\napp morte: valores de 10.000,00 até 100.000,00 - (de 10 em 10 mil)\napp invalidez: valores de 10.000,00 até 100.000,00 - (de 10 em 10 mil)\ndano moral: valores de 5.000,00 a 110.000,00 - (5.000,00 / 10.000,00 / 20.000,00 / .... / 110.000,00)';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_cobertura`
--

LOCK TABLES `tb_cobertura` WRITE;
/*!40000 ALTER TABLE `tb_cobertura` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_cobertura` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_cobertura_compreenssiva`
--

DROP TABLE IF EXISTS `tb_cobertura_compreenssiva`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_cobertura_compreenssiva` (
  `id_cobertura_compreenssiva` int(11) NOT NULL AUTO_INCREMENT,
  `descricao` varchar(15) DEFAULT NULL,
  `tb_Orcamento_id_Orcamento` int(11) NOT NULL,
  PRIMARY KEY (`id_cobertura_compreenssiva`),
  KEY `fk_tb_Cobertura_Compreenssiva_tb_Orcamento1_idx` (`tb_Orcamento_id_Orcamento`),
  CONSTRAINT `fk_tb_Cobertura_Compreenssiva_tb_Orcamento1` FOREIGN KEY (`tb_Orcamento_id_Orcamento`) REFERENCES `tb_orcamento` (`id_Orcamento`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 PACK_KEYS=0 COMMENT='Nesta tabela será possível escolher apenas uma opção marcando com um ''X''';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_cobertura_compreenssiva`
--

LOCK TABLES `tb_cobertura_compreenssiva` WRITE;
/*!40000 ALTER TABLE `tb_cobertura_compreenssiva` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_cobertura_compreenssiva` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_comissoes`
--

DROP TABLE IF EXISTS `tb_comissoes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_comissoes` (
  `id_Comissoes` int(11) NOT NULL AUTO_INCREMENT,
  `pago` varchar(2) NOT NULL,
  `apolice` varchar(7) NOT NULL,
  `parcela` varchar(5) NOT NULL,
  `premio_liquido` double NOT NULL,
  `perc_comissao` double NOT NULL,
  `comissao_bruta` double NOT NULL,
  `desc_30_porcento` double NOT NULL,
  `liquido` double NOT NULL,
  `a_pagar` double NOT NULL,
  `dt_pagto` varchar(14) NOT NULL,
  `valor_pago` double NOT NULL,
  `tb_Pessoa_Fisica_id_Pessoa_Fisica` int(11) DEFAULT NULL,
  `tb_Pessoa_Juridica_id_Pessoa_Juridica` int(11) DEFAULT NULL,
  `tb_Seguradora_id_seguradora` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_Comissoes`),
  KEY `fk_tb_Comissoes_tb_Pessoa_Fisica1_idx` (`tb_Pessoa_Fisica_id_Pessoa_Fisica`),
  KEY `fk_tb_Comissoes_tb_Pessoa_Juridica1_idx` (`tb_Pessoa_Juridica_id_Pessoa_Juridica`),
  KEY `fk_tb_Comissoes_tb_Seguradora1_idx` (`tb_Seguradora_id_seguradora`),
  CONSTRAINT `fk_tb_Comissoes_tb_Pessoa_Fisica1` FOREIGN KEY (`tb_Pessoa_Fisica_id_Pessoa_Fisica`) REFERENCES `tb_pessoa_fisica` (`id_Pessoa_Fisica`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_tb_Comissoes_tb_Pessoa_Juridica1` FOREIGN KEY (`tb_Pessoa_Juridica_id_Pessoa_Juridica`) REFERENCES `tb_pessoa_juridica` (`id_Pessoa_Juridica`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_tb_Comissoes_tb_Seguradora1` FOREIGN KEY (`tb_Seguradora_id_seguradora`) REFERENCES `tb_seguradora` (`id_seguradora`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_comissoes`
--

LOCK TABLES `tb_comissoes` WRITE;
/*!40000 ALTER TABLE `tb_comissoes` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_comissoes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_contas_usuario`
--

DROP TABLE IF EXISTS `tb_contas_usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_contas_usuario` (
  `id_contas_usuario` int(11) NOT NULL AUTO_INCREMENT,
  `usuario` varchar(20) NOT NULL,
  `senha` varchar(50) NOT NULL,
  `nome_cpmpleto` varchar(40) NOT NULL,
  `email` varchar(40) NOT NULL,
  `pergunta_seguranca` varchar(40) NOT NULL,
  `nome_completo` varchar(40) DEFAULT NULL,
  `tb_Contas_Usuariocol` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id_contas_usuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 PACK_KEYS=0;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_contas_usuario`
--

LOCK TABLES `tb_contas_usuario` WRITE;
/*!40000 ALTER TABLE `tb_contas_usuario` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_contas_usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_contato`
--

DROP TABLE IF EXISTS `tb_contato`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_contato` (
  `id_contato` int(11) NOT NULL AUTO_INCREMENT,
  `tel_residencial` varchar(16) DEFAULT NULL,
  `tel_comercial` varchar(16) DEFAULT NULL,
  `tel_recado` varchar(16) DEFAULT NULL,
  `cel_comercial` varchar(17) DEFAULT NULL,
  `cel_pessoal` varchar(17) DEFAULT NULL,
  `cel_recado` varchar(17) DEFAULT NULL,
  `nextel` varchar(13) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  `tb_Seguradora_id_seguradora` int(11) DEFAULT NULL,
  `tb_Pessoa_Fisica_id_Pessoa_Fisica` int(11) DEFAULT NULL,
  `tb_Pessoa_Juridica_id_Pessoa_Juridica` int(11) DEFAULT NULL,
  `tb_Seguradora_id_seguradora1` int(11) DEFAULT NULL,
  `tb_Preposto_id_preposto` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_contato`),
  KEY `fk_tb_Contato_tb_Seguradora1_idx` (`tb_Seguradora_id_seguradora`),
  KEY `fk_tb_Contato_tb_Pessoa_Fisica1_idx` (`tb_Pessoa_Fisica_id_Pessoa_Fisica`),
  KEY `fk_tb_Contato_tb_Pessoa_Juridica1_idx` (`tb_Pessoa_Juridica_id_Pessoa_Juridica`),
  KEY `fk_tb_Contato_tb_Seguradora2_idx` (`tb_Seguradora_id_seguradora1`),
  KEY `fk_tb_Contato_tb_Preposto1_idx` (`tb_Preposto_id_preposto`),
  CONSTRAINT `fk_tb_Contato_tb_Pessoa_Fisica1` FOREIGN KEY (`tb_Pessoa_Fisica_id_Pessoa_Fisica`) REFERENCES `tb_pessoa_fisica` (`id_Pessoa_Fisica`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_tb_Contato_tb_Pessoa_Juridica1` FOREIGN KEY (`tb_Pessoa_Juridica_id_Pessoa_Juridica`) REFERENCES `tb_pessoa_juridica` (`id_Pessoa_Juridica`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_tb_Contato_tb_Preposto1` FOREIGN KEY (`tb_Preposto_id_preposto`) REFERENCES `tb_preposto` (`id_preposto`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_tb_Contato_tb_Seguradora1` FOREIGN KEY (`tb_Seguradora_id_seguradora`) REFERENCES `tb_seguradora` (`id_seguradora`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_tb_Contato_tb_Seguradora2` FOREIGN KEY (`tb_Seguradora_id_seguradora1`) REFERENCES `tb_seguradora` (`id_seguradora`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8 PACK_KEYS=0;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_contato`
--

LOCK TABLES `tb_contato` WRITE;
/*!40000 ALTER TABLE `tb_contato` DISABLE KEYS */;
INSERT INTO `tb_contato` VALUES (1,'(32)4234-3242','(23)4234-2342',NULL,NULL,'(23)42342-3423',NULL,'','ricardo-svc@live.com',NULL,1,NULL,NULL,NULL);
/*!40000 ALTER TABLE `tb_contato` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_cor`
--

DROP TABLE IF EXISTS `tb_cor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_cor` (
  `id_Cor` int(11) NOT NULL AUTO_INCREMENT,
  `Descricao` varchar(17) NOT NULL,
  `tb_Dados_Veiculo_id_Dados_Veiculo` int(11) NOT NULL,
  PRIMARY KEY (`id_Cor`,`tb_Dados_Veiculo_id_Dados_Veiculo`),
  KEY `fk_tb_Cor_tb_Dados_Veiculo1_idx` (`tb_Dados_Veiculo_id_Dados_Veiculo`),
  CONSTRAINT `fk_tb_Cor_tb_Dados_Veiculo1` FOREIGN KEY (`tb_Dados_Veiculo_id_Dados_Veiculo`) REFERENCES `tb_dados_veiculo` (`id_Dados_Veiculo`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_cor`
--

LOCK TABLES `tb_cor` WRITE;
/*!40000 ALTER TABLE `tb_cor` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_cor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_dados_veiculo`
--

DROP TABLE IF EXISTS `tb_dados_veiculo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_dados_veiculo` (
  `id_Dados_Veiculo` int(11) NOT NULL AUTO_INCREMENT,
  `Fabricante` varchar(20) NOT NULL,
  `Modelo` varchar(14) NOT NULL,
  `Ano_Fabricacao` varchar(10) NOT NULL,
  `Ano_Modelo` varchar(10) NOT NULL,
  `Placa` varchar(11) NOT NULL,
  `Renavan` varchar(11) NOT NULL,
  `Chassi` varchar(25) NOT NULL,
  `Financiamento` varchar(3) NOT NULL,
  `Kit_Gas` tinyint(1) NOT NULL,
  PRIMARY KEY (`id_Dados_Veiculo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_dados_veiculo`
--

LOCK TABLES `tb_dados_veiculo` WRITE;
/*!40000 ALTER TABLE `tb_dados_veiculo` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_dados_veiculo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_endereco`
--

DROP TABLE IF EXISTS `tb_endereco`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_endereco` (
  `id_Endereco` int(11) NOT NULL AUTO_INCREMENT,
  `Endereco` varchar(60) NOT NULL,
  `Numero` varchar(7) NOT NULL,
  `cep` varchar(9) NOT NULL,
  `bairro` varchar(30) NOT NULL,
  `cidade` varchar(30) NOT NULL,
  `uf` varchar(2) NOT NULL,
  `pais` varchar(20) DEFAULT NULL,
  `bloco` varchar(10) DEFAULT NULL,
  `Complemento` varchar(45) DEFAULT NULL,
  `tb_Pessoa_Juridica_id_Pessoa_Juridica` int(11) DEFAULT NULL,
  `tb_Seguradora_id_seguradora` int(11) DEFAULT NULL,
  `tb_Preposto_id_preposto` int(11) DEFAULT NULL,
  `tb_Pessoa_Fisica_id_Pessoa_Fisica` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_Endereco`),
  KEY `fk_tb_Endereco_tb_Pessoa_Juridica1_idx` (`tb_Pessoa_Juridica_id_Pessoa_Juridica`),
  KEY `fk_tb_Endereco_tb_Seguradora1_idx` (`tb_Seguradora_id_seguradora`),
  KEY `fk_tb_Endereco_tb_Preposto1_idx` (`tb_Preposto_id_preposto`),
  KEY `fk_tb_Endereco_tb_Pessoa_Fisica1_idx` (`tb_Pessoa_Fisica_id_Pessoa_Fisica`),
  CONSTRAINT `fk_tb_Endereco_tb_Pessoa_Fisica1` FOREIGN KEY (`tb_Pessoa_Fisica_id_Pessoa_Fisica`) REFERENCES `tb_pessoa_fisica` (`id_Pessoa_Fisica`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_tb_Endereco_tb_Pessoa_Juridica1` FOREIGN KEY (`tb_Pessoa_Juridica_id_Pessoa_Juridica`) REFERENCES `tb_pessoa_juridica` (`id_Pessoa_Juridica`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_tb_Endereco_tb_Preposto1` FOREIGN KEY (`tb_Preposto_id_preposto`) REFERENCES `tb_preposto` (`id_preposto`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_tb_Endereco_tb_Seguradora1` FOREIGN KEY (`tb_Seguradora_id_seguradora`) REFERENCES `tb_seguradora` (`id_seguradora`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_endereco`
--

LOCK TABLES `tb_endereco` WRITE;
/*!40000 ALTER TABLE `tb_endereco` DISABLE KEYS */;
INSERT INTO `tb_endereco` VALUES (1,'Rua Lambda','234','23423-423','','São Paulo','SP',NULL,'','',NULL,NULL,NULL,1);
/*!40000 ALTER TABLE `tb_endereco` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_envolvidos`
--

DROP TABLE IF EXISTS `tb_envolvidos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_envolvidos` (
  `id_envolvidos` int(11) NOT NULL AUTO_INCREMENT,
  `nome_completo` varchar(75) NOT NULL,
  `tb_Sinistro_id_sinistro` int(11) NOT NULL,
  `Status` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`id_envolvidos`,`tb_Sinistro_id_sinistro`),
  KEY `fk_tb_Envolvidos_tb_Sinistro1_idx` (`tb_Sinistro_id_sinistro`),
  CONSTRAINT `fk_tb_Envolvidos_tb_Sinistro1` FOREIGN KEY (`tb_Sinistro_id_sinistro`) REFERENCES `tb_sinistro` (`id_sinistro`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 PACK_KEYS=0;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_envolvidos`
--

LOCK TABLES `tb_envolvidos` WRITE;
/*!40000 ALTER TABLE `tb_envolvidos` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_envolvidos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_estacionamento_escola`
--

DROP TABLE IF EXISTS `tb_estacionamento_escola`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_estacionamento_escola` (
  `id_estacionamento_escola` int(11) NOT NULL AUTO_INCREMENT,
  `Descricao` varchar(10) DEFAULT NULL,
  `tb_Questionario_id_questionario` int(11) NOT NULL,
  PRIMARY KEY (`id_estacionamento_escola`),
  KEY `fk_tb_Estacionamento_Escola_tb_Questionario1_idx` (`tb_Questionario_id_questionario`),
  CONSTRAINT `fk_tb_Estacionamento_Escola_tb_Questionario1` FOREIGN KEY (`tb_Questionario_id_questionario`) REFERENCES `tb_questionario` (`id_questionario`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 PACK_KEYS=0;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_estacionamento_escola`
--

LOCK TABLES `tb_estacionamento_escola` WRITE;
/*!40000 ALTER TABLE `tb_estacionamento_escola` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_estacionamento_escola` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_estacionamento_residencia`
--

DROP TABLE IF EXISTS `tb_estacionamento_residencia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_estacionamento_residencia` (
  `id_Estacionamento_Residencia` int(11) NOT NULL AUTO_INCREMENT,
  `Descricao` varchar(10) DEFAULT NULL,
  `tb_Questionario_id_questionario` int(11) NOT NULL,
  PRIMARY KEY (`id_Estacionamento_Residencia`),
  KEY `fk_tb_Estacionamento_Residencia_tb_Questionario1_idx` (`tb_Questionario_id_questionario`),
  CONSTRAINT `fk_tb_Estacionamento_Residencia_tb_Questionario1` FOREIGN KEY (`tb_Questionario_id_questionario`) REFERENCES `tb_questionario` (`id_questionario`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_estacionamento_residencia`
--

LOCK TABLES `tb_estacionamento_residencia` WRITE;
/*!40000 ALTER TABLE `tb_estacionamento_residencia` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_estacionamento_residencia` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_estado_civil`
--

DROP TABLE IF EXISTS `tb_estado_civil`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_estado_civil` (
  `id_Estado_Civil` int(11) NOT NULL AUTO_INCREMENT,
  `Estado_Civil` varchar(45) NOT NULL,
  `tb_Principal_Condutor_id_principal_condutor` int(11) DEFAULT NULL,
  `tb_Pessoa_Fisica_id_Pessoa_Fisica` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_Estado_Civil`),
  KEY `fk_tb_Estado_Civil_tb_Principal_Condutor1_idx` (`tb_Principal_Condutor_id_principal_condutor`),
  KEY `fk_tb_Estado_Civil_tb_Pessoa_Fisica1_idx` (`tb_Pessoa_Fisica_id_Pessoa_Fisica`),
  CONSTRAINT `fk_tb_Estado_Civil_tb_Pessoa_Fisica1` FOREIGN KEY (`tb_Pessoa_Fisica_id_Pessoa_Fisica`) REFERENCES `tb_pessoa_fisica` (`id_Pessoa_Fisica`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_tb_Estado_Civil_tb_Principal_Condutor1` FOREIGN KEY (`tb_Principal_Condutor_id_principal_condutor`) REFERENCES `tb_principal_condutor` (`id_principal_condutor`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_estado_civil`
--

LOCK TABLES `tb_estado_civil` WRITE;
/*!40000 ALTER TABLE `tb_estado_civil` DISABLE KEYS */;
INSERT INTO `tb_estado_civil` VALUES (1,'Solteiro',NULL,1);
/*!40000 ALTER TABLE `tb_estado_civil` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_fechamento_apolices`
--

DROP TABLE IF EXISTS `tb_fechamento_apolices`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_fechamento_apolices` (
  `id_Fechamento_Apolices` int(11) NOT NULL AUTO_INCREMENT,
  `item` int(11) NOT NULL,
  `mes` int(11) NOT NULL,
  `item_segurado` varchar(15) NOT NULL,
  `vencimeto` varchar(14) NOT NULL,
  `status` varchar(20) NOT NULL,
  `comissao` varchar(7) NOT NULL,
  `tb_Dados_Veiculo_id_Dados_Veiculo` int(11) DEFAULT NULL,
  `tb_Pessoa_Fisica_id_Pessoa_Fisica` int(11) DEFAULT NULL,
  `tb_Pessoa_Juridica_id_Pessoa_Juridica` int(11) DEFAULT NULL,
  `tb_Seguradora_id_seguradora` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_Fechamento_Apolices`),
  KEY `fk_tb_Fechamento_Apolices_tb_Dados_Veiculo1_idx` (`tb_Dados_Veiculo_id_Dados_Veiculo`),
  KEY `fk_tb_Fechamento_Apolices_tb_Pessoa_Fisica1_idx` (`tb_Pessoa_Fisica_id_Pessoa_Fisica`),
  KEY `fk_tb_Fechamento_Apolices_tb_Pessoa_Juridica1_idx` (`tb_Pessoa_Juridica_id_Pessoa_Juridica`),
  KEY `fk_tb_Fechamento_Apolices_tb_Seguradora1_idx` (`tb_Seguradora_id_seguradora`),
  CONSTRAINT `fk_tb_Fechamento_Apolices_tb_Dados_Veiculo1` FOREIGN KEY (`tb_Dados_Veiculo_id_Dados_Veiculo`) REFERENCES `tb_dados_veiculo` (`id_Dados_Veiculo`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_tb_Fechamento_Apolices_tb_Pessoa_Fisica1` FOREIGN KEY (`tb_Pessoa_Fisica_id_Pessoa_Fisica`) REFERENCES `tb_pessoa_fisica` (`id_Pessoa_Fisica`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_tb_Fechamento_Apolices_tb_Pessoa_Juridica1` FOREIGN KEY (`tb_Pessoa_Juridica_id_Pessoa_Juridica`) REFERENCES `tb_pessoa_juridica` (`id_Pessoa_Juridica`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_tb_Fechamento_Apolices_tb_Seguradora1` FOREIGN KEY (`tb_Seguradora_id_seguradora`) REFERENCES `tb_seguradora` (`id_seguradora`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_fechamento_apolices`
--

LOCK TABLES `tb_fechamento_apolices` WRITE;
/*!40000 ALTER TABLE `tb_fechamento_apolices` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_fechamento_apolices` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_filho_enteado_17_anos`
--

DROP TABLE IF EXISTS `tb_filho_enteado_17_anos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_filho_enteado_17_anos` (
  `id_filho_enteado_17_anos` int(11) NOT NULL AUTO_INCREMENT,
  `Qnt_Filhos` int(3) DEFAULT NULL,
  `tb_Questionario_id_questionario` int(11) NOT NULL,
  `idade` varchar(3) DEFAULT NULL,
  PRIMARY KEY (`id_filho_enteado_17_anos`),
  KEY `fk_tb_Filho_Enteado_17_Anos_tb_Questionario1_idx` (`tb_Questionario_id_questionario`),
  CONSTRAINT `fk_tb_Filho_Enteado_17_Anos_tb_Questionario1` FOREIGN KEY (`tb_Questionario_id_questionario`) REFERENCES `tb_questionario` (`id_questionario`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 PACK_KEYS=0;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_filho_enteado_17_anos`
--

LOCK TABLES `tb_filho_enteado_17_anos` WRITE;
/*!40000 ALTER TABLE `tb_filho_enteado_17_anos` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_filho_enteado_17_anos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_garagem`
--

DROP TABLE IF EXISTS `tb_garagem`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_garagem` (
  `id_Estacionamento_Trabalho` int(11) NOT NULL AUTO_INCREMENT,
  `Residencia` tinyint(1) DEFAULT NULL,
  `tb_Questionario_id_questionario` int(11) NOT NULL,
  `Trabalho` tinyint(1) DEFAULT NULL,
  `Local_Estudos` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`id_Estacionamento_Trabalho`),
  KEY `fk_tb_Estacionamento_Trabalho_tb_Questionario1_idx` (`tb_Questionario_id_questionario`),
  CONSTRAINT `fk_tb_Estacionamento_Trabalho_tb_Questionario1` FOREIGN KEY (`tb_Questionario_id_questionario`) REFERENCES `tb_questionario` (`id_questionario`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_garagem`
--

LOCK TABLES `tb_garagem` WRITE;
/*!40000 ALTER TABLE `tb_garagem` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_garagem` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_orcamento`
--

DROP TABLE IF EXISTS `tb_orcamento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_orcamento` (
  `id_Orcamento` int(11) NOT NULL AUTO_INCREMENT,
  `dt_Calculo` varchar(14) NOT NULL,
  `premio_seguradora` double NOT NULL,
  `nro_apolice` varchar(15) DEFAULT NULL,
  `CI` varchar(20) DEFAULT NULL,
  `Observacoes` text NOT NULL,
  `tb_Pessoa_Fisica_id_Pessoa_Fisica` int(11) DEFAULT NULL,
  `tb_Pessoa_Juridica_id_Pessoa_Juridica` int(11) DEFAULT NULL,
  `tb_Questionario_id_questionario` int(11) DEFAULT NULL,
  `tb_Seguradora_id_seguradora` int(11) DEFAULT NULL,
  `tb_Principal_Condutor_id_principal_condutor` int(11) DEFAULT NULL,
  `tb_Segundo_Condutor_id_segundo_condutor` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_Orcamento`),
  KEY `fk_tb_Orcamento_tb_Pessoa_Fisica1_idx` (`tb_Pessoa_Fisica_id_Pessoa_Fisica`),
  KEY `fk_tb_Orcamento_tb_Pessoa_Juridica1_idx` (`tb_Pessoa_Juridica_id_Pessoa_Juridica`),
  KEY `fk_tb_Orcamento_tb_Questionario1_idx` (`tb_Questionario_id_questionario`),
  KEY `fk_tb_Orcamento_tb_Seguradora1_idx` (`tb_Seguradora_id_seguradora`),
  KEY `fk_tb_Orcamento_tb_Principal_Condutor1_idx` (`tb_Principal_Condutor_id_principal_condutor`),
  KEY `fk_tb_Orcamento_tb_Segundo_Condutor1_idx` (`tb_Segundo_Condutor_id_segundo_condutor`),
  CONSTRAINT `fk_tb_Orcamento_tb_Pessoa_Fisica1` FOREIGN KEY (`tb_Pessoa_Fisica_id_Pessoa_Fisica`) REFERENCES `tb_pessoa_fisica` (`id_Pessoa_Fisica`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_tb_Orcamento_tb_Pessoa_Juridica1` FOREIGN KEY (`tb_Pessoa_Juridica_id_Pessoa_Juridica`) REFERENCES `tb_pessoa_juridica` (`id_Pessoa_Juridica`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_tb_Orcamento_tb_Principal_Condutor1` FOREIGN KEY (`tb_Principal_Condutor_id_principal_condutor`) REFERENCES `tb_principal_condutor` (`id_principal_condutor`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_tb_Orcamento_tb_Questionario1` FOREIGN KEY (`tb_Questionario_id_questionario`) REFERENCES `tb_questionario` (`id_questionario`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_tb_Orcamento_tb_Segundo_Condutor1` FOREIGN KEY (`tb_Segundo_Condutor_id_segundo_condutor`) REFERENCES `tb_segundo_condutor` (`id_segundo_condutor`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_tb_Orcamento_tb_Seguradora1` FOREIGN KEY (`tb_Seguradora_id_seguradora`) REFERENCES `tb_seguradora` (`id_seguradora`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_orcamento`
--

LOCK TABLES `tb_orcamento` WRITE;
/*!40000 ALTER TABLE `tb_orcamento` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_orcamento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_pagamento`
--

DROP TABLE IF EXISTS `tb_pagamento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_pagamento` (
  `id_Pagamento` int(11) NOT NULL AUTO_INCREMENT,
  `descricao` int(11) NOT NULL,
  `tb_Orcamento_id_Orcamento` int(11) DEFAULT NULL,
  `tb_Comissoes_id_Comissoes` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_Pagamento`),
  KEY `fk_tb_Pagamento_tb_Orcamento1_idx` (`tb_Orcamento_id_Orcamento`),
  KEY `fk_tb_Pagamento_tb_Comissoes1_idx` (`tb_Comissoes_id_Comissoes`),
  CONSTRAINT `fk_tb_Pagamento_tb_Comissoes1` FOREIGN KEY (`tb_Comissoes_id_Comissoes`) REFERENCES `tb_comissoes` (`id_Comissoes`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_tb_Pagamento_tb_Orcamento1` FOREIGN KEY (`tb_Orcamento_id_Orcamento`) REFERENCES `tb_orcamento` (`id_Orcamento`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_pagamento`
--

LOCK TABLES `tb_pagamento` WRITE;
/*!40000 ALTER TABLE `tb_pagamento` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_pagamento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_periodo_estudo`
--

DROP TABLE IF EXISTS `tb_periodo_estudo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_periodo_estudo` (
  `id_periodo_estudo` int(11) NOT NULL AUTO_INCREMENT,
  `matutino` tinyint(1) DEFAULT NULL,
  `tb_Questionario_id_questionario` int(11) NOT NULL,
  `vespertino` tinyint(1) DEFAULT NULL,
  `noturno` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`id_periodo_estudo`),
  KEY `fk_tb_Periodo_Estudo_tb_Questionario1_idx` (`tb_Questionario_id_questionario`),
  CONSTRAINT `fk_tb_Periodo_Estudo_tb_Questionario1` FOREIGN KEY (`tb_Questionario_id_questionario`) REFERENCES `tb_questionario` (`id_questionario`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 PACK_KEYS=0;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_periodo_estudo`
--

LOCK TABLES `tb_periodo_estudo` WRITE;
/*!40000 ALTER TABLE `tb_periodo_estudo` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_periodo_estudo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_pessoa_fisica`
--

DROP TABLE IF EXISTS `tb_pessoa_fisica`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_pessoa_fisica` (
  `id_Pessoa_Fisica` int(11) NOT NULL AUTO_INCREMENT,
  `Nome_Completo` varchar(75) NOT NULL,
  `Cpf` varchar(14) NOT NULL,
  `rg` varchar(15) NOT NULL,
  `dt_expedicao` varchar(14) NOT NULL,
  `orgao_exped` varchar(6) NOT NULL,
  `cnh` varchar(12) NOT NULL,
  `tempo_habilitacao` varchar(14) NOT NULL,
  `dt_nascimento` varchar(14) NOT NULL,
  `profissao` varchar(50) NOT NULL,
  PRIMARY KEY (`id_Pessoa_Fisica`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_pessoa_fisica`
--

LOCK TABLES `tb_pessoa_fisica` WRITE;
/*!40000 ALTER TABLE `tb_pessoa_fisica` DISABLE KEYS */;
INSERT INTO `tb_pessoa_fisica` VALUES (1,'Ricardo Sousa Vaz de Carvalho','234.234.234-23','23,423,324-2','15/04/2015','234','234','3 Anos','29/07/1997','Programador');
/*!40000 ALTER TABLE `tb_pessoa_fisica` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_pessoa_juridica`
--

DROP TABLE IF EXISTS `tb_pessoa_juridica`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_pessoa_juridica` (
  `id_Pessoa_Juridica` int(11) NOT NULL AUTO_INCREMENT,
  `razao_social` varchar(50) DEFAULT NULL,
  `nome_fantasia` varchar(50) DEFAULT NULL,
  `cnpj` varchar(48) NOT NULL,
  `area_Atuacao` varchar(40) NOT NULL,
  `site` varchar(120) DEFAULT NULL,
  `Comentarios` text,
  PRIMARY KEY (`id_Pessoa_Juridica`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_pessoa_juridica`
--

LOCK TABLES `tb_pessoa_juridica` WRITE;
/*!40000 ALTER TABLE `tb_pessoa_juridica` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_pessoa_juridica` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_portas`
--

DROP TABLE IF EXISTS `tb_portas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_portas` (
  `id_Portas` int(11) NOT NULL AUTO_INCREMENT,
  `Descricao` varchar(11) NOT NULL,
  `tb_Dados_Veiculo_id_Dados_Veiculo` int(11) NOT NULL,
  PRIMARY KEY (`id_Portas`,`tb_Dados_Veiculo_id_Dados_Veiculo`),
  KEY `fk_tb_Portas_tb_Dados_Veiculo1_idx` (`tb_Dados_Veiculo_id_Dados_Veiculo`),
  CONSTRAINT `fk_tb_Portas_tb_Dados_Veiculo1` FOREIGN KEY (`tb_Dados_Veiculo_id_Dados_Veiculo`) REFERENCES `tb_dados_veiculo` (`id_Dados_Veiculo`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_portas`
--

LOCK TABLES `tb_portas` WRITE;
/*!40000 ALTER TABLE `tb_portas` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_portas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_preposto`
--

DROP TABLE IF EXISTS `tb_preposto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_preposto` (
  `id_preposto` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(75) NOT NULL,
  `cpf` varchar(14) NOT NULL,
  `comentarios` varchar(300) DEFAULT NULL,
  `rg` varchar(13) DEFAULT NULL,
  `dt_expedicao` varchar(14) DEFAULT NULL,
  `orgao_exped` varchar(6) DEFAULT NULL,
  `dt_nascimento` varchar(14) DEFAULT NULL,
  PRIMARY KEY (`id_preposto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 PACK_KEYS=0;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_preposto`
--

LOCK TABLES `tb_preposto` WRITE;
/*!40000 ALTER TABLE `tb_preposto` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_preposto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_principal_condutor`
--

DROP TABLE IF EXISTS `tb_principal_condutor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_principal_condutor` (
  `id_principal_condutor` int(11) NOT NULL AUTO_INCREMENT,
  `especifique` varchar(20) DEFAULT NULL,
  `nome` varchar(75) DEFAULT NULL,
  `cpf` varchar(14) NOT NULL,
  `rg` varchar(13) NOT NULL,
  `dt_expedicao` varchar(14) DEFAULT NULL,
  `orgao_exped` varchar(6) DEFAULT NULL,
  `profissao` varchar(50) NOT NULL,
  `cep_trabalho` varchar(9) DEFAULT NULL,
  PRIMARY KEY (`id_principal_condutor`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 PACK_KEYS=0;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_principal_condutor`
--

LOCK TABLES `tb_principal_condutor` WRITE;
/*!40000 ALTER TABLE `tb_principal_condutor` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_principal_condutor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_proponente`
--

DROP TABLE IF EXISTS `tb_proponente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_proponente` (
  `id_Proponente` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(75) NOT NULL,
  `tb_Orcamento_id_Orcamento` int(11) DEFAULT NULL,
  `dt_nascimento` varchar(14) DEFAULT NULL,
  PRIMARY KEY (`id_Proponente`),
  KEY `fk_tb_Proponente_tb_Orcamento1_idx` (`tb_Orcamento_id_Orcamento`),
  CONSTRAINT `fk_tb_Proponente_tb_Orcamento1` FOREIGN KEY (`tb_Orcamento_id_Orcamento`) REFERENCES `tb_orcamento` (`id_Orcamento`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_proponente`
--

LOCK TABLES `tb_proponente` WRITE;
/*!40000 ALTER TABLE `tb_proponente` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_proponente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_questionario`
--

DROP TABLE IF EXISTS `tb_questionario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_questionario` (
  `id_questionario` int(11) NOT NULL AUTO_INCREMENT,
  `cep_pernoite` varchar(9) NOT NULL,
  `inicio_vigencia` varchar(14) DEFAULT NULL,
  `qtde_sinis_ult_perio` varchar(3) DEFAULT NULL,
  `bonus` varchar(5) NOT NULL,
  `uso_veiculo` varchar(15) NOT NULL,
  `distan_resi_trab_km` varchar(5) NOT NULL,
  `temp_hab_anos` varchar(2) DEFAULT NULL,
  `temp_hab_mes` varchar(2) DEFAULT NULL,
  `Possui_FIlhos_ate-17` tinyint(1) NOT NULL,
  `Principal_Condutor_Estuda` tinyint(1) NOT NULL,
  `Garagem_fechada` tinyint(1) NOT NULL,
  `Veiculo_Usado_Cli_Forn` tinyint(1) NOT NULL,
  `tb_Roub_Veic_Ult_Dois_Anos` tinyint(1) NOT NULL,
  PRIMARY KEY (`id_questionario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 PACK_KEYS=0;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_questionario`
--

LOCK TABLES `tb_questionario` WRITE;
/*!40000 ALTER TABLE `tb_questionario` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_questionario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_ramo`
--

DROP TABLE IF EXISTS `tb_ramo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_ramo` (
  `id_ramo` int(11) NOT NULL AUTO_INCREMENT,
  `tb_Seguradora_id_seguradora` int(11) DEFAULT NULL,
  `descricao` varchar(13) NOT NULL,
  `tb_Comissoes_id_Comissoes` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_ramo`),
  KEY `tb_Ramo_FKIndex1` (`tb_Seguradora_id_seguradora`),
  KEY `fk_tb_Ramo_tb_Comissoes1_idx` (`tb_Comissoes_id_Comissoes`),
  CONSTRAINT `fk_tb_Ramo_tb_Comissoes1` FOREIGN KEY (`tb_Comissoes_id_Comissoes`) REFERENCES `tb_comissoes` (`id_Comissoes`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_{A824E61A-DF4C-42A0-A1D6-54F756C21D58}` FOREIGN KEY (`tb_Seguradora_id_seguradora`) REFERENCES `tb_seguradora` (`id_seguradora`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 PACK_KEYS=0;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_ramo`
--

LOCK TABLES `tb_ramo` WRITE;
/*!40000 ALTER TABLE `tb_ramo` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_ramo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_rcf`
--

DROP TABLE IF EXISTS `tb_rcf`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_rcf` (
  `id_rfc` int(11) NOT NULL AUTO_INCREMENT COMMENT 'Responsabilidade Civil Facultativa',
  `descricao` varchar(15) DEFAULT NULL,
  `tb_Orcamento_id_Orcamento` int(11) NOT NULL,
  PRIMARY KEY (`id_rfc`,`tb_Orcamento_id_Orcamento`),
  KEY `fk_tb_Rfc_tb_Orcamento1_idx` (`tb_Orcamento_id_Orcamento`),
  CONSTRAINT `fk_tb_Rfc_tb_Orcamento1` FOREIGN KEY (`tb_Orcamento_id_Orcamento`) REFERENCES `tb_orcamento` (`id_Orcamento`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 PACK_KEYS=0 COMMENT='Nesta tabela será possível escolher apenas uma opção marcando com um ''X''';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_rcf`
--

LOCK TABLES `tb_rcf` WRITE;
/*!40000 ALTER TABLE `tb_rcf` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_rcf` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_recibo`
--

DROP TABLE IF EXISTS `tb_recibo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_recibo` (
  `id_recibo` int(11) NOT NULL AUTO_INCREMENT,
  `tb_Preposto_id_preposto` int(11) DEFAULT NULL,
  `item` varchar(3) NOT NULL,
  `produtor` varchar(40) NOT NULL,
  `dt_credito` varchar(14) NOT NULL,
  `ciente_acordo` varchar(40) DEFAULT NULL,
  `tb_Comissoes_id_Comissoes` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_recibo`),
  KEY `tb_Recibo_FKIndex1` (`tb_Preposto_id_preposto`),
  KEY `fk_tb_Recibo_tb_Comissoes1_idx` (`tb_Comissoes_id_Comissoes`),
  CONSTRAINT `fk_tb_Recibo_tb_Comissoes1` FOREIGN KEY (`tb_Comissoes_id_Comissoes`) REFERENCES `tb_comissoes` (`id_Comissoes`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_{DCD68B4B-92BE-4C9F-8551-8AD901845709}` FOREIGN KEY (`tb_Preposto_id_preposto`) REFERENCES `tb_preposto` (`id_preposto`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 PACK_KEYS=0;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_recibo`
--

LOCK TABLES `tb_recibo` WRITE;
/*!40000 ALTER TABLE `tb_recibo` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_recibo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_resid_princ_cond_pes_18_24`
--

DROP TABLE IF EXISTS `tb_resid_princ_cond_pes_18_24`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_resid_princ_cond_pes_18_24` (
  `id_resid_princ_cond_pes_18_24` int(11) NOT NULL AUTO_INCREMENT,
  `descricao` varchar(3) NOT NULL,
  `tb_Questionario_id_questionario` int(11) NOT NULL,
  PRIMARY KEY (`id_resid_princ_cond_pes_18_24`),
  KEY `fk_tb_Resid_Princ_Cond_Pes_18_24_tb_Questionario1_idx` (`tb_Questionario_id_questionario`),
  CONSTRAINT `fk_tb_Resid_Princ_Cond_Pes_18_24_tb_Questionario1` FOREIGN KEY (`tb_Questionario_id_questionario`) REFERENCES `tb_questionario` (`id_questionario`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 PACK_KEYS=0;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_resid_princ_cond_pes_18_24`
--

LOCK TABLES `tb_resid_princ_cond_pes_18_24` WRITE;
/*!40000 ALTER TABLE `tb_resid_princ_cond_pes_18_24` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_resid_princ_cond_pes_18_24` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_seguimento`
--

DROP TABLE IF EXISTS `tb_seguimento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_seguimento` (
  `id_seguimento` int(11) NOT NULL AUTO_INCREMENT,
  `tb_Ramo_id_ramo` int(11) DEFAULT NULL,
  `descricao` varchar(13) NOT NULL,
  PRIMARY KEY (`id_seguimento`),
  KEY `tb_Seguimento_FKIndex1` (`tb_Ramo_id_ramo`),
  CONSTRAINT `fk_{319DB920-C063-4F1A-A8A7-51552BB46C6F}` FOREIGN KEY (`tb_Ramo_id_ramo`) REFERENCES `tb_ramo` (`id_ramo`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 PACK_KEYS=0;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_seguimento`
--

LOCK TABLES `tb_seguimento` WRITE;
/*!40000 ALTER TABLE `tb_seguimento` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_seguimento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_segundo_condutor`
--

DROP TABLE IF EXISTS `tb_segundo_condutor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_segundo_condutor` (
  `id_segundo_condutor` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(75) NOT NULL,
  `dt_nascimento` varchar(14) NOT NULL,
  PRIMARY KEY (`id_segundo_condutor`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 PACK_KEYS=0;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_segundo_condutor`
--

LOCK TABLES `tb_segundo_condutor` WRITE;
/*!40000 ALTER TABLE `tb_segundo_condutor` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_segundo_condutor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_seguradora`
--

DROP TABLE IF EXISTS `tb_seguradora`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_seguradora` (
  `id_seguradora` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(75) NOT NULL,
  `site_corretor` varchar(120) DEFAULT NULL,
  `site_principal` varchar(120) DEFAULT NULL,
  `comentarios` varchar(300) DEFAULT NULL,
  `cnpj` varchar(48) NOT NULL,
  PRIMARY KEY (`id_seguradora`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 PACK_KEYS=0;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_seguradora`
--

LOCK TABLES `tb_seguradora` WRITE;
/*!40000 ALTER TABLE `tb_seguradora` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_seguradora` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_sexo`
--

DROP TABLE IF EXISTS `tb_sexo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_sexo` (
  `id_Sexo` int(11) NOT NULL AUTO_INCREMENT,
  `Sexo_Cliente` varchar(45) NOT NULL,
  `tb_Principal_Condutor_id_principal_condutor` int(11) DEFAULT NULL,
  `tb_Segundo_Condutor_id_segundo_condutor` int(11) DEFAULT NULL,
  `tb_Pessoa_Fisica_id_Pessoa_Fisica` int(11) DEFAULT NULL,
  `tb_Proponente_id_Proponente` int(11) DEFAULT NULL,
  `tb_Preposto_id_preposto` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_Sexo`),
  KEY `fk_tb_Sexo_tb_Principal_Condutor1_idx` (`tb_Principal_Condutor_id_principal_condutor`),
  KEY `fk_tb_Sexo_tb_Segundo_Condutor1_idx` (`tb_Segundo_Condutor_id_segundo_condutor`),
  KEY `fk_tb_Sexo_tb_Pessoa_Fisica1_idx` (`tb_Pessoa_Fisica_id_Pessoa_Fisica`),
  KEY `fk_tb_Sexo_tb_Proponente1_idx` (`tb_Proponente_id_Proponente`),
  KEY `fk_tb_Sexo_tb_Preposto1_idx` (`tb_Preposto_id_preposto`),
  CONSTRAINT `fk_tb_Sexo_tb_Pessoa_Fisica1` FOREIGN KEY (`tb_Pessoa_Fisica_id_Pessoa_Fisica`) REFERENCES `tb_pessoa_fisica` (`id_Pessoa_Fisica`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_tb_Sexo_tb_Preposto1` FOREIGN KEY (`tb_Preposto_id_preposto`) REFERENCES `tb_preposto` (`id_preposto`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_tb_Sexo_tb_Principal_Condutor1` FOREIGN KEY (`tb_Principal_Condutor_id_principal_condutor`) REFERENCES `tb_principal_condutor` (`id_principal_condutor`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_tb_Sexo_tb_Proponente1` FOREIGN KEY (`tb_Proponente_id_Proponente`) REFERENCES `tb_proponente` (`id_Proponente`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_tb_Sexo_tb_Segundo_Condutor1` FOREIGN KEY (`tb_Segundo_Condutor_id_segundo_condutor`) REFERENCES `tb_segundo_condutor` (`id_segundo_condutor`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_sexo`
--

LOCK TABLES `tb_sexo` WRITE;
/*!40000 ALTER TABLE `tb_sexo` DISABLE KEYS */;
INSERT INTO `tb_sexo` VALUES (1,'Masculino',NULL,NULL,1,NULL,NULL);
/*!40000 ALTER TABLE `tb_sexo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_sinistro`
--

DROP TABLE IF EXISTS `tb_sinistro`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_sinistro` (
  `id_sinistro` int(11) NOT NULL AUTO_INCREMENT,
  `sinistro_ocorrido` varchar(20) NOT NULL,
  `dt_sinistro` varchar(14) NOT NULL,
  `comentarios` text,
  `tb_Pessoa_Fisica_id_Pessoa_Fisica` int(11) DEFAULT NULL,
  `tb_Pessoa_Juridica_id_Pessoa_Juridica` int(11) DEFAULT NULL,
  `tb_Orcamento_id_Orcamento` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_sinistro`),
  KEY `fk_tb_Sinistro_tb_Pessoa_Fisica1_idx` (`tb_Pessoa_Fisica_id_Pessoa_Fisica`),
  KEY `fk_tb_Sinistro_tb_Pessoa_Juridica1_idx` (`tb_Pessoa_Juridica_id_Pessoa_Juridica`),
  KEY `fk_tb_Sinistro_tb_Orcamento1_idx` (`tb_Orcamento_id_Orcamento`),
  CONSTRAINT `fk_tb_Sinistro_tb_Orcamento1` FOREIGN KEY (`tb_Orcamento_id_Orcamento`) REFERENCES `tb_orcamento` (`id_Orcamento`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_tb_Sinistro_tb_Pessoa_Fisica1` FOREIGN KEY (`tb_Pessoa_Fisica_id_Pessoa_Fisica`) REFERENCES `tb_pessoa_fisica` (`id_Pessoa_Fisica`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_tb_Sinistro_tb_Pessoa_Juridica1` FOREIGN KEY (`tb_Pessoa_Juridica_id_Pessoa_Juridica`) REFERENCES `tb_pessoa_juridica` (`id_Pessoa_Juridica`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 PACK_KEYS=0;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_sinistro`
--

LOCK TABLES `tb_sinistro` WRITE;
/*!40000 ALTER TABLE `tb_sinistro` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_sinistro` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_veiculo_alienado`
--

DROP TABLE IF EXISTS `tb_veiculo_alienado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_veiculo_alienado` (
  `id_veiculo_alienado` int(11) NOT NULL AUTO_INCREMENT,
  `descricao` varchar(3) NOT NULL,
  `tb_Questionario_id_questionario` int(11) NOT NULL,
  PRIMARY KEY (`id_veiculo_alienado`),
  KEY `fk_tb_Veiculo_Alienado_tb_Questionario1_idx` (`tb_Questionario_id_questionario`),
  CONSTRAINT `fk_tb_Veiculo_Alienado_tb_Questionario1` FOREIGN KEY (`tb_Questionario_id_questionario`) REFERENCES `tb_questionario` (`id_questionario`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 PACK_KEYS=0;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_veiculo_alienado`
--

LOCK TABLES `tb_veiculo_alienado` WRITE;
/*!40000 ALTER TABLE `tb_veiculo_alienado` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_veiculo_alienado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_vigencia`
--

DROP TABLE IF EXISTS `tb_vigencia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_vigencia` (
  `id_Vigencia` int(11) NOT NULL AUTO_INCREMENT,
  `dt_Inicio` varchar(14) NOT NULL,
  `dt_Fim` varchar(14) NOT NULL,
  `tb_Orcamento_id_Orcamento` int(11) NOT NULL,
  PRIMARY KEY (`id_Vigencia`,`tb_Orcamento_id_Orcamento`),
  KEY `fk_tb_Vigencia_tb_Orcamento1_idx` (`tb_Orcamento_id_Orcamento`),
  CONSTRAINT `fk_tb_Vigencia_tb_Orcamento1` FOREIGN KEY (`tb_Orcamento_id_Orcamento`) REFERENCES `tb_orcamento` (`id_Orcamento`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_vigencia`
--

LOCK TABLES `tb_vigencia` WRITE;
/*!40000 ALTER TABLE `tb_vigencia` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_vigencia` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'solafide_v6'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2015-04-16 17:16:28
