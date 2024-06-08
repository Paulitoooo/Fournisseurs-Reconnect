-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : mar. 04 juin 2024 à 11:51
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
(5, 'Honor');

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
