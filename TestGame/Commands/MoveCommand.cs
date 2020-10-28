﻿using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TestGame.Interfaces;

namespace TestGame.Commands
{
    public class MoveCommand : IGameCommand
    {
        public Vector2 speed;

        public MoveCommand()
        {
            this.speed = new Vector2(5, 0);
        }

        public void Execute(ITransform transform, Vector2 direction)
        {
            direction *= speed;
            transform.Position += direction;
        }

        public void Undo()
        {
            throw new NotImplementedException();
        }
    }
}
