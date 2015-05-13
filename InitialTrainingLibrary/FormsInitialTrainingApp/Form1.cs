using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InitialTrainingLibrary.Chmura.OtherChess;
using InitialTrainingLibrary.dysq.Chess;
using InitialTrainingLibrary.frogie.chess;
using InitialTrainingLibrary.Interfaces.chess;
using InitialTrainingLibrary.koziu.Chees;
using InitialTrainingLibrary.mg;
using InitialTrainingLibrary.RS.Chess;
using InitialTrainingLibrary.syf.minesweepershowdown.board;

//using ChessBoard = InitialTrainingLibrary.Domi.Game.Board.ChessBoard;
//using ChessGame = InitialTrainingLibrary.Domi.Game.Board.ChessGame;

//using ChessBoard = InitialTrainingLibrary.hipek._2.ChessGame.ChessBoard;
//using ChessGame = InitialTrainingLibrary.hipek._2.ChessGame.ChessGame;


namespace FormsInitialTrainingApp
{
    public partial class Form1 : Form
    {
        private int coefficient = 75;

        public Form1()
        {
            InitializeComponent();
            //AddChessBoard();
            AddChessBoardsButtons();

        }

        private void AddChessBoardsButtons()
        {
            this.SuspendLayout();

            List<Func<int, IBoard>> boardsList = new List<Func<int, IBoard>>
            {
                (liczba) => new InitialTrainingLibrary.Sito._2.Board(),
                (liczba) =>
                {
                    var board = new ChessGame();
                    return board.GetBoard();
                },
                (liczba) =>
                {
                    var dysqBoard = new InitializeBoard();
                    return dysqBoard.ChessBoard;
                },
                 (liczba) =>
                {
                    var hipekBoard = new InitialTrainingLibrary.hipek._2.ChessGame.ChessGame();
                    hipekBoard.DrawBoard();
                    return hipekBoard.ReturnBoard();
                },
            };

            int i = 0;
            foreach (var boardsListItem in boardsList)
            {
                i++;
                var button = new Button();

                button.Text = boardsListItem(1).GetName();

                button.Location = new Point(30, 20 * i);
                button.Size = new Size(200, 30);

                button.Click += delegate(object sender, EventArgs args) { var window = new ChessBoardPresentation(boardsListItem(1)); window.Show(); };
                this.Controls.Add(button);
            }

            this.ResumeLayout(false);
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

            var chessBoard = game.GetBoard();

            var chessBoardFields = chessBoard.GetFields();

            //for (int i = 0; i < chessBoardFields.GetLength(0); i++)
            //{
            //    for (int j = 0; j < chessBoardFields.GetLength(1); j++)
            //    {
            //        var field = chessBoardFields[i, j];

                    foreach (var field in chessBoardFields)
                    {
                        var button = new Button();

                        button.Location = new Point(GetPointCoordinate(field.GetCoordinates().GetX()),
                            GetPointCoordinate(field.GetCoordinates().GetY()));
                        button.Name = string.Format("{0}{1}", field.GetCoordinates().GetX(),
                            field.GetCoordinates().GetY());
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


                                    //**************************************************************Domi START******************************
                                  ////ChessGame game = new ChessGame();

                                  ////  foreach (var field in game.DrawBoard())
                                  ////  {
                                  ////      var button = new Button();

                                  ////      button.Location = new Point(GetPointCoordinate(field.GetCoordinates().GetX()), GetPointCoordinate(field.GetCoordinates().GetY()));
                                  ////      button.Name = string.Format("{0}{1}", field.GetCoordinates().GetX(), field.GetCoordinates().GetY());
                                  ////      button.Size = new Size(coefficient, coefficient);

                                  ////      if (field.HasFigure())
                                  ////      {
                                  ////          button.Text = field.GetFigure().GetFigureKind().ToString();
                                  ////          button.ForeColor = field.IsFieldWhite() ? Color.Black : Color.White;
                                  ////      }
                                  ////      //button.TabIndex = 0;
                                  ////      //button.Text = "button1";
                                  ////      button.UseVisualStyleBackColor = true;
                                  ////      button.BackColor = field.IsFieldWhite() ? Color.White : Color.Black;

                                  ////      //button.Controls.Add(new PictureBox());

                                  ////      this.Controls.Add(button);
                                  ////  }

                                  ////  //**********************KONIEC DOMI************************************

            //////****************** hipek chess test
            ////ChessGame chessGame = new ChessGame();

            ////foreach (var field in chessGame.DrawBoard())
            ////{
            ////    var button = new Button();

            ////    button.Location = new Point(GetPointCoordinate(field.GetCoordinates().GetX()), GetPointCoordinate(field.GetCoordinates().GetY()));
            ////    button.Name = string.Format("{0}{1}", field.GetCoordinates().GetX(), field.GetCoordinates().GetY());
            ////    button.Size = new Size(coefficient, coefficient);

            ////    if (field.HasFigure())
            ////    {
            ////        button.Text = field.GetFigure().GetFigureKind().ToString();
            ////        button.ForeColor = field.IsFieldWhite() ? Color.Black : Color.White;
            ////    }
            ////    //button.TabIndex = 0;
            ////    //button.Text = "button1";
            ////    button.UseVisualStyleBackColor = true;
            ////    button.BackColor = field.IsFieldWhite() ? Color.White : Color.Black;

            ////    //button.Controls.Add(new PictureBox());

            ////    this.Controls.Add(button);
            ////}
            //////***************************************end of hipek chess test
            //////    }
            //////}


            this.ResumeLayout(false);
        }

        private int GetPointCoordinate(int coord)
        {
            return coord*coefficient;
        }
    }
}
