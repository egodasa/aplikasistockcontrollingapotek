-- Adminer 4.6.2 MySQL dump

SET NAMES utf8;
SET time_zone = '+00:00';
SET foreign_key_checks = 0;
SET sql_mode = 'NO_AUTO_VALUE_ON_ZERO';

DROP VIEW IF EXISTS `daftar_obat`;
CREATE TABLE `daftar_obat` (`Id_Obat` int(11), `Nama_Obat` varchar(50), `Stok` int(11), `Id_Jobat` int(11), `Jenis_Obat` varchar(50), `Id_Sat_Obat` int(11), `Satuan` varchar(30), `Harga_Obat` int(11));


DROP VIEW IF EXISTS `daftar_obat_beli`;
CREATE TABLE `daftar_obat_beli` (`Id_Transaksi` varchar(50), `Id_Obat` int(11), `Nama_Obat` varchar(50), `Jumlah` decimal(32,0), `Harga_Obat` int(11), `Total_Harga` decimal(42,0));


DROP VIEW IF EXISTS `daftar_pembelian`;
CREATE TABLE `daftar_pembelian` (`Id_Pembelian` varchar(50), `Tanggal_Pembelian` varchar(72), `Jumlah` decimal(32,0), `Total_Harga` decimal(32,0));


DROP VIEW IF EXISTS `daftar_satuan`;
CREATE TABLE `daftar_satuan` (`Id_Sat` int(11), `Nama_Satuan` varchar(30), `Id_Jsat` int(11), `Nama_Jenis_Satuan` varchar(30));


DROP VIEW IF EXISTS `daftar_transaksi`;
CREATE TABLE `daftar_transaksi` (`Id_Transaksi` varchar(50), `Tanggal_Transaksi` varchar(72), `Jumlah` decimal(54,0), `Total_Harga` decimal(64,0));


DROP VIEW IF EXISTS `laporan_detail_pembelian`;
CREATE TABLE `laporan_detail_pembelian` (`id_obat` int(11), `id_detail` int(11), `id_pemasok` int(11), `id_pembelian` varchar(50), `Nama_Obat` varchar(50), `jumlah` int(11), `harga` int(11), `Satuan` varchar(30), `Nama_Pemasok` varchar(100));


DROP VIEW IF EXISTS `laporan_detail_transaksi`;
CREATE TABLE `laporan_detail_transaksi` (`Id_Transaksi` varchar(50), `Id_Obat` int(11), `Nama_Obat` varchar(50), `Harga_Obat` int(11), `Jumlah` int(11), `Total` bigint(21), `Satuan` varchar(30));


DROP VIEW IF EXISTS `laporan_pemasok`;
CREATE TABLE `laporan_pemasok` (`id_pemasok` int(11), `Nama_Pemasok` varchar(100), `Alamat` varchar(200), `Nomor_Telepon` varchar(20));


DROP VIEW IF EXISTS `laporan_pemasukan`;
CREATE TABLE `laporan_pemasukan` (`tgl_transaksi` datetime, `Id_Transaksi` varchar(50), `Nama_Obat` varchar(50), `Jumlah` decimal(32,0), `Total_Harga` decimal(42,0));


DROP VIEW IF EXISTS `lap_bulanan`;
CREATE TABLE `lap_bulanan` (`hari` int(2), `Jumlah` decimal(54,0), `Total_Harga` decimal(64,0));


DROP VIEW IF EXISTS `lap_harian`;
CREATE TABLE `lap_harian` (`tgl_transaksi` datetime, `Nama_Obat` varchar(50), `Jumlah` decimal(54,0), `Total_Harga` decimal(64,0));


DROP VIEW IF EXISTS `lap_tahunan`;
CREATE TABLE `lap_tahunan` (`bulan` int(2), `Jumlah` decimal(54,0), `Total_Harga` decimal(64,0));


