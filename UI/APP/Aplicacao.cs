using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Telzir_Tel.DTO;
using Telzir_Tel.BLL;

namespace Telzir_App
{
    public partial class Aplicacao : Form
    {
        public Aplicacao()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.TITULO1 = new System.Windows.Forms.Label();
            this.Origem = new System.Windows.Forms.Label();
            this.Destino = new System.Windows.Forms.Label();
            this.textTempo = new System.Windows.Forms.TextBox();
            this.Tempo = new System.Windows.Forms.Label();
            this.Plano = new System.Windows.Forms.Label();
            this.ValorFM = new System.Windows.Forms.Label();
            this.Valor = new System.Windows.Forms.Label();
            this.cboPlano = new System.Windows.Forms.ComboBox();
            this.cboDestino = new System.Windows.Forms.ComboBox();
            this.cboOrigem = new System.Windows.Forms.ComboBox();
            this.bntVerifica_Click = new System.Windows.Forms.Button();
            this.bntEncerrar_Click = new System.Windows.Forms.Button();
            this.textFM = new System.Windows.Forms.TextBox();
            this.textValor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TITULO1
            // 
            this.TITULO1.AutoSize = true;
            this.TITULO1.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TITULO1.Location = new System.Drawing.Point(300, 22);
            this.TITULO1.Name = "TITULO1";
            this.TITULO1.Size = new System.Drawing.Size(279, 41);
            this.TITULO1.TabIndex = 0;
            this.TITULO1.Text = "Telzir Consultas";
            // 
            // Origem
            // 
            this.Origem.AutoSize = true;
            this.Origem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Origem.Location = new System.Drawing.Point(71, 138);
            this.Origem.Name = "Origem";
            this.Origem.Size = new System.Drawing.Size(64, 19);
            this.Origem.TabIndex = 1;
            this.Origem.Text = "Origem";
            this.Origem.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Destino
            // 
            this.Destino.AutoSize = true;
            this.Destino.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Destino.Location = new System.Drawing.Point(288, 138);
            this.Destino.Name = "Destino";
            this.Destino.Size = new System.Drawing.Size(68, 19);
            this.Destino.TabIndex = 3;
            this.Destino.Text = "Destino";
            this.Destino.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // textTempo
            // 
            this.textTempo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textTempo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textTempo.Location = new System.Drawing.Point(658, 159);
            this.textTempo.Name = "textTempo";
            this.textTempo.Size = new System.Drawing.Size(181, 23);
            this.textTempo.TabIndex = 6;
            this.textTempo.TextChanged += new System.EventHandler(this.textTempo_TextChanged);
            // 
            // Tempo
            // 
            this.Tempo.AutoSize = true;
            this.Tempo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Tempo.Location = new System.Drawing.Point(698, 138);
            this.Tempo.Name = "Tempo";
            this.Tempo.Size = new System.Drawing.Size(103, 19);
            this.Tempo.TabIndex = 5;
            this.Tempo.Text = "Tempo (min)";
            // 
            // Plano
            // 
            this.Plano.AutoSize = true;
            this.Plano.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Plano.Location = new System.Drawing.Point(474, 138);
            this.Plano.Name = "Plano";
            this.Plano.Size = new System.Drawing.Size(128, 19);
            this.Plano.TabIndex = 7;
            this.Plano.Text = "Plano Fale Mais";
            this.Plano.Click += new System.EventHandler(this.label2_Click);
            // 
            // ValorFM
            // 
            this.ValorFM.AutoSize = true;
            this.ValorFM.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ValorFM.Location = new System.Drawing.Point(261, 236);
            this.ValorFM.Name = "ValorFM";
            this.ValorFM.Size = new System.Drawing.Size(123, 19);
            this.ValorFM.TabIndex = 9;
            this.ValorFM.Text = "Valor Fale Mais";
            this.ValorFM.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // Valor
            // 
            this.Valor.AutoSize = true;
            this.Valor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Valor.Location = new System.Drawing.Point(458, 236);
            this.Valor.Name = "Valor";
            this.Valor.Size = new System.Drawing.Size(161, 19);
            this.Valor.TabIndex = 11;
            this.Valor.Text = "Valor Sem Fale Mais";
            // 
            // cboPlano
            // 
            this.cboPlano.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cboPlano.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboPlano.FormattingEnabled = true;
            this.cboPlano.Items.AddRange(new object[] {
            "FaleMais 30",
            "FaleMais 60",
            "FaleMais 120"});
            this.cboPlano.Location = new System.Drawing.Point(448, 159);
            this.cboPlano.Name = "cboPlano";
            this.cboPlano.Size = new System.Drawing.Size(181, 24);
            this.cboPlano.TabIndex = 13;
            this.cboPlano.Text = "[Selecione]";
            this.cboPlano.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cboDestino
            // 
            this.cboDestino.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cboDestino.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboDestino.FormattingEnabled = true;
            this.cboDestino.Items.AddRange(new object[] {
            "011",
            "016",
            "017",
            "018"});
            this.cboDestino.Location = new System.Drawing.Point(236, 159);
            this.cboDestino.Name = "cboDestino";
            this.cboDestino.Size = new System.Drawing.Size(181, 24);
            this.cboDestino.TabIndex = 14;
            this.cboDestino.Text = "[Selecione]";
            // 
            // cboOrigem
            // 
            this.cboOrigem.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboOrigem.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cboOrigem.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboOrigem.FormattingEnabled = true;
            this.cboOrigem.Items.AddRange(new object[] {
            "011",
            "016",
            "017",
            "018"});
            this.cboOrigem.Location = new System.Drawing.Point(21, 159);
            this.cboOrigem.Name = "cboOrigem";
            this.cboOrigem.Size = new System.Drawing.Size(181, 24);
            this.cboOrigem.TabIndex = 15;
            this.cboOrigem.Text = "[Selecione]";
            this.cboOrigem.SelectedIndexChanged += new System.EventHandler(this.cboOrigem_SelectedIndexChanged);
            // 
            // bntVerifica_Click
            // 
            this.bntVerifica_Click.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bntVerifica_Click.Location = new System.Drawing.Point(236, 339);
            this.bntVerifica_Click.Name = "bntVerifica_Click";
            this.bntVerifica_Click.Size = new System.Drawing.Size(181, 43);
            this.bntVerifica_Click.TabIndex = 18;
            this.bntVerifica_Click.Text = "Verificar";
            this.bntVerifica_Click.UseVisualStyleBackColor = true;
            this.bntVerifica_Click.Click += new System.EventHandler(this.bntVerifica_Click_Click);
            // 
            // bntEncerrar_Click
            // 
            this.bntEncerrar_Click.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bntEncerrar_Click.Location = new System.Drawing.Point(448, 338);
            this.bntEncerrar_Click.Name = "bntEncerrar_Click";
            this.bntEncerrar_Click.Size = new System.Drawing.Size(181, 43);
            this.bntEncerrar_Click.TabIndex = 19;
            this.bntEncerrar_Click.Text = "Encerrar";
            this.bntEncerrar_Click.UseVisualStyleBackColor = true;
            this.bntEncerrar_Click.Click += new System.EventHandler(this.bntEncerrar_Click_Click);
            // 
            // textFM
            // 
            this.textFM.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textFM.Location = new System.Drawing.Point(238, 258);
            this.textFM.Name = "textFM";
            this.textFM.Size = new System.Drawing.Size(179, 23);
            this.textFM.TabIndex = 22;
            this.textFM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textValor
            // 
            this.textValor.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textValor.Location = new System.Drawing.Point(448, 258);
            this.textValor.Name = "textValor";
            this.textValor.Size = new System.Drawing.Size(179, 23);
            this.textValor.TabIndex = 23;
            this.textValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textValor.TextChanged += new System.EventHandler(this.textValor_TextChanged_1);
            // 
            // Aplicacao
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(868, 450);
            this.Controls.Add(this.textValor);
            this.Controls.Add(this.textFM);
            this.Controls.Add(this.bntEncerrar_Click);
            this.Controls.Add(this.bntVerifica_Click);
            this.Controls.Add(this.cboOrigem);
            this.Controls.Add(this.cboDestino);
            this.Controls.Add(this.cboPlano);
            this.Controls.Add(this.Valor);
            this.Controls.Add(this.ValorFM);
            this.Controls.Add(this.Plano);
            this.Controls.Add(this.textTempo);
            this.Controls.Add(this.Tempo);
            this.Controls.Add(this.Destino);
            this.Controls.Add(this.Origem);
            this.Controls.Add(this.TITULO1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Aplicacao";
            this.Text = "APP";
            this.Load += new System.EventHandler(this.App_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label TITULO1;
        private Label Origem;

        private void Label1_Click(object sender, EventArgs e)
        {

        }
        private Label Destino;

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private TextBox textTempo;
        private Label Tempo;
        private Label Plano;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private Label ValorFM;

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private Label Valor;

        private void App_Load(object sender, EventArgs e)
        {

        }

        private void textorigem_TextChanged(object sender, EventArgs e)
        {

        }

        private ComboBox cboPlano;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private ComboBox cboDestino;

        public int Custo { get; private set; }

        private void textValor_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private Button bntVerifica_Click;
        private Button bntEncerrar_Click;




        private void bntVerifica_Click_Click(object sender, EventArgs e)
        {

            
            var origem = cboOrigem.SelectedItem.ToString();
            var destino = cboDestino.SelectedItem.ToString();


            // Instanciando obj DTO
            AplicacaoDTO aplicacaoDTO = new AplicacaoDTO();


            // Receber Dados do Formulario 
            aplicacaoDTO.origem = cboOrigem.Text;
            aplicacaoDTO.destino = cboDestino.Text;

            // Encaminhar Dados 
            AplicacaoBLL aplicacaoBLL = new AplicacaoBLL();

            var Aplicacao = aplicacaoBLL.AppBLL(aplicacaoDTO);

            int Comp = int.Parse(textTempo.Text);

            if (!Aplicacao) // Bypass em relação ao banco !
            {
                double vl1;
                string vl2;

                if (cboPlano.SelectedItem.ToString() == "Selecione")
                {
                    MessageBox.Show("Insira um Plano!");
                }
                else
                { 
                    switch (cboPlano.SelectedItem)
                    {
                        // Tratamento Valor sem Plano

                        case "FaleMais 30":
                            if (cboOrigem.SelectedItem.ToString() == "011" && cboDestino.SelectedItem.ToString() == "016")
                            {
                                vl1 = (Comp * 1.9);
                                vl2 = vl1.ToString("0.##");
                                textValor.Text = vl2; 
                            }

                            else if (cboOrigem.SelectedItem.ToString() == "016" && cboDestino.SelectedItem.ToString() == "011")
                            {
                                vl1 = (Comp * 2.9);
                                vl2 = vl1.ToString("0.##");
                                textValor.Text = vl2;
                            }

                            else if (cboOrigem.SelectedItem.ToString() == "011" && cboDestino.SelectedItem.ToString() == "017")
                            {
                                vl1 = (Comp * 1.7);
                                vl2 = vl1.ToString("0.##");
                                textValor.Text = vl2;

                            }


                            else if (cboOrigem.SelectedItem.ToString() == "017" && cboDestino.SelectedItem.ToString() == "011")
                            {
                                vl1 = (Comp * 2.7);
                                vl2 = vl1.ToString("0.##");
                                textValor.Text = vl2;

                            }

                            else if (cboOrigem.SelectedItem.ToString() == "011" && cboDestino.SelectedItem.ToString() == "018")
                            {
                                vl1 = (Comp * 0.9);
                                vl2 = vl1.ToString("0.##");
                                textValor.Text = vl2;
                            }

                            else if (cboOrigem.SelectedItem.ToString() == "018" && cboDestino.SelectedItem.ToString() == "011")
                            {
                                vl1 = (Comp * 1.9);
                                vl2 = vl1.ToString("0.##");
                                textValor.Text = vl2;
                            }

                            break;

                        case "FaleMais 60":

                            if (cboOrigem.SelectedItem.ToString() == "011" && cboDestino.SelectedItem.ToString() == "016")
                            {
                                vl1 = (Comp * 1.9);
                                vl2 = vl1.ToString("0.##");
                                textValor.Text = vl2;
                            }

                            else if (cboOrigem.SelectedItem.ToString() == "016" && cboDestino.SelectedItem.ToString() == "011")
                            {
                                vl1 = (Comp * 2.9);
                                vl2 = vl1.ToString("0.##");
                                textValor.Text = vl2;
                            }

                            else if (cboOrigem.SelectedItem.ToString() == "011" && cboDestino.SelectedItem.ToString() == "017")
                            {
                                vl1 = (Comp * 1.7);
                                vl2 = vl1.ToString("0.##");
                                textValor.Text = vl2;

                            }


                            else if (cboOrigem.SelectedItem.ToString() == "017" && cboDestino.SelectedItem.ToString() == "011")
                            {
                                vl1 = (Comp * 2.7);
                                vl2 = vl1.ToString("0.##");
                                textValor.Text = vl2;

                            }

                            else if (cboOrigem.SelectedItem.ToString() == "011" && cboDestino.SelectedItem.ToString() == "018")
                            {
                                vl1 = (Comp * 0.9);
                                vl2 = vl1.ToString("0.##");
                                textValor.Text = vl2;
                            }

                            else if (cboOrigem.SelectedItem.ToString() == "018" && cboDestino.SelectedItem.ToString() == "011")
                            {
                                vl1 = (Comp * 1.9);
                                vl2 = vl1.ToString("0.##");
                                textValor.Text = vl2;
                            }

                            break;


                        case "FaleMais 120":

                            if (cboOrigem.SelectedItem.ToString() == "011" && cboDestino.SelectedItem.ToString() == "016")
                            {
                                vl1 = (Comp * 1.9);
                                vl2 = vl1.ToString("0.##");
                                textValor.Text = vl2;
                            }

                            else if (cboOrigem.SelectedItem.ToString() == "016" && cboDestino.SelectedItem.ToString() == "011")
                            {
                                vl1 = (Comp * 2.9);
                                vl2 = vl1.ToString("0.##");
                                textValor.Text = vl2;
                            }

                            else if (cboOrigem.SelectedItem.ToString() == "011" && cboDestino.SelectedItem.ToString() == "017")
                            {
                                vl1 = (Comp * 1.7);
                                vl2 = vl1.ToString("0.##");
                                textValor.Text = vl2;

                            }


                            else if (cboOrigem.SelectedItem.ToString() == "017" && cboDestino.SelectedItem.ToString() == "011")
                            {
                                vl1 = (Comp * 2.7);
                                vl2 = vl1.ToString("0.##");
                                textValor.Text = vl2;

                            }

                            else if (cboOrigem.SelectedItem.ToString() == "011" && cboDestino.SelectedItem.ToString() == "018")
                            {
                                vl1 = (Comp * 0.9);
                                vl2 = vl1.ToString("0.##");
                                textValor.Text = vl2;
                            }

                            else if (cboOrigem.SelectedItem.ToString() == "018" && cboDestino.SelectedItem.ToString() == "011")
                            {
                                vl1 = (Comp * 1.9);
                                vl2 = vl1.ToString("0.##");
                                textValor.Text = vl2;
                            }

                            break;

                        default:

                            MessageBox.Show("Digite Valores Validos");

                            break;
                    }
                }

            }

            // Tratamento Valor Com Plano

            var vl = "0";
            double vl3, vl4;
            string rf1;

            if (cboPlano.SelectedItem.ToString() == "Selecione")
            {
                MessageBox.Show("Insira um Plano!");
            }
            else 
            {
               switch (cboPlano.SelectedItem)
                {

                    case "FaleMais 30":
                        if (cboOrigem.SelectedItem.ToString() == "011" && cboDestino.SelectedItem.ToString() == "016")
                        {
                            if (Comp <= 30)
                            {
                                textFM.Text = vl;

                            }

                            else
                            {
                                vl3 = int.Parse(textTempo.Text);
                                vl4 = ((vl3 - 30) * 2.09);
                                rf1 = vl4.ToString("0.##");
                                textFM.Text = rf1;
                            }
                        }


                        else if (cboOrigem.SelectedItem.ToString() == "016" && cboDestino.SelectedItem.ToString() == "011")
                        {
                            if (Comp <= 30)
                            {
                                textFM.Text = vl;

                            }

                            else
                            {
                                vl3 = int.Parse(textTempo.Text);
                                vl4 = ((vl3 - 30) * 3.19);
                                rf1 = vl4.ToString("0.##");
                                textFM.Text = rf1;
                            }

                        }

                        else if (cboOrigem.SelectedItem.ToString() == "011" && cboDestino.SelectedItem.ToString() == "017")
                        {
                            if (Comp <= 30)
                            {
                                textFM.Text = vl;

                            }

                            else
                            {
                                vl3 = int.Parse(textTempo.Text);
                                vl4 = ((vl3 - 30) * 1.87);
                                rf1 = vl4.ToString("0.##");
                                textFM.Text = rf1;
                            }

                        }


                        else if (cboOrigem.SelectedItem.ToString() == "017" && cboDestino.SelectedItem.ToString() == "011")
                        {
                            if (Comp <= 30)
                            {
                                textFM.Text = vl;

                            }

                            else
                            {
                                vl3 = int.Parse(textTempo.Text);
                                vl4 = ((vl3 - 30) * 2.97);
                                rf1 = vl4.ToString("0.##");
                                textFM.Text = rf1;
                            }

                        }

                        else if (cboOrigem.SelectedItem.ToString() == "011" && cboDestino.SelectedItem.ToString() == "018")
                        {
                            if (Comp <= 30)
                            {
                                textFM.Text = vl;

                            }

                            else
                            {
                                vl3 = int.Parse(textTempo.Text);
                                vl4 = ((vl3 - 30) * 0.99);
                                rf1 = vl4.ToString("0.##");
                                textFM.Text = rf1;
                            }
                        }


                        else if (cboOrigem.SelectedItem.ToString() == "018" && cboDestino.SelectedItem.ToString() == "011")
                        {
                            if (Comp <= 30)
                            {
                                textFM.Text = vl;

                            }

                            else
                            {
                                vl3 = int.Parse(textTempo.Text);
                                vl4 = ((vl3 - 30) * 2.09);
                                rf1 = vl4.ToString("0.##");
                                textFM.Text = rf1;
                            }
                        }

                        break;

                    case "FaleMais 60":

                        if (cboOrigem.SelectedItem.ToString() == "011" && cboDestino.SelectedItem.ToString() == "016")
                        {
                            if (Comp <= 60)
                            {
                                textFM.Text = vl;

                            }

                            else
                            {
                                vl3 = int.Parse(textTempo.Text);
                                vl4 = ((vl3 - 60) * 2.09);
                                rf1 = vl4.ToString("0.##");
                                textFM.Text = rf1;
                            }
                        }


                        else if (cboOrigem.SelectedItem.ToString() == "016" && cboDestino.SelectedItem.ToString() == "011")
                        {
                            if (Comp <= 60)
                            {
                                textFM.Text = vl;

                            }

                            else
                            {
                                vl3 = int.Parse(textTempo.Text);
                                vl4 = ((vl3 - 60) * 3.19);
                                rf1 = vl4.ToString("0.##");
                                textFM.Text = rf1;
                            }

                        }

                        else if (cboOrigem.SelectedItem.ToString() == "011" && cboDestino.SelectedItem.ToString() == "017")
                        {
                            if (Comp <= 60)
                            {
                                textFM.Text = vl;

                            }

                            else
                            {
                                vl3 = int.Parse(textTempo.Text);
                                vl4 = ((vl3 - 60) * 1.87);
                                rf1 = vl4.ToString("0.##");
                                textFM.Text = rf1;
                            }

                        }


                        else if (cboOrigem.SelectedItem.ToString() == "017" && cboDestino.SelectedItem.ToString() == "011")
                        {
                            if (Comp <= 60)
                            {
                                textFM.Text = vl;

                            }

                            else
                            {
                                vl3 = int.Parse(textTempo.Text);
                                vl4 = ((vl3 - 60) * 2.97);
                                rf1 = vl4.ToString("0.##");
                                textFM.Text = rf1;
                            }

                        }

                        else if (cboOrigem.SelectedItem.ToString() == "011" && cboDestino.SelectedItem.ToString() == "018")
                        {
                            if (Comp <= 60)
                            {
                                textFM.Text = vl;

                            }

                            else
                            {
                                vl3 = int.Parse(textTempo.Text);
                                vl4 = ((vl3 - 60) * 0.99);
                                rf1 = vl4.ToString("0.##");
                                textFM.Text = rf1;
                            }
                        }


                        else if (cboOrigem.SelectedItem.ToString() == "018" && cboDestino.SelectedItem.ToString() == "011")
                        {
                            if (Comp <= 60)
                            {
                                textFM.Text = vl;

                            }

                            else
                            {
                                vl3 = int.Parse(textTempo.Text);
                                vl4 = ((vl3 - 60) * 2.09);
                                rf1 = vl4.ToString("0.##");
                                textFM.Text = rf1;
                            }
                        }

                        break;


                    case "FaleMais 120":

                        if (cboOrigem.SelectedItem.ToString() == "011" && cboDestino.SelectedItem.ToString() == "016")
                        {
                            if (Comp <= 120)
                            {
                                textFM.Text = vl;

                            }

                            else
                            {
                                vl3 = int.Parse(textTempo.Text);
                                vl4 = ((vl3 - 120) * 2.09);
                                rf1 = vl4.ToString("0.##");
                                textFM.Text = rf1;
                            }
                        }


                        else if (cboOrigem.SelectedItem.ToString() == "016" && cboDestino.SelectedItem.ToString() == "011")
                        {
                            if (Comp <= 120)
                            {
                                textFM.Text = vl;

                            }

                            else
                            {
                                vl3 = int.Parse(textTempo.Text);
                                vl4 = ((vl3 - 120) * 3.19);
                                rf1 = vl4.ToString("0.##");
                                textFM.Text = rf1;
                            }

                        }

                        else if (cboOrigem.SelectedItem.ToString() == "011" && cboDestino.SelectedItem.ToString() == "017")
                        {
                            if (Comp <= 120)
                            {
                                textFM.Text = vl;

                            }

                            else
                            {
                                vl3 = int.Parse(textTempo.Text);
                                vl4 = ((vl3 - 120) * 1.87);
                                rf1 = vl4.ToString("0.##");
                                textFM.Text = rf1;
                            }

                        }


                        else if (cboOrigem.SelectedItem.ToString() == "017" && cboDestino.SelectedItem.ToString() == "011")
                        {
                            if (Comp <= 120)
                            {
                                textFM.Text = vl;

                            }

                            else
                            {
                                vl3 = int.Parse(textTempo.Text);
                                vl4 = ((vl3 - 120) * 2.97);
                                rf1 = vl4.ToString("0.##");
                                textFM.Text = rf1;
                            }

                        }

                        else if (cboOrigem.SelectedItem.ToString() == "011" && cboDestino.SelectedItem.ToString() == "018")
                        {
                            if (Comp <= 120)
                            {
                                textFM.Text = vl;

                            }

                            else
                            {
                                vl3 = int.Parse(textTempo.Text);
                                vl4 = ((vl3 - 120) * 0.99);
                                rf1 = vl4.ToString("0.##");
                                textFM.Text = rf1;
                            }
                        }


                        else if (cboOrigem.SelectedItem.ToString() == "018" && cboDestino.SelectedItem.ToString() == "011")
                        {
                            if (Comp <= 120)
                            {
                                textFM.Text = vl;

                            }

                            else
                            {
                                vl3 = int.Parse(textTempo.Text);
                                vl4 = ((vl3 - 120) * 2.09);
                                rf1 = vl4.ToString("0.##");
                                textFM.Text = rf1;
                            }
                        }

                        break;

                    default:

                        MessageBox.Show("Digite Valores Validos");

                        break;

               }
            }


        }
        

        private void bntEncerrar_Click_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textTempo_TextChanged(object sender, EventArgs e)
        {

        }

        public TextBox textValor;
        public TextBox textFM;

        private void textValor_TextChanged_1(object sender, EventArgs e)
        {

        }

        private ComboBox cboOrigem;

        private void cboOrigem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
