static class Player{
    //Action Method
    static void Left(){
        Console.WriteLine("\nGoing left");
    }

    static void Right(){
        Console.WriteLine("\nGoing right");
    }

    static void Forward(){
        Console.WriteLine("\nGoing Forward");
    }

    static void Backward(){
        Console.WriteLine("\nGoing bakcward");
    }

    static void Stop(){
        Console.WriteLine("\nStopping");
    }
    

    static void PerformAction(PlayerAction action){
        action();
    }

    

    delegate void PlayerAction();

    static void Main(){
        //instantiate delegate
        PlayerAction goForward = Forward;
        PlayerAction goBackward = Backward;
        PlayerAction goLeft = Left;
        PlayerAction goRight = Right;
        PlayerAction goRightForward = goForward + Right;
        PlayerAction goLeftForward = goForward + Left;
        PlayerAction goRightBackward = goBackward + Right;
        PlayerAction goLeftBackward = goBackward + Left;
        PlayerAction stop = Stop;

        Console.WriteLine("click for direction: W,A,S,D,Q,E,Z,X,C");
        char input =' ';

        do{
            input = Char.ToUpper(Console.ReadKey().KeyChar);
            switch(input){
                case 'W' :
                    PerformAction(goForward);
                    break;

                case 'A' :
                    PerformAction(goLeft);
                    break;
                
                case 'X' :
                    PerformAction(goBackward);
                    break;
                
                case 'D' :
                    PerformAction(goRight);
                    break;
                
                case 'Q' :
                    PerformAction(goLeftForward);
                    break;

                case 'E' :
                    PerformAction(goRightForward);
                    break;
                
                case 'Z' :
                    PerformAction(goLeftBackward);
                    break;

                case 'C' :
                    PerformAction(goRightBackward);
                    break;

                case 'S' :
                    PerformAction(stop);
                    break;
                default :
                    Console.WriteLine("\nInvalid input. Please press I,J,K,L.");
					break;
            }
        }while(input != ' ');

    }
}