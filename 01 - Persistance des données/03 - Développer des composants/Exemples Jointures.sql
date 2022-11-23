-- on prend toutes les colonnes des 2 tables
SELECT commandes.`idCommande`, commandes.`idClient`, commandes.`idArticle`, commandes.`dateCommande`, commandes.`quantiteCommande`, commandes.`cde_total`, 
    articles.descriptionArticle, articles.prixArticle 
FROM `commandes` 
-- on crée la jointure entre les tables en matérialisant le lien du concepteur
INNER JOIN articles ON commandes.idArticle = articles.idArticle 

-- on crée le lien entre les tables, puis on multiplie les colonnes
SELECT MAX( commandes.quantiteCommande * articles.prixArticle ) 
FROM `commandes` 
INNER JOIN articles ON commandes.idArticle = articles.idArticle 

-- liens entre plusieurs tables
SELECT clients.nomClient,
	articles.descriptionArticle,
    commandes.dateCommande,
    commandes.quantiteCommande
FROM commandes
INNER JOIN clients ON commandes.idClient = clients.idClient
INNER JOIN articles ON commandes.idArticle = articles.idArticle

-- autres solutions avec alias

SELECT cl.nomClient,
	a.descriptionArticle,
    co.dateCommande,
    co.quantiteCommande
FROM commandes as co
INNER JOIN clients as cl ON co.idClient = cl.idClient
INNER JOIN articles as a ON co.idArticle = a.idArticle