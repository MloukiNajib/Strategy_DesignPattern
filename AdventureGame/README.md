


![image](https://github.com/user-attachments/assets/d1ebb4bc-f65d-4359-8598-e09ae20c61d8)


# Explication de la Relation UML entre Context (Personnage) et Strategy (IUtiliserArme) 🎯

## Context (Personnage) <>─── Strategy (IUtiliserArme) 

Le diagramme UML montre une relation de dépendance (flèche en pointillés <>───) entre :

1. Context (Personnage) → La classe qui utilise une stratégie.
2. Strategy (IUtiliserArme) → L'interface définissant le contrat des algorithmes.


🔍 Détail de la Relation

1. Type de Relation : Agrégation (ou Dépendance selon les cas)
2. Symbolisée par : <>─── (flèche en pointillés + losange vide en UML).

Signification :

1. Context utilise une implémentation de Strategy, mais ne la possède pas (pas de gestion du cycle de vie).
2. Strategy peut être interchangée dynamiquement (ex: setStrategy()).


