using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorTextBox
{
    public partial class ColorTextBox : Component
    {
        public ColorTextBox()
        {
            InitializeComponent();
        }

        public ColorTextBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
