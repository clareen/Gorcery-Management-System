-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: May 17, 2017 at 12:49 PM
-- Server version: 10.1.16-MariaDB
-- PHP Version: 7.0.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `coinworth`
--

-- --------------------------------------------------------

--
-- Table structure for table `assistanttable`
--

CREATE TABLE `assistanttable` (
  `assistantID` varchar(20) NOT NULL,
  `assistantname` varchar(20) NOT NULL,
  `contact` varchar(20) NOT NULL,
  `starttime` varchar(20) NOT NULL,
  `endtime` varchar(20) NOT NULL,
  `day` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `assistanttable`
--

INSERT INTO `assistanttable` (`assistantID`, `assistantname`, `contact`, `starttime`, `endtime`, `day`) VALUES
('dfd', 'dgfg', 'dfgdfgfg', '10:22:56 PM', '10:27:21 PM', 'Thursday, May 11, 20');

-- --------------------------------------------------------

--
-- Table structure for table `billingtable`
--

CREATE TABLE `billingtable` (
  `recieptNumber` int(10) NOT NULL,
  `product` varchar(50) NOT NULL,
  `quantity` varchar(50) NOT NULL,
  `sellingPrice` varchar(50) NOT NULL,
  `totalCost` varchar(55) NOT NULL,
  `totalAmount` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `companydetails`
--

CREATE TABLE `companydetails` (
  `NAME` varchar(20) NOT NULL,
  `LOCATION` varchar(20) NOT NULL,
  `TIN` varchar(20) NOT NULL,
  `CIN` varchar(20) NOT NULL,
  `CONTACT` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `companydetails`
--

INSERT INTO `companydetails` (`NAME`, `LOCATION`, `TIN`, `CIN`, `CONTACT`) VALUES
('darst labs', 'uk', '344', '566', '256000');

-- --------------------------------------------------------

--
-- Table structure for table `companyimage`
--

CREATE TABLE `companyimage` (
  `name` varchar(20) NOT NULL,
  `image` longblob NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `companyimage`
--

INSERT INTO `companyimage` (`name`, `image`) VALUES
('', ''),
('darst labs', 0x433a5573657273442e412e522e5354204c4142534465736b746f700861636b646674662e6a7067);

-- --------------------------------------------------------

--
-- Table structure for table `contacttable`
--

CREATE TABLE `contacttable` (
  `NAME` varchar(20) NOT NULL,
  `NUMBER` varchar(20) NOT NULL,
  `DEPARTMENT` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `contacttable`
--

INSERT INTO `contacttable` (`NAME`, `NUMBER`, `DEPARTMENT`) VALUES
('DSDSD', '454545', 'YTYTY'),
('bghnvbbb', 'ffff', 'ggg');

-- --------------------------------------------------------

--
-- Table structure for table `logintable`
--

CREATE TABLE `logintable` (
  `Token` varchar(20) NOT NULL,
  `userID` varchar(20) NOT NULL,
  `loginTime` time(6) NOT NULL,
  `logoutTime` time(6) NOT NULL,
  `hours` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `logintable`
--

INSERT INTO `logintable` (`Token`, `userID`, `loginTime`, `logoutTime`, `hours`) VALUES
('', '1234tyu', '10:36:04.000000', '00:00:00.000000', '0'),
('1234', '', '05:31:44.000000', '00:00:00.000000', ''),
('34', '', '07:27:22.000000', '07:31:42.000000', ''),
('T1', '1234TYU', '11:12:29.000000', '08:30:27.000000', '');

-- --------------------------------------------------------

--
-- Table structure for table `managertable`
--

CREATE TABLE `managertable` (
  `managerID` varchar(20) NOT NULL,
  `managerName` varchar(20) NOT NULL,
  `managerContact` varchar(20) NOT NULL,
  `managerPassword` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `managertable`
--

INSERT INTO `managertable` (`managerID`, `managerName`, `managerContact`, `managerPassword`) VALUES
('1', 'drees', '567', '2');

-- --------------------------------------------------------

--
-- Table structure for table `paymenttable`
--

CREATE TABLE `paymenttable` (
  `WORKERID` varchar(20) NOT NULL,
  `PAY_PER_HOUR` varchar(20) NOT NULL,
  `WORKEDHOURS` varchar(20) NOT NULL,
  `AMOUNTPAID` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `paymenttable`
--

INSERT INTO `paymenttable` (`WORKERID`, `PAY_PER_HOUR`, `WORKEDHOURS`, `AMOUNTPAID`) VALUES
('12', '20000', '120', '2400000');

-- --------------------------------------------------------

--
-- Table structure for table `productstable`
--

CREATE TABLE `productstable` (
  `PRODUCTID` varchar(10) NOT NULL,
  `PRODUCTNAME` varchar(20) NOT NULL,
  `PRODUCTPRICE` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `productstable`
--

INSERT INTO `productstable` (`PRODUCTID`, `PRODUCTNAME`, `PRODUCTPRICE`) VALUES
('5rrr', 'rice', 20000),
('bd123', 'bread', 3000),
('fth', 'ovacado', 500);

-- --------------------------------------------------------

--
-- Table structure for table `stafftable`
--

CREATE TABLE `stafftable` (
  `STAFFID` varchar(10) NOT NULL,
  `NAME` varchar(20) NOT NULL,
  `GENDER` varchar(6) NOT NULL,
  `CONTACT` varchar(20) NOT NULL,
  `HIREDATE` varchar(20) NOT NULL,
  `PASSWORD` varchar(20) NOT NULL,
  `ENDDATE` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `stafftable`
--

INSERT INTO `stafftable` (`STAFFID`, `NAME`, `GENDER`, `CONTACT`, `HIREDATE`, `PASSWORD`, `ENDDATE`) VALUES
('1', 'dree', 'FEMALE', '4567', '5/12/2017', '2', '');

-- --------------------------------------------------------

--
-- Table structure for table `supplierstable`
--

CREATE TABLE `supplierstable` (
  `ID` varchar(20) NOT NULL,
  `NAME` varchar(20) NOT NULL,
  `LOCATION` varchar(20) NOT NULL,
  `CONTACT` varchar(20) NOT NULL,
  `ADDRESS` varchar(20) NOT NULL,
  `EMAIL` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tableadmin`
--

CREATE TABLE `tableadmin` (
  `username` varchar(20) NOT NULL,
  `password` varchar(20) NOT NULL,
  `adminEmail` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tableadmin`
--

INSERT INTO `tableadmin` (`username`, `password`, `adminEmail`) VALUES
('Admin', 'admin', '');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `assistanttable`
--
ALTER TABLE `assistanttable`
  ADD PRIMARY KEY (`assistantID`);

--
-- Indexes for table `billingtable`
--
ALTER TABLE `billingtable`
  ADD PRIMARY KEY (`recieptNumber`);

--
-- Indexes for table `contacttable`
--
ALTER TABLE `contacttable`
  ADD PRIMARY KEY (`NUMBER`);

--
-- Indexes for table `logintable`
--
ALTER TABLE `logintable`
  ADD PRIMARY KEY (`Token`);

--
-- Indexes for table `managertable`
--
ALTER TABLE `managertable`
  ADD PRIMARY KEY (`managerID`);

--
-- Indexes for table `productstable`
--
ALTER TABLE `productstable`
  ADD PRIMARY KEY (`PRODUCTID`);

--
-- Indexes for table `stafftable`
--
ALTER TABLE `stafftable`
  ADD PRIMARY KEY (`STAFFID`);

--
-- Indexes for table `supplierstable`
--
ALTER TABLE `supplierstable`
  ADD PRIMARY KEY (`ID`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
