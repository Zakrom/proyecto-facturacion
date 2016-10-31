CREATE DATABASE `cotimex` /*!40100 DEFAULT CHARACTER SET utf8 */;

CREATE TABLE `producto` (
  `pto_id` int(11) NOT NULL AUTO_INCREMENT,
  `pto_name` varchar(100) NOT NULL,
  `pto_price` double NOT NULL,
  `pto_img` varchar(255),
  `pto_type` tinyint(4) NOT NULL,
  PRIMARY KEY (`pto_id`),
  UNIQUE KEY `vta_id_UNIQUE` (`pto_id`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8;

CREATE TABLE `user` (
  `user_id` int(11) NOT NULL AUTO_INCREMENT,
  `user_name` varchar(45) DEFAULT NULL,
  `user_password` varchar(45) DEFAULT NULL,
  `user_salary` double DEFAULT NULL,
  PRIMARY KEY (`user_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE `cliente` (
  `cte_id` int(11) NOT NULL AUTO_INCREMENT,
  `cte_name` varchar(255) DEFAULT NULL,
  `cte_phone_number` varchar(15) DEFAULT NULL,
  `cte_email` varchar(50) DEFAULT NULL,
  `cte_business` varchar(100) DEFAULT NULL,
  `cte_address` varchar(511) DEFAULT NULL,
  `cte_rfc` varchar(13) DEFAULT NULL,
  `user_user_id` int(11) NOT NULL,
  PRIMARY KEY (`cte_id`,`user_user_id`),
  UNIQUE KEY `cte_id_UNIQUE` (`cte_id`),
  KEY `fk_cliente_user1_idx` (`user_user_id`),
  CONSTRAINT `fk_cliente_user1` FOREIGN KEY (`user_user_id`) REFERENCES `user` (`user_id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE `factura` (
  `fct_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `fct_start_date` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `fct_total` double DEFAULT NULL,
  `facturacol` varchar(45) DEFAULT NULL,
  `facturacol1` varchar(45) DEFAULT NULL,
  `cte_id` int(11) NOT NULL,
  PRIMARY KEY (`fct_id`,`cte_id`),
  KEY `fk_factura_cliente1_idx` (`cte_id`),
  CONSTRAINT `fk_factura_cliente1` FOREIGN KEY (`cte_id`) REFERENCES `cliente` (`cte_id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE `factura_venta` (
  `pto_id` int(11) NOT NULL,
  `fct_id` int(10) unsigned NOT NULL,
  PRIMARY KEY (`pto_id`,`fct_id`),
  KEY `fk_vta_producto_has_factura_factura1_idx` (`fct_id`),
  KEY `fk_vta_producto_has_factura_vta_producto_idx` (`pto_id`),
  CONSTRAINT `fk_vta_producto_has_factura_factura1` FOREIGN KEY (`fct_id`) REFERENCES `factura` (`fct_id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_vta_producto_has_factura_vta_producto` FOREIGN KEY (`pto_id`) REFERENCES `producto` (`pto_id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

ALTER TABLE cotimex.producto AUTO_INCREMENT =1;
INSERT INTO cotimex.producto VALUE (null, 'Brazo FARO Platinum', 420, null, 2);
INSERT INTO cotimex.producto VALUE (null, 'Brazo FARO Edge', 525, null, 2);
INSERT INTO cotimex.producto VALUE (null, 'Laptop', 185, null, 2);
INSERT INTO cotimex.producto VALUE (null, 'Tripie', 53, null, 2);
INSERT INTO cotimex.producto VALUE (null, 'FARO Laser Tracker', 650, null, 2);
INSERT INTO cotimex.producto VALUE (null, 'Scanner Geomagic Capture', 10000, null, 1);
INSERT INTO cotimex.producto VALUE (null, 'Geomagic Design X ', 15000, null, 1);
INSERT INTO cotimex.producto VALUE (null, 'Geomagic Control ', 12000, null, 1);
INSERT INTO cotimex.producto VALUE (null, 'Plugin Geomagic for Solidworks', 5000, null, 1);
INSERT INTO cotimex.producto VALUE (null, 'Entrenamiento Geomagic Design X', 3000, null, 1);
INSERT INTO cotimex.producto VALUE (null, 'Entrenamiento Geomagic Control', 3000, null, 1);
SELECT * FROM cotimex.producto;


