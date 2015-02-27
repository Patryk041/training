namespace InitialTrainingLibrary.Domi.Game.Board.Figures
{
    class King : Figure
    {
        public King(int x, int y, string name) : base(x, y, name)   // lokalizacja konkretnej figury (konkretny typ, skoczek królowa itp) 
        {
            this.FigureX = x;
            this.FigureY = y;
            this.FigureName = name; 
        }

       
    }
}
