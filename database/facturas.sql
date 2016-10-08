-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 08-10-2016 a las 01:38:08
-- Versión del servidor: 10.1.13-MariaDB
-- Versión de PHP: 5.6.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `facturas`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `productos_renta`
--

CREATE TABLE `productos_renta` (
  `id` bigint(20) NOT NULL,
  `producto_r` varchar(20) NOT NULL,
  `precio_r` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `productos_renta`
--

INSERT INTO `productos_renta` (`id`, `producto_r`, `precio_r`) VALUES
(1, 'Brazo FARO Platinum', 420),
(2, 'Brazo FARO Edge', 525),
(3, 'Laptop ', 185),
(4, 'Tripie', 53),
(5, 'FARO Laser Tracker', 650);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `productos_venta`
--

CREATE TABLE `productos_venta` (
  `id_v` bigint(10) NOT NULL,
  `producto_v` varchar(40) NOT NULL,
  `precio_v` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `productos_venta`
--

INSERT INTO `productos_venta` (`id_v`, `producto_v`, `precio_v`) VALUES
(1, 'Scanner Geomagic Capture', 10000),
(2, 'Geomagic Design X ', 15000),
(3, 'Geomagic Control ', 12000),
(4, 'Plugin Geomagic for Solidworks', 5000),
(5, 'Entrenamiento Geomagic Design X', 3000),
(6, 'Entrenamiento Geomagic Control', 3000);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `productos_renta`
--
ALTER TABLE `productos_renta`
  ADD UNIQUE KEY `id` (`id`);

--
-- Indices de la tabla `productos_venta`
--
ALTER TABLE `productos_venta`
  ADD UNIQUE KEY `id_v` (`id_v`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `productos_renta`
--
ALTER TABLE `productos_renta`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT de la tabla `productos_venta`
--
ALTER TABLE `productos_venta`
  MODIFY `id_v` bigint(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
