using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.dysq.Chess.Figures;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.mg.Chess
{
    static class ReturnFigure
    {
       public static  IFigure getFigureFactory(int _x, int _y, bool _isWhite, FigureKind figureKind)
        {
            Dictionary<FigureKind, Func<int, int, bool, IFigure>> figure = new Dictionary<FigureKind, Func<int, int, bool,IFigure>>()
            {
                {FigureKind.Bishop, (x,y,isWhite)=> new Bishop(x,y,isWhite)},
                {FigureKind.Horse, (x,y,isWhite)=> new Horse(x,y,isWhite)},
                {FigureKind.King, (x,y,isWhite)=> new King(x,y,isWhite)},
                {FigureKind.Pawn, (x,y,isWhite)=> new Pawn(x,y,isWhite)},
                {FigureKind.Queen, (x,y,isWhite)=> new Queen(x,y,isWhite)},
                {FigureKind.Rook, (x,y,isWhite)=> new Rook(x,y,isWhite)}

            };

            return figure[figureKind](_x, _y, _isWhite);
        }

       public static  IFigure getFigureSwitch(int _x, int _y, bool _isWhite, FigureKind figureKind)
        {
            switch (figureKind)
            {
                case FigureKind.Bishop:
                    return new Bishop(_x,_y,_isWhite);
                   

                case FigureKind.Horse:
                    return new Horse(_x, _y, _isWhite);
                    
                case FigureKind.King:
                    return new King(_x, _y, _isWhite);
                   

                case FigureKind.Pawn:
                    return new Pawn(_x, _y, _isWhite);
                    

                case FigureKind.Queen:
                    return new Queen(_x, _y, _isWhite);
                    

                case FigureKind.Rook:
                    return new Rook(_x, _y, _isWhite);


                default:
                    return null;
            }
        }
    }
}
