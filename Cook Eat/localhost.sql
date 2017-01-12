-- phpMyAdmin SQL Dump
-- version 3.3.9
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Jan 12, 2017 at 02:17 PM
-- Server version: 5.5.8
-- PHP Version: 5.3.5

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `cookeat`
--
CREATE DATABASE `cookeat` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `cookeat`;

-- --------------------------------------------------------

--
-- Table structure for table `dlog`
--

CREATE TABLE IF NOT EXISTS `dlog` (
  `id` int(100) NOT NULL AUTO_INCREMENT,
  `userby` varchar(100) NOT NULL,
  `made` varchar(100) NOT NULL,
  `userto` varchar(100) NOT NULL,
  `dtime` datetime NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=262 ;

--
-- Dumping data for table `dlog`
--

INSERT INTO `dlog` (`id`, `userby`, `made`, `userto`, `dtime`) VALUES
(242, 'patrick', 'Login', '', '2017-01-11 21:52:47'),
(243, 'patrick', 'Login', '', '2017-01-11 21:52:57'),
(244, 'patrick', 'Login', '', '2017-01-11 21:54:00'),
(245, 'patrick', 'Login', '', '2017-01-11 21:54:57'),
(246, 'patrick', 'Login', '', '2017-01-11 22:00:47'),
(247, 'admin', 'Login', '', '2017-01-11 22:04:19'),
(248, 'josh', 'Login', '', '2017-01-11 22:04:25'),
(249, 'josh', 'Login', '', '2017-01-11 22:04:29'),
(250, 'patrick', 'Login', '', '2017-01-11 22:08:46'),
(251, 'Patrick', 'Logout', '', '2017-01-11 22:11:00'),
(252, 'patrick', 'Login', '', '2017-01-11 22:16:52'),
(253, 'Patrick', 'Logout', '', '2017-01-11 22:21:41'),
(254, 'josh', 'Login', '', '2017-01-11 22:26:34'),
(255, 'josh', 'Logout', '', '2017-01-11 22:27:34'),
(256, '', 'Logout', '', '2017-01-11 22:56:45'),
(257, '', 'Logout', '', '2017-01-11 23:00:22'),
(258, '', 'Logout', '', '2017-01-12 00:59:12'),
(259, '', 'Logout', '', '2017-01-12 01:20:37'),
(260, '', 'Logout', '', '2017-01-14 09:56:43'),
(261, '', 'Logout', '', '2017-01-12 09:59:58');

-- --------------------------------------------------------

--
-- Table structure for table `res`
--

CREATE TABLE IF NOT EXISTS `res` (
  `rno` int(11) NOT NULL AUTO_INCREMENT,
  `cname` varchar(100) NOT NULL,
  `cno` varchar(100) NOT NULL,
  `day` date NOT NULL,
  `time` time NOT NULL,
  `rtable` varchar(100) NOT NULL,
  `note` varchar(1000) NOT NULL,
  `torder` varchar(100) NOT NULL,
  `status` varchar(20) NOT NULL,
  PRIMARY KEY (`rno`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=124 ;

--
-- Dumping data for table `res`
--

INSERT INTO `res` (`rno`, `cname`, `cno`, `day`, `time`, `rtable`, `note`, `torder`, `status`) VALUES
(114, 'Patrick', '09778130509', '2017-01-12', '01:00:00', '5', 'Birthday Party', '', 'pending'),
(115, 'Josh Lomeda', '09778130509', '2017-01-12', '01:30:00', '5', 'N/A', '', 'done'),
(119, '123', '123', '2017-01-12', '01:00:00', '123', '123', '', 'pending'),
(121, '213', '23', '2017-01-12', '01:00:00', '13', '123', '', 'pending'),
(122, '324', '234', '2017-01-12', '10:00:00', '234', '234', '', 'pending'),
(123, '123', '123', '2017-01-12', '05:00:00', '123', '123', '', 'pending');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE IF NOT EXISTS `users` (
  `no` int(100) NOT NULL AUTO_INCREMENT,
  `fname` varchar(100) NOT NULL,
  `lname` varchar(100) NOT NULL,
  `cno` varchar(15) NOT NULL,
  `pos` varchar(50) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `time` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`no`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=46 ;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`no`, `fname`, `lname`, `cno`, `pos`, `username`, `password`, `time`) VALUES
(35, 'Patrick', 'Santos', '09778130509', 'Admin', 'Patrick', 'admin', '2016-12-26 13:39:53'),
(36, 'Ekei', 'Santos', '1234562', 'Cashier', 'ekei', 'admin', '2016-12-26 13:40:11'),
(37, 'Evangeline', 'santos', '123153', 'Kitchen', 'eva', 'admin', '2016-12-26 13:41:13'),
(41, 'Joshua', 'Lomeda', '09778130509', 'Admin', 'josh', 'josh', '2017-01-03 18:55:33'),
(43, 'sheila Jane', 'Santos', '09778130905', 'Admin', 'sheitrick', 'nolsaranghe', '2017-01-10 09:46:41'),
(44, '123', '123', '123', 'Cashier', '123', '123', '2017-01-11 23:12:17'),
(45, '123', '123', '123', 'Cashier', '13', '123', '2017-01-11 23:12:23');
