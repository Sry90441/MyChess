public enum FieldType
{
    Black, 
    White
}
class GameField
{
    FieldType _color;
    string _fieldName;
    bool _pieceOnField;
    ChessPiece _chessPiece;
    public GameField(FieldType color, string fieldName, bool pieceOnField, ChessPiece chessPiece = null)
    {
        _color = color;
        _fieldName = fieldName;
        _pieceOnField = pieceOnField;
        if (_pieceOnField == true)
        {
            _chessPiece = chessPiece;
        }
    }
}