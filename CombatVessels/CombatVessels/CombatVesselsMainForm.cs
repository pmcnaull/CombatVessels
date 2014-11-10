using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CombatVessels
{
    public partial class CombatVesselsMainForm : Form
    {
        public CombatVesselsMainForm()
        {
            InitializeComponent();

            boardUserControl1.InitBoard(10, 10);

            Ship s = new Ship(5, "test");
            s.BaseSquare = new Square(0, 0);
            s.Direction = ShipDirection.Vertical;
            boardUserControl1.DrawShip(s);

            boardUserControl1.MarkHit(new Square(5, 5));
            boardUserControl1.MarkMiss(new Square(00, 0));
        }
    }
}
