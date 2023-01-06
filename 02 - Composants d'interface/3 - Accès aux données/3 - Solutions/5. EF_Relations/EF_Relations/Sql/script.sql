--
-- Base de données : `ef_relations`
--
-- --------------------------------------------------------

--
-- Structure de la table `commandes`
--

DROP TABLE IF EXISTS `commandes`;
CREATE TABLE IF NOT EXISTS `commandes` (
  `idCommande` int(11) NOT NULL AUTO_INCREMENT,
  `libelleCommande` varchar(50) NOT NULL,
  PRIMARY KEY (`idCommande`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `commandes`
--

INSERT INTO `commandes` (`idCommande`, `libelleCommande`) VALUES
(1, 'cde1'),
(2, 'de2');

-- --------------------------------------------------------

--
-- Structure de la table `contenus`
--

DROP TABLE IF EXISTS `contenus`;
CREATE TABLE IF NOT EXISTS `contenus` (
  `idProduit` int(11) NOT NULL,
  `idCommande` int(11) NOT NULL,
  `Quantite` int(11) NOT NULL,
  PRIMARY KEY (`idProduit`,`idCommande`),
  KEY `fk_contenus_commandes` (`idCommande`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `contenus`
--

INSERT INTO `contenus` (`idProduit`, `idCommande`, `Quantite`) VALUES
(1, 1, 1),
(1, 2, 2);

-- --------------------------------------------------------

--
-- Structure de la table `produits`
--

DROP TABLE IF EXISTS `produits`;
CREATE TABLE IF NOT EXISTS `produits` (
  `IdProduit` int(11) NOT NULL AUTO_INCREMENT,
  `LibelleProduit` varchar(50) NOT NULL,
  PRIMARY KEY (`IdProduit`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `produits`
--

INSERT INTO `produits` (`IdProduit`, `LibelleProduit`) VALUES
(1, 'prod1'),
(2, 'Prod2');

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `contenus`
--
ALTER TABLE `contenus`
  ADD CONSTRAINT `fk_contenus_commandes` FOREIGN KEY (`idCommande`) REFERENCES `commandes` (`idCommande`),
  ADD CONSTRAINT `fk_contenus_produits` FOREIGN KEY (`idProduit`) REFERENCES `produits` (`IdProduit`);

