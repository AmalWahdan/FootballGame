// See https://aka.ms/new-console-template for more information
using ObserverPattern;
using ObserverPattern.ObserverConcrrete;
using ObserverPattern.SubjectConcrete;

Observer player = new Player(1,"Ali");
Observer player1 = new Player(2,"Ahmed");
Observer player2 = new Player(3,"Mohamed");
Observer referee = new Referee(1, "Mohsen");

FootBall ball = new FootBall();
ball.AttachObserver(player);
ball.AttachObserver(player1);
ball.AttachObserver(player2);
ball.AttachObserver(referee);

ball.SetBallPosition(new Position(5, 10, 3));

ball.NotifyObserver();

