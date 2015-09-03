-- phpMyAdmin SQL Dump
-- version 4.1.14
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: 30 Sie 2015, 13:26
-- Server version: 5.6.17
-- PHP Version: 5.5.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `id_numbers`
--

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `numbers`
--

CREATE TABLE IF NOT EXISTS `numbers` (
  `id_number` varchar(30) COLLATE utf8_polish_ci NOT NULL,
  `country` varchar(20) COLLATE utf8_polish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Zrzut danych tabeli `numbers`
--

INSERT INTO `numbers` (`id_number`, `country`) VALUES
('94121801635', 'Poland'),
('71021401635', 'Poland'),
('94121801645', 'Poland'),
('38609030000', 'Hungary'),
('27201130000', 'Hungary'),
('63211110000', 'Hungary'),
('49008150000', 'Hungary'),
('17204230000', 'Hungary'),
('58705180000', 'Hungary');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
