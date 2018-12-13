namespace Messaging.Client
{
    partial class ClientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.labelServer = new System.Windows.Forms.Label();
            this.textBoxServer = new System.Windows.Forms.TextBox();
            this.textBoxHello = new System.Windows.Forms.TextBox();
            this.labelHello = new System.Windows.Forms.Label();
            this.buttonSendHello = new System.Windows.Forms.Button();
            this.buttonSayHello = new System.Windows.Forms.Button();
            this.textBoxSayHello = new System.Windows.Forms.TextBox();
            this.labelSayHello = new System.Windows.Forms.Label();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel.Controls.Add(this.labelSayHello, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.textBoxSayHello, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.buttonSayHello, 2, 2);
            this.tableLayoutPanel.Controls.Add(this.buttonConnect, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.labelServer, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.textBoxServer, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.textBoxHello, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.labelHello, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.buttonSendHello, 2, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 4;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(679, 283);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonConnect.Location = new System.Drawing.Point(562, 3);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(114, 28);
            this.buttonConnect.TabIndex = 5;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.ButtonConnectClick);
            // 
            // labelServer
            // 
            this.labelServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelServer.Location = new System.Drawing.Point(4, 0);
            this.labelServer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelServer.Name = "labelServer";
            this.labelServer.Size = new System.Drawing.Size(112, 34);
            this.labelServer.TabIndex = 0;
            this.labelServer.Text = "Server";
            this.labelServer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxServer
            // 
            this.textBoxServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxServer.Location = new System.Drawing.Point(123, 3);
            this.textBoxServer.Name = "textBoxServer";
            this.textBoxServer.Size = new System.Drawing.Size(433, 22);
            this.textBoxServer.TabIndex = 1;
            // 
            // textBoxHello
            // 
            this.textBoxHello.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxHello.Location = new System.Drawing.Point(123, 37);
            this.textBoxHello.Name = "textBoxHello";
            this.textBoxHello.Size = new System.Drawing.Size(433, 22);
            this.textBoxHello.TabIndex = 2;
            // 
            // labelHello
            // 
            this.labelHello.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelHello.Location = new System.Drawing.Point(3, 34);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(114, 34);
            this.labelHello.TabIndex = 3;
            this.labelHello.Text = "Hello";
            this.labelHello.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonSendHello
            // 
            this.buttonSendHello.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSendHello.Location = new System.Drawing.Point(562, 37);
            this.buttonSendHello.Name = "buttonSendHello";
            this.buttonSendHello.Size = new System.Drawing.Size(114, 28);
            this.buttonSendHello.TabIndex = 4;
            this.buttonSendHello.Text = "Send";
            this.buttonSendHello.UseVisualStyleBackColor = true;
            this.buttonSendHello.Click += new System.EventHandler(this.ButtonSendHelloClick);
            // 
            // buttonSayHello
            // 
            this.buttonSayHello.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSayHello.Location = new System.Drawing.Point(562, 71);
            this.buttonSayHello.Name = "buttonSayHello";
            this.buttonSayHello.Size = new System.Drawing.Size(114, 28);
            this.buttonSayHello.TabIndex = 6;
            this.buttonSayHello.Text = "Send";
            this.buttonSayHello.UseVisualStyleBackColor = true;
            this.buttonSayHello.Click += new System.EventHandler(this.ButtonSayHelloClick);
            // 
            // textBoxSayHello
            // 
            this.textBoxSayHello.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSayHello.Location = new System.Drawing.Point(123, 71);
            this.textBoxSayHello.Name = "textBoxSayHello";
            this.textBoxSayHello.Size = new System.Drawing.Size(433, 22);
            this.textBoxSayHello.TabIndex = 7;
            // 
            // labelSayHello
            // 
            this.labelSayHello.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSayHello.Location = new System.Drawing.Point(3, 68);
            this.labelSayHello.Name = "labelSayHello";
            this.labelSayHello.Size = new System.Drawing.Size(114, 34);
            this.labelSayHello.TabIndex = 8;
            this.labelSayHello.Text = "SayHello";
            this.labelSayHello.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 283);
            this.Controls.Add(this.tableLayoutPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ClientForm";
            this.Text = "Messaging Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label labelServer;
        private System.Windows.Forms.TextBox textBoxServer;
        private System.Windows.Forms.TextBox textBoxHello;
        private System.Windows.Forms.Label labelHello;
        private System.Windows.Forms.Button buttonSendHello;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label labelSayHello;
        private System.Windows.Forms.TextBox textBoxSayHello;
        private System.Windows.Forms.Button buttonSayHello;
    }
}

