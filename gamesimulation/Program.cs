using gamesimulation.Abstract;
using gamesimulation.concrete;
using gamesimulation.entity;

BasisPersonManage personManager = new PersonManager(new PersonCheckManager());

Person person = new Person() {Id = 5, Age = 22, Name = "Emir" };
personManager.Add(new Person() { Id = 10, Age = 22, Name = "Emir"});
personManager.Delete(person);
personManager.Update(person);

Offer offer = new Offer() { ID = 15, Name = "Kampanya"};
IOfferService offerManager = new OfferManager();

offerManager.Add(offer);
offerManager.Update(offer);
offerManager.Delete(offer);

Game game = new Game() { Id = 100, Name = "Last of us", Price = 500 };
IGameService gameManager = new GameManager();

gameManager.Add(game);
gameManager.Delete(game);
gameManager.Update(game);









