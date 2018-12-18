namespace Messaging.Server
{
    partial class ServerForm
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
            this.labelServer = new System.Windows.Forms.Label();
            this.textBoxServer = new System.Windows.Forms.TextBox();
            this.textBoxMessages = new System.Windows.Forms.TextBox();
            this.textBoxUdp = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.85895F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.14105F));
            this.tableLayoutPanel.Controls.Add(this.textBoxUdp, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.labelServer, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.textBoxServer, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.textBoxMessages, 1, 2);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(660, 260);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // labelServer
            // 
            this.labelServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelServer.Location = new System.Drawing.Point(4, 0);
            this.labelServer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelServer.Name = "labelServer";
            this.labelServer.Size = new System.Drawing.Size(116, 34);
            this.labelServer.TabIndex = 0;
            this.labelServer.Text = "Server";
            this.labelServer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxServer
            // 
            this.textBoxServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxServer.Location = new System.Drawing.Point(127, 3);
            this.textBoxServer.Name = "textBoxServer";
            this.textBoxServer.ReadOnly = true;
            this.textBoxServer.Size = new System.Drawing.Size(530, 22);
            this.textBoxServer.TabIndex = 1;
            // 
            // textBoxMessages
            // 
            this.textBoxMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxMessages.Location = new System.Drawing.Point(127, 71);
            this.textBoxMessages.Multiline = true;
            this.textBoxMessages.Name = "textBoxMessages";
            this.textBoxMessages.ReadOnly = true;
            this.textBoxMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMessages.Size = new System.Drawing.Size(530, 186);
            this.textBoxMessages.TabIndex = 2;
            this.textBoxMessages.WordWrap = false;
            // 
            // textBoxUdp
            // 
            this.textBoxUdp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxUdp.Location = new System.Drawing.Point(127, 37);
            this.textBoxUdp.Name = "textBoxUdp";
            this.textBoxUdp.ReadOnly = true;
            this.textBoxUdp.Size = new System.Drawing.Size(530, 22);
            this.textBoxUdp.TabIndex = 3;
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 260);
            this.Controls.Add(this.tableLayoutPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ServerForm";
            this.Text = "Messaging Server";
            this.Load += new System.EventHandler(this.ServerFormLoad);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label labelServer;
        private System.Windows.Forms.TextBox textBoxServer;
        private System.Windows.Forms.TextBox textBoxMessages;
        private System.Windows.Forms.TextBox textBoxUdp;
    }
}

