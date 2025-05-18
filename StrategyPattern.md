# Strategy Pattern (Patron Stratégie) 🎯

Le Strategy Pattern est un pattern comportemental qui permet de définir une famille d'algorithmes, de les encapsuler dans des classes séparées et de les rendre interchangeables.

📌 Problème résolu

<ul>
    <li> Vous avez plusieurs variantes d'un algorithme (ex : différents types de tris, méthodes de paiement, règles de calcul).           </li>
    <li> Vous voulez <strong>éviter les <code>if/else</code> ou <code>switch</code></strong> complexes pour choisir entre ces algorithmes.</li>
    <li> Vous souhaitez <strong>pouvoir changer l'algorithme à l'exécution</strong>.                                                      </li>
</ul>

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

![image](https://github.com/user-attachments/assets/0017344a-7081-4a6a-b0ab-6cc716ef1173)




