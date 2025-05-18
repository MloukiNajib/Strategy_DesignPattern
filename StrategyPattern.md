# Strategy Pattern (Patron Stratégie) 🎯

Le Strategy Pattern est un pattern comportemental qui permet de définir une famille d'algorithmes, de les encapsuler dans des classes séparées et de les rendre interchangeables.

📌 Problème résolu
Vous avez plusieurs variantes d'un algorithme (ex : différents types de tris, méthodes de paiement, règles de calcul).

Vous voulez éviter les if/else ou switch complexes pour choisir entre ces algorithmes.

Vous souhaitez pouvoir changer l'algorithme à l'exécution.

🎯 Structure du Pattern

1. Composants clés

<table>
    <thead><tr>         <th> Composant </th>                        <th> Rôle </th></tr></thead>
    <tbody>
      <tr><td><strong><code> Strategy          </code></strong></td><td> Interface commune à tous les algorithmes (ex: <code>PaymentStrategy</code>).                         </td></tr>
      <tr><td><strong><code> ConcreteStrategy  </code></strong></td><td> Implémentations spécifiques (ex: <code>CreditCard</code>, <code>PayPal</code>, <code>Bitcoin</code>).</td></tr>
      <tr><td><strong><code> Context           </code></strong></td><td> Classe qui utilise une stratégie (ex: <code>ShoppingCart</code>).                                    </td></tr>
    </tbody>
</table>


2. Diagramme simplifié

┌───────────────────---┐       ┌───────────────────────┐
│     Context          │       │      Strategy         │
├───────────────────---┤       ├───────────────────────┤
│ - strategy: Strategy │<>──--─│ + executeAlgorithm()  │
└──────────────────---─┘       └───────────────────────┘
                                          ^
                         _________________|____________
                        |                              |
            ┌─────────────────────┐        ┌─────────────────────┐
            │  ConcreteStrategyA  │        │  ConcreteStrategyB  │
            └─────────────────────┘        └─────────────────────┘



