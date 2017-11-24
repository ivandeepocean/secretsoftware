-- phpMyAdmin SQL Dump
-- version 4.6.5.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 24, 2017 at 01:21 PM
-- Server version: 10.1.21-MariaDB
-- PHP Version: 7.1.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `yumidb`
--

-- --------------------------------------------------------

--
-- Table structure for table `accountstbl`
--

CREATE TABLE `accountstbl` (
  `AccountNo` int(60) NOT NULL,
  `Username` varchar(40) NOT NULL,
  `Password` varchar(40) NOT NULL,
  `Type` varchar(40) NOT NULL,
  `Active` varchar(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `accountstbl`
--

INSERT INTO `accountstbl` (`AccountNo`, `Username`, `Password`, `Type`, `Active`) VALUES
(1, 'Admin001', 'password', 'admin', 'y'),
(2, 'Admin002', 'password', 'admin', 'n'),
(7, 'ivan', '1234', '', ''),
(8, 'ivan', '12345', '', ''),
(9, 'user', 'user', '', '');

-- --------------------------------------------------------

--
-- Table structure for table `productstbl`
--

CREATE TABLE `productstbl` (
  `ProductNo` int(30) NOT NULL,
  `ProductName` varchar(50) NOT NULL,
  `Description` varchar(50) NOT NULL,
  `Quantity` int(30) NOT NULL,
  `Size` int(30) NOT NULL,
  `Price` int(30) NOT NULL,
  `Activity` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `productstbl`
--

INSERT INTO `productstbl` (`ProductNo`, `ProductName`, `Description`, `Quantity`, `Size`, `Price`, `Activity`) VALUES
(1, 'Pencil', 'Pencilx', 0, 0, 0, 'no'),
(2, 'candles', 'ivan', 5, 5, 5, 'no'),
(3, 'Sample Product', 'sample', 20, 20, 20, ''),
(5, '', '', 0, 0, 0, ''),
(6, '', '', 0, 0, 0, ''),
(7, 'cj', 'cj', 0, 0, 0, '');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `accountstbl`
--
ALTER TABLE `accountstbl`
  ADD PRIMARY KEY (`AccountNo`);

--
-- Indexes for table `productstbl`
--
ALTER TABLE `productstbl`
  ADD PRIMARY KEY (`ProductNo`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `accountstbl`
--
ALTER TABLE `accountstbl`
  MODIFY `AccountNo` int(60) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
--
-- AUTO_INCREMENT for table `productstbl`
--
ALTER TABLE `productstbl`
  MODIFY `ProductNo` int(30) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
