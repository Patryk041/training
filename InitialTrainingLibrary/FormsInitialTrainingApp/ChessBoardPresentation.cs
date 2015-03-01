using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InitialTrainingLibrary.Interfaces.chess;

namespace FormsInitialTrainingApp
{
    public partial class ChessBoardPresentation : Form
    {
        public ChessBoardPresentation()
        {
            InitializeComponent();
        }

        public ChessBoardPresentation(IBoard board)
        {
            RenderChessBoard(board);
        }

        private void RenderChessBoard(IBoard board)
        {
            this.SuspendLayout();
            

            var fields = board.GetFields();

            foreach (var field in fields)
            {
                var button = new Button();

                button.BackColor = field.IsFieldWhite() ? Color.White : Color.Black;
                button.Size = new Size(75, 75);
                button.Location = new Point(GetCoords(field.GetCoordinates().GetX()), GetCoords(field.GetCoordinates().GetY()));

                if (field.HasFigure())
                {
                    button.Text = field.GetFigure().GetFigureKind().ToString();
                    button.ForeColor = button.BackColor == Color.Black ? Color.White : Color.Black;
                }

                this.Controls.Add(button);
            }

            this.ResumeLayout(false);
        }

        private int GetCoords(int coord)
        {
            return coord*75;
        }
    }
}
