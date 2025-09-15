# Exercice: RandoReduce

Voir un tracé de randonnée sur une carte, c'est un bon début, mais un randonneur aime aussi savoir quel est le dénivelé ainsi que la longueur du tracé.

## Réduction

1. Calculer la longueur du tracé, son dénivelé positif et négatif, affichez ces valeurs dans un coin de la fenêtre
2. Ajouter un bouton pour réduire le nombre de points: on ne garde qu'un point sur cinq
3. Ajouter un autre bouton pour une réduction plus intelligente: au lieu de supprimer un point tout les X points, on ne garde que un point tous les 100m. (indice: commencer par une transformation qui ajoute à chaque point la distance qui le sépare du début de la rando. Diviser cette distance par 100 et grouper par cette valeur)
