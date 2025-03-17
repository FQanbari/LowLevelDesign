
namespace ChessGame;

// Board.cs
public class Board
{
    private readonly Block[,] _blocks;

    public Board()
    {
        _blocks = new Block[8, 8];
        InitializeBoard();
    }

    private void InitializeBoard()
    {
        // Setting White Pieces
        _blocks[0, 0] = new Block(0, 0, new Rook(true));
        _blocks[0, 1] = new Block(0, 1, new Knight(true));
        _blocks[0, 2] = new Block(0, 2, new Bishop(true));
        _blocks[0, 3] = new Block(0, 3, new Queen(true));
        _blocks[0, 4] = new Block(0, 4, new King(true));
        _blocks[0, 5] = new Block(0, 5, new Bishop(true));
        _blocks[0, 6] = new Block(0, 6, new Knight(true));
        _blocks[0, 7] = new Block(0, 7, new Rook(true));

        for (int j = 0; j < 8; j++)
        {
            _blocks[1, j] = new Block(1, j, new Pawn(true));
        }

        // Setting Black Pieces
        _blocks[7, 0] = new Block(7, 0, new Rook(false));
        _blocks[7, 1] = new Block(7, 1, new Knight(false));
        _blocks[7, 2] = new Block(7, 2, new Bishop(false));
        _blocks[7, 3] = new Block(7, 3, new Queen(false));
        _blocks[7, 4] = new Block(7, 4, new King(false));
        _blocks[7, 5] = new Block(7, 5, new Bishop(false));
        _blocks[7, 6] = new Block(7, 6, new Knight(false));
        _blocks[7, 7] = new Block(7, 7, new Rook(false));

        for (int j = 0; j < 8; j++)
        {
            _blocks[6, j] = new Block(6, j, new Pawn(false));
        }

        // Defining rest of the blocks with no pieces
        for (int i = 2; i < 6; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                _blocks[i, j] = new Block(i, j, null);
            }
        }
    }

    public Block this[int x, int y] => _blocks[x, y]; // Indexer for easier access
}
// Block.cs
public class Block
{
    public int X { get; }
    public int Y { get; }
    public string Label { get; }
    private Piece? _piece;

    public Block(int x, int y, Piece? piece)
    {
        X = x;
        Y = y;
        Label = AssignLabel(x, y);
        _piece = piece;
    }

    private static string AssignLabel(int x, int y)
    {
        string[] xLabels = ["1", "2", "3", "4", "5", "6", "7", "8"];
        string[] yLabels = ["A", "B", "C", "D", "E", "F", "G", "H"];
        return $"{xLabels[x]}{yLabels[y]}";
    }

    public Piece? GetPiece() => _piece;
    public void SetPiece(Piece? piece) => _piece = piece;
}
// Move.cs
public class Move
{
    private readonly Block _startBlock;
    private readonly Block _endBlock;

    public Move(Block startBlock, Block endBlock)
    {
        _startBlock = startBlock ?? throw new ArgumentNullException(nameof(startBlock));
        _endBlock = endBlock ?? throw new ArgumentNullException(nameof(endBlock));
    }

    public bool IsValid()
    {
        Piece? startPiece = _startBlock.GetPiece();
        Piece? endPiece = _endBlock.GetPiece();
        if (startPiece == null || endPiece == null) return true; // If end is empty, move is valid
        return startPiece.IsWhite != endPiece.IsWhite;
    }

    public Block StartBlock => _startBlock;
    public Block EndBlock => _endBlock;
}