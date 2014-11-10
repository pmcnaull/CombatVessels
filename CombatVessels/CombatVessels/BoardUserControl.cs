using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CombatVessels
{
    public partial class BoardUserControl : UserControl
    {
        Color WATER_COLOR = Color.LightBlue;
        Color HIT_COLOR = Color.Red;
        Color MISS_COLOR = Color.White;
        Color SHIP_COLOR = Color.Gray;
        
        Panel[,] _squares;
        Panel[,] _pegs;

        public BoardUserControl()
        {
            InitializeComponent();
        }

        
        /// <summary>
        /// Initializes the board with the given size
        /// </summary>
        /// <param name="numberRows"></param>
        /// <param name="numberColumns"></param>
        public void InitBoard(int numberRows, int numberColumns)
        {
            _squares = new Panel[numberRows, numberColumns];
            _pegs = new Panel[numberRows, numberColumns];

            //setup the size of the board
            SquaresTableLayoutPanel.RowStyles.Clear();
            for (int i = 0; i < numberRows; i++)
            {
                SquaresTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, (float)(100.0 / numberRows)));
            }
            SquaresTableLayoutPanel.ColumnStyles.Clear();
            for (int i = 0; i < numberColumns; i++)
            {
                SquaresTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, (float)(100.0 / numberColumns)));
            }

            //init the squares to water
            for (int i = 0; i < numberRows; i++)
            {
                for (int j = 0; j < numberColumns; j++)
                {
                    Panel backgroundPanel = new Panel();
                    backgroundPanel.BackColor = WATER_COLOR;
                    backgroundPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    SquaresTableLayoutPanel.Controls.Add(backgroundPanel, j, i);
                    _squares[i, j] = backgroundPanel;

                    Panel peg = new Panel();
                    peg.Height = backgroundPanel.Height / 2;
                    peg.Width = backgroundPanel.Width / 2;
                    peg.Left = backgroundPanel.Width / 4;
                    peg.Top = backgroundPanel.Height / 4;
                    peg.BackColor = WATER_COLOR;
                    backgroundPanel.Controls.Add(peg);
                    _pegs[i, j] = peg;
                }
            }
        }

        public void MarkHit(Square square)
        {
            _pegs[square.Row, square.Column].BackColor = HIT_COLOR;
        }

        public void MarkMiss(Square square)
        {
            _pegs[square.Row, square.Column].BackColor = MISS_COLOR;
        }

        /// <summary>
        /// Draws a ship on the board
        /// </summary>
        /// <param name="ship"></param>
        public void DrawShip(Ship ship)
        {
            Square currentSquare = ship.BaseSquare;
            int lengthCounter = 0;
            while (lengthCounter < ship.Length)
            {
                _squares[currentSquare.Row, currentSquare.Column].BackColor = SHIP_COLOR;
                _pegs[currentSquare.Row, currentSquare.Column].BackColor = SHIP_COLOR;

                //move to the next square to color
                if (ship.Direction == ShipDirection.Horizontal)
                {
                    currentSquare = new Square(currentSquare.Row, currentSquare.Column + 1);
                }
                else if (ship.Direction == ShipDirection.Vertical)
                {
                    currentSquare = new Square(currentSquare.Row + 1, currentSquare.Column);
                }
                lengthCounter++;
            }
        }


    }
}
