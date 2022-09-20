
CREATE SCHEMA IF NOT EXISTS `controle` DEFAULT CHARACTER SET utf8 ;
USE `controle` ;

-- -----------------------------------------------------
-- Table `controle`.`Agenda`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `controle`.`Agenda` (
  `idAgenda` INT NOT NULL AUTO_INCREMENT,
  `titulo` VARCHAR(45) NOT NULL,
  `hora` TIME NOT NULL,
  `data` DATE NOT NULL,
  `descricao` TEXT(200) NOT NULL,
  PRIMARY KEY (`idAgenda`))
;

-- -----------------------------------------------------
-- Table `controle`.`Contas`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `controle`.`Contas` (
  `idContasPagar` INT NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(45) NOT NULL,
  `descricao` VARCHAR(50) NOT NULL,
  `valor` DOUBLE NOT NULL,
  `dataVencimento` DATE NOT NULL,
  `pago_recebido` TINYINT NULL,
  `tipo` TINYINT NOT NULL,
  PRIMARY KEY (`idContasPagar`))
;

-- -----------------------------------------------------
-- Table `controle`.`Endereco`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `controle`.`Endereco` (
  `idEndereco` INT NOT NULL AUTO_INCREMENT,
  `Logradouro` VARCHAR(45) NOT NULL,
  `Cidade` VARCHAR(45) NOT NULL,
  `Bairro` VARCHAR(45) NOT NULL,
  `UF` VARCHAR(2) NOT NULL,
  `CEP` DECIMAL(8) NOT NULL,
  PRIMARY KEY (`idEndereco`))
;

-- -----------------------------------------------------
-- Table `controle`.`Contato`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `controle`.`Contato` (
  `idContato` INT NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(45) NOT NULL,
  `email` VARCHAR(45) NULL,
  `CPF` DECIMAL(11) NULL,
  `Sexo` TINYINT NOT NULL,
  `dataNascimento` DATE NULL,
  `numeroCasa` VARCHAR(20) NULL,
  `complemento` VARCHAR(45) NULL,
  `fkEndereco` INT NULL,
  PRIMARY KEY (`idContato`),
  FOREIGN KEY (`fkEndereco`)  REFERENCES `controle`.`Endereco`(`idEndereco`)
  );


CREATE TABLE IF NOT EXISTS `controle`.`Telefone` (
  `idTelefone` INT NOT NULL AUTO_INCREMENT,
  `fkContato` INT NOT NULL,
  `operadora` VARCHAR(45) NULL,
  `ddd` DECIMAL(2) NOT NULL,
  `numero` DECIMAL(9) NOT NULL,
  PRIMARY KEY (`idTelefone`),
  FOREIGN KEY (`fkContato`)  REFERENCES `controle`.`Contato` (`idContato`));


