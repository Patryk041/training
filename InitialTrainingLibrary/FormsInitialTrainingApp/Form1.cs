using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

            //this.
            ChessBoard chessBoard = new ChessBoard();

            var chessBoardFields = chessBoard.GetFields();

            //for (int i = 0; i < chessBoardFields.GetLength(0); i++)
            //{
            //    for (int j = 0; j < chessBoardFields.GetLength(1); j++)
            //    {
            //        var field = chessBoardFields[i,j];
            foreach (var field in chessBoardFields)
            {
                var button = new Button();

                button.Location = new Point(GetPointCoordinate(field.GetX()), GetPointCoordinate(field.GetY()));
                button.Name = string.Format("{0}{1}", field.GetX(), field.GetY());
                button.Size = new Size(coefficient, coefficient);
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
