-- --------------------------------------------------------
-- Host:                         localhost
-- Server version:               5.7.24 - MySQL Community Server (GPL)
-- Server OS:                    Win64
-- HeidiSQL Version:             10.2.0.5599
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Dumping database structure for cinemas_henry
CREATE DATABASE IF NOT EXISTS `cinemas_henry` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `cinemas_henry`;

-- Dumping structure for table cinemas_henry.funcion
CREATE TABLE IF NOT EXISTS `funcion` (
  `Folio` int(11) NOT NULL,
  `dia` int(11) DEFAULT NULL,
  `mes` varchar(20) DEFAULT NULL,
  `ano` int(11) DEFAULT NULL,
  `hora` time DEFAULT NULL,
  `Precio` double DEFAULT NULL,
  `fk_id_Pelicula` int(11) DEFAULT NULL,
  `fk_nombre_salas` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`Folio`),
  KEY `fk_id_Pelicula` (`fk_id_Pelicula`),
  KEY `funcion_ibfk_2` (`fk_nombre_salas`),
  CONSTRAINT `funcion_ibfk_2` FOREIGN KEY (`fk_nombre_salas`) REFERENCES `salas` (`Nombre`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Dumping data for table cinemas_henry.funcion: ~7 rows (approximately)
/*!40000 ALTER TABLE `funcion` DISABLE KEYS */;
INSERT INTO `funcion` (`Folio`, `dia`, `mes`, `ano`, `hora`, `Precio`, `fk_id_Pelicula`, `fk_nombre_salas`) VALUES
	(1, 25, 'Mayo', 2018, '13:30:00', 70, 1, 'A'),
	(2, 25, 'Mayo', 2018, '13:30:00', 70, 9, 'A'),
	(3, 26, 'Mayo', 2018, '13:30:00', 70, 4, 'A'),
	(6, 21, 'Mayo', 2018, '14:30:00', 70, 2, 'B'),
	(55, 30, 'Mayo', 2018, '11:30:00', 70, 3, 'B'),
	(2344, 14, 'Mayo', 2018, '23:30:00', 50, 4, 'B'),
	(4534, 11, 'Julio', 2018, '14:10:00', 45, 3, 'B');
/*!40000 ALTER TABLE `funcion` ENABLE KEYS */;

-- Dumping structure for table cinemas_henry.pelicula
CREATE TABLE IF NOT EXISTS `pelicula` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(100) DEFAULT NULL,
  `Clasificacion` varchar(100) DEFAULT NULL,
  `Genero` varchar(50) DEFAULT NULL,
  `Director` varchar(150) DEFAULT NULL,
  `Reparto` varchar(400) DEFAULT NULL,
  `Duracion` int(11) DEFAULT NULL,
  `Sinopsis` varchar(767) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;

-- Dumping data for table cinemas_henry.pelicula: ~7 rows (approximately)
/*!40000 ALTER TABLE `pelicula` DISABLE KEYS */;
INSERT INTO `pelicula` (`ID`, `Nombre`, `Clasificacion`, `Genero`, `Director`, `Reparto`, `Duracion`, `Sinopsis`) VALUES
	(1, 'Avengers: Infinity War', 'B', 'Aventura y acción', 'Joe Russo, Anthony Russo', 'Robert Downey Jr., Chris Evans, Mark Ruffalo, Scarlett Johansson, Chris Hemsworth', 96, 'Marvel Studios trae a la pantalla el enfrentamiento definitivo y más sangriento de todos los tiempos. Los Vengadores y sus superhéroes deben estar dispuestos a sacrificar todo en un intento de derrotar al poderoso Thanos, antes de que sus planes de devastación y ruina ponga fin al universo.'),
	(2, 'Tres anuncios en las afueras', 'C', 'Aventura y acción', 'Martin McDonagh', 'Frances McDormand, Woody Harrelson, Sam Rockwell, Peter Dinklage', 115, 'Una mujer cuya hija fue asesinada se enfrenta a la policía usando los carteles publicitarios para denunciar que han pasado meses desde que se cometió el crimen y no solo no han resuelto nada, sino que parecen no tener interés en hacerlo.'),
	(3, 'La forma del agua', 'B15', 'Drama', 'Guillermo del Toro', 'Sally Hawkins,  Doug Jones,  Michael Shannon,  Octavia Spencer,  Richard Jenkins, Michael Stuhlbarg,  Lauren Lee Smith,  David Hewlett,  Nick Searcy,  Morgan Kelly, Dru Viergever,  Maxine Grossman,  Amanda Smith,  Cyndy Day,  Dave Reachill', 119, 'En un inquietante laboratorio de alta seguridad, durante la Guerra Fría, se produce una conexión insólita entre dos mundos aparentemente alejados. La vida de la solitaria Elisa (Sally Hawkins), que trabaja como limpiadora en el laboratorio, cambia por completo cuando descubre un experimento clasificado como secreto: un hombre anfibio (Doug Jones) que se encuentra ahí recluido. \r\n'),
	(4, 'Coco', 'A', 'Infantil', 'Lee Unkrich', 'Anthony Gonzalez, Gael García Bernal, Benjamin Bratt', 109, 'Miguel es un niño que sueña con ser músico, pero su familia se lo prohíbe porque su tatarabuelo, músico, los abandonó, y quieren obligar a Miguel a ser zapatero, como todos los miembros de la familia. Por accidente, Miguel entra en la Tierra de los Muertos, de donde sólo podrá salir si un familiar difunto le concede su bendición.\r\n'),
	(7, 'Star Wars: Episodio IV - Una nueva esperanza', 'B', 'Ciencia ficción', 'George Lucas', 'Mark Hamill, Carrie Fischer, Harrison Ford', 125, 'La nave en la que viaja la princesa Leia es capturada por las tropas imperiales al mando del temible Darth Vader. Antes de ser atrapada, Leia consigue introducir un mensaje en su robot R2-D2, quien acompañado de su inseparable C-3PO logra escapar.'),
	(8, 'E.T., El extraterrestre', 'AA', 'Ciencia ficción', 'Steven Spielberg', 'Henry Thomas, Pat Welsh, Robert MacNaughton', 115, 'El encuentro cercano de un niño con un alienígena perdido conduce hacia una amistad única. Ganadora de un Oscar.'),
	(9, 'Black Panther', 'B', 'Aventura y acción', 'Ryan Coogler', '', 134, 'TChalla asume la personalidad de Pantera Negra para salvar no solo al reino de Wakanda, sino a toda la humanidad.');
/*!40000 ALTER TABLE `pelicula` ENABLE KEYS */;

-- Dumping structure for table cinemas_henry.salas
CREATE TABLE IF NOT EXISTS `salas` (
  `Nombre` varchar(10) NOT NULL,
  `Asientos` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`Nombre`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Dumping data for table cinemas_henry.salas: ~4 rows (approximately)
/*!40000 ALTER TABLE `salas` DISABLE KEYS */;
INSERT INTO `salas` (`Nombre`, `Asientos`) VALUES
	('A', '100'),
	('B', '105'),
	('CC', '210'),
	('D', '234');
/*!40000 ALTER TABLE `salas` ENABLE KEYS */;

-- Dumping structure for table cinemas_henry.tickets
CREATE TABLE IF NOT EXISTS `tickets` (
  `folio_ticket` int(11) NOT NULL AUTO_INCREMENT,
  `fk_sala_nombre` varchar(10) DEFAULT NULL,
  `fk_funcion_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`folio_ticket`),
  KEY `fk_sala_nombre` (`fk_sala_nombre`),
  KEY `fk_funcion_id` (`fk_funcion_id`),
  CONSTRAINT `tickets_ibfk_1` FOREIGN KEY (`fk_sala_nombre`) REFERENCES `salas` (`Nombre`),
  CONSTRAINT `tickets_ibfk_2` FOREIGN KEY (`fk_funcion_id`) REFERENCES `funcion` (`Folio`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Dumping data for table cinemas_henry.tickets: ~0 rows (approximately)
/*!40000 ALTER TABLE `tickets` DISABLE KEYS */;
/*!40000 ALTER TABLE `tickets` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
