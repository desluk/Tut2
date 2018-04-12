using System;
using System.Collections.Generic;
using System.Text;

namespace Checkers
{
     public class Piece : IPiece
    {
        public Piece (Color c, int pos)
        {
            Status = Status.active;
            Position = pos;
            Color = c;
        }
        public virtual Status Status { get; set; }

        public virtual Color Color { get; private set; }

        public virtual int Position { get; private set; }

        public virtual IEnumerable<int> CapturingMoves(IBoard board)
        {
            throw new NotImplementedException();
        }

        public virtual void Move(int destination)
        {
            throw new NotImplementedException();
        }

        public virtual IEnumerable<int> NormalMoves(IBoard b)
        {
            List<int> result = new List<int>();
            int col = (Position - 1) % 4;
            int row = (Position - 1) / 4;
            bool sideSpace = (col == 0 && row % 2 == 1) || (col == 3 && row % 2 == 0);
            if (Color == Color.Black)
            {
                int next = Position + 3;
                if (row % 2 == 0 || col == 0) next++;
                if (next <= 32 && b.Occupant(next) == null)
                {
                    result.Add(next);
                }
                next++;
                if (!sideSpace && next <= 32 && b.Occupant(next) == null)
                {
                    result.Add(next);
                }
            }
            else
            {
                
                    int next = Position - 3;
                    if (row % 2 == 1 || col == 3) next--;
                    if (next >= 1 && b.Occupant(next)==null)
                    {
                        result.Add(next);
                    }
                    next--;
                    if (!sideSpace && next >= 1 && b.Occupant(next) == null)
                    {
                        result.Add(next);
                    }
                
            }
            return result;

        }
    }
}
