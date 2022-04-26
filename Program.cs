using System;
using System.Drawing;
using System.Windows.Forms;

Application.SetHighDpiMode(HighDpiMode.SystemAware);
Application.EnableVisualStyles();
Application.SetCompatibleTextRenderingDefault(false);

Form form = new Form();

Label lblogin = new Label();
lblogin.Text = "Login";
form.Controls.Add(lblogin);

Label lbsenha = new Label();
lbsenha.Text = "Senha";
lbsenha.Location = new Point(0, 40);
form.Controls.Add(lbsenha);

TextBox tblogin = new TextBox();
tblogin.Location = new Point(100, 0);
form.Controls.Add(tblogin);

TextBox tbsenha = new TextBox();
tbsenha.Location = new Point(100, 40);
tbsenha.PasswordChar = '●';
form.Controls.Add(tbsenha);

CheckBox cbmostrar = new CheckBox();
cbmostrar.Text = "Mostrar Senha";
cbmostrar.AutoSize = true;
cbmostrar.Location = new Point(100, 80);
cbmostrar.CheckedChanged += delegate(object sender, EventArgs e)
{
    if (cbmostrar.Checked)
    {
        tbsenha.PasswordChar = default;
    }
    else
    {
        tbsenha.PasswordChar = '●';
    }
};
form.Controls.Add(cbmostrar);

Button btlogin = new Button();
btlogin.Text = "Logar";
btlogin.Location = cbmostrar.Location + new Size(0, 40);
btlogin.Click += delegate(object sender, EventArgs e)
{
    if (tblogin.Text == "xispita" && tbsenha.Text == "123")
    {
        MessageBox.Show("Parabéns você sabe ler!", ":)", 
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        Form frmmatrix = new Form();
        frmmatrix.TopMost = true;
        frmmatrix.WindowState = FormWindowState.Maximized;
        frmmatrix.BackColor = Color.Black;
        frmmatrix.FormBorderStyle = FormBorderStyle.None;

        frmmatrix.FormClosed += delegate(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        };

        Label message = new Label();
        message.Text = "Você pegou virus >:(";
        message.ForeColor = Color.Green;
        message.AutoSize = true;
        message.Font = new Font(FontFamily.GenericSerif, 40f);
        frmmatrix.Controls.Add(message);
        frmmatrix.Show();
        form.Hide();
    }
};
form.Controls.Add(btlogin);

Application.Run(form);