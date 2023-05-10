-- phpMyAdmin SQL Dump
-- version 6.0.0-dev
-- https://www.phpmyadmin.net/
--
-- Hôte : 192.168.30.23
-- Généré le : mer. 10 Mai 2023 à 11:33
-- Version du serveur : 8.0.18
-- Version de PHP : 8.2.5

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `BDD_QuizV2`
--
DROP DATABASE IF EXISTS `BDD_QuizV2`;
CREATE DATABASE IF NOT EXISTS `BDD_QuizV2` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci;
USE `BDD_QuizV2`;

-- --------------------------------------------------------

--
-- Structure de la table `diff`
--

DROP TABLE IF EXISTS `diff`;
CREATE TABLE `diff` (
  `CLE_quiz` tinyint(4) NOT NULL,
  `CLE_difficulte` tinyint(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Structure de la table `Difficulte`
--

DROP TABLE IF EXISTS `Difficulte`;
CREATE TABLE `Difficulte` (
  `CLP_difficulte` tinyint(4) NOT NULL,
  `nom_diff` varchar(16) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Structure de la table `Questions`
--

DROP TABLE IF EXISTS `Questions`;
CREATE TABLE `Questions` (
  `CLP_question` tinyint(4) NOT NULL,
  `question` varchar(64) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Structure de la table `Quiz`
--

DROP TABLE IF EXISTS `Quiz`;
CREATE TABLE `Quiz` (
  `CLP_quiz` tinyint(4) NOT NULL,
  `titre_quiz` varchar(32) NOT NULL,
  `difficulte` tinyint(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Structure de la table `repondre`
--

DROP TABLE IF EXISTS `repondre`;
CREATE TABLE `repondre` (
  `CLE_question` tinyint(4) NOT NULL,
  `CLE_reponse` tinyint(4) NOT NULL,
  `good_rep` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Structure de la table `Reponse`
--

DROP TABLE IF EXISTS `Reponse`;
CREATE TABLE `Reponse` (
  `CLP_reponse` tinyint(4) NOT NULL,
  `reponse` varchar(64) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Structure de la table `Score`
--

DROP TABLE IF EXISTS `Score`;
CREATE TABLE `Score` (
  `CLE_login` varchar(32) NOT NULL,
  `CLE_quiz` tinyint(4) NOT NULL,
  `score` tinyint(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Structure de la table `Utilisateur`
--

DROP TABLE IF EXISTS `Utilisateur`;
CREATE TABLE `Utilisateur` (
  `login` varchar(32) NOT NULL,
  `nom` varchar(16) NOT NULL,
  `password` varchar(200) NOT NULL,
  `prenom` varchar(16) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Structure de la table `Verifier`
--

DROP TABLE IF EXISTS `Verifier`;
CREATE TABLE `Verifier` (
  `CLE_quiz` tinyint(4) NOT NULL,
  `CLE_question` tinyint(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `diff`
--
ALTER TABLE `diff`
  ADD PRIMARY KEY (`CLE_quiz`,`CLE_difficulte`),
  ADD KEY `CLE_difficulte` (`CLE_difficulte`);

--
-- Index pour la table `Difficulte`
--
ALTER TABLE `Difficulte`
  ADD PRIMARY KEY (`CLP_difficulte`);

--
-- Index pour la table `Questions`
--
ALTER TABLE `Questions`
  ADD PRIMARY KEY (`CLP_question`);

--
-- Index pour la table `Quiz`
--
ALTER TABLE `Quiz`
  ADD PRIMARY KEY (`CLP_quiz`);

--
-- Index pour la table `repondre`
--
ALTER TABLE `repondre`
  ADD PRIMARY KEY (`CLE_question`,`CLE_reponse`),
  ADD KEY `CLE_reponse` (`CLE_reponse`);

--
-- Index pour la table `Reponse`
--
ALTER TABLE `Reponse`
  ADD PRIMARY KEY (`CLP_reponse`);

--
-- Index pour la table `Score`
--
ALTER TABLE `Score`
  ADD PRIMARY KEY (`CLE_login`,`CLE_quiz`),
  ADD KEY `CLE_quiz` (`CLE_quiz`);

--
-- Index pour la table `Utilisateur`
--
ALTER TABLE `Utilisateur`
  ADD PRIMARY KEY (`login`);

--
-- Index pour la table `Verifier`
--
ALTER TABLE `Verifier`
  ADD PRIMARY KEY (`CLE_quiz`,`CLE_question`),
  ADD KEY `CLE_question` (`CLE_question`);

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `diff`
--
ALTER TABLE `diff`
  ADD CONSTRAINT `diff_ibfk_1` FOREIGN KEY (`CLE_quiz`) REFERENCES `Quiz` (`CLP_quiz`),
  ADD CONSTRAINT `diff_ibfk_2` FOREIGN KEY (`CLE_difficulte`) REFERENCES `Difficulte` (`CLP_difficulte`);

--
-- Contraintes pour la table `repondre`
--
ALTER TABLE `repondre`
  ADD CONSTRAINT `repondre_ibfk_1` FOREIGN KEY (`CLE_reponse`) REFERENCES `Reponse` (`CLP_reponse`),
  ADD CONSTRAINT `repondre_ibfk_2` FOREIGN KEY (`CLE_question`) REFERENCES `Questions` (`CLP_question`);

--
-- Contraintes pour la table `Score`
--
ALTER TABLE `Score`
  ADD CONSTRAINT `Score_ibfk_1` FOREIGN KEY (`CLE_login`) REFERENCES `Utilisateur` (`login`),
  ADD CONSTRAINT `Score_ibfk_2` FOREIGN KEY (`CLE_quiz`) REFERENCES `Quiz` (`CLP_quiz`);

--
-- Contraintes pour la table `Verifier`
--
ALTER TABLE `Verifier`
  ADD CONSTRAINT `Verifier_ibfk_1` FOREIGN KEY (`CLE_quiz`) REFERENCES `Quiz` (`CLP_quiz`),
  ADD CONSTRAINT `Verifier_ibfk_2` FOREIGN KEY (`CLE_question`) REFERENCES `Questions` (`CLP_question`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
