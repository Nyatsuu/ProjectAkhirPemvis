-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 17, 2024 at 07:21 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbprojekpa`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbkeranjang`
--

CREATE TABLE `tbkeranjang` (
  `id_pembelian` int(20) NOT NULL,
  `nama_barang` text NOT NULL,
  `jumlah` int(10) NOT NULL,
  `harga` int(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tbtambah`
--

CREATE TABLE `tbtambah` (
  `id` int(11) NOT NULL,
  `nama_barang` varchar(255) NOT NULL,
  `tanggal_masuk` date NOT NULL,
  `kategori` varchar(100) NOT NULL,
  `harga` int(50) NOT NULL,
  `kondisi` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbtambah`
--

INSERT INTO `tbtambah` (`id`, `nama_barang`, `tanggal_masuk`, `kategori`, `harga`, `kondisi`) VALUES
(25, 'Raket', '2024-05-17', 'Badminton', 50000, 'Baru'),
(26, 'Jersey', '2024-05-17', 'Futsal', 250000, 'Baru'),
(28, 'Sepatu', '2024-05-17', 'Voli', 450000, 'Baru'),
(29, 'Bola', '2024-05-17', 'Futsal', 500000, 'Baru'),
(30, 'Senar', '2024-05-17', 'Badminton', 30000, 'Baru');

-- --------------------------------------------------------

--
-- Table structure for table `tbuser`
--

CREATE TABLE `tbuser` (
  `username` text NOT NULL,
  `password` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbuser`
--

INSERT INTO `tbuser` (`username`, `password`) VALUES
('hakim', 'hakim'),
('a', 'a'),
('b', 'a'),
('c', 'c'),
('d', 'd'),
('f', 'f'),
('mamat', 'mamat'),
('asd', 'asd'),
('user', 'user');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbkeranjang`
--
ALTER TABLE `tbkeranjang`
  ADD PRIMARY KEY (`id_pembelian`);

--
-- Indexes for table `tbtambah`
--
ALTER TABLE `tbtambah`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbkeranjang`
--
ALTER TABLE `tbkeranjang`
  MODIFY `id_pembelian` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=48;

--
-- AUTO_INCREMENT for table `tbtambah`
--
ALTER TABLE `tbtambah`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=32;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
