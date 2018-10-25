using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusChange
{
    public class MouseStatus
    {
        public int x_down { get; set; }
        public int y_down { get; set; }
        public bool isDown { get; set; }
    }

    public class PlayerStatus
    {
        public int x { get; set; }
        public int y { get; set; }
        public int velocity { get; set; }
        public int direction { get; set; }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            var player = new PlayerStatus
            {
                x = 0,
                y = 0,
                velocity = 0
            };
            var mouse = new MouseStatus
            {
                x_down = 10,
                y_down = 10,
                isDown = true
            };

            CallThisEveryFrame(mouse, player);
        }

        public static void CallThisEveryFrame(MouseStatus mouse, PlayerStatus player)
        {
            if (mouse.isDown)
            {
                MovePlayer(mouse, player);
            }
            else
            {
                StopPlayer(mouse, player);
            }
        }

        public static void MovePlayer(MouseStatus mouse, PlayerStatus player)
        {
            if (mouse.x_down != player.x || mouse.y_down != player.y)
            {
                player.velocity = 10;
                player.direction = SetPlayerDirection();
            }
        }

        public static void StopPlayer(MouseStatus mouse, PlayerStatus player)
        {
            if (mouse.x_down == player.x && mouse.y_down == player.y && player.velocity != 0)
            {
                player.velocity = 0;
                player.direction = SetPlayerDirection();
            }
        }

        public static int SetPlayerDirection()
        {
            //To Do
            return 0;
        }
    }
}
