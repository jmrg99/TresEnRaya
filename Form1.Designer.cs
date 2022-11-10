
namespace TresEnRaya
{
    partial class FORM
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM));
            this.lblpuntosIntel = new System.Windows.Forms.Label();
            this.lblPuntosAmd = new System.Windows.Forms.Label();
            this.lblTexto = new System.Windows.Forms.Label();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.lblGanador = new System.Windows.Forms.Label();
            this.tablero = new System.Windows.Forms.TableLayoutPanel();
            this.pbxGanador = new System.Windows.Forms.PictureBox();
            this.pbxAmd = new System.Windows.Forms.PictureBox();
            this.pbxIntel = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGanador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAmd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIntel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblpuntosIntel
            // 
            this.lblpuntosIntel.AutoSize = true;
            this.lblpuntosIntel.BackColor = System.Drawing.Color.Transparent;
            this.lblpuntosIntel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpuntosIntel.ForeColor = System.Drawing.Color.White;
            this.lblpuntosIntel.Location = new System.Drawing.Point(848, 61);
            this.lblpuntosIntel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblpuntosIntel.Name = "lblpuntosIntel";
            this.lblpuntosIntel.Size = new System.Drawing.Size(25, 26);
            this.lblpuntosIntel.TabIndex = 3;
            this.lblpuntosIntel.Text = "0";
            // 
            // lblPuntosAmd
            // 
            this.lblPuntosAmd.AutoSize = true;
            this.lblPuntosAmd.BackColor = System.Drawing.Color.Transparent;
            this.lblPuntosAmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntosAmd.ForeColor = System.Drawing.Color.White;
            this.lblPuntosAmd.Location = new System.Drawing.Point(585, 56);
            this.lblPuntosAmd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPuntosAmd.Name = "lblPuntosAmd";
            this.lblPuntosAmd.Size = new System.Drawing.Size(25, 26);
            this.lblPuntosAmd.TabIndex = 4;
            this.lblPuntosAmd.Text = "0";
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.BackColor = System.Drawing.Color.Transparent;
            this.lblTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.ForeColor = System.Drawing.Color.White;
            this.lblTexto.Location = new System.Drawing.Point(36, 48);
            this.lblTexto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(0, 39);
            this.lblTexto.TabIndex = 14;
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.BackColor = System.Drawing.Color.Transparent;
            this.btnReiniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciar.Location = new System.Drawing.Point(138, 483);
            this.btnReiniciar.Margin = new System.Windows.Forms.Padding(2);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(193, 31);
            this.btnReiniciar.TabIndex = 15;
            this.btnReiniciar.Text = "REINICIAR";
            this.btnReiniciar.UseVisualStyleBackColor = false;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // lblGanador
            // 
            this.lblGanador.AutoSize = true;
            this.lblGanador.BackColor = System.Drawing.Color.Transparent;
            this.lblGanador.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGanador.ForeColor = System.Drawing.Color.White;
            this.lblGanador.Location = new System.Drawing.Point(546, 381);
            this.lblGanador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGanador.Name = "lblGanador";
            this.lblGanador.Size = new System.Drawing.Size(231, 35);
            this.lblGanador.TabIndex = 16;
            this.lblGanador.Text = "El ganador es...";
            // 
            // tablero
            // 
            this.tablero.BackColor = System.Drawing.Color.Transparent;
            this.tablero.ColumnCount = 3;
            this.tablero.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.23944F));
            this.tablero.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.76056F));
            this.tablero.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tablero.Location = new System.Drawing.Point(41, 62);
            this.tablero.Name = "tablero";
            this.tablero.RowCount = 3;
            this.tablero.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.33333F));
            this.tablero.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.66667F));
            this.tablero.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tablero.Size = new System.Drawing.Size(405, 375);
            this.tablero.TabIndex = 30;
            // 
            // pbxGanador
            // 
            this.pbxGanador.BackColor = System.Drawing.Color.Transparent;
            this.pbxGanador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxGanador.Location = new System.Drawing.Point(781, 339);
            this.pbxGanador.Margin = new System.Windows.Forms.Padding(2);
            this.pbxGanador.Name = "pbxGanador";
            this.pbxGanador.Size = new System.Drawing.Size(122, 116);
            this.pbxGanador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxGanador.TabIndex = 29;
            this.pbxGanador.TabStop = false;
            // 
            // pbxAmd
            // 
            this.pbxAmd.BackColor = System.Drawing.Color.Transparent;
            this.pbxAmd.BackgroundImage = global::TresEnRaya.Properties.Resources.f_1;
            this.pbxAmd.Image = ((System.Drawing.Image)(resources.GetObject("pbxAmd.Image")));
            this.pbxAmd.Location = new System.Drawing.Point(526, 82);
            this.pbxAmd.Margin = new System.Windows.Forms.Padding(2);
            this.pbxAmd.Name = "pbxAmd";
            this.pbxAmd.Size = new System.Drawing.Size(146, 116);
            this.pbxAmd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAmd.TabIndex = 2;
            this.pbxAmd.TabStop = false;
            // 
            // pbxIntel
            // 
            this.pbxIntel.BackColor = System.Drawing.Color.Transparent;
            this.pbxIntel.BackgroundImage = global::TresEnRaya.Properties.Resources.f_1;
            this.pbxIntel.Image = global::TresEnRaya.Properties.Resources.f_2;
            this.pbxIntel.Location = new System.Drawing.Point(804, 95);
            this.pbxIntel.Margin = new System.Windows.Forms.Padding(2);
            this.pbxIntel.Name = "pbxIntel";
            this.pbxIntel.Size = new System.Drawing.Size(115, 90);
            this.pbxIntel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxIntel.TabIndex = 1;
            this.pbxIntel.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::TresEnRaya.Properties.Resources.f_1;
            this.pictureBox1.Image = global::TresEnRaya.Properties.Resources.vs;
            this.pictureBox1.Location = new System.Drawing.Point(654, 82);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // FORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TresEnRaya.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(951, 548);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tablero);
            this.Controls.Add(this.pbxGanador);
            this.Controls.Add(this.lblGanador);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.lblPuntosAmd);
            this.Controls.Add(this.lblpuntosIntel);
            this.Controls.Add(this.pbxAmd);
            this.Controls.Add(this.pbxIntel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FORM";
            this.Text = "T R E S   E N   R A Y A";
            ((System.ComponentModel.ISupportInitialize)(this.pbxGanador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAmd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIntel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbxIntel;
        private System.Windows.Forms.PictureBox pbxAmd;
        private System.Windows.Forms.Label lblpuntosIntel;
        private System.Windows.Forms.Label lblPuntosAmd;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Label lblGanador;
        private System.Windows.Forms.PictureBox pbxGanador;
        private System.Windows.Forms.TableLayoutPanel tablero;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