DROP TABLE IF EXISTS `tbl_detail_pembelian`;
CREATE TABLE `tbl_detail_pembelian` (
  `id_detail` int(11) NOT NULL AUTO_INCREMENT,
  `id_pembelian` varchar(50) NOT NULL,
  `id_obat` int(11) NOT NULL,
  `jumlah` int(11) NOT NULL,
  `harga` int(11) NOT NULL,
  `id_pemasok` int(11) NOT NULL,
  PRIMARY KEY (`id_detail`),
  KEY `id_pembelian` (`id_pembelian`),
  KEY `id_obat` (`id_obat`),
  KEY `id_pemasok` (`id_pemasok`),
  CONSTRAINT `tbl_detail_pembelian_ibfk_1` FOREIGN KEY (`id_obat`) REFERENCES `tbl_obat` (`id_obat`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `tbl_detail_pembelian_ibfk_2` FOREIGN KEY (`id_pemasok`) REFERENCES `tbl_pemasok` (`id_pemasok`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `tbl_detail_pembelian` (`id_detail`, `id_pembelian`, `id_obat`, `jumlah`, `harga`, `id_pemasok`) VALUES
(1,	'2006181158043165',	10,	20,	100000,	1),
(3,	'2006181158043165',	14,	200,	100000,	1),
(6,	'2106181210346578',	9,	300,	1200000,	1)
ON DUPLICATE KEY UPDATE `id_detail` = VALUES(`id_detail`), `id_pembelian` = VALUES(`id_pembelian`), `id_obat` = VALUES(`id_obat`), `jumlah` = VALUES(`jumlah`), `harga` = VALUES(`harga`), `id_pemasok` = VALUES(`id_pemasok`);

DELIMITER ;;

CREATE TRIGGER `tambah_stok_beli` AFTER INSERT ON `tbl_detail_pembelian` FOR EACH ROW
update tbl_obat set stok = stok + NEW.jumlah where id_obat = NEW.id_obat;;

CREATE TRIGGER `kurang_stok_beli` AFTER DELETE ON `tbl_detail_pembelian` FOR EACH ROW
update tbl_obat set stok = stok - OLD.jumlah where id_obat = OLD.id_obat;;

DELIMITER ;

DROP TABLE IF EXISTS `tbl_detail_transaksi`;
CREATE TABLE `tbl_detail_transaksi` (
  `id_detail` int(11) NOT NULL AUTO_INCREMENT,
  `id_obat` int(11) NOT NULL,
  `jumlah` int(11) NOT NULL,
  `id_transaksi` varchar(50) NOT NULL,
  PRIMARY KEY (`id_detail`),
  KEY `id_transaksi` (`id_transaksi`),
  KEY `id_obat` (`id_obat`),
  CONSTRAINT `tbl_detail_transaksi_ibfk_1` FOREIGN KEY (`id_obat`) REFERENCES `tbl_obat` (`id_obat`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `tbl_detail_transaksi` (`id_detail`, `id_obat`, `jumlah`, `id_transaksi`) VALUES
(1,	1,	3,	'100620181115456348'),
(5,	10,	2,	'1006181122392383'),
(6,	1,	2,	'110620181206354178'),
(7,	8,	1,	'110620181214334910'),
(8,	10,	2,	'1806180902007400'),
(9,	10,	0,	'1806180902007400'),
(10,	12,	20,	'1806180902007400'),
(12,	11,	2,	'2106180317125498'),
(13,	12,	2,	'2106180317125498'),
(14,	11,	5,	'2206180933141041')
ON DUPLICATE KEY UPDATE `id_detail` = VALUES(`id_detail`), `id_obat` = VALUES(`id_obat`), `jumlah` = VALUES(`jumlah`), `id_transaksi` = VALUES(`id_transaksi`);

DELIMITER ;;

CREATE TRIGGER `kurangi_stok` AFTER INSERT ON `tbl_detail_transaksi` FOR EACH ROW
update tbl_obat set stok = stok - new.jumlah where id_obat = new.id_obat;;

CREATE TRIGGER `reset_stok` AFTER DELETE ON `tbl_detail_transaksi` FOR EACH ROW
update tbl_obat set stok = stok + OLD.jumlah where id_obat = OLD.id_obat;;

DELIMITER ;

DROP TABLE IF EXISTS `tbl_jenis_obat`;
CREATE TABLE `tbl_jenis_obat` (
  `id_jobat` int(11) NOT NULL AUTO_INCREMENT,
  `nm_jobat` varchar(50) NOT NULL,
  PRIMARY KEY (`id_jobat`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `tbl_jenis_obat` (`id_jobat`, `nm_jobat`) VALUES
(1,	'KB'),
(2,	'Ringan'),
(3,	'Keras'),
(4,	'Suplemen')
ON DUPLICATE KEY UPDATE `id_jobat` = VALUES(`id_jobat`), `nm_jobat` = VALUES(`nm_jobat`);

DROP TABLE IF EXISTS `tbl_jsatuan`;
CREATE TABLE `tbl_jsatuan` (
  `id_jsat` int(11) NOT NULL AUTO_INCREMENT,
  `nm_jsat` varchar(30) NOT NULL,
  PRIMARY KEY (`id_jsat`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `tbl_jsatuan` (`id_jsat`, `nm_jsat`) VALUES
(1,	'Berat'),
(2,	'Panjang'),
(3,	'Waktu'),
(4,	'Banyak'),
(5,	'Tekanan')
ON DUPLICATE KEY UPDATE `id_jsat` = VALUES(`id_jsat`), `nm_jsat` = VALUES(`nm_jsat`);

DROP TABLE IF EXISTS `tbl_obat`;
CREATE TABLE `tbl_obat` (
  `id_obat` int(11) NOT NULL AUTO_INCREMENT,
  `nm_obat` varchar(50) NOT NULL,
  `stok` int(11) NOT NULL,
  `status` enum('Aktif','Tidak Aktif') NOT NULL DEFAULT 'Aktif',
  `id_jobat` int(11) NOT NULL,
  `hrg_obat` int(11) NOT NULL,
  `id_sat_obat` int(11) NOT NULL DEFAULT '25',
  PRIMARY KEY (`id_obat`),
  KEY `id_jobat` (`id_jobat`),
  KEY `id_sat_obat` (`id_sat_obat`),
  CONSTRAINT `tbl_obat_ibfk_1` FOREIGN KEY (`id_jobat`) REFERENCES `tbl_jenis_obat` (`id_jobat`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `tbl_obat_ibfk_2` FOREIGN KEY (`id_sat_obat`) REFERENCES `tbl_satuan` (`id_sat`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `tbl_obat` (`id_obat`, `nm_obat`, `stok`, `status`, `id_jobat`, `hrg_obat`, `id_sat_obat`) VALUES
(1,	'Kabe',	3,	'Aktif',	1,	10000,	25),
(2,	'Ringan',	2,	'Aktif',	2,	1800,	25),
(8,	'Suntik',	3,	'Aktif',	1,	9000,	25),
(9,	'Parasetamol',	307,	'Aktif',	2,	1100,	25),
(10,	'STM',	1,	'Aktif',	2,	1000,	25),
(11,	'Promag',	23,	'Aktif',	2,	2000,	25),
(12,	'Amoxilin',	18,	'Aktif',	2,	3000,	25),
(13,	'Vitamin C',	12,	'Aktif',	2,	12000,	25),
(14,	'sitrizin',	20,	'Aktif',	2,	12000,	23)
ON DUPLICATE KEY UPDATE `id_obat` = VALUES(`id_obat`), `nm_obat` = VALUES(`nm_obat`), `stok` = VALUES(`stok`), `status` = VALUES(`status`), `id_jobat` = VALUES(`id_jobat`), `hrg_obat` = VALUES(`hrg_obat`), `id_sat_obat` = VALUES(`id_sat_obat`);

DROP TABLE IF EXISTS `tbl_pemasok`;
CREATE TABLE `tbl_pemasok` (
  `id_pemasok` int(11) NOT NULL AUTO_INCREMENT,
  `nm_pemasok` varchar(100) NOT NULL,
  `no_telpon` varchar(20) NOT NULL,
  `alamat` varchar(200) NOT NULL,
  PRIMARY KEY (`id_pemasok`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `tbl_pemasok` (`id_pemasok`, `nm_pemasok`, `no_telpon`, `alamat`) VALUES
(1,	'Pemasok 2',	'22222',	'Alamat 2'),
(3,	'Pemasok 5',	'55555',	'Alamat 5')
ON DUPLICATE KEY UPDATE `id_pemasok` = VALUES(`id_pemasok`), `nm_pemasok` = VALUES(`nm_pemasok`), `no_telpon` = VALUES(`no_telpon`), `alamat` = VALUES(`alamat`);

DROP TABLE IF EXISTS `tbl_pembelian`;
CREATE TABLE `tbl_pembelian` (
  `id_pembelian` varchar(50) NOT NULL,
  `tgl_pembelian` datetime NOT NULL,
  PRIMARY KEY (`id_pembelian`),
  CONSTRAINT `tbl_pembelian_ibfk_1` FOREIGN KEY (`id_pembelian`) REFERENCES `tbl_detail_pembelian` (`id_pembelian`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `tbl_pembelian` (`id_pembelian`, `tgl_pembelian`) VALUES
('2006181158043165',	'2018-06-20 11:59:15')
ON DUPLICATE KEY UPDATE `id_pembelian` = VALUES(`id_pembelian`), `tgl_pembelian` = VALUES(`tgl_pembelian`);

DROP TABLE IF EXISTS `tbl_pengguna`;
CREATE TABLE `tbl_pengguna` (
  `id_pengguna` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(15) NOT NULL,
  `password` text NOT NULL,
  `nm_lengkap` varchar(100) NOT NULL,
  `jenis` enum('Admin','Apoteker','Pimpinan') NOT NULL,
  PRIMARY KEY (`id_pengguna`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `tbl_pengguna` (`id_pengguna`, `username`, `password`, `nm_lengkap`, `jenis`) VALUES
(1,	'apoteker',	'326dd0e9d42a3da01b50028c51cf21fc',	'apoteker',	'Apoteker'),
(4,	'admin',	'21232f297a57a5a743894a0e4a801fc3',	'admin',	'Admin'),
(5,	'pimpinan',	'90973652b88fe07d05a4304f0a945de8',	'pimpinan',	'Pimpinan')
ON DUPLICATE KEY UPDATE `id_pengguna` = VALUES(`id_pengguna`), `username` = VALUES(`username`), `password` = VALUES(`password`), `nm_lengkap` = VALUES(`nm_lengkap`), `jenis` = VALUES(`jenis`);

DROP TABLE IF EXISTS `tbl_satuan`;
CREATE TABLE `tbl_satuan` (
  `id_sat` int(11) NOT NULL AUTO_INCREMENT,
  `nm_sat` varchar(30) NOT NULL,
  `id_jsat` int(11) NOT NULL,
  PRIMARY KEY (`id_sat`),
  KEY `id_jsat` (`id_jsat`),
  CONSTRAINT `tbl_satuan_ibfk_2` FOREIGN KEY (`id_jsat`) REFERENCES `tbl_jsatuan` (`id_jsat`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `tbl_satuan` (`id_sat`, `nm_sat`, `id_jsat`) VALUES
(1,	'Kg',	1),
(2,	'Hg',	1),
(3,	'Dag',	1),
(4,	'Gr',	1),
(5,	'Cg',	1),
(6,	'Mg',	1),
(7,	'Km',	2),
(8,	'Hm',	2),
(9,	'Dam',	2),
(10,	'M',	2),
(11,	'Dm',	2),
(12,	'Cm',	2),
(13,	'Mm',	2),
(14,	'Detik',	3),
(15,	'Menit',	3),
(16,	'Jam',	3),
(17,	'Hari',	3),
(18,	'Minggu',	3),
(19,	'Bulan',	3),
(20,	'Tahun',	3),
(21,	'Dg',	1),
(22,	'Pcs',	4),
(23,	'Lembar',	4),
(24,	'Tablet',	4),
(25,	'Buah',	4),
(26,	'MMHG',	5),
(27,	'Sachet',	4),
(28,	'Botol',	4)
ON DUPLICATE KEY UPDATE `id_sat` = VALUES(`id_sat`), `nm_sat` = VALUES(`nm_sat`), `id_jsat` = VALUES(`id_jsat`);

DROP TABLE IF EXISTS `tbl_transaksi`;
CREATE TABLE `tbl_transaksi` (
  `id_transaksi` varchar(50) NOT NULL,
  `tgl_transaksi` datetime NOT NULL,
  PRIMARY KEY (`id_transaksi`),
  CONSTRAINT `tbl_transaksi_ibfk_1` FOREIGN KEY (`id_transaksi`) REFERENCES `tbl_detail_transaksi` (`id_transaksi`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `tbl_transaksi` (`id_transaksi`, `tgl_transaksi`) VALUES
('2106180317125498',	'2018-06-21 03:17:54'),
('2206180933141041',	'2018-06-22 09:34:17')
ON DUPLICATE KEY UPDATE `id_transaksi` = VALUES(`id_transaksi`), `tgl_transaksi` = VALUES(`tgl_transaksi`);

DROP TABLE IF EXISTS `daftar_obat`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `daftar_obat` AS select `a`.`id_obat` AS `Id_Obat`,`a`.`nm_obat` AS `Nama_Obat`,`a`.`stok` AS `Stok`,`b`.`id_jobat` AS `Id_Jobat`,`b`.`nm_jobat` AS `Jenis_Obat`,`a`.`id_sat_obat` AS `Id_Sat_Obat`,`c`.`Nama_Satuan` AS `Satuan`,`a`.`hrg_obat` AS `Harga_Obat` from ((`tbl_obat` `a` join `tbl_jenis_obat` `b` on((`a`.`id_jobat` = `b`.`id_jobat`))) join `daftar_satuan` `c` on((`a`.`id_sat_obat` = `c`.`Id_Sat`)));

DROP TABLE IF EXISTS `daftar_obat_beli`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `daftar_obat_beli` AS select `a`.`id_transaksi` AS `Id_Transaksi`,`a`.`id_obat` AS `Id_Obat`,`b`.`nm_obat` AS `Nama_Obat`,sum(`a`.`jumlah`) AS `Jumlah`,`b`.`hrg_obat` AS `Harga_Obat`,sum((`b`.`hrg_obat` * `a`.`jumlah`)) AS `Total_Harga` from (`tbl_detail_transaksi` `a` join `tbl_obat` `b` on((`a`.`id_obat` = `b`.`id_obat`))) group by `a`.`id_transaksi`,`a`.`id_obat`;

DROP TABLE IF EXISTS `daftar_pembelian`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `daftar_pembelian` AS select `b`.`id_pembelian` AS `Id_Pembelian`,date_format(`a`.`tgl_pembelian`,'%d-%M-%Y') AS `Tanggal_Pembelian`,sum(`b`.`jumlah`) AS `Jumlah`,sum(`b`.`harga`) AS `Total_Harga` from (`tbl_pembelian` `a` join `laporan_detail_pembelian` `b` on((`a`.`id_pembelian` = `b`.`id_pembelian`))) group by `a`.`id_pembelian` order by `a`.`tgl_pembelian` desc;

DROP TABLE IF EXISTS `daftar_satuan`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `daftar_satuan` AS select `a`.`id_sat` AS `Id_Sat`,`a`.`nm_sat` AS `Nama_Satuan`,`a`.`id_jsat` AS `Id_Jsat`,`b`.`nm_jsat` AS `Nama_Jenis_Satuan` from (`tbl_satuan` `a` join `tbl_jsatuan` `b` on((`a`.`id_jsat` = `b`.`id_jsat`)));

DROP TABLE IF EXISTS `daftar_transaksi`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `daftar_transaksi` AS select `b`.`Id_Transaksi` AS `Id_Transaksi`,date_format(`a`.`tgl_transaksi`,'%d-%M-%Y') AS `Tanggal_Transaksi`,sum(`b`.`Jumlah`) AS `Jumlah`,sum(`b`.`Total_Harga`) AS `Total_Harga` from (`tbl_transaksi` `a` join `daftar_obat_beli` `b` on((`a`.`id_transaksi` = `b`.`Id_Transaksi`))) group by `a`.`id_transaksi` order by `a`.`tgl_transaksi` desc;

DROP TABLE IF EXISTS `laporan_detail_pembelian`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `laporan_detail_pembelian` AS select `a`.`id_obat` AS `id_obat`,`a`.`id_detail` AS `id_detail`,`a`.`id_pemasok` AS `id_pemasok`,`a`.`id_pembelian` AS `id_pembelian`,`b`.`Nama_Obat` AS `Nama_Obat`,`a`.`jumlah` AS `jumlah`,`a`.`harga` AS `harga`,`b`.`Satuan` AS `Satuan`,`c`.`Nama_Pemasok` AS `Nama_Pemasok` from ((`tbl_detail_pembelian` `a` join `daftar_obat` `b` on((`a`.`id_obat` = `b`.`Id_Obat`))) join `laporan_pemasok` `c` on((`a`.`id_pemasok` = `c`.`id_pemasok`)));

DROP TABLE IF EXISTS `laporan_detail_transaksi`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `laporan_detail_transaksi` AS select `a`.`id_transaksi` AS `Id_Transaksi`,`a`.`id_obat` AS `Id_Obat`,`b`.`Nama_Obat` AS `Nama_Obat`,`b`.`Harga_Obat` AS `Harga_Obat`,`a`.`jumlah` AS `Jumlah`,(`a`.`jumlah` * `b`.`Harga_Obat`) AS `Total`,`b`.`Satuan` AS `Satuan` from (`tbl_detail_transaksi` `a` join `daftar_obat` `b` on((`a`.`id_obat` = `b`.`Id_Obat`)));

DROP TABLE IF EXISTS `laporan_pemasok`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `laporan_pemasok` AS select `tbl_pemasok`.`id_pemasok` AS `id_pemasok`,`tbl_pemasok`.`nm_pemasok` AS `Nama_Pemasok`,`tbl_pemasok`.`alamat` AS `Alamat`,`tbl_pemasok`.`no_telpon` AS `Nomor_Telepon` from `tbl_pemasok`;

DROP TABLE IF EXISTS `laporan_pemasukan`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `laporan_pemasukan` AS select `a`.`tgl_transaksi` AS `tgl_transaksi`,`b`.`Id_Transaksi` AS `Id_Transaksi`,`b`.`Nama_Obat` AS `Nama_Obat`,`b`.`Jumlah` AS `Jumlah`,`b`.`Total_Harga` AS `Total_Harga` from (`daftar_obat_beli` `b` join `tbl_transaksi` `a` on((`a`.`id_transaksi` = `b`.`Id_Transaksi`)));

DROP TABLE IF EXISTS `lap_bulanan`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `lap_bulanan` AS select dayofmonth(`laporan_pemasukan`.`tgl_transaksi`) AS `hari`,sum(`laporan_pemasukan`.`Jumlah`) AS `Jumlah`,sum(`laporan_pemasukan`.`Total_Harga`) AS `Total_Harga` from `laporan_pemasukan` where ((month(`laporan_pemasukan`.`tgl_transaksi`) = month(now())) and (year(`laporan_pemasukan`.`tgl_transaksi`) = year(now()))) group by dayofmonth(`laporan_pemasukan`.`tgl_transaksi`);

DROP TABLE IF EXISTS `lap_harian`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `lap_harian` AS select `laporan_pemasukan`.`tgl_transaksi` AS `tgl_transaksi`,`laporan_pemasukan`.`Nama_Obat` AS `Nama_Obat`,sum(`laporan_pemasukan`.`Jumlah`) AS `Jumlah`,sum(`laporan_pemasukan`.`Total_Harga`) AS `Total_Harga` from `laporan_pemasukan` group by `laporan_pemasukan`.`Nama_Obat`;

DROP TABLE IF EXISTS `lap_tahunan`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `lap_tahunan` AS select month(`laporan_pemasukan`.`tgl_transaksi`) AS `bulan`,sum(`laporan_pemasukan`.`Jumlah`) AS `Jumlah`,sum(`laporan_pemasukan`.`Total_Harga`) AS `Total_Harga` from `laporan_pemasukan` where (year(`laporan_pemasukan`.`tgl_transaksi`) = year(now())) group by month(`laporan_pemasukan`.`tgl_transaksi`);

-- 2018-06-22 14:23:23
