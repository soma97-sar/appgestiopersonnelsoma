-- phpMyAdmin SQL Dump
-- version 5.0.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le : mar. 01 juin 2021 à 23:27
-- Version du serveur :  10.4.11-MariaDB
-- Version de PHP : 7.4.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `appligestiopersonnelsoma`
--

-- --------------------------------------------------------

--
-- Structure de la table `absences`
--

CREATE TABLE `absences` (
  `datedebuts` varchar(30) COLLATE utf8_unicode_ci NOT NULL,
  `datefins` varchar(30) COLLATE utf8_unicode_ci NOT NULL,
  `idmotifs` int(10) NOT NULL,
  `idpersonnels` int(10) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `absences`
--

INSERT INTO `absences` (`datedebuts`, `datefins`, `idmotifs`, `idpersonnels`) VALUES
('2021-06-21', '2021-06-30', 4, 1),
('2021-06-21', '2021-06-30', 4, 1),
('2021_06_21', '2021_06_30', 4, 1),
('19/03/2021', '31/05/2021', 2, 2),
('14/05/2022', '24/05/2022', 1, 3),
('22/01/2021', '21/02/2021', 3, 4),
('23/01/2022', '13/02/2022', 2, 5),
('11/09/2020', '11/10/2020', 1, 6),
('12/09/2020', '28/09/2020', 4, 7),
('13/09/2020', '01/10/2020', 3, 8),
('14/09/2020', '29/09/2020', 4, 9),
('15/09/2020', '12/01/2021', 4, 10),
('16/09/2020', '16/09/2022', 2, 11),
('17/09/2020', '17/09/2020', 1, 12),
('18/09/2020', '15/02/2020', 3, 13),
('19/09/2020', '29/09/2020', 4, 14),
('20/09/2020', '30/09/2020', 2, 15),
('21/09/2020', '30/09/2020', 1, 16),
('22/09/2020', '27/09/2020', 2, 17),
('23/09/2020', '23/11/2020', 3, 18),
('24/09/2020', '10/10/2020', 1, 19),
('25/09/2020', '27/09/2020', 2, 20),
('26/09/2020', '26/12/2020', 4, 21),
('27/09/2020', '27/10/2020', 3, 22),
('28/09/2020', '30/09/2020', 4, 23),
('29/09/2020', '29/11/2020', 2, 24),
('30/09/2020', '30/10/2020', 4, 25),
('01/10/2020', '01/11/2020', 3, 26),
('02/10/2020', '25/10/2020', 4, 27),
('03/10/2020', '23/10/2020', 1, 28),
('04/10/2020', '14/10/2020', 1, 29),
('05/10/2020', '25/10/2020', 2, 30),
('06/10/2020', '20/10/2020', 1, 31),
('07/10/2020', '17/10/2020', 3, 32),
('08/10/2020', '18/12/2020', 4, 33),
('09/10/2020', '11/10/2020', 3, 34),
('10/10/2020', '23/10/2020', 4, 35),
('11/10/2020', '11/10/2020', 3, 36),
('12/10/2020', '12/04/2021', 4, 37),
('13/10/2020', '30/10/2020', 1, 38),
('14/10/2020', '14/10/2020', 3, 39),
('15/10/2020', '15/04/2021', 4, 40),
('16/10/2020', '26/10/2020', 2, 41),
('17/10/2020', '27/10/2020', 3, 42),
('18/10/2020', '18/02/2021', 4, 43),
('19/10/2020', '29/10/2020', 2, 44),
('20/10/2020', '30/10/2020', 1, 45),
('21/10/2020', '11/11/2020', 3, 46),
('22/10/2020', '22/12/2020', 3, 47),
('23/10/2020', '31/12/2020', 4, 48),
('24/10/2020', '24/12/2020', 1, 49),
('25/10/2020', '27/10/2020', 2, 50),
('26/10/2020', '06/11/2020', 4, 51),
('27/01/2021', '27/02/2021', 1, 52);

-- --------------------------------------------------------

--
-- Structure de la table `motifs`
--

CREATE TABLE `motifs` (
  `idmotifs` int(10) NOT NULL,
  `libelle` varchar(60) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `motifs`
--

INSERT INTO `motifs` (`idmotifs`, `libelle`) VALUES
(1, 'vacances'),
(2, 'maladie'),
(3, 'motif_familial'),
(4, 'conge_parental');

-- --------------------------------------------------------

--
-- Structure de la table `personnels`
--

CREATE TABLE `personnels` (
  `idpersonnels` int(10) DEFAULT NULL,
  `idservices` int(10) DEFAULT NULL,
  `mail` varchar(60) COLLATE utf8_unicode_ci DEFAULT NULL,
  `nom` varchar(30) COLLATE utf8_unicode_ci DEFAULT NULL,
  `prenom` varchar(30) COLLATE utf8_unicode_ci DEFAULT NULL,
  `tel` varchar(30) COLLATE utf8_unicode_ci DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `personnels`
--

INSERT INTO `personnels` (`idpersonnels`, `idservices`, `mail`, `nom`, `prenom`, `tel`) VALUES
(30, 3, 'nonummy.ults@accumsan.ca', 'tatiana', 'louis', '(955) 416-4618'),
(31, 1, 'imperdiet@Morbi.org', 'louis', 'daryl', '(683) 392-7210'),
(32, 2, 'in.consect@corper.com', 'gay', 'sybil', '(663)144-6779'),
(33, 2, 'in.dolor.Fusce@bendum.co.uk', 'nigel', 'keiht', '(977) 884-1568'),
(34, 2, 'vestibulum.massa@cingnon.com', 'ciara', 'ocean', '(686) 284-6073'),
(35, 3, 'Sed.nunc@in.net', 'uriel', 'mylis', '(157) 983-5429'),
(36, 3, 'tellus.augue@odio.ca', 'josephine', 'rahim', '(633) 531-2517'),
(37, 1, 'Morbi.Pellen@Nuncsedorci.edu', 'dexter', 'nital', '(631) 990-4471'),
(38, 1, 'magna.Nam@Mauris.net', 'rosalyn', 'richard', '(442) 669-8548'),
(39, 2, 'ipsum.nunc@honcus.net', 'chiquita', 'ryder', '(537) 729-1755'),
(40, 2, 'viveiaculis@diam.org', 'jenna', 'michel', '(443) 707-5102'),
(41, 3, 'posuere@aculis.org|Jillian', 'jillian', 'nevada', '(267) 685-5823'),
(42, 1, 'est.arcu@Aenean.com', 'yvette', 'melenda', '(511) 148-9515'),
(44, 3, 'nonummy.ultr@accumsan.ca', 'tatiana', 'louis', '(955) 416-4618');

-- --------------------------------------------------------

--
-- Structure de la table `responsables`
--

CREATE TABLE `responsables` (
  `login` varchar(64) COLLATE utf8_unicode_ci DEFAULT NULL,
  `pwd` varchar(64) COLLATE utf8_unicode_ci DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `responsables`
--

INSERT INTO `responsables` (`login`, `pwd`) VALUES
(NULL, NULL),
('admin', '8C6976E5B5410415BDE908BD4DEE15DFB167A9C873FC4BB8A81F6F2AB448A918');

-- --------------------------------------------------------

--
-- Structure de la table `services`
--

CREATE TABLE `services` (
  `nom` varchar(30) COLLATE utf8_unicode_ci NOT NULL,
  `idservices` int(10) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `services`
--

INSERT INTO `services` (`nom`, `idservices`) VALUES
('administratif', 1),
('mediation_culturelle', 3),
('prêt', 2);

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `absences`
--
ALTER TABLE `absences`
  ADD KEY `fk_absperson` (`idpersonnels`),
  ADD KEY `fk_absmotifs` (`idmotifs`);

--
-- Index pour la table `motifs`
--
ALTER TABLE `motifs`
  ADD PRIMARY KEY (`idmotifs`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
