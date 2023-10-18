namespace Supermarker_mvp.Views
{
    partial class PayModeView
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            label2 = new Label();
            tabPage2 = new TabPage();
            panel1 = new Panel();
            DgPayMode = new DataGridView();
            BtnNew = new Button();
            BtnEdit = new Button();
            BtnDelete = new Button();
            BtnClose = new Button();
            label3 = new Label();
            TxtPayModeId = new TextBox();
            label4 = new Label();
            TxtPayModeName = new TextBox();
            label5 = new Label();
            TxtPayModeObservation = new TextBox();
            BtnSave = new Button();
            BtnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(219, 43);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Pay Mode";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.buy;
            pictureBox1.Location = new Point(16, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(136, 81);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 111);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 327);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(BtnClose);
            tabPage1.Controls.Add(BtnDelete);
            tabPage1.Controls.Add(BtnEdit);
            tabPage1.Controls.Add(BtnNew);
            tabPage1.Controls.Add(DgPayMode);
            tabPage1.Controls.Add(BtnSearch);
            tabPage1.Controls.Add(TxtSearch);
            tabPage1.Controls.Add(label2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 299);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Pay Mode List";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // BtnSearch
            // 
            BtnSearch.Location = new Point(512, 31);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(75, 23);
            BtnSearch.TabIndex = 2;
            BtnSearch.Text = "Search";
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Location = new Point(38, 31);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(441, 23);
            TxtSearch.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 13);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 0;
            label2.Text = "Search Pay Mode";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(BtnCancel);
            tabPage2.Controls.Add(BtnSave);
            tabPage2.Controls.Add(TxtPayModeObservation);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(TxtPayModeName);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(TxtPayModeId);
            tabPage2.Controls.Add(label3);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 299);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Pay Mode Datail";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(772, 81);
            panel1.TabIndex = 3;
            // 
            // DgPayMode
            // 
            DgPayMode.AllowUserToAddRows = false;
            DgPayMode.AllowUserToDeleteRows = false;
            DgPayMode.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgPayMode.Location = new Point(38, 78);
            DgPayMode.Name = "DgPayMode";
            DgPayMode.ReadOnly = true;
            DgPayMode.RowTemplate.Height = 25;
            DgPayMode.Size = new Size(549, 215);
            DgPayMode.TabIndex = 3;
            // 
            // BtnNew
            // 
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(593, 78);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(159, 50);
            BtnNew.TabIndex = 4;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(593, 131);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(159, 50);
            BtnEdit.TabIndex = 5;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(593, 187);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(159, 50);
            BtnDelete.TabIndex = 6;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(593, 243);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(159, 50);
            BtnClose.TabIndex = 7;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 3);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 0;
            label3.Text = "Pay Mode Id";
            // 
            // TxtPayModeId
            // 
            TxtPayModeId.Location = new Point(31, 21);
            TxtPayModeId.Name = "TxtPayModeId";
            TxtPayModeId.Size = new Size(145, 23);
            TxtPayModeId.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 59);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 2;
            label4.Text = "Pay Mode Name";
            // 
            // TxtPayModeName
            // 
            TxtPayModeName.Location = new Point(31, 77);
            TxtPayModeName.Name = "TxtPayModeName";
            TxtPayModeName.PlaceholderText = "Pay Mode Name";
            TxtPayModeName.Size = new Size(248, 23);
            TxtPayModeName.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 123);
            label5.Name = "label5";
            label5.Size = new Size(127, 15);
            label5.TabIndex = 4;
            label5.Text = "Pay Mode Observation";
            // 
            // TxtPayModeObservation
            // 
            TxtPayModeObservation.Location = new Point(31, 141);
            TxtPayModeObservation.Multiline = true;
            TxtPayModeObservation.Name = "TxtPayModeObservation";
            TxtPayModeObservation.PlaceholderText = "Pay Mode Observation";
            TxtPayModeObservation.Size = new Size(248, 65);
            TxtPayModeObservation.TabIndex = 5;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(31, 225);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(95, 54);
            BtnSave.TabIndex = 6;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(152, 225);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(95, 54);
            BtnCancel.TabIndex = 7;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // PayModeView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "PayModeView";
            Text = "Pay Mode Management";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label2;
        private Button BtnSearch;
        private TextBox TxtSearch;
        private Panel panel1;
        private DataGridView DgPayMode;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private TextBox TxtPayModeId;
        private Label label3;
        private TextBox TxtPayModeName;
        private Label label4;
        private TextBox TxtPayModeObservation;
        private Label label5;
        private Button BtnCancel;
        private Button BtnSave;
    }
}