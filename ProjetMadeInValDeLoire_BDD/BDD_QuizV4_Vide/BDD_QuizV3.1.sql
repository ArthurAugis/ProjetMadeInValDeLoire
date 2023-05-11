-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Hôte : localhost
-- Généré le : jeu. 11 mai 2023 à 13:42
-- Version du serveur : 10.5.18-MariaDB-0+deb11u1
-- Version de PHP : 7.4.33

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `BDD_QuizV3.1`
--
DROP DATABASE IF EXISTS `BDD_QuizV3.1`;
CREATE DATABASE IF NOT EXISTS `BDD_QuizV3.1` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `BDD_QuizV3.1`;

-- --------------------------------------------------------

--
-- Structure de la table `difficulte`
--

DROP TABLE IF EXISTS `difficulte`;
CREATE TABLE IF NOT EXISTS `difficulte` (
  `CLP_difficulte` tinyint(4) NOT NULL AUTO_INCREMENT COMMENT 'ClÃ© primaire de la table difficulte',
  `nom_diff` varchar(16) NOT NULL COMMENT 'Nom de la difficulte',
  PRIMARY KEY (`CLP_difficulte`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Structure de la table `questions`
--

DROP TABLE IF EXISTS `questions`;
CREATE TABLE IF NOT EXISTS `questions` (
  `CLP_question` tinyint(4) NOT NULL AUTO_INCREMENT COMMENT 'ClÃ© primaire de la table question',
  `question` varchar(64) NOT NULL COMMENT 'la question de la table question',
  PRIMARY KEY (`CLP_question`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Structure de la table `quiz`
--

DROP TABLE IF EXISTS `quiz`;
CREATE TABLE IF NOT EXISTS `quiz` (
  `CLP_quiz` tinyint(4) NOT NULL AUTO_INCREMENT COMMENT 'ClÃ© quiz',
  `titre_quiz` varchar(32) NOT NULL COMMENT 'nom du quiz',
  `difficulte` tinyint(4) NOT NULL COMMENT 'difficulte du quiz',
  PRIMARY KEY (`CLP_quiz`),
  KEY `difficulte` (`difficulte`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Structure de la table `repondre`
--

DROP TABLE IF EXISTS `repondre`;
CREATE TABLE IF NOT EXISTS `repondre` (
  `CLE_question` tinyint(4) NOT NULL COMMENT 'cle question',
  `CLE_reponse` tinyint(4) NOT NULL COMMENT 'cle reponse',
  `good_rep` tinyint(1) NOT NULL COMMENT 'revoie vrai ou faux a la reponse',
  PRIMARY KEY (`CLE_question`,`CLE_reponse`),
  KEY `CLE_reponse` (`CLE_reponse`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Structure de la table `reponse`
--

DROP TABLE IF EXISTS `reponse`;
CREATE TABLE IF NOT EXISTS `reponse` (
  `CLP_reponse` tinyint(4) NOT NULL AUTO_INCREMENT COMMENT 'ClÃ© reponse',
  `reponse` varchar(64) NOT NULL COMMENT 'la reponse',
  PRIMARY KEY (`CLP_reponse`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Structure de la table `score`
--

DROP TABLE IF EXISTS `score`;
CREATE TABLE IF NOT EXISTS `score` (
  `CLE_login` varchar(32) NOT NULL COMMENT 'ClÃ© login',
  `CLE_quiz` tinyint(4) NOT NULL AUTO_INCREMENT COMMENT 'ClÃ© quiz',
  `score` tinyint(4) NOT NULL COMMENT 'Score du joueur',
  PRIMARY KEY (`CLE_login`,`CLE_quiz`),
  KEY `CLE_quiz` (`CLE_quiz`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Structure de la table `utilisateur`
--

DROP TABLE IF EXISTS `utilisateur`;
CREATE TABLE IF NOT EXISTS `utilisateur` (
  `login` varchar(32) NOT NULL COMMENT 'ClÃ© primaire de la table login',
  `nom` varchar(16) NOT NULL COMMENT 'nom de l utilisateur',
  `password` varchar(200) NOT NULL COMMENT 'mot de passe',
  `prenom` varchar(16) DEFAULT NULL COMMENT 'prenom de l utilisateur',
  PRIMARY KEY (`login`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Structure de la table `verifier`
--

DROP TABLE IF EXISTS `verifier`;
CREATE TABLE IF NOT EXISTS `verifier` (
  `CLE_quiz` tinyint(4) NOT NULL COMMENT 'ClÃ© quiz',
  `CLE_question` tinyint(4) NOT NULL COMMENT 'ClÃ© question',
  PRIMARY KEY (`CLE_quiz`,`CLE_question`),
  KEY `CLE_question` (`CLE_question`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `quiz`
--
ALTER TABLE `quiz`
  ADD CONSTRAINT `quiz_ibfk_1` FOREIGN KEY (`difficulte`) REFERENCES `difficulte` (`CLP_difficulte`);

--
-- Contraintes pour la table `repondre`
--
ALTER TABLE `repondre`
  ADD CONSTRAINT `repondre_ibfk_1` FOREIGN KEY (`CLE_reponse`) REFERENCES `reponse` (`CLP_reponse`),
  ADD CONSTRAINT `repondre_ibfk_2` FOREIGN KEY (`CLE_question`) REFERENCES `questions` (`CLP_question`);

--
-- Contraintes pour la table `score`
--
ALTER TABLE `score`
  ADD CONSTRAINT `Score_ibfk_1` FOREIGN KEY (`CLE_login`) REFERENCES `utilisateur` (`login`),
  ADD CONSTRAINT `Score_ibfk_2` FOREIGN KEY (`CLE_quiz`) REFERENCES `quiz` (`CLP_quiz`);

--
-- Contraintes pour la table `verifier`
--
ALTER TABLE `verifier`
  ADD CONSTRAINT `Verifier_ibfk_1` FOREIGN KEY (`CLE_quiz`) REFERENCES `quiz` (`CLP_quiz`),
  ADD CONSTRAINT `Verifier_ibfk_2` FOREIGN KEY (`CLE_question`) REFERENCES `questions` (`CLP_question`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
