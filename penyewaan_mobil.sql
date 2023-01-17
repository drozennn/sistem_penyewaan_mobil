-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 09 Jan 2023 pada 18.44
-- Versi server: 10.4.25-MariaDB
-- Versi PHP: 8.1.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `penyewaan_mobil`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `jenis_mobil`
--

CREATE TABLE `jenis_mobil` (
  `id` int(10) NOT NULL,
  `jenis_mobil` varchar(100) NOT NULL,
  `created_at` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `jenis_mobil`
--

INSERT INTO `jenis_mobil` (`id`, `jenis_mobil`, `created_at`) VALUES
(1, 'Sedan', '2022-12-19'),
(2, 'Van', '2022-12-15'),
(3, 'SUV', '2022-12-10');

-- --------------------------------------------------------

--
-- Struktur dari tabel `mobil`
--

CREATE TABLE `mobil` (
  `id` int(10) NOT NULL,
  `jenis` int(10) NOT NULL,
  `foto_mobil` text NOT NULL,
  `tipe` varchar(100) NOT NULL,
  `merek` varchar(100) NOT NULL,
  `jumlah` int(10) NOT NULL,
  `harga_sewa` varchar(20) NOT NULL,
  `tahun_pembuatan` year(4) NOT NULL,
  `tanggal_data_masuk` date NOT NULL,
  `status_sewa` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `mobil`
--

INSERT INTO `mobil` (`id`, `jenis`, `foto_mobil`, `tipe`, `merek`, `jumlah`, `harga_sewa`, `tahun_pembuatan`, `tanggal_data_masuk`, `status_sewa`) VALUES
(9, 2, 'C:/Users/Fazril/source/repos/sistem_penyewaan_mobil/gambar/bg.jpg', 'KU32', 'toyota', 1, '320000', 2019, '2022-06-27', 'Dipinjam');

-- --------------------------------------------------------

--
-- Struktur dari tabel `penyewa`
--

CREATE TABLE `penyewa` (
  `id_penyewa` int(10) NOT NULL,
  `nama` varchar(100) NOT NULL,
  `nik` varchar(16) NOT NULL,
  `alamat` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `penyewa`
--

INSERT INTO `penyewa` (`id_penyewa`, `nama`, `nik`, `alamat`) VALUES
(8, 'jumaidisdfdsf', '21232321', 'lorem ipsum'),
(9, 'asep', '232323', 'jalanan');

-- --------------------------------------------------------

--
-- Struktur dari tabel `sewa`
--

CREATE TABLE `sewa` (
  `id` int(10) NOT NULL,
  `merek` int(10) NOT NULL,
  `penyewa` int(10) NOT NULL,
  `rencana_pinjam` int(10) NOT NULL,
  `tanggal_pinjam` date NOT NULL,
  `tanggal_kembali` date DEFAULT NULL,
  `total_biaya_sewa` varchar(100) DEFAULT NULL,
  `biaya_kelebihan_pinjam` varchar(100) DEFAULT NULL,
  `total_bayar` varchar(100) DEFAULT NULL,
  `status_sewa` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `sewa`
--

INSERT INTO `sewa` (`id`, `merek`, `penyewa`, `rencana_pinjam`, `tanggal_pinjam`, `tanggal_kembali`, `total_biaya_sewa`, `biaya_kelebihan_pinjam`, `total_bayar`, `status_sewa`) VALUES
(16, 9, 8, 3, '2023-01-10', NULL, '960000', '0', '960000', 'Pinjam');

-- --------------------------------------------------------

--
-- Struktur dari tabel `users`
--

CREATE TABLE `users` (
  `id` int(10) NOT NULL,
  `username` varchar(100) NOT NULL,
  `email` varchar(100) NOT NULL,
  `password` varchar(255) NOT NULL,
  `foto` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `users`
--

INSERT INTO `users` (`id`, `username`, `email`, `password`, `foto`) VALUES
(4, '1', '1', 'c4ca4238a0b923820dcc509a6f75849b', 'C:/Users/Fazril/source/repos/sistem_penyewaan_mobil/gambar/shine-girl-writing-in-a-notebook.png'),
(5, 'q', 'q@gmail.com', 'c4ca4238a0b923820dcc509a6f75849b', 'C:/Users/Fazril/source/repos/sistem_penyewaan_mobil/gambar/sammy-man-thinks.png'),
(6, 'qwerty', 'qwerty@gmail.com', 'd8578edf8458ce06fbc5bb76a58c5ca4', 'C:/Users/Fazril/source/repos/sistem_penyewaan_mobil/gambar/sammy-man-thinks.png');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `jenis_mobil`
--
ALTER TABLE `jenis_mobil`
  ADD PRIMARY KEY (`id`);

--
-- Indeks untuk tabel `mobil`
--
ALTER TABLE `mobil`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_jenismobil` (`jenis`);

--
-- Indeks untuk tabel `penyewa`
--
ALTER TABLE `penyewa`
  ADD PRIMARY KEY (`id_penyewa`);

--
-- Indeks untuk tabel `sewa`
--
ALTER TABLE `sewa`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_merek` (`merek`),
  ADD KEY `fk_penyewa` (`penyewa`);

--
-- Indeks untuk tabel `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `jenis_mobil`
--
ALTER TABLE `jenis_mobil`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT untuk tabel `mobil`
--
ALTER TABLE `mobil`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT untuk tabel `penyewa`
--
ALTER TABLE `penyewa`
  MODIFY `id_penyewa` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;


--
-- AUTO_INCREMENT untuk tabel `sewa`
--
ALTER TABLE `sewa`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT untuk tabel `users`
--
ALTER TABLE `users`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;


--
-- Ketidakleluasaan untuk tabel pelimpahan (Dumped Tables)
--

--
-- Ketidakleluasaan untuk tabel `mobil`
--
ALTER TABLE `mobil`
  ADD CONSTRAINT `fk_jenismobil` FOREIGN KEY (`jenis`) REFERENCES `jenis_mobil` (`id`);

--
-- Ketidakleluasaan untuk tabel `sewa`
--
ALTER TABLE `sewa`
  ADD CONSTRAINT `fk_merek` FOREIGN KEY (`merek`) REFERENCES `mobil` (`id`),
  ADD CONSTRAINT `fk_penyewa` FOREIGN KEY (`penyewa`) REFERENCES `penyewa` (`id_penyewa`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
