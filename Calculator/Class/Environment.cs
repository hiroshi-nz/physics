﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Class
{
    class Environment
    {
        public readonly int sizeX;
        public readonly int sizeY;
        public int[,] environment;
        

        public Environment(int sizeX, int sizeY)
        {
            this.sizeX = sizeX;
            this.sizeY = sizeY;
            
            Initialize(sizeX, sizeY);
        }
        private void Initialize(int sizeX, int sizeY)
        {
            environment = new int[sizeX, sizeY];
            for (int i = 0; i < sizeX; i++)
            {
                for (int j = 0; j < sizeY; j++)
                {
                    environment[i, j] = 0;
                }
            }
        }
        public void Refresh(List<Entities> entityList)
        {
            for (int i = 0; i < sizeX; i++)
            {
                for (int j = 0; j < sizeY; j++)
                {
                    environment[i, j] = 0;
                }
            }
            foreach(Entities entity in entityList)
            {
                //make rounding method for the simplified version

                if (Convert.ToInt16(entity.location.x) < sizeX && Convert.ToInt16(entity.location.y) < sizeY)
                {
                    environment[Convert.ToInt16(entity.location.x), Convert.ToInt16(entity.location.y)] = entity.id;
                }
                else//collision with the boundry
                {

                }            
            }
        }



    }
}
