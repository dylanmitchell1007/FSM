using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    delegate void handler();
    delegate void Callback();
    delegate void CallbackString(State St);
    class CurrentPlayer
    {
       public CurrentPlayer()
        {
            
        }

       

    }
    class Program
    {
        static void Main(string[] args)
        {
            FSM<Player> fsm = new FSM<Player>();
            fsm.AddTransition(Player.INIT, Player.IDLE);
            fsm.AddTransition(Player.IDLE, Player.WALK);
            fsm.AddTransition(Player.WALK, Player.RUN);
            fsm.AddTransition(Player.RUN, Player.WALK);
            fsm.Start(Player.INIT);
            fsm.ChangeState(Player.IDLE);

        }
    }
   



}
