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
  `email` VARCHAR(45) NULL,
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
  `titulo` VARCHAR(45) NULL,
  `autor` INT NULL,
  `editor` INT NULL,
  `fechaPublic` DATE NULL,
  `edicion` VARCHAR(45) NULL,
  `categoria` INT NULL,
  `idioma` INT NULL,
  `pagina` INT NULL,
  `estado` INT NULL,
  `notas` VARCHAR(45) NULL,
  `stock` INT NULL,
  `condicionLibro` INT NULL,
  PRIMARY KEY (`idLibros`),
  INDEX `editorial_idx` (`editor` ASC) VISIBLE,
  INDEX `idioma_idx` (`idioma` ASC) VISIBLE,
  INDEX `categoria_idx` (`categoria` ASC) VISIBLE,
  INDEX `estado_idx` (`estado` ASC) VISIBLE,
  INDEX `autor_idx` (`autor` ASC) VISIBLE,
  CONSTRAINT `editorial`
    FOREIGN KEY (`editor`)
    REFERENCES `Libreria_bd`.`Editorial` (`idEditorial`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `idioma`
    FOREIGN KEY (`idioma`)
    REFERENCES `Libreria_bd`.`Idioma` (`idIdioma`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `categoria`
    FOREIGN KEY (`categoria`)
    REFERENCES `Libreria_bd`.`Categoria` (`idCategoria`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `estado`
    FOREIGN KEY (`estado`)
    REFERENCES `Libreria_bd`.`Estado` (`idEstado`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `autor`
    FOREIGN KEY (`autor`)
    REFERENCES `Libreria_bd`.`Autor` (`idAutor`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
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
  PRIMARY KEY (`idPrestamo`),
  INDEX `estado_idx` (`idEstadoLibro` ASC) VISIBLE,
  INDEX `usuario_idx` (`idUsuario` ASC) VISIBLE,
  INDEX `libro_idx` (`idLibro` ASC) VISIBLE,
  CONSTRAINT `estado`
    FOREIGN KEY (`idEstadoLibro`)
    REFERENCES `Libreria_bd`.`Estado` (`idEstado`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `usuario`
    FOREIGN KEY (`idUsuario`)
    REFERENCES `Libreria_bd`.`Usuario` (`id_usuario`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `libro`
    FOREIGN KEY (`idLibro`)
    REFERENCES `Libreria_bd`.`Libros` (`idLibros`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
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
  PRIMARY KEY (`idReserva`),
  INDEX `usuario_idx` (`idUsuario` ASC) VISIBLE,
  INDEX `libro_idx` (`idLibro` ASC) VISIBLE,
  INDEX `estadoReserva_idx` (`estadoReserva` ASC) VISIBLE,
  CONSTRAINT `usuario`
    FOREIGN KEY (`idUsuario`)
    REFERENCES `Libreria_bd`.`Usuario` (`id_usuario`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `libro`
    FOREIGN KEY (`idLibro`)
    REFERENCES `Libreria_bd`.`Libros` (`idLibros`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `estadoReserva`
    FOREIGN KEY (`estadoReserva`)
    REFERENCES `Libreria_bd`.`EstadoReserva` (`idEstadoReserva`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
