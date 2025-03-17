
namespace ChessGame;

// Piece.cs
public abstract class Piece
{
    private readonly bool _isWhite;
    private bool _isKilled;

    public Piece(bool isWhite)
    {
        _isWhite = isWhite;
        _isKilled = false;
    }

    public abstract bool CanMove(Board board, Block startBlock, Block endBlock);

    public bool IsWhite => _isWhite;
    public bool IsKilled => _isKilled;
    public void SetKilled(bool killed) => _isKilled = killed;
}
// King.cs
public class King : Piece
{
    public King(bool isWhite) : base(isWhite) { }

    public override bool CanMove(Board board, Block startBlock, Block endBlock)
    {
        return false; // Add actual movement logic later
    }
}

// Queen.cs
public class Queen : Piece
{
    public Queen(bool isWhite) : base(isWhite) { }

    public override bool CanMove(Board board, Block startBlock, Block endBlock)
    {
        return false; // Add actual movement logic later
    }
}

// Bishop.cs
public class Bishop : Piece
{
    public Bishop(bool isWhite) : base(isWhite) { }

    public override bool CanMove(Board board, Block startBlock, Block endBlock)
    {
        return false; // Add actual movement logic later
    }
}

// Knight.cs
public class Knight : Piece
{
    public Knight(bool isWhite) : base(isWhite) { }

    public override bool CanMove(Board board, Block startBlock, Block endBlock)
    {
        return false; // Add actual movement logic later
    }
}

// Rook.cs
public class Rook : Piece
{
    public Rook(bool isWhite) : base(isWhite) { }

    public override bool CanMove(Board board, Block startBlock, Block endBlock)
    {
        return false; // Add actual movement logic later
    }
}

// Pawn.cs
public class Pawn : Piece
{
    public Pawn(bool isWhite) : base(isWhite) { }

    public override bool CanMove(Board board, Block startBlock, Block endBlock)
    {
        return false; // Add actual movement logic later
    }
}