using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RacingGame
{
    class GameLogic
    {
        public Player player;
        public Road road1;
        public Road road2;
        public List<Barrier> barriers;
        int i;
        int u;
        float[] pos = new float[] {0 ,26, 147, 268, 389 };
        public bool GameOver = false;
        public int score;
        public bool bost;
        public int endBoost;
        int q;
        /*
         *1.Игрок
         * 1.1 Действия игрока(Движение вправо влево)
         * 1.2 Скорость игрока
         * 1.3 Очки игрока
         * 2. Дорога
         * 2.1 Скорость дороги(скорость игрока одинаково)
         * 2.2 постоянное движение дороги
         * 3. Препятствия
         * 3.1 Статичные препятствия
         * 3.1.1 Появление препятствий 
         * 3.1.2 Движение препятствий
         * 3.2 Движущиеся препятствия(машины)
         * 3.2.1 Появление препятсвий
         * 3.2.2 Выбор скорости встречного препятствия 
         * 4. Начало и конец игры
         * 4.1 Старт
         * 4.2 Конец игры при аварии
         */
        public void GameStart()
        {
            player = new Player();
            road1 = new Road();
            road2 = new Road();
            barriers = new List<Barrier>();
            player.cord = new Coord() { x = 26, y = 500 };
            player.speed = 1;
            road1.speed = player.speed;
            road1.coord = new Coord() { x = 0, y = 0 };
            road2.speed = player.speed;
            road2.coord = new Coord() { x = 0, y = 700 };
            i = 0;
            GameOver = false;
            score = 0;
            bost = false;
            endBoost = 0;
            q = 0;
        }
        public void Game()
        {

            MoveRoad(); // Двигаем дорогу
            if (i == 50)//Скорость создания барьеров
            {
                i = 0;
                CreatBarriers();
            }
            else i++;
            
            if (q == 500)//Скорость создания барьеров
            {
                q = 0;
                CreatBoost();
            }
            else q++;
            if (u == 350)
            {
                u = 0;
                player.speed += 0.5f;
            } else
            {
                u++;
            }
            MoveBarier();
            //// устанавливаем метод обратного вызова
            //TimerCallback tm = new TimerCallback(MoveRoad);
            //// создаем таймер
            //Timer timer = new Timer(tm, 0, 0, 200);
        }
        // разделить класс барьер на обьекты
        // буст
        private void MoveBarier()
        {
            for (int i = 0; i < barriers.Count(); i++)
            {
                if (barriers[i] is car)
                {
                    barriers[i].coord = new Coord() { x = barriers[i].coord.x, y = barriers[i].coord.y + player.speed + (barriers[i] as car).speed };
                }
                else
                {
                    barriers[i].coord = new Coord() { x = barriers[i].coord.x, y = barriers[i].coord.y + player.speed };
                }
                if (barriers[i].coord.y >= player.cord.y - 15 && barriers[i].coord.x == player.cord.x)
                {
                    if (barriers[i] is Boost)
                    {
                        bost = true;
                        endBoost = score + (barriers[i] as Boost).jump;
                    }
                }
                if (barriers[i].coord.y >= player.cord.y - 15 && barriers[i].coord.x == player.cord.x && score>endBoost) GameOver = true;
                if (barriers[i].coord.y > 550)
                {
                    barriers.RemoveAt(i);
                    score++;
                }
            }
        }

        private void CreatBarriers()
        {
            Random random = new Random();
            switch (random.Next(0,3))
            {
                case 0:

                    break;
                case 1:
                    CreatBarriersstatic();
                    break;
                case 2:
                    CreatBarriersCar();
                    break;
            }
        }

        private void CreatBarriersCar()
        {
            Random random = new Random();
            Coord coord1 = new Coord() { x = player.cord.x, y = 10 }; 
            barriers.Add(new car { speed = random.Next(3, 10)+player.speed, coord = coord1 });
        }

        private void CreatBarriersstatic()
        {
            Random random = new Random();
            Coord coord1 = new Coord() { x = pos[random.Next(0,5)] , y = 10 };
            barriers.Add(new Barrier { coord = coord1 });

        }

        private void CreatBoost()
        {
            Random random = new Random();
            Coord coord1 = new Coord() { x = pos[random.Next(0, 5)], y = 10 };
            barriers.Add(new Boost { coord = coord1 , jump = random.Next(0,9)});
        }

        protected void MoveRoad()
        {
            if (road1.coord.y > 700) road1.coord.y = -699;
            if (road2.coord.y > 700) road2.coord.y = -699;
            road1.coord = new Coord() { x = 0, y = road1.coord.y + player.speed };
            road2.coord = new Coord() { x = 0, y = road2.coord.y + player.speed };
        }
        public void Move_Player_Right()
        {
            if (player.cord.x < 389) player.cord = new Coord() { x = player.cord.x + 121, y = player.cord.y };
        }
        public void Move_Player_Left()
        {
            if (player.cord.x > 145) player.cord = new Coord() { x = player.cord.x - 121, y = player.cord.y };
        }
    }
}
