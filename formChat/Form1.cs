using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using formChat.referenciaChat;

namespace formChat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        referenciaChat.chatSoapClient c = new referenciaChat.chatSoapClient();

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            lstSala.Items.Add(txtMensaje.Text);
           var res= c.Chatear(txtMensaje.Text);
           lstSala.Items.Add(res);
            
        }
    }
}
