# 🧠 Demo Console App — .NET 8 (Async / Await + Logging)

Petit exemple d’application console développée avec **C# (.NET 8)**, illustrant :

- L’utilisation d’**async/await** pour des traitements asynchrones  
- La **gestion d’erreurs** (`try/catch/finally`)  
- Un **système de log simple** avec horodatage  
- Des **bonnes pratiques** de validation et de structure de code  

---

## 🚀 Aperçu du projet

Ce petit projet demande à l’utilisateur de saisir un nombre, puis calcule son carré de manière asynchrone.

En cas d’entrée invalide ou d’erreur, le programme enregistre un message clair avec un **horodatage** et un **niveau de sévérité**.

📸 Exemple d’exécution :

Bienvenue! Tapez un nombre pour calculer son carré :
5
2025-10-04 20:00:00 [INFO] Le carré de 5 est 25


---

## ⚙️ Technologies utilisées

| Composant | Description |
|------------|-------------|
| **.NET 8** | Framework moderne pour le développement multiplateforme |
| **C#** | Langage principal |
| **Async/Await** | Gestion de tâches asynchrones |
| **try/catch** | Gestion des exceptions |
| **Console Logging** | Système de log simple avec timestamps |

---

## 🧩 Structure du code

- **Entrée utilisateur** : via `Console.ReadLine()`  
- **Validation** : `int.TryParse()`  
- **Traitement asynchrone** : méthode locale `CalculateSquareAsync()`  
- **Gestion des erreurs** : `try/catch`  
- **Logging** : fonction `Log()` avec horodatage et niveaux `[INFO] / [ERREUR]`

---

## 🧪 Exécution locale

### 1️⃣ Cloner le dépôt
```bash
git clone https://github.com/gilberto00/console-app-async-logging.git
cd console-app-async-logging



dotnet run



Bienvenue! Tapez un nombre pour calculer son carré :
-3
2025-10-04 20:05:10 [ERREUR] Le nombre ne peut pas être négatif.


📚 Concepts démontrés

✅ Utilisation des top-level statements (nouveauté .NET 6+)
✅ Utilisation d’un traitement asynchrone (Task / await)
✅ Séparation claire entre logique, validation et logging
✅ Gestion d’exceptions propre et informative

🧠 Auteur

👤 Gilberto Couto Pereira Rosa
📍 Saint-Roch-de-Richelieu, QC
📧 gilberto00@gmail.com

🔗 LinkedIn

💡 Objectif du projet

Ce projet a été créé pour démontrer des pratiques simples mais essentielles en développement .NET :

Comment structurer une application console moderne

Comment tracer et gérer les erreurs efficacement

Comment appliquer l’asynchronisme dans un flux simple


---

💡 **Dica extra:**  
Se quiser, posso gerar **uma versão em inglês** também (útil caso você decida usar o mesmo projeto no LinkedIn ou portfolio internacional).  
Quer que eu gere a versão em inglês também?
