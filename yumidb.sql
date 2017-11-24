-- phpMyAdmin SQL Dump
-- version 4.6.5.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 24, 2017 at 05:11 PM
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
  `Size` varchar(30) NOT NULL,
  `Activity` varchar(20) NOT NULL,
  `ProductCode` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `productstbl`
--

INSERT INTO `productstbl` (`ProductNo`, `ProductName`, `Description`, `Quantity`, `Size`, `Activity`, `ProductCode`) VALUES
(8, 'Tracing Paper', '', 0, '...', 'yes', 'Product0001'),
(22, 'Stickers', '', 0, '...', '', 'Product0002'),
(23, 'Bluprint Paper', '', 0, '...', '', 'Product0003'),
(24, 'Developer', '', 0, '...', '', 'Product0004'),
(25, 'Plotter Paper', '', 0, '...', '', 'Product0005'),
(26, 'Xindra Board', '', 0, '...', '', 'Product0006'),
(27, 'Panaflex', '', 0, '...', '', 'Product0007'),
(28, 'Ink-Tarp', '', 0, '...', '', 'Product0008'),
(29, 'Ink-Hp-Plotter', '', 0, '...', '', 'Product0009'),
(30, 'Ink-Canon-Plotter', '', 0, '...', '', 'Project0010'),
(31, 'Tarpaulin', '', 0, '...', '', 'Product0011'),
(32, 'Sample', 'sample', 0, '...', '', 'Product0012');

-- --------------------------------------------------------

--
-- Table structure for table `sizesandpricetbl`
--

CREATE TABLE `sizesandpricetbl` (
  `SizeandPriceNo` int(30) NOT NULL,
  `ProductCode` varchar(30) NOT NULL,
  `Option1` varchar(30) NOT NULL,
  `Option2` varchar(30) NOT NULL,
  `Option3` varchar(30) NOT NULL,
  `Option4` varchar(30) NOT NULL,
  `Option5` varchar(30) NOT NULL,
  `ProductName` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `sizesandpricetbl`
--

INSERT INTO `sizesandpricetbl` (`SizeandPriceNo`, `ProductCode`, `Option1`, `Option2`, `Option3`, `Option4`, `Option5`, `ProductName`) VALUES
(1, 'Product0001', '20 x 30 inches', '24 x 30 inches', '', '', '', 'Tracing Paper'),
(2, 'Product0002', '', '', '', '', '', 'Stickers'),
(3, 'Product0003', '20 x 30', '24 x 36', '', '', '', 'Bluprint Paper'),
(4, 'Product0004', '', '', '', '', '', 'Developer'),
(5, 'Product0005', '', '', '', '', '', 'Plotter Paper'),
(6, 'Product0006', '', '', '', '', '', 'Xindra Board'),
(7, 'Product0007', '', '', '', '', '', 'Panaflex'),
(8, 'Product0008', '', '', '', '', '', 'Ink-Tarp'),
(9, 'Product0009', '', '', '', '', '', 'Ink-Hp-Plotter'),
(10, 'Project0010', '', '', '', '', '', 'Ink-Canon-Plotter'),
(11, 'Product0011', '', '', '', '', '', 'Tarpaulin'),
(12, 'Product0012', '', '', '', '', '', 'Sample');

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
-- Indexes for table `sizesandpricetbl`
--
ALTER TABLE `sizesandpricetbl`
  ADD PRIMARY KEY (`SizeandPriceNo`);

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
  MODIFY `ProductNo` int(30) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=33;
--
-- AUTO_INCREMENT for table `sizesandpricetbl`
--
ALTER TABLE `sizesandpricetbl`
  MODIFY `SizeandPriceNo` int(30) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
