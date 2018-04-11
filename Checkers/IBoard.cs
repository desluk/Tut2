using System;
using System.Collections.Generic;
using System.Text;

namespace Checkers
{
    public interface IBoard
    {
        IPiece Occupant(int position);
        IEnumerable<int> Pieces(Color color); // This is used instead of List<int> as there will allow a list,array,queue,etc to be used as well.
        void Move(IPiece piece, int destination);
        void RemoveCapturedPieces();
        void Promote(IPiece piece);
    }

    public enum Color {Black, White};
    public enum Status { Capture, active};

    public interface IPiece
    {
        IEnumerable<int> NormalMoves(IBoard board);
        IEnumerable<int> CapturingMoves(IBoard board);
        Status Status { get; }
        Color color { get; }
        int Position { get; }
        void Move(int destination);
    }

    public interface IPlayer
    {
        string Name { get; }
        (int, int) GetMove();

    }

    public interface IReferee
    {
        IPlayer Winner();
        bool IsDraw();
        void Play();
    }

    public class IllegalMoveException : ApplicationException { }

}
