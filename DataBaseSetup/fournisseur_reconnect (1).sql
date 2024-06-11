-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : mar. 11 juin 2024 à 15:56
-- Version du serveur : 8.3.0
-- Version de PHP : 8.2.18

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `fournisseur_reconnect`
--

-- --------------------------------------------------------

--
-- Structure de la table `accessoire`
--

DROP TABLE IF EXISTS `accessoire`;
CREATE TABLE IF NOT EXISTS `accessoire` (
  `idAccessoire` int NOT NULL,
  `idTypeAccessoire` int NOT NULL,
  `idMarqueAccessoire` int NOT NULL,
  `nomAccessoire` varchar(150) NOT NULL,
  PRIMARY KEY (`idAccessoire`),
  KEY `FK_idTypeAccessoire` (`idTypeAccessoire`),
  KEY `FK_idMarqueAccessoire` (`idMarqueAccessoire`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Structure de la table `accessoire_fourni`
--

DROP TABLE IF EXISTS `accessoire_fourni`;
CREATE TABLE IF NOT EXISTS `accessoire_fourni` (
  `idFournisseur` int NOT NULL,
  `idAccessoire` int NOT NULL,
  `Prix` float NOT NULL,
  `siteAccessoireFourni` varchar(2000) NOT NULL,
  PRIMARY KEY (`idFournisseur`,`idAccessoire`),
  KEY `FK_idAccessoire` (`idAccessoire`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Structure de la table `appareil`
--

DROP TABLE IF EXISTS `appareil`;
CREATE TABLE IF NOT EXISTS `appareil` (
  `idAppareil` int NOT NULL,
  `modele` varchar(150) NOT NULL,
  `idMarqueAppareil` int NOT NULL,
  `idTypeAppareil` int NOT NULL,
  `StockageAppareil` int NOT NULL,
  `Neuf` bit(1) NOT NULL,
  PRIMARY KEY (`idAppareil`),
  KEY `FK_MarqueAppareil` (`idMarqueAppareil`),
  KEY `FK_TypeAppareil` (`idTypeAppareil`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `appareil`
--

INSERT INTO `appareil` (`idAppareil`, `modele`, `idMarqueAppareil`, `idTypeAppareil`, `StockageAppareil`, `Neuf`) VALUES
(11, 'Iphone 14 Plus', 1, 1, 256, b'1'),
(10, 'Iphone 14', 1, 1, 512, b'1'),
(9, 'Iphone 14', 1, 1, 256, b'1'),
(8, 'Iphone 14', 1, 1, 128, b'1'),
(6, 'Iphone 12', 1, 1, 64, b'1'),
(7, 'Iphone 13', 1, 1, 512, b'1'),
(5, 'Iphone 12', 1, 1, 128, b'1'),
(4, 'Iphone 11', 1, 1, 64, b'1'),
(2, 'Iphone 13', 1, 1, 256, b'1'),
(3, 'Iphone 11', 1, 1, 128, b'1'),
(1, 'Iphone 13', 1, 1, 128, b'1'),
(12, 'Iphone 14 Pro', 1, 1, 128, b'1'),
(13, 'Iphone 14 Pro', 1, 1, 512, b'1'),
(14, 'Iphone 15', 1, 1, 256, b'1'),
(15, 'Iphone 15 Plus', 1, 1, 128, b'1'),
(16, 'Iphone 15 Plus', 1, 1, 256, b'1'),
(17, 'Iphone 15 Pro', 1, 1, 128, b'1'),
(18, 'Iphone 15 Pro', 1, 1, 256, b'1'),
(19, 'Iphone SE 2022 5G', 1, 1, 64, b'1'),
(20, 'Iphone XR', 1, 1, 64, b'1'),
(21, 'Iphone 15 Pro Max', 1, 1, 1000, b'1'),
(22, 'Iphone 15 Pro Max', 1, 1, 512, b'1'),
(23, 'Iphone 15 Pro Max', 1, 1, 256, b'1'),
(24, 'Iphone 15 Plus', 1, 1, 512, b'1'),
(25, 'Iphone 15', 1, 1, 512, b'1'),
(26, 'Iphone 15', 1, 1, 128, b'1'),
(27, 'Galaxy S24 Ultra 5G', 2, 1, 256, b'1'),
(28, 'Galaxy S24 Plus 5G', 2, 1, 512, b'1'),
(29, 'Galaxy S24 Plus 5G', 2, 1, 256, b'1'),
(30, 'Galaxy Z Flip5 5G', 2, 1, 512, b'1'),
(31, 'Galaxy S24 5G', 2, 1, 256, b'1'),
(32, 'Galaxy S24 5G', 2, 1, 128, b'1'),
(33, 'Galaxy S23 5G', 2, 1, 256, b'1'),
(34, 'Galaxy A55 5G', 2, 1, 256, b'1'),
(35, 'Galaxy A55 5G', 2, 1, 128, b'1'),
(36, 'Galaxy A54 5G', 2, 1, 128, b'1'),
(37, 'Galaxy A35 5G', 2, 1, 128, b'1'),
(38, 'Galaxy A25 5G', 2, 1, 256, b'1'),
(39, 'Galaxy A25 5G', 2, 1, 128, b'1'),
(40, 'Galaxy A15 5G', 2, 1, 128, b'1'),
(41, 'Galaxy A24', 2, 1, 128, b'1'),
(42, 'Galaxy A23', 2, 1, 128, b'1'),
(43, 'Galaxy A14 5G', 2, 1, 128, b'1'),
(44, 'Galaxy A15', 2, 1, 128, b'1'),
(45, 'Galaxy A03', 2, 1, 128, b'1'),
(46, 'Galaxy A04S', 2, 1, 64, b'1'),
(47, 'Galaxy A05S', 2, 1, 128, b'1'),
(48, 'Redmi Note 11', 3, 1, 64, b'1'),
(49, 'Redmi 13C', 3, 1, 128, b'1'),
(50, 'Redmi A3', 3, 1, 128, b'1'),
(51, 'Redmi A3', 3, 1, 64, b'1'),
(52, 'Redmi A1 Plus', 3, 1, 32, b'1'),
(53, 'Redmi A2', 3, 1, 32, b'1'),
(54, 'Redmi A1', 3, 1, 32, b'1'),
(55, 'X2 8+', 6, 1, 128, b'1'),
(56, 'Narzo 50 5G', 6, 1, 128, b'1'),
(57, 'Realme X50 5G', 6, 1, 128, b'1'),
(58, 'Narzo 30 5G', 6, 1, 128, b'1'),
(59, '8 5G', 6, 1, 128, b'1'),
(60, '7 5G', 6, 1, 128, b'1'),
(61, '9 5G', 6, 1, 128, b'1'),
(62, 'Narzo 50', 6, 1, 128, b'1'),
(63, '7', 6, 1, 128, b'1'),
(64, '5 Pro', 6, 1, 128, b'1'),
(65, '6', 6, 1, 128, b'1'),
(66, '9 5G', 6, 1, 64, b'1'),
(67, 'C3', 6, 1, 64, b'1'),
(68, '7 i', 6, 1, 64, b'1'),
(69, 'Narzo A3', 6, 1, 64, b'1'),
(70, '5 i', 6, 1, 64, b'1'),
(71, 'C30', 6, 1, 32, b'1'),
(72, 'A76', 7, 1, 128, b'1'),
(73, 'A54 5G', 7, 1, 64, b'1'),
(74, 'Blackview BV6200', 8, 1, 64, b'1'),
(75, 'A52 Pro', 8, 1, 128, b'1'),
(76, 'Moto E32S', 9, 1, 32, b'1'),
(77, 'A14 5G', 9, 1, 54, b'1'),
(78, 'A54 5G', 9, 1, 128, b'1'),
(79, 'A17', 7, 1, 64, b'1'),
(80, 'Galaxy Z Fold 5 5G', 2, 1, 256, b'1'),
(81, 'Galaxy XCover 6 Pro', 2, 1, 128, b'1'),
(82, 'Galaxy A34 5G', 2, 1, 128, b'1'),
(83, 'Galaxy A03 Core', 2, 1, 32, b'1'),
(84, 'Galaxy A03s', 2, 1, 32, b'1'),
(85, 'Galaxy A03s', 2, 1, 64, b'1'),
(86, 'Galaxy A04', 2, 1, 32, b'1'),
(87, 'Galaxy A04', 2, 1, 64, b'1'),
(88, 'Galaxy A04S', 2, 1, 32, b'1'),
(89, 'Galaxy A13 5G', 2, 1, 128, b'1'),
(90, 'Galaxy A13', 2, 1, 32, b'1'),
(91, 'Galaxy A14', 2, 1, 128, b'1'),
(92, 'Galaxy A14', 2, 1, 64, b'1'),
(93, 'Galaxy A14 5G', 2, 1, 64, b'1'),
(94, 'Galaxy A23 5G', 2, 1, 128, b'1'),
(95, 'Galaxy A23 5G', 2, 1, 64, b'1'),
(96, 'Galaxy A33 5G', 2, 1, 128, b'1'),
(97, 'Galaxy A8', 2, 1, 32, b'1'),
(98, 'Galaxy A53 5G', 2, 1, 128, b'1'),
(99, 'Galaxy Z Flip 3 5G', 2, 1, 128, b'1'),
(100, 'Galaxy Z Flip 4 5G', 2, 1, 128, b'1'),
(101, 'Galaxy Z Flip 5 5G', 2, 1, 256, b'1'),
(102, 'Galaxy Z Fold 4 5G', 2, 1, 256, b'1'),
(103, 'Galaxy Xcover 5', 2, 1, 64, b'1'),
(104, 'Galaxy Xcover 7 5G Edition Entreprise', 2, 1, 128, b'1'),
(105, 'Galaxy Xcover 6 Pro', 2, 1, 128, b'1'),
(106, 'Galaxy S20 FE', 2, 1, 128, b'1'),
(107, 'Galaxy S20 Plus', 2, 1, 128, b'1'),
(108, 'Galaxy S21 FE 5G', 2, 1, 128, b'1'),
(109, 'Galaxy S21 5G', 2, 1, 256, b'1'),
(110, 'Galaxy S21 5G', 2, 1, 128, b'1'),
(111, 'Galaxy S23 FE 5G', 2, 1, 128, b'1'),
(112, 'Galaxy S22 5G', 2, 1, 128, b'1'),
(113, 'Galaxy S23 5G', 2, 1, 128, b'1'),
(114, 'Galaxy S23 Plus 5G', 2, 1, 256, b'1'),
(115, 'Galaxy S23 Plus 5G', 2, 1, 512, b'1'),
(116, 'Galaxy S23 Ultra 5G', 2, 1, 256, b'1'),
(117, 'Galaxy S24', 2, 1, 128, b'1'),
(118, 'Galaxy S24', 2, 1, 256, b'1');

-- --------------------------------------------------------

--
-- Structure de la table `appareil_fourni`
--

DROP TABLE IF EXISTS `appareil_fourni`;
CREATE TABLE IF NOT EXISTS `appareil_fourni` (
  `idFournisseur` int NOT NULL,
  `idAppareil` int NOT NULL,
  `Prix` float NOT NULL,
  `siteAppareilFourni` varchar(2000) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`idFournisseur`,`idAppareil`),
  KEY `FK_idAppareil` (`idAppareil`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `appareil_fourni`
--

INSERT INTO `appareil_fourni` (`idFournisseur`, `idAppareil`, `Prix`, `siteAppareilFourni`) VALUES
(2, 9, 0, 'https://www.hemfrance.com/fr/mobiles-et-smartphones-neufs/11736-iphone-14-61-256-go-6-go-ram-lumiere-stellaire'),
(1, 2, 0, 'https://esmovil.es/inicio-sesion?back=my-account'),
(2, 4, 0, 'https://www.hemfrance.com/fr/mobiles-et-smartphones-neufs/10079-iphone-11-64go-noir'),
(2, 3, 0, 'https://www.hemfrance.com/fr/mobiles-et-smartphones-neufs/10142-iphone-11-128go-noir'),
(2, 5, 0, 'https://www.hemfrance.com/fr/mobiles-et-smartphones-neufs/10743-iphone-12-61-128-go-noir'),
(2, 6, 0, 'https://www.hemfrance.com/fr/mobiles-et-smartphones-neufs/10998-iphone-12-61-64go-blanc'),
(2, 1, 0, 'https://www.hemfrance.com/fr/mobiles-et-smartphones-neufs/11235-iphone-13-61-128-go-4-go-ram-noir'),
(2, 7, 0, 'https://www.hemfrance.com/fr/mobiles-et-smartphones-neufs/11392-iphone-13-61-128-go-4-go-ram-bleu'),
(2, 8, 0, 'https://www.hemfrance.com/fr/mobiles-et-smartphones-neufs/11672-iphone-14-61-128-go-6-go-ram-minuit'),
(1, 1, 0, 'https://esmovil.es/inicio-sesion?back=my-account'),
(2, 10, 0, 'https://www.hemfrance.com/fr/mobiles-et-smartphones-neufs/12329-iphone-14-61-512-go-6-go-ram-minuit'),
(2, 11, 0, 'https://www.hemfrance.com/fr/mobiles-et-smartphones-neufs/11818-iphone-14-plus-67-256-go-6-go-ram-minuit'),
(2, 12, 0, 'https://www.hemfrance.com/fr/mobiles-et-smartphones-neufs/11747-iphone-14-pro-61-128-go-6-go-ram-noir-sideral'),
(2, 13, 0, 'https://www.hemfrance.com/fr/mobiles-et-smartphones-neufs/12083-iphone-14-pro-61-512-go-6-go-ram-noir-sideral');

-- --------------------------------------------------------

--
-- Structure de la table `fournisseur`
--

DROP TABLE IF EXISTS `fournisseur`;
CREATE TABLE IF NOT EXISTS `fournisseur` (
  `idFournisseur` int NOT NULL,
  `nomFournisseur` varchar(150) NOT NULL,
  `siteFournisseur` varchar(500) NOT NULL,
  PRIMARY KEY (`idFournisseur`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `fournisseur`
--

INSERT INTO `fournisseur` (`idFournisseur`, `nomFournisseur`, `siteFournisseur`) VALUES
(4, 'Spectrum', 'https://www.spectrum-international.fr/'),
(3, 'LCD-Phone', 'https://lcd-phone.com/fr/'),
(1, 'Esmovil', 'https://esmovil.es/fr/'),
(2, 'HemFrance', 'https://www.hemfrance.com/fr/'),
(5, 'Prodealee', 'https://prodealee-retail.com/'),
(6, 'GPdis', 'https://www.gpdis.com/'),
(7, 'M2M', 'https://www.m2mlease.fr/'),
(8, 'ReparGSM', 'https://repargsm.com/fr/');

-- --------------------------------------------------------

--
-- Structure de la table `marque`
--

DROP TABLE IF EXISTS `marque`;
CREATE TABLE IF NOT EXISTS `marque` (
  `idMarque` int NOT NULL,
  `nomMarque` varchar(150) NOT NULL,
  PRIMARY KEY (`idMarque`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `marque`
--

INSERT INTO `marque` (`idMarque`, `nomMarque`) VALUES
(1, 'Apple'),
(2, 'Samsung'),
(4, 'Huawei'),
(3, 'Xiaomi'),
(5, 'Honor'),
(6, 'Realme'),
(7, 'Oppo'),
(8, 'Blackview'),
(9, 'Motorola');

-- --------------------------------------------------------

--
-- Structure de la table `objetconnecte`
--

DROP TABLE IF EXISTS `objetconnecte`;
CREATE TABLE IF NOT EXISTS `objetconnecte` (
  `idObjetConnecte` int NOT NULL,
  `idMarqueObjetCo` varchar(150) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `modeleObjetCo` varchar(150) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `idTypeObjetCo` varchar(150) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`idObjetConnecte`),
  KEY `FK_TypeObjetCo` (`idTypeObjetCo`),
  KEY `FK_Marque` (`idMarqueObjetCo`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Structure de la table `objetconnecte_fourni`
--

DROP TABLE IF EXISTS `objetconnecte_fourni`;
CREATE TABLE IF NOT EXISTS `objetconnecte_fourni` (
  `idObjetConnecte` int NOT NULL,
  `idFournisseur` int NOT NULL,
  `Prix` float NOT NULL,
  `siteObjetCoFourni` varchar(2000) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Structure de la table `piecedetachee`
--

DROP TABLE IF EXISTS `piecedetachee`;
CREATE TABLE IF NOT EXISTS `piecedetachee` (
  `idPieceDetachee` int NOT NULL,
  `idTypePieceDetachee` int NOT NULL,
  `nomModeleAppareil` varchar(150) NOT NULL,
  `nomPieceDetachee` varchar(150) NOT NULL,
  PRIMARY KEY (`idPieceDetachee`),
  KEY `FK_idTypePieceDetachee` (`idTypePieceDetachee`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Structure de la table `piecedetachee_fournie`
--

DROP TABLE IF EXISTS `piecedetachee_fournie`;
CREATE TABLE IF NOT EXISTS `piecedetachee_fournie` (
  `idFournisseur` int NOT NULL,
  `idPieceDetachee` int NOT NULL,
  `Prix` float NOT NULL,
  `sitePieceDetacheeFourni` varchar(2000) NOT NULL,
  PRIMARY KEY (`idFournisseur`,`idPieceDetachee`),
  KEY `FK_idPieceDetachee` (`idPieceDetachee`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Structure de la table `typeaccessoire`
--

DROP TABLE IF EXISTS `typeaccessoire`;
CREATE TABLE IF NOT EXISTS `typeaccessoire` (
  `idTypeAccessoire` int NOT NULL,
  `libelleTypeAccessoire` varchar(150) NOT NULL,
  PRIMARY KEY (`idTypeAccessoire`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `typeaccessoire`
--

INSERT INTO `typeaccessoire` (`idTypeAccessoire`, `libelleTypeAccessoire`) VALUES
(1, 'Chargeur'),
(2, 'Coque');

-- --------------------------------------------------------

--
-- Structure de la table `typeappareil`
--

DROP TABLE IF EXISTS `typeappareil`;
CREATE TABLE IF NOT EXISTS `typeappareil` (
  `idTypeAppareil` int NOT NULL,
  `libelleTypeAppareil` varchar(150) NOT NULL,
  PRIMARY KEY (`idTypeAppareil`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `typeappareil`
--

INSERT INTO `typeappareil` (`idTypeAppareil`, `libelleTypeAppareil`) VALUES
(1, 'Smartphone'),
(2, 'Tablette'),
(3, 'Ordinateur Portable');

-- --------------------------------------------------------

--
-- Structure de la table `typeobjetco`
--

DROP TABLE IF EXISTS `typeobjetco`;
CREATE TABLE IF NOT EXISTS `typeobjetco` (
  `idTypeObjetCo` int NOT NULL,
  `libelleTypeObjetCo` varchar(150) NOT NULL,
  PRIMARY KEY (`idTypeObjetCo`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `typeobjetco`
--

INSERT INTO `typeobjetco` (`idTypeObjetCo`, `libelleTypeObjetCo`) VALUES
(1, 'Montre Connectée'),
(2, 'Enceinte Connectée');

-- --------------------------------------------------------

--
-- Structure de la table `typepiecedetachee`
--

DROP TABLE IF EXISTS `typepiecedetachee`;
CREATE TABLE IF NOT EXISTS `typepiecedetachee` (
  `idTypePieceDetachee` int NOT NULL,
  `libelleTypePiece` varchar(150) NOT NULL,
  PRIMARY KEY (`idTypePieceDetachee`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `typepiecedetachee`
--

INSERT INTO `typepiecedetachee` (`idTypePieceDetachee`, `libelleTypePiece`) VALUES
(1, 'Lentille de caméra'),
(2, 'Batterie');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
