using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SlackBotMessages;
namespace slackb
{
    public partial class Form1 : Form
    {
        TextBox tx;
        Button bn;
        public Form1()
        {
            InitializeComponent();
             bn = new Button();
             tx = new TextBox();

            tx.Width = 70;
            tx.Height = 40;
            tx.Location = new Point(80, 40);
          

            bn.Location = new Point(80, 80);
            bn.Text = "Send";
            bn.Click += btn_s;
               
            this.Controls.Add(tx);
            this.Controls.Add(bn);
        }

        private void btn_s(object sender,EventArgs e)
        {
            var client = new SbmClient("https://hooks.slack.com/services/xxxxxxxxxxxxx/xxxxxxxxxx/xxxxxxxxxxxxxx");
            SlackBotMessages.Models.Message p = new SlackBotMessages.Models.Message(tx.Text);
            p.Username = "various";
            p.Channel = "random";
            p.IconEmoji = ":eggplant:";
            client.Send(p);
        }

    }
}
