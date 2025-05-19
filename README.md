

# design pattern ?

🌟 Un design pattern (ou patron de conception en français) est une solution générique et réutilisable à un problème récurrent de conception logicielle.

🔍 Définition simple

C’est comme un modèle de best practices que les développeurs utilisent pour résoudre des problèmes courants, sans réinventer la roue à chaque fois.

📌 À quoi ça sert ?

✅ Éviter les erreurs : solutions déjà testées et éprouvées.

✅ Améliorer la maintenabilité : code plus clair et structuré.

✅ Faciliter la communication : termes communs entre devs (ex: "On utilise un Singleton ici").

🏗 3 Catégories de Design Patterns (GoF)

<div class="markdown-table-wrapper"><table><thead><tr><th>Type</th><th>Exemple</th><th>Problème résolu</th></tr></thead><tbody><tr><td><strong>Créationnel</strong></td><td>Singleton, Factory</td><td>Comment créer des objets de manière optimale ?</td></tr><tr><td><strong>Structurel</strong></td><td>Adapter, Decorator</td><td>Comment composer des classes/objets ?</td></tr><tr><td><strong>Comportemental</strong></td><td>Observer, Strategy</td><td>Comment gérer les interactions entre objets ?</td></tr></tbody></table></div>




# Strategy Pattern (Patron Stratégie) 🎯

Le Strategy Pattern est un pattern comportemental qui permet de définir une famille d'algorithmes, de les encapsuler dans des classes séparées et de les rendre interchangeables.

📌 Problème résolu

<ul>
    <li> Vous avez plusieurs variantes d'un algorithme (ex : différents types de tris, méthodes de paiement, règles de calcul).           </li>
    <li> Vous voulez <strong>éviter les <code>if/else</code> ou <code>switch</code></strong> complexes pour choisir entre ces algorithmes.</li>
    <li> Vous souhaitez <strong>pouvoir changer l'algorithme à l'exécution</strong>.                                                      </li>
</ul>

🎯 Structure du Pattern

## 1. Composants clés

<table>
    <thead><tr>         <th> Composant </th>                        <th> Rôle </th></tr></thead>
    <tbody>
      <tr><td><strong><code> Strategy          </code></strong></td><td> Interface commune à tous les algorithmes (ex: <code>PaymentStrategy</code>).                         </td></tr>
      <tr><td><strong><code> ConcreteStrategy  </code></strong></td><td> Implémentations spécifiques (ex: <code>CreditCard</code>, <code>PayPal</code>, <code>Bitcoin</code>).</td></tr>
      <tr><td><strong><code> Context           </code></strong></td><td> Classe qui utilise une stratégie (ex: <code>ShoppingCart</code>).                                    </td></tr>
    </tbody>
</table>


## 2. Diagramme simplifié

![image](https://github.com/user-attachments/assets/0017344a-7081-4a6a-b0ab-6cc716ef1173)

💡 En Résumé

- Context délègue le comportement à Strategy.

- La flèche <>─── montre que Context dépend de l'interface Strategy, pas des implémentations.

📌 Différence avec d'autres Relations UML

<table><thead><tr><th>Relation</th><th>Symbole</th><th>Exemple</th><th>Description</th></tr></thead><tbody><tr><td><strong>Agrégation</strong></td><td><code>&lt;&gt;───</code></td><td><code>Context</code> → <code>Strategy</code></td><td><code>Context</code> utilise <code>Strategy</code> (liens faibles).</td></tr><tr><td><strong>Composition</strong></td><td><code>◆───</code></td><td><code>Maison</code> → <code>Pièce</code></td><td><code>Pièce</code> ne peut exister sans <code>Maison</code>.</td></tr><tr><td><strong>Héritage</strong></td><td><code>▷────</code></td><td><code>Chien</code> → <code>Animal</code></td><td>Relation "est un".</td></tr></tbody></table>


## 🎯 Pourquoi cette Relation ?

- Découplage : Context ne dépend pas des implémentations concrètes (ConcreteStrategyA, B...).

- Flexibilité : On peut changer de stratégie à l'exécution avec setStrategy().

- Extensibilité : Ajouter une nouvelle stratégie ne modifie pas Context.


# Exemple AdventureGame


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


