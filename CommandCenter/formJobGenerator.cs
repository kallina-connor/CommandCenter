using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommandCenter
{
    public partial class formJobGenerator : Form
    {

        Dictionary<String, List<String>> parameters = new Dictionary<string, List<string>>();

        public formJobGenerator()
        {
            InitializeComponent();
            pictureBoxJobs.Image = Properties.Resources.jobsPicture;
        }
    }
}
