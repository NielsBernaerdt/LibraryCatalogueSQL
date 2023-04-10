namespace LibraryCatalogueSQL
{
    partial class LibraryCatalogue
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
			this.BooksFoundListBox = new System.Windows.Forms.ListBox();
			this.SearchButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.InsTitleTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.InsAuthorTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.InsNrPagesTextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.InsLanguageTextBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.InsTargetAudienceTextBox = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.InsertButton = new System.Windows.Forms.Button();
			this.DeleteButton = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.GenreComboBox = new System.Windows.Forms.ComboBox();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.ModifyButton = new System.Windows.Forms.Button();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.tableLayoutPanel4.SuspendLayout();
			this.tableLayoutPanel5.SuspendLayout();
			this.SuspendLayout();
			// 
			// BooksFoundListBox
			// 
			this.BooksFoundListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.BooksFoundListBox.FormattingEnabled = true;
			this.BooksFoundListBox.Location = new System.Drawing.Point(2, 2);
			this.BooksFoundListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.BooksFoundListBox.Name = "BooksFoundListBox";
			this.BooksFoundListBox.Size = new System.Drawing.Size(580, 173);
			this.BooksFoundListBox.TabIndex = 0;
			// 
			// SearchButton
			// 
			this.SearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.SearchButton.Location = new System.Drawing.Point(87, 2);
			this.SearchButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.SearchButton.Name = "SearchButton";
			this.SearchButton.Size = new System.Drawing.Size(81, 44);
			this.SearchButton.TabIndex = 3;
			this.SearchButton.Text = "Search";
			this.SearchButton.UseVisualStyleBackColor = true;
			this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(2, 0);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label1.Size = new System.Drawing.Size(64, 33);
			this.label1.TabIndex = 5;
			this.label1.Text = "Title";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// InsTitleTextBox
			// 
			this.InsTitleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.InsTitleTextBox.Location = new System.Drawing.Point(70, 2);
			this.InsTitleTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.InsTitleTextBox.Name = "InsTitleTextBox";
			this.InsTitleTextBox.Size = new System.Drawing.Size(268, 20);
			this.InsTitleTextBox.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(2, 33);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label2.Size = new System.Drawing.Size(64, 33);
			this.label2.TabIndex = 7;
			this.label2.Text = "Author";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// InsAuthorTextBox
			// 
			this.InsAuthorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.InsAuthorTextBox.Location = new System.Drawing.Point(70, 35);
			this.InsAuthorTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.InsAuthorTextBox.Name = "InsAuthorTextBox";
			this.InsAuthorTextBox.Size = new System.Drawing.Size(268, 20);
			this.InsAuthorTextBox.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(2, 66);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label3.Size = new System.Drawing.Size(64, 33);
			this.label3.TabIndex = 9;
			this.label3.Text = "NrPages";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// InsNrPagesTextBox
			// 
			this.InsNrPagesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.InsNrPagesTextBox.Location = new System.Drawing.Point(70, 68);
			this.InsNrPagesTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.InsNrPagesTextBox.Name = "InsNrPagesTextBox";
			this.InsNrPagesTextBox.Size = new System.Drawing.Size(268, 20);
			this.InsNrPagesTextBox.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(2, 99);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label4.Size = new System.Drawing.Size(64, 33);
			this.label4.TabIndex = 11;
			this.label4.Text = "Language";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// InsLanguageTextBox
			// 
			this.InsLanguageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.InsLanguageTextBox.Location = new System.Drawing.Point(70, 101);
			this.InsLanguageTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.InsLanguageTextBox.Name = "InsLanguageTextBox";
			this.InsLanguageTextBox.Size = new System.Drawing.Size(268, 20);
			this.InsLanguageTextBox.TabIndex = 10;
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(2, 132);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label5.Size = new System.Drawing.Size(64, 33);
			this.label5.TabIndex = 13;
			this.label5.Text = "TargetAudience";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// InsTargetAudienceTextBox
			// 
			this.InsTargetAudienceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.InsTargetAudienceTextBox.Location = new System.Drawing.Point(70, 134);
			this.InsTargetAudienceTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.InsTargetAudienceTextBox.Name = "InsTargetAudienceTextBox";
			this.InsTargetAudienceTextBox.Size = new System.Drawing.Size(268, 20);
			this.InsTargetAudienceTextBox.TabIndex = 12;
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(2, 165);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label6.Size = new System.Drawing.Size(64, 38);
			this.label6.TabIndex = 15;
			this.label6.Text = "Genre";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// InsertButton
			// 
			this.InsertButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.InsertButton.Location = new System.Drawing.Point(2, 2);
			this.InsertButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.InsertButton.Name = "InsertButton";
			this.InsertButton.Size = new System.Drawing.Size(81, 44);
			this.InsertButton.TabIndex = 16;
			this.InsertButton.Text = "Insert";
			this.InsertButton.UseVisualStyleBackColor = true;
			this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
			// 
			// DeleteButton
			// 
			this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.DeleteButton.Location = new System.Drawing.Point(257, 2);
			this.DeleteButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.DeleteButton.Name = "DeleteButton";
			this.DeleteButton.Size = new System.Drawing.Size(81, 44);
			this.DeleteButton.TabIndex = 17;
			this.DeleteButton.Text = "Delete";
			this.DeleteButton.UseVisualStyleBackColor = true;
			this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.InsTargetAudienceTextBox, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.InsLanguageTextBox, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.InsNrPagesTextBox, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.InsTitleTextBox, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.InsAuthorTextBox, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.GenreComboBox, 1, 5);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 6;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(340, 203);
			this.tableLayoutPanel1.TabIndex = 18;
			// 
			// GenreComboBox
			// 
			this.GenreComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.GenreComboBox.FormattingEnabled = true;
			this.GenreComboBox.Location = new System.Drawing.Point(70, 167);
			this.GenreComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.GenreComboBox.Name = "GenreComboBox";
			this.GenreComboBox.Size = new System.Drawing.Size(268, 21);
			this.GenreComboBox.TabIndex = 16;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(118, 2);
			this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 2;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(344, 259);
			this.tableLayoutPanel2.TabIndex = 19;
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel3.ColumnCount = 4;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.99813F));
			this.tableLayoutPanel3.Controls.Add(this.InsertButton, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.SearchButton, 1, 0);
			this.tableLayoutPanel3.Controls.Add(this.DeleteButton, 3, 0);
			this.tableLayoutPanel3.Controls.Add(this.ModifyButton, 2, 0);
			this.tableLayoutPanel3.Location = new System.Drawing.Point(2, 209);
			this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 1;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(340, 48);
			this.tableLayoutPanel3.TabIndex = 19;
			// 
			// ModifyButton
			// 
			this.ModifyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ModifyButton.Location = new System.Drawing.Point(172, 2);
			this.ModifyButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ModifyButton.Name = "ModifyButton";
			this.ModifyButton.Size = new System.Drawing.Size(81, 44);
			this.ModifyButton.TabIndex = 18;
			this.ModifyButton.Text = "Modify";
			this.ModifyButton.UseVisualStyleBackColor = true;
			this.ModifyButton.Click += new System.EventHandler(this.ModifyButton_Click);
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel4.ColumnCount = 1;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel4.Controls.Add(this.BooksFoundListBox, 0, 0);
			this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 1);
			this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 2);
			this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 2;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
			this.tableLayoutPanel4.Size = new System.Drawing.Size(584, 444);
			this.tableLayoutPanel4.TabIndex = 20;
			// 
			// tableLayoutPanel5
			// 
			this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel5.ColumnCount = 3;
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel2, 1, 0);
			this.tableLayoutPanel5.Location = new System.Drawing.Point(2, 179);
			this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tableLayoutPanel5.Name = "tableLayoutPanel5";
			this.tableLayoutPanel5.RowCount = 1;
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
			this.tableLayoutPanel5.Size = new System.Drawing.Size(580, 263);
			this.tableLayoutPanel5.TabIndex = 1;
			// 
			// LibraryCatalogue
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(586, 449);
			this.Controls.Add(this.tableLayoutPanel4);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "LibraryCatalogue";
			this.Text = " ";
			this.Load += new System.EventHandler(this.LibraryCatalogue_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel4.ResumeLayout(false);
			this.tableLayoutPanel5.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox BooksFoundListBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InsTitleTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox InsAuthorTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox InsNrPagesTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox InsLanguageTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox InsTargetAudienceTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.ComboBox GenreComboBox;
        private System.Windows.Forms.Button ModifyButton;
    }
}

