-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema Libreria_bd
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema Libreria_bd
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `Libreria_bd` DEFAULT CHARACTER SET utf8 ;
USE `Libreria_bd` ;

-- -----------------------------------------------------
-- Table `Libreria_bd`.`Usuario`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Libreria_bd`.`Usuario` (
  `id_usuario` INT NOT NULL AUTO_INCREMENT,
  `NombreUsuario` VARCHAR(45) NULL,
  `ApellidoUsuario` VARCHAR(45) NULL,
  `DniUsuario` INT NULL,
  `TipoUsuario` INT NULL,
  `email` VARCHAR(200) NULL,
  `direccion` VARCHAR(200) NULL,
  `telefono` VARCHAR(45) NULL,
  `estadoUsuario` TINYINT NULL,
  PRIMARY KEY (`id_usuario`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Libreria_bd`.`Editorial`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Libreria_bd`.`Editorial` (
  `idEditorial` INT NOT NULL AUTO_INCREMENT,
  `Editorial` VARCHAR(45) NULL,
  PRIMARY KEY (`idEditorial`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Libreria_bd`.`Idioma`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Libreria_bd`.`Idioma` (
  `idIdioma` INT NOT NULL AUTO_INCREMENT,
  `Idioma` VARCHAR(45) NULL,
  PRIMARY KEY (`idIdioma`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Libreria_bd`.`Categoria`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Libreria_bd`.`Categoria` (
  `idCategoria` INT NOT NULL AUTO_INCREMENT,
  `Categoria` VARCHAR(45) NULL,
  PRIMARY KEY (`idCategoria`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Libreria_bd`.`Estado`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Libreria_bd`.`Estado` (
  `idEstado` INT NOT NULL AUTO_INCREMENT,
  `Estado` VARCHAR(45) NULL,
  PRIMARY KEY (`idEstado`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Libreria_bd`.`Autor`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Libreria_bd`.`Autor` (
  `idAutor` INT NOT NULL AUTO_INCREMENT,
  `nombreAutor` VARCHAR(45) NULL,
  `apellidoAutor` VARCHAR(45) NULL,
  PRIMARY KEY (`idAutor`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Libreria_bd`.`Libros`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Libreria_bd`.`Libros` (
  `idLibros` INT NOT NULL AUTO_INCREMENT,
  `titulo` VARCHAR(70) NULL,
  `id_autor` INT NULL,
  `id_editor` INT NULL,
  `fechaPublic` DATE NULL,
  `edicion` VARCHAR(45) NULL,
  `id_categoria` INT NULL,
  `id_idioma` INT NULL,
  `pagina` INT NULL,
  `id_estado` INT NULL,
  `notas` VARCHAR(200) NULL,
  `stock` INT NULL,
  `condicionLibro` INT NULL,
  PRIMARY KEY (`idLibros`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Libreria_bd`.`Prestamo`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Libreria_bd`.`Prestamo` (
  `idPrestamo` INT NOT NULL AUTO_INCREMENT,
  `idUsuario` INT NULL,
  `idLibro` INT NULL,
  `fechaSalida` DATE NULL,
  `fechaEntrega` DATE NULL,
  `fechaDevolucion` DATE NULL,
  `idEstadoLibro` INT NULL,
  `mora` FLOAT NULL,
  `condicion` TINYINT NULL,
  PRIMARY KEY (`idPrestamo`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Libreria_bd`.`EstadoReserva`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Libreria_bd`.`EstadoReserva` (
  `idEstadoReserva` INT NOT NULL AUTO_INCREMENT,
  `EstadoReserva` VARCHAR(45) NULL,
  PRIMARY KEY (`idEstadoReserva`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Libreria_bd`.`Reserva`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Libreria_bd`.`Reserva` (
  `idReserva` INT NOT NULL AUTO_INCREMENT,
  `idUsuario` INT NULL,
  `idLibro` INT NULL,
  `fechaReserva` DATE NULL,
  `estadoReserva` INT NULL,
  PRIMARY KEY (`idReserva`))
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
