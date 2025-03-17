
namespace ChessGame;

// Game.cs
public class Game
{
    private readonly Board _board;
    private readonly Player _player1; // White
    private readonly Player _player2; // Black
    private bool _isWhiteTurn;
    private readonly List<Move> _gameLog;
    private Status _status;

    public Game(Player player1, Player player2)
    {
        _player1 = player1 ?? throw new ArgumentNullException(nameof(player1));
        _player2 = player2 ?? throw new ArgumentNullException(nameof(player2));
        _board = new Board();
        _isWhiteTurn = true;
        _status = Status.Active;
        _gameLog = new List<Move>();
    }

    public void Start()
    {
        while (_status == Status.Active)
        {
            // Player input would need to be implemented
            // For now, it's a placeholder
            if (_isWhiteTurn)
            {
                // MakeMove(new Move(startBlock, endBlock), _player1);
            }
            else
            {
                // MakeMove(new Move(startBlock, endBlock), _player2);
            }
        }
    }

    public void MakeMove(Move move, Player player)
    {
        ArgumentNullException.ThrowIfNull(move);
        ArgumentNullException.ThrowIfNull(player);

        if (!move.IsValid()) return;

        Piece? sourcePiece = move.StartBlock.GetPiece();
        if (sourcePiece == null) return;

        if (sourcePiece.CanMove(_board, move.StartBlock, move.EndBlock))
        {
            Piece? destinationPiece = move.EndBlock.GetPiece();

            if (destinationPiece != null)
            {
                if (destinationPiece is King)
                {
                    _status = _isWhiteTurn ? Status.WhiteWin : Status.BlackWin;
                    return;
                }
                destinationPiece.SetKilled(true);
            }

            _gameLog.Add(move);
            move.EndBlock.SetPiece(sourcePiece);
            move.StartBlock.SetPiece(null);
            _isWhiteTurn = !_isWhiteTurn;
        }
    }

    public Status Status => _status;
    public IReadOnlyList<Move> GameLog => _gameLog.AsReadOnly();
}