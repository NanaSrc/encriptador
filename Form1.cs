using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Encriptador
{
    public partial class Form1 : Form
    {
        private string abrirtexto;
        private string texto;
        private string encriptado;
        private string guardarencrip;
        private string abrirencript;
        private string guardatexto;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtAbrirFichTexto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.FileName = tbAbrirTexto.Text; 
            dlg.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"; 
            dlg.FilterIndex = 1; 
                                 
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                abrirtexto = dlg.FileName;
                tbAbrirTexto.Text = abrirtexto;

                if(File.Exists(abrirtexto))
                {
                    FileStream fs = new FileStream(abrirtexto, FileMode.Open, FileAccess.Read);
                    StreamReader sr = new StreamReader(fs);

                    if(sr.Peek() != -1)
                    {
                        texto = sr.ReadToEnd();
                    }

                    tbTexto.Text = texto;

                    sr.Close();
                    fs.Close();
                }
            }

        }

        private void BtEncripta_Click(object sender, EventArgs e)
        {
            char[] arraychar = texto.ToCharArray();
            int chave = (int)nudChaveEncripta.Value;

            for (int i = 0; i < arraychar.Length; i++)
            {
                arraychar[i] += ((char)chave);
            }

            encriptado = "";

            for(int i = 0; i<arraychar.Length; i++)
            {
                encriptado += arraychar[i];
            }
            
            tbEncriptado.Text = encriptado;

        }

        private void BtGuardarTexto_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.FileName = "texto.txt";
            dlg.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            dlg.FilterIndex = 1;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                guardatexto = dlg.FileName;
                tbAbrirTexto.Text = guardatexto;

                FileStream fs = new FileStream(guardatexto, FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);

                sw.Write(texto);

                sw.Close();
                fs.Close();

            }
        }

        private void BtGuardarEncriptado_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.FileName = "encriptado.enc";
            dlg.Filter = "Encript files (*.enc)|*.enc|All files (*.*)|*.*";
            dlg.FilterIndex = 1;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                guardarencrip = dlg.FileName;
                tbAbrirEncriptado.Text = guardarencrip;
                
                FileStream fs = new FileStream(guardarencrip, FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);

                sw.Write(encriptado);

                sw.Close();
                fs.Close();
                
            }
        }

        private void BtAbrirEncriptado_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.FileName = tbAbrirEncriptado.Text;
            dlg.Filter = "encript files (*.enc)|*.enc|All files (*.*)|*.*";
            dlg.FilterIndex = 1;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                abrirencript= dlg.FileName;
                tbAbrirEncriptado.Text = abrirencript;

                if (File.Exists(abrirencript))
                {
                    FileStream fs = new FileStream(abrirencript, FileMode.Open, FileAccess.Read);
                    StreamReader sr = new StreamReader(fs);

                    if (sr.Peek() != -1)
                    {
                        encriptado = sr.ReadToEnd();
                    }

                    tbEncriptado.Text = encriptado;

                    sr.Close();
                    fs.Close();
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            char[] arraychar = encriptado.ToCharArray();
            int chave = (int)nudDesencripta.Value;

            for (int i = 0; i < arraychar.Length; i++)
            {
                arraychar[i] -= ((char)chave);
            }

            texto = "";

            for (int i = 0; i < arraychar.Length; i++)
            {
                texto += arraychar[i];
            }

            tbTexto.Text = texto;
        }
    }
}
