using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicación_Broma
{
    public partial class AplicacionBroma : Form
    {
        public AplicacionBroma()
        {
            InitializeComponent();
        }

        int A = 0, B = 0, beforeA = 0, beforeB = 0;
        bool ext = true;

        private void BotonBroma_MouseEnter(object sender, EventArgs e)
        {
            ext = true;

            while (ext)
            {
                A = random.Next(42, 400);

                if (beforeA + 100 < A || beforeA - 100 < A)
                {
                    ext = false;
                }
            }

            ext = true;

            while (ext)
            {
                B = random.Next(35, 400);

                if (beforeB + 100 < B || beforeB - 100 < B)
                {
                    ext = false;
                }
            }

            BotonBroma.Location = new Point(A, B);
            beforeA = A;
            beforeB = B;
        }

        Random random = new Random();
    }
}
