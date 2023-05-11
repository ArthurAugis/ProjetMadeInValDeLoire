-- phpMyAdmin SQL Dump
-- version 4.2.7.1
-- http://www.phpmyadmin.net
--
-- Client :  localhost
-- Généré le :  Mer 10 Mai 2023 à 22:20
-- Version du serveur :  5.6.20-log
-- Version de PHP :  5.4.31

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de données :  `bdd_quizv2`
--
CREATE DATABASE IF NOT EXISTS `bdd_quizv2` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `bdd_quizv2`;

-- --------------------------------------------------------

--
-- Structure de la table `diff`
--

CREATE TABLE IF NOT EXISTS `diff` (
  `CLE_quiz` tinyint(4) NOT NULL,
  `CLE_difficulte` tinyint(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Contenu de la table `diff`
--

INSERT INTO `diff` (`CLE_quiz`, `CLE_difficulte`) VALUES
(1, 1);

-- --------------------------------------------------------

--
-- Structure de la table `difficulte`
--

CREATE TABLE IF NOT EXISTS `difficulte` (
  `CLP_difficulte` tinyint(4) NOT NULL,
  `nom_diff` varchar(16) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Contenu de la table `difficulte`
--

INSERT INTO `difficulte` (`CLP_difficulte`, `nom_diff`) VALUES
(1, 'Collégiens'),
(2, 'Lycéens'),
(3, 'Etudiants'),
(4, 'Professionnels');

-- --------------------------------------------------------

--
-- Structure de la table `questions`
--

CREATE TABLE IF NOT EXISTS `questions` (
  `CLP_question` tinyint(4) NOT NULL,
  `question` varchar(64) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Contenu de la table `questions`
--

INSERT INTO `questions` (`CLP_question`, `question`) VALUES
(1, 'Qu''est-ce qu''un mot de passe fort ?');

-- --------------------------------------------------------

--
-- Structure de la table `quiz`
--

CREATE TABLE IF NOT EXISTS `quiz` (
  `CLP_quiz` tinyint(4) NOT NULL,
  `titre_quiz` varchar(32) NOT NULL,
  `difficulte` tinyint(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Contenu de la table `quiz`
--

INSERT INTO `quiz` (`CLP_quiz`, `titre_quiz`, `difficulte`) VALUES
(1, 'Collégiens', 1),
(2, 'Lycéens', 2),
(3, 'Etudiants', 3),
(4, 'Professionnels', 4);

-- --------------------------------------------------------

--
-- Structure de la table `repondre`
--

CREATE TABLE IF NOT EXISTS `repondre` (
  `CLE_question` tinyint(4) NOT NULL,
  `CLE_reponse` tinyint(4) NOT NULL,
  `good_rep` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Contenu de la table `repondre`
--

INSERT INTO `repondre` (`CLE_question`, `CLE_reponse`, `good_rep`) VALUES
(1, 1, 0),
(1, 2, 0),
(1, 3, 1);

-- --------------------------------------------------------

--
-- Structure de la table `reponse`
--

CREATE TABLE IF NOT EXISTS `reponse` (
  `CLP_reponse` tinyint(4) NOT NULL,
  `reponse` varchar(64) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Contenu de la table `reponse`
--

INSERT INTO `reponse` (`CLP_reponse`, `reponse`) VALUES
(1, 'Un mot de passe facile à deviner'),
(2, 'Un mot de passe court et simple'),
(3, 'Un mot de passe long et complexe');

-- --------------------------------------------------------

--
-- Structure de la table `score`
--

CREATE TABLE IF NOT EXISTS `score` (
  `CLE_login` varchar(32) NOT NULL,
  `CLE_quiz` tinyint(4) NOT NULL,
  `score` tinyint(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Contenu de la table `score`
--

INSERT INTO `score` (`CLE_login`, `CLE_quiz`, `score`) VALUES
('admin', 1, 99);

-- --------------------------------------------------------

--
-- Structure de la table `utilisateur`
--

CREATE TABLE IF NOT EXISTS `utilisateur` (
  `login` varchar(32) NOT NULL,
  `nom` varchar(16) NOT NULL,
  `password` varchar(200) NOT NULL,
  `prenom` varchar(16) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Contenu de la table `utilisateur`
--

INSERT INTO `utilisateur` (`login`, `nom`, `password`, `prenom`) VALUES
('admin', 'Admin', '8C6976E5B5410415BDE908BD4DEE15DFB167A9C873FC4BB8A81F6F2AB448A918', 'Admin');

-- --------------------------------------------------------

--
-- Structure de la table `verifier`
--

CREATE TABLE IF NOT EXISTS `verifier` (
  `CLE_quiz` tinyint(4) NOT NULL,
  `CLE_question` tinyint(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Contenu de la table `verifier`
--

INSERT INTO `verifier` (`CLE_quiz`, `CLE_question`) VALUES
(1, 1);

--
-- Index pour les tables exportées
--

--
-- Index pour la table `diff`
--
ALTER TABLE `diff`
 ADD PRIMARY KEY (`CLE_quiz`,`CLE_difficulte`), ADD KEY `CLE_difficulte` (`CLE_difficulte`);

--
-- Index pour la table `difficulte`
--
ALTER TABLE `difficulte`
 ADD PRIMARY KEY (`CLP_difficulte`);

--
-- Index pour la table `questions`
--
ALTER TABLE `questions`
 ADD PRIMARY KEY (`CLP_question`);

--
-- Index pour la table `quiz`
--
ALTER TABLE `quiz`
 ADD PRIMARY KEY (`CLP_quiz`);

--
-- Index pour la table `repondre`
--
ALTER TABLE `repondre`
 ADD PRIMARY KEY (`CLE_question`,`CLE_reponse`), ADD KEY `CLE_reponse` (`CLE_reponse`);

--
-- Index pour la table `reponse`
--
ALTER TABLE `reponse`
 ADD PRIMARY KEY (`CLP_reponse`);

--
-- Index pour la table `score`
--
ALTER TABLE `score`
 ADD PRIMARY KEY (`CLE_login`,`CLE_quiz`), ADD KEY `CLE_quiz` (`CLE_quiz`);

--
-- Index pour la table `utilisateur`
--
ALTER TABLE `utilisateur`
 ADD PRIMARY KEY (`login`);

--
-- Index pour la table `verifier`
--
ALTER TABLE `verifier`
 ADD PRIMARY KEY (`CLE_quiz`,`CLE_question`), ADD KEY `CLE_question` (`CLE_question`);

--
-- Contraintes pour les tables exportées
--

--
-- Contraintes pour la table `diff`
--
ALTER TABLE `diff`
ADD CONSTRAINT `diff_ibfk_1` FOREIGN KEY (`CLE_quiz`) REFERENCES `quiz` (`CLP_quiz`),
ADD CONSTRAINT `diff_ibfk_2` FOREIGN KEY (`CLE_difficulte`) REFERENCES `difficulte` (`CLP_difficulte`);

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

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
