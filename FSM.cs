using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class FSM<T>
    {
        public FSM()
        {
            
            states = new Dictionary<string, State>();
            var v = Enum.GetValues(typeof(T));
            foreach (var e in v) 
            {
                State s = new State(e as Enum);
                states.Add(s.name, s);
            }
        }
        Dictionary<string, State> states;
        State cState;

        State current;

        public void ChangeState(T state)
        {
            string Key = CurrentPlayer.ToString() + "->" + (state as Enum).ToString();



            if (isValidTransition(state))
            {
                cState.onExit();
                cState = state;
                cState.onExit();
            }
        }

      

        public bool AddState(State state)
        {
            if(transitions[state.name] == null)
            {
                transitions.Add(state.name, new List<State>());
                return true;
            }
            return false;
        }


        public bool AddTransition<V>(V a, V b)
        {
            State s = a as State;
            var tmp = transitions[s.name];

            return true;
        }


        public State GetState(T e)
        {
            string key = (e as State).name;
            return states[key];
        }



        private Dictionary<string, List<State>> transitions = new Dictionary<string, List<State>>();
        private bool isValidTransition(State to)
        {
            var validStates = transitions[cState.name];
            if (validStates == null)
                return false;
            foreach (var state in validStates)
            {
                if (state == to)
                    return true;
            }
            return false;
        }




            public bool Start(T state)
        {
            return true;
        }




        public bool Update()
        {
            return true;
        }



        }
    }

