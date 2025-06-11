# Syst�me de Gestion d'H�tel

Ce projet a pour objectif de d�velopper une application API web en C# pour la gestion d'un h�tel, couvrant divers aspects comme la r�servation de chambres, la gestion des clients, le personnel et les services de l'h�tel.

L'objectif est d'appliquer les concepts de programmation orient�e objet, les patterns d'architecture et de conception, et de d�velopper une application fonctionnelle et s�curis�e.

## Execution du projet
Mettre le projet `HotelManagement.Api.UI` en projet de demarrage et le lancer avec le https
pour que le swagger s'ouvre sous l'url `https://localhost:7080/swagger/index.html`

une fois cela fait , il faut importer la collection postman presente dans le projet
`HotelManagement.Api.UI` ( `hotel management.postman_collection.json`)

dans ce json il y a les routes d'auth avec 3 requetes
- ce connecter avec le compte client
- ce connecter avec le compte receptionniste
- ce connecter avec le compte personnel de m�nage


Ensuite les requete li� au chambre et les requete li� au reservations et au payment


# Architecture
Une Clean archi DDD a �t� faite pour ce projet avec different partern :
- factory pattern
- strategy pattern
- repository pattern
- singleton pattern
- un system de useCase mise en place qui fait office de command pattern ( pseudo CQRS )
- respect des principe SOLID


# Stockage
Pour ce projet un system de persitance de donn�e en json a ete choisi pour eviter de prendre trop de temps sur la connection bdd avec EF core \
On a simuler un context comme EF core qui nous permet de faire un CRUD sur nos donn�es
### Amelioration
- Mise en place d'une bdd Sqlserver ou postgreSQL et installer et confiruration de EFcore pour mapper nos model avec nos table en BDD
- Mise en place d'un Unit of work
- amelioration du repository pattern


# Utilisateur
il y a une route de creation des utilisateurs pour tester nos route avec un [role](./HotelManagement.Domain/Users/RoleType.cs) assosier a chaque utilisateur \
Le mot de passe est cryper grace � la methode `PasswordHasher` fourni par dotnet \
Un system de Login est fait qui renvoie un bearer Token  et les endpoints sont soumis a u system d'authorisation et meme parfois d'accessibilit� selon le role de l'utilisateur

# D�fis Rencontrer
- Apprentissage du c#
- Apprentiisage dotnet
- Charge de travail et timing

# Axe amelioration
- Mise en place du vrai system de commande pattern
- Mise en place du CQRS avec MediaTor
- Mise en place TDD
- Envoie de notifications 
- Creer une interface front end




