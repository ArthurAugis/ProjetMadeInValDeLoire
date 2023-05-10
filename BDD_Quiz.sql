-- phpMyAdmin SQL Dump
-- version 6.0.0-dev
-- https://www.phpmyadmin.net/
--
-- Hôte : 192.168.30.23
-- Généré le : mer. 10 Mai 2023 à 07:26
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
-- Base de données : `BDD_Quiz`
--
CREATE DATABASE IF NOT EXISTS `BDD_Quiz` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;
USE `BDD_Quiz`;

-- --------------------------------------------------------

--
-- Structure de la table `TAB_difficultes`
--

CREATE TABLE `TAB_difficultes` (
  `CLP_difficulte` int(11) NOT NULL,
  `DIF_nomDif` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Structure de la table `TAB_question`
--

CREATE TABLE `TAB_question` (
  `CLP_question` int(11) NOT NULL,
  `QUE_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Structure de la table `TAB_Quiz`
--

CREATE TABLE `TAB_Quiz` (
  `CLP_quiz` int(11) NOT NULL,
  `QUI_description` varchar(50) NOT NULL,
  `CLE_question` int(11) NOT NULL,
  `CLE_reponse` int(11) NOT NULL,
  `CLE_difficulte` int(11) NOT NULL,
  `CLE_nom` int(11) NOT NULL,
  `CLE_resultat` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Structure de la table `TAB_reponse`
--

CREATE TABLE `TAB_reponse` (
  `CLP_reponse` int(11) NOT NULL,
  `REP_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Structure de la table `TAB_resultat`
--

CREATE TABLE `TAB_resultat` (
  `CLP_resultat` int(11) NOT NULL,
  `CLE_nom` int(11) NOT NULL,
  `CLE_difficulte` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Structure de la table `TAB_user`
--

CREATE TABLE `TAB_user` (
  `CLP_nom` int(11) NOT NULL,
  `USE_id` int(11) NOT NULL,
  `USE_prenom` varchar(50) NOT NULL,
  `USE_login` varchar(50) NOT NULL,
  `USE_mdr` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `TAB_difficultes`
--
ALTER TABLE `TAB_difficultes`
  ADD PRIMARY KEY (`CLP_difficulte`);

--
-- Index pour la table `TAB_question`
--
ALTER TABLE `TAB_question`
  ADD PRIMARY KEY (`CLP_question`);

--
-- Index pour la table `TAB_Quiz`
--
ALTER TABLE `TAB_Quiz`
  ADD PRIMARY KEY (`CLP_quiz`),
  ADD KEY `CLE_question` (`CLE_question`),
  ADD KEY `CLE_reponse` (`CLE_reponse`),
  ADD KEY `CLE_difficulte` (`CLE_difficulte`),
  ADD KEY `CLE_nom` (`CLE_nom`),
  ADD KEY `CLE_resultat` (`CLE_resultat`);

--
-- Index pour la table `TAB_reponse`
--
ALTER TABLE `TAB_reponse`
  ADD PRIMARY KEY (`CLP_reponse`);

--
-- Index pour la table `TAB_resultat`
--
ALTER TABLE `TAB_resultat`
  ADD PRIMARY KEY (`CLP_resultat`),
  ADD KEY `CLE_nom` (`CLE_nom`),
  ADD KEY `CLE_difficulte` (`CLE_difficulte`);

--
-- Index pour la table `TAB_user`
--
ALTER TABLE `TAB_user`
  ADD PRIMARY KEY (`CLP_nom`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `TAB_difficultes`
--
ALTER TABLE `TAB_difficultes`
  MODIFY `CLP_difficulte` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `TAB_question`
--
ALTER TABLE `TAB_question`
  MODIFY `CLP_question` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `TAB_Quiz`
--
ALTER TABLE `TAB_Quiz`
  MODIFY `CLP_quiz` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `TAB_reponse`
--
ALTER TABLE `TAB_reponse`
  MODIFY `CLP_reponse` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `TAB_resultat`
--
ALTER TABLE `TAB_resultat`
  MODIFY `CLP_resultat` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `TAB_user`
--
ALTER TABLE `TAB_user`
  MODIFY `CLP_nom` int(11) NOT NULL AUTO_INCREMENT;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `TAB_Quiz`
--
ALTER TABLE `TAB_Quiz`
  ADD CONSTRAINT `TAB_Quiz_ibfk_1` FOREIGN KEY (`CLE_question`) REFERENCES `TAB_question` (`CLP_question`),
  ADD CONSTRAINT `TAB_Quiz_ibfk_2` FOREIGN KEY (`CLE_reponse`) REFERENCES `TAB_reponse` (`CLP_reponse`),
  ADD CONSTRAINT `TAB_Quiz_ibfk_3` FOREIGN KEY (`CLE_difficulte`) REFERENCES `TAB_difficultes` (`CLP_difficulte`),
  ADD CONSTRAINT `TAB_Quiz_ibfk_4` FOREIGN KEY (`CLE_nom`) REFERENCES `TAB_user` (`CLP_nom`),
  ADD CONSTRAINT `TAB_Quiz_ibfk_5` FOREIGN KEY (`CLE_resultat`) REFERENCES `TAB_resultat` (`CLP_resultat`);

--
-- Contraintes pour la table `TAB_resultat`
--
ALTER TABLE `TAB_resultat`
  ADD CONSTRAINT `TAB_resultat_ibfk_1` FOREIGN KEY (`CLE_nom`) REFERENCES `TAB_user` (`CLP_nom`),
  ADD CONSTRAINT `TAB_resultat_ibfk_2` FOREIGN KEY (`CLE_difficulte`) REFERENCES `TAB_difficultes` (`CLP_difficulte`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
