using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;


namespace InitialTrainingLibrary.dysq.Chess
{
    public class CreateFigures
    {
        public ChessBoard Chess { get; private set; }

       

        public CreateFigures()
        {
            FigureFactory.CreateFigure(FigureKind.Queen, 1, 1, true);
            Chess = new ChessBoard();

             var fields = Chess.GetFields();

         
            //black figures
            fields[0,0].SetFigure(FigureFactory.CreateFigure(FigureKind.Rook, 0,0, false));
            fields[1,0].SetFigure(FigureFactory.CreateFigure(FigureKind.Horse, 1,0, false));
            fields[2,0].SetFigure(FigureFactory.CreateFigure(FigureKind.Bishop, 2,0, false));
            fields[3,0].SetFigure(FigureFactory.CreateFigure(FigureKind.Queen, 3,0, false));
            fields[4,0].SetFigure(FigureFactory.CreateFigure(FigureKind.King, 4,0, false));
            fields[5,0].SetFigure(FigureFactory.CreateFigure(FigureKind.Bishop, 5,0, false));
            fields[6,0].SetFigure(FigureFactory.CreateFigure(FigureKind.Horse, 6,0, false));
            fields[7,0].SetFigure(FigureFactory.CreateFigure(FigureKind.Rook, 7,0, false));

           

            //Pawn figures
            //for (int i = 0; i < 8; i++)
            //{
            //    fields[i, 1].SetFigure(FigureFactory.CreateFigure(FigureKind.Pawn, i, 1, false));
            //    fields[i,6].SetFigure(FigureFactory.CreateFigure(FigureKind.Pawn, i,6, true));
            //}

            SetPawns();

            //white figures
            fields[0,7].SetFigure(FigureFactory.CreateFigure(FigureKind.Rook, 0,7, true));
            fields[1,7].SetFigure(FigureFactory.CreateFigure(FigureKind.Horse, 1,7, true));
            fields[2,7].SetFigure(FigureFactory.CreateFigure(FigureKind.Bishop, 2,7, true));
            fields[3,7].SetFigure(FigureFactory.CreateFigure(FigureKind.Queen, 3,7, true));
            fields[4,7].SetFigure(FigureFactory.CreateFigure(FigureKind.King, 4,7, true));
            fields[5,7].SetFigure(FigureFactory.CreateFigure(FigureKind.Bishop, 5,7, true));
            fields[6,7].SetFigure(FigureFactory.CreateFigure(FigureKind.Horse, 6,7, true));
            fields[7,7].SetFigure(FigureFactory.CreateFigure(FigureKind.Rook, 7,7, true));

       
        }

        private void SetPawns()
        {
            var fields = Chess.GetFields();

            for (int i = 0; i < 8; i++)
            {
                fields[i, 1].SetFigure(FigureFactory.CreateFigure(FigureKind.Pawn, i, 1, false));
                fields[i, 6].SetFigure(FigureFactory.CreateFigure(FigureKind.Pawn, i, 6, true));
            }
        }
    }
}
