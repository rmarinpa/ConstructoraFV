SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;


CREATE TABLE IF NOT EXISTS `curso` (
  `cod_curso` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) NOT NULL,
  PRIMARY KEY (`cod_curso`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=6 ;

INSERT INTO `curso` (`cod_curso`, `nombre`) VALUES
(1, 'SEXTO'),
(2, 'SEPTIMO'),
(3, 'OCTAVO'),
(4, 'NOVENO'),
(5, 'DECIMO');

CREATE TABLE IF NOT EXISTS `estudiante` (
  `cod_estudiante` int(11) NOT NULL AUTO_INCREMENT,
  `num_documento` bigint(20) NOT NULL,
  `nombres` varchar(50) NOT NULL,
  `apellido1` varchar(20) NOT NULL,
  `apellido2` varchar(20) NOT NULL,
  `fecha_nacimiento` date NOT NULL,
  `direccion` varchar(50) NOT NULL,
  `telefono` bigint(20) NOT NULL,
  PRIMARY KEY (`cod_estudiante`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;

INSERT INTO `estudiante` (`cod_estudiante`, `num_documento`, `nombres`, `apellido1`, `apellido2`, `fecha_nacimiento`, `direccion`, `telefono`) VALUES
(1, 1129543026, 'GENESIS', 'VARGAS', 'JIMENEZ', '2013-09-01', 'CARRERA 27 N 9 05', 3012263915),
(2, 1045721619, 'MARIA JUANA', 'PEREZ', 'RODRIGUEZ', '2013-09-06', 'CARRERA 75 N 90 - 67', 330750),
(3, 1234567890, 'JUAN CARLOS', 'JIMENEZ', 'PEREZ', '2013-09-07', 'CARRERA 34 N 98 - 56', 320546890);

CREATE TABLE IF NOT EXISTS `jornada` (
  `cod_jornada` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) NOT NULL,
  PRIMARY KEY (`cod_jornada`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

INSERT INTO `jornada` (`cod_jornada`, `nombre`) VALUES
(1, 'DIURNA'),
(2, 'NOCTURNA');

CREATE TABLE IF NOT EXISTS `matricula` (
  `cod_matricula` int(20) NOT NULL AUTO_INCREMENT,
  `tipo_matricula` varchar(50) NOT NULL,
  `cod_estudiante` int(11) NOT NULL,
  `cod_curso` int(11) NOT NULL,
  `cod_jornada` int(11) NOT NULL,
  `fecha_matricula` date NOT NULL,
  `monto` bigint(20) NOT NULL,
  `cod_usuario` int(11) NOT NULL,
  PRIMARY KEY (`cod_matricula`),
  KEY `cod_estudiante` (`cod_estudiante`),
  KEY `cod_usuario` (`cod_usuario`),
  KEY `cod_jornada` (`cod_jornada`),
  KEY `cod_curso` (`cod_curso`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;

INSERT INTO `matricula` (`cod_matricula`, `tipo_matricula`, `cod_estudiante`, `cod_curso`, `cod_jornada`, `fecha_matricula`, `monto`, `cod_usuario`) VALUES
(1, 'NUEVA', 1, 4, 1, '2013-09-06', 200500, 2),
(2, 'RENOVACIÓN', 2, 3, 2, '2013-09-07', 521000, 2),
(3, 'NUEVA', 2, 4, 1, '2013-09-19', 2012541, 2);

CREATE TABLE IF NOT EXISTS `usuario` (
  `cod_usuario` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  PRIMARY KEY (`cod_usuario`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

INSERT INTO `usuario` (`cod_usuario`, `nombre`, `password`) VALUES
(1, 'GENESIS', '12345'),
(2, 'ADMIN', 'admin');


ALTER TABLE `matricula`
  ADD CONSTRAINT `matricula_ibfk_1` FOREIGN KEY (`cod_usuario`) REFERENCES `usuario` (`cod_usuario`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `matricula_ibfk_2` FOREIGN KEY (`cod_estudiante`) REFERENCES `estudiante` (`cod_estudiante`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `matricula_ibfk_3` FOREIGN KEY (`cod_curso`) REFERENCES `curso` (`cod_curso`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `matricula_ibfk_4` FOREIGN KEY (`cod_jornada`) REFERENCES `jornada` (`cod_jornada`) ON DELETE CASCADE ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
