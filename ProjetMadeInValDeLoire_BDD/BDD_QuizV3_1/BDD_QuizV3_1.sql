-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Hôte : localhost
-- Généré le : jeu. 11 mai 2023 à 15:56
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
CREATE DATABASE IF NOT EXISTS `BDD_QuizV3.1` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `BDD_QuizV3.1`;

-- --------------------------------------------------------

--
-- Structure de la table `difficulte`
--

CREATE TABLE `difficulte` (
  `CLP_difficulte` tinyint(4) NOT NULL COMMENT 'ClÃ© primaire de la table difficulte',
  `nom_diff` varchar(16) NOT NULL COMMENT 'Nom de la difficulte'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `difficulte`
--

INSERT INTO `difficulte` (`CLP_difficulte`, `nom_diff`) VALUES
(1, 'Collegiens'),
(2, 'Lyceen'),
(3, 'Etudiant '),
(4, 'Professionnel');

-- --------------------------------------------------------

--
-- Structure de la table `questions`
--

CREATE TABLE `questions` (
  `CLP_question` tinyint(4) NOT NULL COMMENT 'ClÃ© primaire de la table question',
  `question` text NOT NULL COMMENT 'la question de la table question'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `questions`
--

INSERT INTO `questions` (`CLP_question`, `question`) VALUES
(1, 'Qu\'est-ce qu\'un mot de passe fort ?'),
(2, 'Qu est-ce qu un mot de passe?'),
(3, 'Pourquoi est-il important d avoir un mot de passe complexe? \r\n'),
(4, 'Qu est-ce qu un virus informatique? '),
(5, 'Comment peut-on sécuriser son ordinateur personnel ?'),
(6, 'Pourquoi est-il important de ne pas utiliser le même mot de passe pour tous les comptes en ligne ?\r\n'),
(7, 'Qu est-ce qu un logiciel malveillant ?\r\n'),
(8, 'Comment peut-on protéger sa vie privée en ligne ?\r\n'),
(9, 'Qu est-ce que l hameçonnage (phishing) ?\r\n'),
(10, 'Qu est-ce qu un virus informatique? \r\n'),
(11, 'Qu est-ce qu un proxy?\r\n'),
(12, 'Qu est-ce que le chiffrement des données ? \r\n'),
(13, 'Qu est-ce que la cryptographie ?\r\n'),
(14, 'Qu est-ce que l authentification à deux facteurs ?\r\n'),
(15, 'Qu est-ce que la veille cybersécurité ?\r\n'),
(16, 'Quels sont les types de cryptage les plus couramment utilisés en matière de sécurité des données? \r\n'),
(17, 'Qu est-ce qu un pare-feu? \r\n'),
(18, 'Qu est-ce que la vulnérabilité \"zero-day\" ? \r\n'),
(19, 'Qu est-ce que la méthode d attaque \"man-in-the-middle\" ? \r\n'),
(20, 'Qu est-ce qu un mot de passe fort ?\r\n'),
(21, 'Qu est-ce qu une sauvegarde des données ?\r\n'),
(22, 'Qu est-ce que le cyberespionnage ?\r\n'),
(23, 'Quel est le type de logiciel malveillant qui verrouille les fichiers d un ordinateur et demande une rançon pour les déverrouiller ?\r\n'),
(24, 'Qu est-ce qu une attaque DDoS ?\r\n'),
(25, 'Qu est-ce que la cybersécurité proactive ?\r\n'),
(26, 'Qu est-ce que le chiffrement homomorphe? \r\n'),
(27, 'Comment les algorithmes de chiffrement sont-ils utilisés dans les transactions financières en \r\n'),
(28, 'Qu est-ce que l authentification forte? \r\n'),
(29, 'Qu est-ce que l ingénierie sociale ?\r\n'),
(30, 'Comment posséder un mot de passe fort?\r\n'),
(31, 'Qu est-ce que la sauvegarde des données ?\r\n'),
(32, 'Qu est-ce qu un pare-feu ?\r\n'),
(33, 'Qu est-ce que la protection par mot de passe ?\r\n'),
(34, 'Qu est-ce que la mise à jour des logiciels ?\r\n'),
(35, 'Qu est-ce qu un logiciel malveillant ?\r\n');

-- --------------------------------------------------------

--
-- Structure de la table `quiz`
--

CREATE TABLE `quiz` (
  `CLP_quiz` tinyint(4) NOT NULL COMMENT 'ClÃ© quiz',
  `titre_quiz` varchar(32) NOT NULL COMMENT 'nom du quiz',
  `difficulte` tinyint(4) NOT NULL COMMENT 'difficulte du quiz'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `quiz`
--

INSERT INTO `quiz` (`CLP_quiz`, `titre_quiz`, `difficulte`) VALUES
(1, 'Niveau 1 - Collegiens', 1),
(2, 'Niveau 2 - Lyceen', 2),
(3, 'Niveau 3 - Etudiant', 3),
(4, 'Niveau 4 - Professionnel', 4);

-- --------------------------------------------------------

--
-- Structure de la table `repondre`
--

CREATE TABLE `repondre` (
  `CLE_question` tinyint(4) NOT NULL COMMENT 'cle question',
  `CLE_reponse` tinyint(4) NOT NULL COMMENT 'cle reponse',
  `good_rep` tinyint(1) NOT NULL COMMENT 'revoie vrai ou faux a la reponse'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `repondre`
--

INSERT INTO `repondre` (`CLE_question`, `CLE_reponse`, `good_rep`) VALUES
(1, 1, 0),
(1, 2, 0),
(1, 3, 1),
(2, 4, 0),
(2, 5, 0),
(2, 6, 1),
(3, 7, 0),
(3, 8, 1),
(3, 9, 0),
(4, 10, 0),
(4, 11, 1),
(4, 12, 0),
(5, 13, 1),
(5, 14, 0),
(5, 15, 0),
(6, 16, 0),
(6, 17, 1),
(6, 18, 0),
(7, 19, 1),
(7, 20, 0),
(7, 21, 0),
(8, 22, 0),
(8, 23, 1),
(8, 24, 0),
(9, 25, 0),
(9, 26, 1),
(9, 27, 0),
(10, 28, 0),
(10, 29, 1),
(10, 30, 0),
(11, 31, 1),
(11, 32, 0),
(11, 33, 0),
(12, 34, 0),
(12, 35, 1),
(12, 36, 0),
(13, 37, 0),
(13, 38, 1),
(13, 39, 0),
(14, 40, 1),
(14, 41, 0),
(14, 42, 0),
(15, 43, 1),
(15, 44, 0),
(15, 45, 0),
(16, 46, 1),
(16, 47, 0),
(16, 48, 0),
(17, 49, 0),
(17, 50, 1),
(17, 51, 0),
(18, 52, 0),
(18, 53, 0),
(18, 54, 1),
(19, 55, 1),
(19, 56, 0),
(19, 57, 0);

-- --------------------------------------------------------

--
-- Structure de la table `reponse`
--

CREATE TABLE `reponse` (
  `CLP_reponse` tinyint(4) NOT NULL COMMENT 'ClÃ© reponse',
  `reponse` text NOT NULL COMMENT 'la reponse'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `reponse`
--

INSERT INTO `reponse` (`CLP_reponse`, `reponse`) VALUES
(1, 'Un mot de passe facile à deviner'),
(2, 'Un mot de passe court et simple'),
(3, ' Un mot de passe long et complexe'),
(4, 'Une carte d identité virtualisée \r\n'),
(5, 'Une méthode de chiffrement '),
(6, 'Un code secret pour accéder à un compte'),
(7, 'Pour rendre la connexion plus lente'),
(8, 'Pour éviter les attaques de pirates informatiques'),
(9, 'Pour afficher ses compétences en informatique\r\n'),
(10, 'Un aliment informatique'),
(11, 'Un programme malveillant qui se propage entre les ordinateurs'),
(12, 'Un assistant virtuel pour la sécurité'),
(13, 'En ne téléchargeant que des fichiers provenant de sources fiables +\r\n'),
(14, 'En partageant ses informations personnelles sur les réseaux sociaux\r\n'),
(15, 'En cliquant sur tous les liens que l on rencontre en ligne\r\n'),
(16, 'Pour ne pas oublier ses mots de passe\r\n'),
(17, 'Pour éviter les piratages en série '),
(18, 'Pour économiser du temps \r\n'),
(19, 'Un logiciel qui protège votre ordinateur\r\n'),
(20, 'Un logiciel qui peut causer des dommages à votre ordinateur ou voler vos informations personnelles'),
(21, 'Un logiciel qui peut améliorer les performances de votre ordinateur\r\n'),
(22, 'En partageant ses informations personnelles sur les réseaux sociaux\r\n'),
(23, 'En utilisant un VPN pour naviguer sur internet'),
(24, ' En ne se connectant jamais à internet\r\n'),
(25, 'Une technique de pêche\r\n'),
(26, 'Une technique de hacking pour voler des informations personnelles en se faisant passer pour une entreprise ou une organisation de confiance\r\n'),
(27, 'Une technique de protection de la vie privée en ligne\r\n'),
(28, 'Un aliment informatique \r\n'),
(29, 'Un programme malveillant qui se propage entre les ordinateurs'),
(30, 'Un assistant virtuel pour la sécurité\r\n'),
(31, 'Un outil pour masquer son adresse IP'),
(32, 'Un type de virus informatique \r\n'),
(33, 'Un type de virus informatique \r\n'),
(34, 'Une méthode pour supprimer les données de manière permanente \r\n'),
(35, 'Une méthode pour rendre les données illisibles sauf pour ceux qui ont la clé de déchiffrement '),
(36, 'Une méthode pour limiter l accès aux données \r\n'),
(37, 'Une technique de protection de la vie privée en ligne\r\n'),
(38, ' Une science des codes secrets permettant de sécuriser les communications '),
(39, 'Une technique utilisée par les hackers pour accéder à des informations confidentielles\r\n'),
(40, 'Une méthode de vérification de l identité nécessitant deux informations distinctes '),
(41, 'Une méthode de protection contre les logiciels malveillants\r\n'),
(42, 'Une méthode de chiffrement des données\r\n'),
(43, 'Une surveillance constante des menaces et des risques pour la sécurité en ligne'),
(44, 'Une technique de hacking permettant de cibler les vulnérabilités des systèmes informatiques\r\n'),
(45, 'Une méthode de protection contre les attaques de phishing\r\n'),
(46, 'AES et RSA'),
(47, 'MD5 et SHA-1'),
(48, 'XOR et DES'),
(49, 'Un type de virus informatique \r\n'),
(50, 'Un système de sécurité qui protège les réseaux informatiques contre les intrusions +\r\n'),
(51, 'Un proxy avancé\r\n'),
(52, 'Une vulnérabilité qui a été corrigée avant que ne puisse en profiter \r\n'),
(53, 'Une vulnérabilité qui a été révélée publiquement avant d être corrigée \r\n'),
(54, 'Une vulnérabilité qui est inconnue et non corrigée par les développeurs '),
(55, 'Une méthode d attaque où un attaquant intercepte les communications entre deux parties pour voler des informations '),
(56, 'Une méthode d attaque où un attaquant force un utilisateur à cliquer sur un lien malveillant \r\n'),
(57, 'Une méthode d attaque où un attaquant utilise un logiciel malveillant pour prendre le contrôle d un ordinateur à distance \r\n'),
(58, 'Un mot de passe facile à deviner\r\n'),
(59, 'Un mot de passe complexe qui utilise des lettres, des chiffres et des caractères spéciaux '),
(60, 'Un mot de passe que vous utilisez pour plusieurs comptes en ligne\r\n'),
(61, 'Une méthode pour protéger votre ordinateur contre les logiciels malveillants\r\n'),
(62, ' Une méthode de stockage des données sur des disques durs externes\r\n'),
(63, 'Une méthode de copie des données importantes pour éviter leur perte en cas d incident '),
(64, 'Une technique de surveillance gouvernementale\r\n'),
(65, 'Une méthode de piratage pour voler des secrets gouvernementaux ou industriels\r\n'),
(66, 'Un moyen de récolter des données pour des études de marché\r\n'),
(67, 'Adware\r\n'),
(68, 'Ransomware'),
(69, 'Rootkit'),
(70, 'Une attaque visant à voler des informations personnelles\r\n'),
(71, ' Une attaque visant à saturer un serveur avec des demandes de connexions en masse '),
(72, 'Une méthode de chiffrement des données\r\n'),
(73, 'Une approche qui vise à prévenir les attaques avant qu elles ne se produisent \r\n'),
(74, 'Une approche qui vise à réagir rapidement aux attaques pour minimiser les dommages\r\n'),
(75, ' Une technique de protection contre les logiciels malveillants.\r\n'),
(76, 'Un type de cryptage qui permet de conserver la structure de données '),
(77, 'Un mécanisme de sécurité pour déchiffrer les messages codés \r\n'),
(78, '  Une méthode pour connecter plusieurs réseaux distincts'),
(79, 'Pour ajouter des taxes supplémentaires \r\n'),
(80, 'Pour sécuriser les informations sensibles des clients et les transactions en ligne '),
(81, 'Pour vérifier les identités des clients\r\n'),
(82, ' Une technique d identification qui nécessite la saisie de plusieurs mots de passe \r\n'),
(83, ' Un processus de sécurité pour vérifier les identités des utilisateurs à l aide de plusieurs facteurs, comme un code PIN, une empreinte digitale et une carte d identité '),
(84, 'Une méthode pour empêcher les intrusions sur les réseaux informatiques \r\n'),
(85, 'Une technique de hacking qui utilise des programmes informatiques sophistiqués pour tromper les utilisateurs\r\n'),
(86, ' Une méthode de cryptage des données pour les rendre plus sécurisées\r\n'),
(87, ' Une technique de hacking qui utilise des méthodes de persuasion pour obtenir des informations confidentielles +\r\n'),
(88, 'plus de 8 caractères sans des caractère spéciaux.\r\n'),
(89, 'plus de 8 caractère avec des caractères spéciaux'),
(90, 'Une méthode de stockage des données sur des disques durs externes\r\n'),
(91, 'Une méthode de conversion des données en code secret pour les rendre plus sécurisées\r\n'),
(92, ' Une méthode de copie des données importantes pour éviter leur perte en cas d incident \r\n\r\n'),
(93, 'Un logiciel de sécurité qui contrôle l accès au réseau en bloquant les connexions non autorisées. '),
(94, ' Un type de virus informatique qui se propage via les e-mails.\r\n'),
(95, 'Un logiciel malveillant qui vise à voler des informations personnelles.\r\n'),
(96, ' Une méthode de cryptage pour protéger les données sensibles.\r\n'),
(97, 'Une méthode de protection des réseaux Wi-Fi contre les intrusions.\r\n'),
(98, ' Une méthode de protection des données par l utilisation de mots de passe sécurisés.'),
(99, 'Une méthode de protection des réseaux Wi-Fi contre les intrusions.\r\n'),
(100, ' Une méthode de protection des systèmes informatiques contre les virus en installant les dernières mises à jour de sécurité. '),
(101, 'Une méthode de protection des données par l utilisation de mots de passe sécurisés.\r\n'),
(102, ' Un type de logiciel utilisé pour améliorer la performance des systèmes informatiques.\r\n'),
(103, ' Un logiciel conçu pour endommager ou compromettre un système informatique sans le consentement de l utilisateur. \r\n'),
(104, ' Un type de logiciel utilisé pour bloquer l accès à des sites Web spécifiques.\r\n'),
(105, ' moins de 8 caracteres avec des caracteres speciaux');

-- --------------------------------------------------------

--
-- Structure de la table `score`
--

CREATE TABLE `score` (
  `CLE_login` varchar(32) NOT NULL COMMENT 'ClÃ© login',
  `CLE_quiz` tinyint(4) NOT NULL COMMENT 'ClÃ© quiz',
  `score` tinyint(4) NOT NULL COMMENT 'Score du joueur'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `score`
--

INSERT INTO `score` (`CLE_login`, `CLE_quiz`, `score`) VALUES
('adminsio', 1, 6),
('kkk', 1, 83);

-- --------------------------------------------------------

--
-- Structure de la table `utilisateur`
--

CREATE TABLE `utilisateur` (
  `login` varchar(32) NOT NULL COMMENT 'ClÃ© primaire de la table login',
  `nom` varchar(16) NOT NULL COMMENT 'nom de l utilisateur',
  `password` varchar(200) NOT NULL COMMENT 'mot de passe',
  `prenom` varchar(16) DEFAULT NULL COMMENT 'prenom de l utilisateur'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `utilisateur`
--

INSERT INTO `utilisateur` (`login`, `nom`, `password`, `prenom`) VALUES
('admin', 'admin', '8C6976E5B5410415BDE908BD4DEE15DFB167A9C873FC4BB8A81F6F2AB448A918', 'admin'),
('adminsio', 'admin', 'Kirikou202209!', 'sio'),
('kkk', 'kkk', '96EFBC43A462AB9D9C6A8173E5B322E17F218B56EB3A05A4BBC53221ADEBC7B3', 'kkk');

-- --------------------------------------------------------

--
-- Structure de la table `verifier`
--

CREATE TABLE `verifier` (
  `CLE_quiz` tinyint(4) NOT NULL COMMENT 'ClÃ© quiz',
  `CLE_question` tinyint(4) NOT NULL COMMENT 'ClÃ© question'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `verifier`
--

INSERT INTO `verifier` (`CLE_quiz`, `CLE_question`) VALUES
(1, 1),
(1, 2),
(1, 3),
(1, 4),
(1, 5),
(1, 6),
(2, 7),
(2, 8),
(2, 9),
(2, 10),
(2, 11),
(3, 12),
(3, 13),
(3, 14),
(3, 15),
(3, 16),
(3, 17),
(3, 18),
(3, 19),
(3, 20),
(4, 21),
(4, 22),
(4, 23),
(4, 24),
(4, 25),
(4, 26),
(4, 27),
(4, 28),
(4, 29),
(4, 30),
(4, 31),
(4, 32),
(4, 33),
(4, 34),
(4, 35);

--
-- Index pour les tables déchargées
--

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
  ADD PRIMARY KEY (`CLP_quiz`),
  ADD KEY `difficulte` (`difficulte`);

--
-- Index pour la table `repondre`
--
ALTER TABLE `repondre`
  ADD PRIMARY KEY (`CLE_question`,`CLE_reponse`),
  ADD KEY `CLE_reponse` (`CLE_reponse`);

--
-- Index pour la table `reponse`
--
ALTER TABLE `reponse`
  ADD PRIMARY KEY (`CLP_reponse`);

--
-- Index pour la table `score`
--
ALTER TABLE `score`
  ADD PRIMARY KEY (`CLE_login`,`CLE_quiz`),
  ADD KEY `CLE_quiz` (`CLE_quiz`);

--
-- Index pour la table `utilisateur`
--
ALTER TABLE `utilisateur`
  ADD PRIMARY KEY (`login`);

--
-- Index pour la table `verifier`
--
ALTER TABLE `verifier`
  ADD PRIMARY KEY (`CLE_quiz`,`CLE_question`),
  ADD KEY `CLE_question` (`CLE_question`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `difficulte`
--
ALTER TABLE `difficulte`
  MODIFY `CLP_difficulte` tinyint(4) NOT NULL AUTO_INCREMENT COMMENT 'ClÃ© primaire de la table difficulte', AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT pour la table `questions`
--
ALTER TABLE `questions`
  MODIFY `CLP_question` tinyint(4) NOT NULL AUTO_INCREMENT COMMENT 'ClÃ© primaire de la table question', AUTO_INCREMENT=36;

--
-- AUTO_INCREMENT pour la table `quiz`
--
ALTER TABLE `quiz`
  MODIFY `CLP_quiz` tinyint(4) NOT NULL AUTO_INCREMENT COMMENT 'ClÃ© quiz', AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT pour la table `reponse`
--
ALTER TABLE `reponse`
  MODIFY `CLP_reponse` tinyint(4) NOT NULL AUTO_INCREMENT COMMENT 'ClÃ© reponse', AUTO_INCREMENT=106;

--
-- AUTO_INCREMENT pour la table `score`
--
ALTER TABLE `score`
  MODIFY `CLE_quiz` tinyint(4) NOT NULL AUTO_INCREMENT COMMENT 'ClÃ© quiz', AUTO_INCREMENT=2;

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
