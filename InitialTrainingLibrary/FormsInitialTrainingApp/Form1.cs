using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InitialTrainingLibrary.Chmura.OtherChess;
using InitialTrainingLibrary.dysq.Chess;
using InitialTrainingLibrary.frogie.chess;
using InitialTrainingLibrary.koziu.Chees;
using InitialTrainingLibrary.mg;
using InitialTrainingLibrary.syf.minesweepershowdown.board;

namespace FormsInitialTrainingApp
{
    public partial class Form1 : Form
    {
        private int coefficient = 75;

        public Form1()
        {
            InitializeComponent();
            AddChessBoard();

            
        }

        private void AddChessBoard()
        {
            this.SuspendLayout();

            //CreateFigures chesswithfigures = new CreateFigures();
            //InitialTrainingLibrary.dysq.ChessBoard chessBoard = chesswithfigures.Chess;

            //InitializeBoard chesswithfigures = new InitializeBoard();
            //var chessBoard = chesswithfigures.ChessBoard;

            //var chessBoard = new InitialTrainingLibrary.Sito._2.Board();
            //Szachownica chessBoard = new Szachownica();
            //CheesBoard chessBoard = new CheesBoard();

            ChessGame game = new ChessGame();
            game.DrawBoard();
            var chessBoard = game.MyBoard;

            var chessBoardFields = chessBoard.GetFields();

            //for (int i = 0; i < chessBoardFields.GetLength(0); i++)
            //{
            //    for (int j = 0; j < chessBoardFields.GetLength(1); j++)
            //    {
            //        var field = chessBoardFields[i,j];
            foreach (var field in chessBoardFields)
            {
                var button = new Button();

                button.Location = new Point(GetPointCoordinate(field.GetCoordinates().GetX()), GetPointCoordinate(field.GetCoordinates().GetY()));
                button.Name = string.Format("{0}{1}", field.GetCoordinates().GetX(), field.GetCoordinates().GetY());
                button.Size = new Size(coefficient, coefficient);

                if (field.HasFigure())
                {
                    button.Text = field.GetFigure().GetFigureKind().ToString();
                    button.ForeColor = field.IsFieldWhite() ? Color.Black : Color.White;
                }
                //button.TabIndex = 0;
                //button.Text = "button1";
                button.UseVisualStyleBackColor = true;
                button.BackColor = field.IsFieldWhite() ? Color.White : Color.Black;

                //button.Controls.Add(new PictureBox());

                this.Controls.Add(button);
            }
            //    }
            //}

            this.ResumeLayout(false);
        }

        private int GetPointCoordinate(int coord)
        {
            return coord*coefficient;
        }
    }
}
